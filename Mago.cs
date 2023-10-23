namespace WizardSamuraiNinja
{
    public class Mago : Human
    {
        public Mago(string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            Health = 50;
        }
        public override int Attack(Human enemigo)
        {
            int dmg = Intelligence * 3;
            enemigo.Health -= dmg;
            Console.WriteLine($"{Name} Ataco a {enemigo.Name} causando {dmg} de daño");
            Health += dmg;
            return enemigo.Health;
        }
        public int Curar(Human enemigo)
        {
            int curar = Intelligence * 3;
            enemigo.Health += curar;
            Console.WriteLine($"{Name} Ha sanado a {enemigo.Name} y a restaurado su salud en {curar.ToString()} hp!");
            return enemigo.Health;
        }

    }
}