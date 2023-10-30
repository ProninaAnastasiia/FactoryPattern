using FactoryPattern.Heroes;

namespace FactoryPattern.Elfes;

public class MeleeElf: Melee
{
    public MeleeElf()
    {
        MaxHealth = 550;
        Health = 550;
        Initiative = 70;
        Damage = 65;
    }
}