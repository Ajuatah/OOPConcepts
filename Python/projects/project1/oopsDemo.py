from abc import ABC, abstractmethod

# 1. Abstract Base Class for Products
class AbstractProduct(ABC):
    @abstractmethod
    def get_details(self):
        pass

# 2. Product Class
class Product(AbstractProduct):
    def __init__(self, product_id, name, price, stock):
        self.product_id = product_id
        self.name = name
        self.price = price
        self.stock = stock

    def get_details(self):
        return f"{self.name} - ${self.price:.2f}"

    def update_stock(self, quantity):
        self.stock -= quantity

# 3. Inherited Digital Product Class
class DigitalProduct(Product):
    def __init__(self, product_id, name, price, file_size):
        super().__init__(product_id, name, price, stock=float('inf'))
        self.file_size = file_size

    def get_details(self):
        return f"[Digital Download] {self.name} - ${self.price:.2f} ({self.file_size}MB)"

# 4. Shopping Cart Class (Composition)
class ShoppingCart:
    def __init__(self):
        self._items = {} # Dictionary format: {product_obj: quantity}

    def add_item(self, product, quantity=1):
        if product.stock >= quantity:
            if product in self._items:
                self._items[product] += quantity
            else:
                self._items[product] = quantity
            print(f"Added {quantity}x {product.name} to your cart.")
        else:
            print(f"Sorry, insufficient stock for {product.name}.")

    def remove_item(self, product):
        if product in self._items:
            del self._items[product]
            print(f"Removed {product.name} from your cart.")

    def calculate_total(self):
        total = 0
        for product, quantity in self._items.items():
            total += product.price * quantity
        return total

    def display_cart(self):
        print("\n--- YOUR SHOPPING CART ---")
        if not self._items:
            print("Your cart is empty.")
        for product, quantity in self._items.items():
            print(f"- {product.get_details()} x {quantity}")
        print(f"Total: XAF{self.calculate_total():.2f}\n--------------------------")

# 5. Customer Class
class Customer:
    def __init__(self, customer_id, name, email):
        self.customer_id = customer_id
        self.name = name
        self.email = email
        self.cart = ShoppingCart()

    def checkout(self):
        print(f"\nProcessing checkout for {self.name}...")
        total = self.cart.calculate_total()
        if total > 0:
            for product, quantity in self.cart._items.items():
                if product.stock != float('inf'):
                    product.update_stock(quantity)
            print(f"Payment of  {total:.2f} XAF successful! Thank you for your purchase, {self.name}.")
            self.cart._items.clear() # Empty cart after checkout
        else:
            print("Your cart is empty. Add items before checking out.")

# ==========================================
# TESTING THE SYSTEM
# ==========================================
if __name__ == "__main__":
    # Create inventory products
    p1 = Product("P001", "Mechanical Keyboard", 89.99, 15)
    p2 = Product("P002", "UltraWide Monitor", 349.99, 5)
    p3 = DigitalProduct("P003", "Python OOP Masterclass E-Book", 19.99, 45)

    # Create a customer
    customer1 = Customer("C001", "Alice Smith", "alice@example.com")

    # Customer interacts with cart
    customer1.cart.add_item(p1, 1)
    customer1.cart.add_item(p3, 2)
    customer1.cart.display_cart()

    # Attempt checkout
    customer1.checkout()

    # Check stock update after checkout
    print(f"\nRemaining stock for {p1.name}: {p1.stock} units left.")