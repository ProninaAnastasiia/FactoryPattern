namespace FactoryPattern.Heroes;

public abstract class Hero
{
    public int MaxHealth { get; set;}
    public int Health { get; set; }
    public int Initiative { get; protected set; }

    public abstract void Run();

}