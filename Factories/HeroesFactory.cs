using FactoryPattern.Heroes;

namespace FactoryPattern.Factories;

public abstract class HeroesFactory
{
    public abstract Melee CreateMelee();
    public abstract Archer CreateArcher();
    public abstract Healer CreateHealer();
}