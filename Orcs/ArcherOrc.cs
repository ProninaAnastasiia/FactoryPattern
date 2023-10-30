using FactoryPattern.Heroes;

namespace FactoryPattern.Orcs;

public class ArcherOrc: Archer
{
    public ArcherOrc()
    {
        MaxHealth = 500;
        Health = 500;
        Initiative = 80;
        Damage = 65;
        Arrows = 3;
    }
}