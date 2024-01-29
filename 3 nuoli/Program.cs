
// tämä koko homma on niin sekava että en itsekkään saa selvää mitä tapahtuu mutta en jaksa alkaa tekemään uudestaan nii jätän nyt vaa näin

namespace _3_nuoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Nuoli nuoli = new Nuoli();
                
                Console.WriteLine("oma vai valmis nuoli");
                string valinta = Console.ReadLine();
                switch(valinta)
                {
                    case "valmis":
                        Console.WriteLine("1: aloittelijanuoli 2: perusnuoli vai 3: eliittinuoli");
                        string valinta2 = Console.ReadLine();
                        switch(valinta2)
                        {
                            case "3":
                                Nuoli.LuoEliittinuoli(nuoli);
                                break;

                            case "2":
                                Nuoli.LuoPerusNuoli(nuoli);
                                break;

                            case "1":
                                Nuoli.LuoAloittelijaNuoli(nuoli);
                                break;
                        }
                        Console.WriteLine($"nuolen hinta on {nuoli.cost()}");
                        break;

                    case "oma":
                        Console.WriteLine("mikä kärki? 1: puu 2: teräs vai 3: timantti");
                        string kärkiinput = Console.ReadLine();

                        Console.WriteLine("mikä perä? 1: lehti 2: kana vai 3: kotkansulka");
                        string peräinput = Console.ReadLine();

                        Console.WriteLine("mikä pituus? 60-100 cm");
                        int pituusinput = Int32.Parse(Console.ReadLine());
                        if (pituusinput < 60 || pituusinput > 100)
                        {
                            Console.WriteLine("väärä pituus");
                            continue;
                        }
                        nuoli.pituus = pituusinput;
                        switch (kärkiinput)
                        {
                            case "puu":
                                nuoli.kärki = kärkityyppi.puu;
                                break;
                            case "teräs":
                                nuoli.kärki = kärkityyppi.teräs;
                                break;
                            case "timantti":
                                nuoli.kärki = kärkityyppi.timantti;
                                break;
                            default:
                                break;
                        }
                        switch (peräinput)
                        {
                            case "1":
                                nuoli.perä = perätyyppi.lehti;
                                break;
                            case "2":
                                nuoli.perä = perätyyppi.kanansulka;
                                break;
                            case "3":
                                nuoli.perä = perätyyppi.kotkansulka;
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine($"nuolen hinta on {nuoli.cost()}");
                        break;
                    default:
                        {
                            Console.WriteLine("täh");
                            continue;
                        }
                }
            }
        }
        public class Nuoli
        {
            public kärkityyppi kärki { get; set; }
            public float pituus { get; set; }
            public perätyyppi perä { get; set; }

            public static Nuoli LuoEliittinuoli(Nuoli nuoli)
            {
                nuoli.kärki = kärkityyppi.timantti;
                nuoli.pituus = 100;
                nuoli.perä = perätyyppi.kotkansulka;
                return nuoli;
            }
            public static Nuoli LuoPerusNuoli(Nuoli nuoli)
            {
                nuoli.kärki = kärkityyppi.teräs;
                nuoli.pituus = 85;
                nuoli.perä = perätyyppi.kanansulka;
                return nuoli;
            }
            public static Nuoli LuoAloittelijaNuoli(Nuoli nuoli)
            {
                nuoli.kärki = kärkityyppi.puu;
                nuoli.pituus = 70;
                nuoli.perä = perätyyppi.lehti;
                return nuoli;
            }
            public float cost()
            {
                float cost = 0;

                if (kärki == kärkityyppi.puu) { cost += 3; }
                if (kärki == kärkityyppi.teräs) { cost += 5; }
                if (kärki == kärkityyppi.timantti) { cost += 50; }

                if (perä == perätyyppi.lehti) { cost += 0; }
                if (perä == perätyyppi.kanansulka) { cost += 1; }
                if (perä == perätyyppi.kotkansulka) { cost += 5; }

                Console.WriteLine($"{kärki} {perä} {pituus} ");
                cost += pituus * 0.05f;
                return cost;
            }
        }

        public enum kärkityyppi
        {
            puu,
            teräs,
            timantti
        }

        public enum perätyyppi
        {
            lehti,
            kanansulka,
            kotkansulka
        }
    }
}