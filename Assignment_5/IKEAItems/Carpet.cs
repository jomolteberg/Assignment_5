using Assignment_5.Interfaces;

namespace Assignment_5.IKEAItems;

public class Carpet : Product, ILivingRoom, IOffice, IBedroom
{
    public Carpet(string name, float price) : base(name, price)
    {
        
    }

    public override float GetPrice()
    {
        return Price;
    }
    
    public override string GetShelf()
    {
        return "G83";
    }
    
    public override string GetDescription()
    {
        return "A luxurious and soft carpet, adding warmth and comfort to any room. Its elegant design complements both modern and traditional decor.";
    }
    
    public string LivingRoom()
    {
        return "This carpet brings a touch of elegance and coziness to your living room, creating an inviting atmosphere for guests and family alike.";
    }
    
    public string Bedroom()
    {
        return "Add softness and warmth to your bedroom with this plush carpet, perfect for stepping onto first thing in the morning.";
    }
    
    public string Office()
    {
        return "Enhance your office space with this stylish carpet, providing comfort underfoot and reducing noise for a more focused work environment.";
    }
}