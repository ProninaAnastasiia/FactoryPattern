using FactoryPattern.Factories;
using FactoryPattern.Heroes;

namespace FactoryPattern;

public class HeroesSpawn
{
    public Melee Melee;
    public Healer Healer;
    public Archer Archer;
    
    public HeroesSpawn(HeroesFactory factory)
    {
        Melee = factory.CreateMelee();
        Archer = factory.CreateArcher();
        Healer = factory.CreateHealer();
    }
    
    public void Fight(HeroesSpawn enemy)
    {
        while (true)
        {
            Console.WriteLine($"{Melee.GetType().Namespace} атакуют:");
            Melee.Attack(enemy.Melee);
            Archer.Attack(enemy.Melee);
            Healer.Heal(Archer);
            
            if (enemy.Melee.Health < 0) break;
            
            Console.WriteLine($"Очередь {enemy.Melee.GetType().Namespace}:");
            
            enemy.Melee.Attack(Archer);
            enemy.Archer.Attack(Archer);
            enemy.Healer.Heal(enemy.Melee);
            
            if (Archer.Health<0) break;
        }
        
    }
}