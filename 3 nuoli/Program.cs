namespace _3_nuoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        class Nuoli
        {
            kärkityyppi kärki;
            int pituus;
            perätyyppi perä;
        }

        enum kärkityyppi
        {
            kivi,
            teräs,
            timantti
        }

        enum perätyyppi
        {
            kanasulka,
            kotkasulka,
            dodosulka
        }
    }
}