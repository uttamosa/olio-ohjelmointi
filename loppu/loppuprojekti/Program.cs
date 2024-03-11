namespace loppuprojekti
{
    internal class Program
    {
        static void taistelu()
        {
            Console.WriteLine("mitä vastaan haluat taistella? tässä lista vihollisista:");
            Console.WriteLine("worm");
            Console.WriteLine("rat");
            Console.WriteLine("dog");
            Console.WriteLine("baby");
            Console.WriteLine("goblin");
            Console.WriteLine("orc");
            Console.WriteLine("bird");
            Console.WriteLine("sea snake");
            Console.WriteLine("dragon");


        }

        static void Main(string[] args)
        {
            Console.WriteLine("MORO");
            Player player = new Player();

            Console.WriteLine("");
            Console.WriteLine("mikä on nimesi?");

            //katsotaan onko nimi kelvollinen
            while (true)
            {
                string nimi = Console.ReadLine();

                if (nimi != null)
                {
                    player.name = nimi;
                    break;
                }
                else
                {
                    Console.WriteLine("eipä ole kelvollinen kouta uudestaan");
                }
            }

            //peli loop
            while (true)
            {
                Console.WriteLine("mitä hauat tehdä? valitse näistä:");
                Console.WriteLine("taistelu, kauppa, tavara");
                string choose = Console.ReadLine();

                if (choose != null)
                {
                    if (choose == "taistelu")
                    {
                        taistelu();
                    }
                    if (choose == "kauppa")
                    {
                        Console.WriteLine("kumpikauppa, potion vai tavara");
                        choose = Console.ReadLine();

                        // tavara kauppa
                        if (choose == "tavara")
                        {

                        }

                        // potion kauppa
                        if (choose == "potion")
                        {

                        }
                    }
                    if (choose == "tavara")
                    {
                        if (player.equip_inventory.Count == 0)
                        {
                            Console.WriteLine("ei löydy mitään tavaroita");
                        }
                        else
                        {
                            Console.WriteLine("tässä kaikki tavarasi:");
                            foreach (Equipment equip in player.equip_inventory)
                            {                                
                                Console.WriteLine(equip.name);
                            }
                            Console.WriteLine("----------");
                            Console.WriteLine("minkä valitset? kirjoita exit jos haluat takaisin");
                            choose = Console.ReadLine();
                            if (choose != null && choose != "exit")
                            {
                                player.equip
                            }
                            else
                            {
                                continue;
                            }
                         
                        }
                    }
                }
                Console.WriteLine("--------------------------------");
            }
        }
    }
}