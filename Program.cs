namespace WizardSamuraiNinja
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mago mago = new Mago("Merlin");
            Ninja ninja = new Ninja("Fujibayashi Nagato");
            Samurai samurai = new Samurai("Miyamoto Musashi");
            mago.Attack(ninja);
            mago.Curar(mago);
            ninja.Attack(mago);
            ninja.Steal(mago);
            samurai.meditar();
            samurai.Attack(ninja);
        }
    }
}