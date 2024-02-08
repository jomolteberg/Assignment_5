using Assignment_5.Interfaces;

namespace Assignment_5.IKEAItems;

public class DeskLamp : Product, IOffice, IBedroom
{
    public DeskLamp(string name, float price) : base(name, price)
    {
        
    }

    public override float GetPrice()
    {
        return Price; 
    }
    
    public override string GetShelf()
    {
        return "C54";
    }
    
    public override string GetDescription()
    {
        return "A sleek and modern desk lamp, perfect for enhancing your workspace lighting or adding a cozy ambiance to your bedroom.";
    }
    
    public string Office()
    {
        return "Illuminate your workspace with this stylish desk lamp, designed to reduce eye strain during long hours of work.";
    }
    
    public string Bedroom()
    {
        return "Add a touch of warmth to your bedroom with this versatile desk lamp, ideal for reading or relaxing before bed.";
    }
}