namespace WizardSamuraiNinja
{


    public class Human
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }



        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            Console.WriteLine($"{Name} ataco a {target.Name} causando {dmg} de daño!");
            return target.Health;
        }
    }
}