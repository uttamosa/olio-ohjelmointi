using loppuprojekti.enemies;

namespace loppuprojekti
{
    internal class Program
    {
        static void taistelu(enemy vihu, Player player)
        {
            player.calculate_stats();
            while (true)
            {
                Console.WriteLine("----------");
                if (player.hp <= 0)
                {
                    Console.WriteLine("kuolema :((");
                    break;
                }
                if (vihu.hp <= 0)
                {
                    Console.WriteLine("VOITIT :DDDD");
                    player.level += 1;
                    break;
                }

                Console.WriteLine($"sinulla on {player.hp} hpta");
                Console.WriteLine("");
                Console.WriteLine($"vihulla on {vihu.hp} hpta");
                Console.WriteLine("");
                Console.WriteLine("mitä haluat tehdä? hyökkää, tavara, juokse");

                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "hyökkää":
                        float attackings = player.attack();
                        vihu.hp -= attackings;
                        break;
                    case "tavara":
                        player.use_item(); 
                        break;
                }
            }
        }
        static void taistelu_valinta(Player player)
        {
            Console.WriteLine("mitä vastaan haluat taistella? tässä lista vihollisista:");
            Console.WriteLine("1. rat");
            Console.WriteLine("2. dog");
            Console.WriteLine("3. goblin");
            Console.WriteLine("4. orc");
            Console.WriteLine("5. sea snake");
            Console.WriteLine("6. dragon");

            string choose = Console.ReadLine();

            if (choose == "1")
            {
                rat vihu = new rat();
                taistelu(vihu, player);
            }
            else if (choose == "2")
            {
                dog vihu = new dog(1, 1);
                taistelu(vihu, player);
            }
            else if (choose == "3")
            {
                goblin vihu = new goblin(1, 1);
                taistelu(vihu, player);
            }
            else if (choose == "4")
            {
                orc vihu = new orc(1, 1);
                taistelu(vihu, player);
            }
            else if (choose == "5")
            {
                sea_snake vihu = new sea_snake(1, 1);
                taistelu(vihu, player);
            }
            else if (choose == "6")
            {
                dragon vihu = new dragon(1, 1);
                taistelu(vihu, player);
            }
            else
            {
                Console.WriteLine("täh");
            }
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
                Console.WriteLine("taistelu, kauppa, tavara, stats");
                string choose = Console.ReadLine();

                if (choose != null)
                {
                    if (choose == "taistelu")
                    {
                        taistelu_valinta(player);
                    }
                    if (choose == "kauppa")
                    {
                        Console.WriteLine("kumpikauppa, potion vai equip");
                        choose = Console.ReadLine();

                        // tavara kauppa
                        if (choose == "equip")
                        {

                        }

                        // potion kauppa
                        if (choose == "potion")
                        {

                        }
                    }
                    if (choose == "tavara")
                    {
                        if (player.equip_inventory == null)
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
                                player.equip(choose);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    if (choose == "stats")
                    {
                        player.print_stats();
                    }
                    Console.WriteLine("--------------------------------");
                }
            }
        }
    }
}