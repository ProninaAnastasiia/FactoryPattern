using FactoryPattern.Heroes;
using FactoryPattern.Orcs;

namespace FactoryPattern.Factories;

public class OrcFactory: HeroesFactory
{
    public override Melee CreateMelee()
    {
        return new MeleeOrc();
    }

    public override Archer CreateArcher()
    {
        return new ArcherOrc();
    }

    public override Healer CreateHealer()
    {
        return new HealerOrc();
    }
}