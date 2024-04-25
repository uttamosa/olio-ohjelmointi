namespace loppuprojekti
{
    internal class Player

    {
        public float hp;
        public float dmg;
        public int level;
        public string name;
        public int raha;

        public List<Equipment> equip_inventory = new List<Equipment>();
        public List<item> item_inventory = new List<item>();

        public Equipment armor;
        public Equipment weapon;

        public void print_stats()
        {
            //pistää kaikki statit
            Console.WriteLine("---------");
            Console.WriteLine($"hp {hp}");
            Console.WriteLine($"dmg {dmg}");
            Console.WriteLine($"level {level}");
            Console.WriteLine($"coins {raha}");
            if (armor != null)
            {
                Console.WriteLine($"armor {armor.name}");
            }
            else
            {
                Console.WriteLine("ei armoria");
            }
            if (weapon != null)
            {
                Console.WriteLine($"weapon {weapon.name}");
            }
            else
            {
                Console.WriteLine("ei asetta");
            }
        }
        public float attack()
        {
            //laskee paljon damagea teet
            Random random = new Random();
            float enemyattack = random.Next(100, 200) / 100f;
            float attackhomma = enemyattack * dmg;
            return attackhomma;
        }
        public void use_item()
        {
            if (!item_inventory.Any())
            {
                Console.WriteLine("sinulla ei ole yhtään potioneita");
            }
            else
            {
                while (true)
                {
                    int num = 1;
                    foreach (item item in item_inventory)
                    {
                        Console.WriteLine($"{num} {item.name}");
                        num += 1;
                    }
                    Console.WriteLine("minkä haluat käyttää? laita exit jos haluat takaisin");
                    string choose = Console.ReadLine();

                    if (choose == "exit")
                    {
                        Console.WriteLine("nojuu");
                        break;
                    }
                    else
                    {
                        try
                        {
                            int num2 = Int32.Parse(choose) -1;
                            item potion = item_inventory[num2];

                            hp *= 1 + potion.boost;
                            item_inventory.Remove(potion);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            continue;
                        }
                    }
                }
            }
        }
        public void equip(Equipment equip)
        {
            if (equip.type == "armor")
            {
                armor = equip;
            }
            if (equip.type == "weapon")
            {
                weapon = equip;
            }
        }
        public void go_to_shop(string shop)
        {
            if (shop == "1")
            {
                Console.WriteLine($"sinulla on {raha} rahaa");
                Console.WriteLine("----------");
                Console.WriteLine("potioneita kaupassa:");
                Console.WriteLine("1. lesser health potion - 5g");
                Console.WriteLine("2. normal health potion - 25g");
                Console.WriteLine("3. greater health potion - 200g");
                Console.WriteLine("----------");

                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    if (raha >= 5)
                    {
                        lesser_health_potion lhp = new lesser_health_potion();
                        item_inventory.Add(lhp);
                    }
                }
                else if (choose == "2")
                {
                    if (raha >= 25)
                    {
                        health_potion hp = new health_potion();
                        item_inventory.Add(hp);
                    }
                }
                if (choose == "3")
                {
                    if (raha >= 5)
                    {
                        greater_health_potion ghp = new greater_health_potion();
                        item_inventory.Add(ghp);
                    }
                }
            }

            if (shop == "2")
            {
                Console.WriteLine($"sinulla on {raha} rahaa");
                Console.WriteLine("----------");
                Console.WriteLine("potioneita kaupassa:");
                Console.WriteLine("1. wooden sword - 75g");
                Console.WriteLine("2. iron sword - 25g");
                Console.WriteLine("3. gobo armor - 60");
                Console.WriteLine("4. iron armor - 200g");
                Console.WriteLine("----------");

                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    if (raha >= 75)
                    {
                        wood_sword wood_Sword = new wood_sword();
                        equip_inventory.Add(wood_Sword);
                    }
                }
                else if (choose == "2")
                {
                    if (raha >= 25)
                    {
                        iron_sword iron_sword = new iron_sword();
                        equip_inventory.Add(iron_sword);
                    }
                }
                if (choose == "3")
                {
                    if (raha >= 60)
                    {
                        gobo_armor gobo_armor = new gobo_armor();
                        equip_inventory.Add(gobo_armor);
                    }
                }
                if (choose == "4")
                {
                    if (raha >= 200)
                    {
                        iron_armor iron_armor = new iron_armor();
                        equip_inventory.Add(iron_armor);
                    }
                }
            }
        }
        public void calculate_stats()
        {
            //lasketaan statit
            if (armor != null) 
            {
                hp = (8 + 0.6f * level) * (1 + armor.boost);
            }
            else
            {
                hp = (8 + 0.6f * level);
            }
            if (weapon != null)
            {
                dmg = (2 + 0.2f * level) * (1 + weapon.boost);
            }
            else
            {
                dmg = (2 + 0.2f * level);
            }
        }
    }
}