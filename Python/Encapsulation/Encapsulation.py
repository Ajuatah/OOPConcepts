

from Python.Inheritance.Inheritance import Product

class SecureProduct(Product):
    def __init__(self, name, price, stock):
        super().__init__(name, price, stock)
        self.__price = price # Private attribute

    # Getter method
    def get_price(self):
        return self.__price

    # Setter method with validation
    def set_price(self, new_price):
        if new_price > 0:
            self.__price = new_price
        else:
            print("Price must be greater than zero!")