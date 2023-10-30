namespace FactoryPattern.Heroes;

public class Melee: Hero
{
    protected int Damage { get; set; }

    public override void Run()
    {
        Initiative += 10;
    }
    
    public void Attack(Hero target)
    {
        var rand = new Random();
        Damage += rand.Next(-20, 30);
        if (target.Initiative > Initiative)
        {
            Console.WriteLine($"{this.GetType().Name} не хватает инициативы. Выполняет бег.");
            Run();
        }
        else
        {
            target.Health -= Damage;
            if (target.Health<0) Console.WriteLine($"{this.GetType().Name} наносит урон = {Damage} по {target.GetType().Name}, {target.GetType().Name} убит.");
            else Console.WriteLine($"{this.GetType().Name} наносит урон = {Damage} по {target.GetType().Name}, {target.GetType().Name} Health = {target.Health}.");
            
        }
    }
}