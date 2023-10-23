namespace WizardSamuraiNinja
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            Health = 200;
        }
        public override int Attack(Human enemigo)
        {
            base.Attack(enemigo);
            if (enemigo.Health < 50)
            {
                enemigo.Health = 0;
            }
            return enemigo.Health;
        }
        public int meditar()
        {
            Health = 200;
            Console.WriteLine($"{Name} Ha recuperado 200 de hp");
            return Health;
        }
    }
}