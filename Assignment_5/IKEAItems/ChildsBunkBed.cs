using Assignment_5.Interfaces;

namespace Assignment_5.IKEAItems;

public class ChildBunkBed : Product, IAssemblable, IBedroom
{
    public ChildBunkBed(string name, float price) : base(name, price)
    {
        
    }

    public override float GetPrice()
    {
        return Price;
    }
    
    public override string GetShelf()
    {
        return "B95";
    }
    
    public override string GetDescription()
    {
        return "A fun and space-saving bunk bed perfect for children's bedrooms. Designed with safety and comfort in mind, it offers a cozy sleep space while maximizing room for play.";
    }
    
    public string Assemble()
    {
        return "Assembly instructions: Begin with the lower bed frame, ensuring all support slats are securely in place. Stack the upper frame and secure it with safety rails. Attach the ladder firmly for easy access.";
    }
    
    public string Bedroom()
    {
        return "This bunk bed transforms any child's bedroom into a playful yet restful retreat. Ideal for siblings sharing a room or for sleepovers, it combines functionality with safety features.";
    }
}