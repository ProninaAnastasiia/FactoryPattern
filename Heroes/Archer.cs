using System.Security.Cryptography;

namespace FactoryPattern.Heroes;

public class Archer: Hero
{
    protected int Damage { get; set; }
    protected int Arrows { get; set; }

    public override void Run()
    {
        Initiative += 5;
    }
    
    public void Attack(Hero target)
    {
        var rand = new Random();
        Damage += rand.Next(-10, 20);
        if (target.Initiative > Initiative)
        {
            Console.WriteLine($"{this.GetType().Name} не хватает инициативы. Выполняет бег.");
            Run();
        }
        else
        {
            if (Arrows<=0) Console.WriteLine($"{this.GetType().Name} не хватает стрел. Больше не может атаковать.");
            else
            {
                target.Health -= Damage;
                Arrows -= 1;
                if (target.Health<0) Console.WriteLine($"{this.GetType().Name} наносит урон = {Damage} по {target.GetType().Name}, {target.GetType().Name} убит.");
                else Console.WriteLine($"{this.GetType().Name} наносит урон = {Damage} по {target.GetType().Name}, {target.GetType().Name} Health = {target.Health}.");
            }
        }
    }
    
}