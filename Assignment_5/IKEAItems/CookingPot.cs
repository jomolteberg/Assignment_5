using Assignment_5.Interfaces;

namespace Assignment_5.IKEAItems;

public class CookingPot : Product, IKitchen
{
    public CookingPot(string name, float price) : base(name, price)
    {
        
    }

    public override float GetPrice()
    {
        return Price;
    }
    
    public override string GetShelf()
    {
        return "G3";
    }
    
    public override string GetDescription()
    {
        return "A durable and versatile cooking pot, ideal for a wide range of culinary tasks. Made from high-quality materials, it ensures even heat distribution for perfect cooking results.";
    }
    
    public string Kitchen()
    {
        return "This cooking pot is a kitchen essential, designed to handle everything from simmering soups to boiling pasta. Its robust construction and user-friendly design make it a favorite among home cooks.";
    }
}