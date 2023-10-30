using FactoryPattern.Heroes;

namespace FactoryPattern.Elfes;

public class HealerElf: Healer
{
    public HealerElf()
    {
        MaxHealth = 300;
        Health = 300;
        Initiative = 50;
        Intelligence = 25;
        SpellSlots = 4;
    }
}