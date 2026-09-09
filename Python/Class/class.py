class Product:
    # Constructor method to initialize attributes
    def __init__(self, name, price, stock):
        self.name = name
        self.price = price
        self.stock = stock

    # Method to display product info
    def display_info(self):
        return f"{self.name} - ${self.price:.2f} ({self.stock} in stock)"

# Creating objects (instances)
item1 = Product("Laptop", 1200.00, 10)
item2 = Product("Mouse", 25.50, 50)

print(item1.display_info())
print(item2.display_info())