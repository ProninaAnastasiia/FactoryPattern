using FactoryPattern.Heroes;

namespace FactoryPattern.Orcs;

public class MeleeOrc: Melee
{
    public MeleeOrc()
    {
        MaxHealth = 700;
        Health = 700;
        Initiative = 70;
        Damage = 80;
    }
}