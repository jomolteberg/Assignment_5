using Assignment_5.Interfaces;

namespace Assignment_5.IKEAItems;

public class Basket : Product, IBedroom, ILivingRoom
{
    public Basket(string name, float price) : base(name, price)
    {
        
    }

    public override float GetPrice()
    {
        return Price;
    }
    
    public override string GetShelf()
    {
        return "H43";
    }
    
    public override string GetDescription()
    {
        return "A versatile and stylish basket, perfect for decluttering and adding a touch of elegance to any room. Its durable design is ideal for storing a variety of items, from blankets to magazines.";
    }
    
    public string LivingRoom()
    {
        return "This basket serves as a chic storage solution in your living room, keeping your space tidy while complementing your decor.";
    }
    
    public string Bedroom()
    {
        return "Enhance your bedroom's organization and style with this basket, perfect for storing extra pillows, throws, or even books for a cozy night in.";
    }
}