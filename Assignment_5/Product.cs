namespace Assignment_5;

public abstract class Product
{
    public string Name { get; set; }
    public float Price { get; set; }

    public Product(string name, float price)
    {
        Name = name;
        Price = price;
    }
    
    public abstract float GetPrice();
    public abstract string GetShelf();
    public abstract string GetDescription();
}