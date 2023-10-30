using FactoryPattern.Elfes;
using FactoryPattern.Heroes;
using FactoryPattern.Orcs;

namespace FactoryPattern.Factories;

public class ElfFactory: HeroesFactory
{
    public override Melee CreateMelee()
    {
        return new MeleeElf();
    }

    public override Archer CreateArcher()
    {
        return new ArcherElf();
    }

    public override Healer CreateHealer()
    {
        return new HealerElf();
    }
}