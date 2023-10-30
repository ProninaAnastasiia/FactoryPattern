namespace FactoryPattern.Heroes;

public class Healer: Hero
{
    protected int Intelligence { get; set; }
    protected int SpellSlots { get; set; }

    public override void Run()
    {
        Initiative += 5;
    }
    
    public void Heal(Hero target)
    {
        if(target.GetType().Namespace != this.GetType().Namespace) Console.WriteLine("Нельзя лечить врагов!");
        else if (target.Health==target.MaxHealth) Console.WriteLine("Здоровье цели сейчас полное!");
        else
        {
            if(SpellSlots<=0) Console.WriteLine($"{this.GetType().Name} не может больше лечить, кончились очки заклинаний.");
            else
            {
                target.Health += Intelligence*Health/100;
                if (target.Health > target.MaxHealth) target.Health = target.MaxHealth;
                Console.WriteLine($"{this.GetType().Name} лечит {target.GetType().Name} на {Intelligence*Health/100}, {target.GetType().Name} Health = {target.Health}.");
                SpellSlots -= 1;
            }
        }
        
    }
    
}