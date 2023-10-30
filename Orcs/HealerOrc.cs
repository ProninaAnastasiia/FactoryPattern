using FactoryPattern.Heroes;

namespace FactoryPattern.Orcs;

public class HealerOrc: Healer
{
    public HealerOrc()
    {
        MaxHealth = 600;
        Health = 600;
        Initiative = 50;
        Intelligence = 10;
        SpellSlots = 5;
    }
}