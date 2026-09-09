from fastapi import FastAPI, HTTPException
from pydantic import BaseModel
import random
from typing import Dict

app = FastAPI(title="Andropov OOP RPG Battle API", version="1.0")

# --- 1. OOP Core Classes (Inheritance & Polymorphism) ---
class Character:
    def __init__(self, name: str, health: int, attack_power: int):
        self.name = name
        self.__health = health
        self.attack_power = attack_power

    def get_health(self) -> int:
        return self.__health

    def take_damage(self, amount: int) -> int:
        self.__health -= amount
        if self.__health < 0:
            self.__health = 0
        return self.__health

    def attack(self, other: 'Character') -> dict:
        damage = random.randint(self.attack_power - 5, self.attack_power + 5)
        remaining_hp = other.take_damage(damage)
        return {
            "attacker": self.name,
            "defender": other.name,
            "action": "standard_attack",
            "damage_dealt": damage,
            "defender_health": remaining_hp
        }

    def is_alive(self) -> bool:
        return self.__health > 0

    def special_move(self, other: 'Character') -> dict:
        raise NotImplementedError("Subclasses must implement special_move")

class Warrior(Character):
    def __init__(self, name: str):
        super().__init__(name, health=130, attack_power=20)

    def special_move(self, other: 'Character') -> dict:
        damage = 35
        remaining_hp = other.take_damage(damage)
        return {
            "attacker": self.name,
            "defender": other.name,
            "action": "Heavy Cleave (Warrior Special)",
            "damage_dealt": damage,
            "defender_health": remaining_hp
        }

class Mage(Character):
    def __init__(self, name: str):
        super().__init__(name, health=90, attack_power=30)

    def special_move(self, other: 'Character') -> dict:
        damage = 45
        remaining_hp = other.take_damage(damage)
        return {
            "attacker": self.name,
            "defender": other.name,
            "action": "Arcane Explosion (Mage Special)",
            "damage_dealt": damage,
            "defender_health": remaining_hp
        }

# --- 2. In-Memory Database & Pydantic Schemas ---
game_session: Dict[str, Character] = {}

class FighterCreate(BaseModel):
    name: str
    class_type: str  # "warrior" or "mage"

class ActionRequest(BaseModel):
    action_type: str  # "attack" or "special"

# --- 3. REST Endpoints ---
@app.post("/fighters/")
def create_fighter(fighter: FighterCreate):
    """Create a fighter (Warrior or Mage) and add them to the session."""
    name = fighter.name.strip()
    ctype = fighter.class_type.lower()
    
    if ctype == "warrior":
        char = Warrior(name)
    elif ctype == "mage":
        char = Mage(name)
    else:
        raise HTTPException(status_code=400, detail="Invalid class type. Choose 'warrior' or 'mage'.")
    
    game_session[name] = char
    return {"message": f"Successfully created {ctype} named {name}!", "health": char.get_health()}

@app.get("/fighters/")
def list_fighters():
    """View all active fighters in the arena and their current health."""
    if not game_session:
        return {"message": "No fighters in the arena yet."}
    
    return {
        name: {"health": char.get_health(), "is_alive": char.is_alive()}
        for name, char in game_session.items()
    }

@app.post("/battle/{attacker_name}/vs/{defender_name}")
def execute_turn(attacker_name: str, defender_name: str, payload: ActionRequest):
    """Execute a turn-based action between two active fighters."""
    if attacker_name not in game_session or defender_name not in game_session:
        raise HTTPException(status_code=404, detail="One or both fighters not found in the session.")
    
    attacker = game_session[attacker_name]
    defender = game_session[defender_name]
    
    if not attacker.is_alive() or not defender.is_alive():
        raise HTTPException(status_code=400, detail="Both combatants must be alive to fight.")
    
    if payload.action_type == "attack":
        result = attacker.attack(defender)
    elif payload.action_type == "special":
        result = attacker.special_move(defender)
    else:
        raise HTTPException(status_code=400, detail="Invalid action type. Choose 'attack' or 'special'.")
    
    if not defender.is_alive():
        result["winner"] = attacker.name
        result["message"] = f"🏆 {defender.name} has been defeated! {attacker.name} wins the match!"
        
    return result

@app.delete("/battle/reset")
def reset_arena():
    """Clear the session to start a fresh game."""
    game_session.clear()
    return {"message": "The arena has been cleared."}