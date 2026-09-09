from importlib import import_module

Product = import_module("Python.Class.class").Product


class DigitalProduct(Product):
    def __init__(self, name, price, file_size):
        super().__init__(name, price, stock=9999) # Digital products have infinite stock
        self.file_size = file_size

    # Overriding the parent method (Polymorphism)
    def display_info(self):
        return f"[Digital] {self.name} - ${self.price:.2f} ({self.file_size}MB)"