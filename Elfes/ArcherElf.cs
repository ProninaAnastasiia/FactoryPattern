using FactoryPattern.Heroes;

namespace FactoryPattern.Elfes;

public class ArcherElf: Archer
{
    public ArcherElf()
    {
        MaxHealth = 500;
        Health = 400;
        Initiative = 85;
        Damage = 70;
        Arrows = 7;
    }
}