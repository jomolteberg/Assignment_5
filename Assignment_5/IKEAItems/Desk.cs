using Assignment_5.Interfaces;

namespace Assignment_5.IKEAItems;

public class Desk : Product, IAssemblable, IOffice
{
    public Desk(string name, float price) : base(name, price)
    {
        
    }

    public override float GetPrice()
    {
        return Price;
    }
    
    public override string GetShelf()
    {
        return "F35";
    }
    
    public override string GetDescription()
    {
        return "A sturdy and spacious desk, designed for both functionality and style. Perfect for any home office or study area.";
    }
    
    string IAssemblable.Assemble()
    {
        return "Assembly instructions: Start by assembling the desk frame, attach the legs securely, then align and fix the desktop to the frame. Ensure all screws are tightened for stability.";
    }
    
    public string Office()
    {
        return "Enhance your productivity with this ergonomically designed desk. Its spacious surface provides ample room for your computer, documents, and office supplies.";
    }
}