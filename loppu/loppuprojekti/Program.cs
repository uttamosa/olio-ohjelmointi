using loppuprojekti.enemies;

namespace loppuprojekti
{
    internal class Program
    {
        static void taistelu(enemy vihu, Player player)
        {
            //taistelu alkaa
            player.calculate_stats();
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("----------");
                if (player.hp <= 0)
                {
                    Console.WriteLine("kuolema :((");
                    Console.WriteLine("kuolit joten menetät himan juttuja");
                    player.level -= vihu.levels * 3;
                    break;
                }
                if (vihu.hp <= 0)
                {
                    Console.WriteLine("VOITIT :DDDD");
                    if (vihu.drops != null)
                    {
                        //jos hyvö tuuri saat jonku palkkion
                        if (random.Next(0, 100) >= 80)
                        {
                            player.equip_inventory.Add(vihu.drops[random.Next(0,vihu.drops.Count)]);
                            Console.WriteLine("sait jonkun dropin :D");
                        }
                    }
                    player.level += vihu.levels;
                    player.raha += vihu.levels * 5;
                    break;
                }

                Console.WriteLine($"sinulla on {player.hp} hpta");
                Console.WriteLine("");
                Console.WriteLine($"vihulla on {vihu.hp} hpta");
                Console.WriteLine("");
                Console.WriteLine("mitä haluat tehdä? 1: hyökkää, 2: tavara, 3: juokse");

                string choose = Console.ReadLine();

                if (choose == "3")
                {
                    break;
                }

                switch (choose)
                {
                    case "1":
                        float attackings = player.attack();
                        vihu.hp -= attackings;
                        Console.WriteLine($"teit {attackings} damagea");
                        break;

                    case "2":
                        player.use_item();
                        break;
                }

                float enemyattack = random.Next(100, 200) / 100f;
                player.hp -= enemyattack * vihu.dmg;

                
                Console.WriteLine($"vihu teki {enemyattack * vihu.dmg} damagea");
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
                dog vihu = new dog();
                taistelu(vihu, player);
            }
            else if (choose == "3")
            {
                goblin vihu = new goblin();
                taistelu(vihu, player);
            }
            else if (choose == "4")
            {
                orc vihu = new orc();
                taistelu(vihu, player);
            }
            else if (choose == "5")
            {
                sea_snake vihu = new sea_snake();
                taistelu(vihu, player);
            }
            else if (choose == "6")
            {
                dragon vihu = new dragon();
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

            //nimi ei tässä edes tee mitään eikä sitä taideta kertaakaan käyttää missään kun en oikeen keksiny sille käyttöä mut siinä se kuitenki on

            //peli loop
            while (true)
            {
                if (player.level <= 0)
                {
                    Console.WriteLine("voi muna levelisi tippui alle 0, joten sain aivovaurion. peli loppu");
                }
                Console.WriteLine("mitä hauat tehdä? valitse näistä:");
                Console.WriteLine("1: taistelu, 2:  kauppa, 3: tavara, 4: stats");
                string choose = Console.ReadLine();

                if (choose != null)
                {
                    if (choose == "1")
                    {
                        taistelu_valinta(player);
                    }
                    if (choose == "2")
                    {
                        Console.WriteLine("kumpikauppa, 1: potion vai 2: equip");
                        choose = Console.ReadLine();

                        // potio  kauppa
                        if (choose == "1")
                        {
                            player.go_to_shop("1");
                        }

                        // tavara kauppa
                        if (choose == "2")
                        {
                            player.go_to_shop("2");
                        }
                    }
                    if (choose == "3")
                    {
                        if (!player.equip_inventory.Any())
                        {
                            Console.WriteLine("ei löydy mitään tavaroita");
                        }
                        else
                        {
                            Console.WriteLine("tässä kaikki tavarasi:");
                            int num = 1;
                            foreach (Equipment equip in player.equip_inventory)
                            {
                                Console.WriteLine($"{num} {equip.name}");
                                num++;
                            }
                            Console.WriteLine("----------");
                            Console.WriteLine("minkä valitset? laita numero. kirjoita exit jos haluat takaisin");
                            int choosenum = Convert.ToInt32(Console.ReadLine());
                            if (choose != null && choose != "exit")
                            {
                                player.equip(player.equip_inventory[choosenum - 1]);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    if (choose == "4")
                    {
                        player.calculate_stats();

                        player.print_stats();
                    }
                    Console.WriteLine("----------");
                }
            }
        }
    }
}