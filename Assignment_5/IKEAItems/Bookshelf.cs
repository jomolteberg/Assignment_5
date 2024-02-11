using Assignment_5.Interfaces;

namespace Assignment_5.IKEAItems;

public class Bookshelf : Product, IAssemblable, IOffice, ILivingRoom
{
    public Bookshelf(string name, float price) : base(name, price)
    {
        
    }

    public override float GetPrice()
    {
        return Price;
    }
    
    public override string GetShelf()
    {
        return "L85";
    }
    
    public override string GetDescription()
    {
        return "A versatile and elegant bookshelf, perfect for organizing books, displaying decorations, or housing collections. Its sleek design fits seamlessly into any living room or office space.";
    }
    
    string IAssemblable.Assemble()
    {
        return "Assembly instructions: Begin with the sides, inserting shelves at the desired heights. Secure the back panel, then anchor to a wall for stability. Follow the manual for detailed steps.";
    }
    
    public string Office()
    {
        return "This bookshelf not only organizes your professional literature and documents but also adds a touch of sophistication to your office environment.";
    }
    public string LivingRoom()
    {
        return "Elevate your living room's decor with this stylish bookshelf, providing ample space for books, art, and memorabilia, enhancing the room's ambiance.";
    }
}