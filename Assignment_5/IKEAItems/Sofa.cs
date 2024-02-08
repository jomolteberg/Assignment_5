using Assignment_5.Interfaces;

namespace Assignment_5.IKEAItems;

public class Sofa: Product, IAssemblable, ILivingRoom
{
    public Sofa(string name, float price) : base(name, price)
    {
        
    }

    public override float GetPrice()
    {
        return Price;
    }
    
    public override string GetShelf()
    {
        return "B67";
    }
    public override string GetDescription()
    {
        return "A comfortable and stylish sofa, perfect for any living room.";
    }
    
    public string Assemble()
    {
        return "Assembly instructions: Connect frame pieces, attach legs, then place cushions.";
    }
    public string LivingRoom()
    {
        return
            $"This carpet would look absolutely marvelous in your living room.";
    }
}