namespace loppuprojekti
{
    internal class Player

    {
        public float hp;
        public float dmg;
        public int level = 0;
        public string name;
        public int raha;

        public List<Equipment> equip_inventory;
        public List<item> item_inventory;
        public Equipment armor;
        public Equipment weapon;

        public void print_stats()
        {
            Console.WriteLine("---------");
            Console.WriteLine($"hp {hp}");
            Console.WriteLine($"dmg {dmg}");
            Console.WriteLine($"level {level}");
            if (armor != null)
            {
                Console.WriteLine($"armor {armor}");
            }
            else
            {
                Console.WriteLine("ei armoria");
            }
            if (weapon != null)
            {
                Console.WriteLine($"weapon {weapon}");
            }
            else
            {
                Console.WriteLine("ei asetta");
            }
        }
        public float attack()
        {
            Random random = new Random();
            float random1 = random.Next(50,150) / 100;

            float attack = random1 * dmg;
            return attack;
        }
        public void use_item()
        {
            if (item_inventory.Count == null)
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
                            int num2 = Int32.Parse(choose);
                            item potion = item_inventory[num2];

                            hp *= 1 + potion.boost;
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("jokin meni pieleen");
                            continue;
                        }
                    }
                }
            }
        }
        public void equip(string name)
        {
            
            foreach (Equipment equip in equip_inventory)
            {
                if (equip.name == name)
                {
                    if (equip.type == "armor")
                    {
                        armor = equip;
                    }
                    if (equip.type == "weapon")
                    {
                        weapon = equip;
                    }
                    else
                    {
                        Console.WriteLine("töh");
                    }
                }
            }
        }
        public void go_to_shop()
        {

        }
        public void calculate_stats()
        {
            if (armor != null) 
            {
                hp = (10 + 2 * level) * (1 + armor.boost);
            }
            else
            {
                hp = (10 + 2 * level);
            }
            if (weapon != null)
            {
                dmg = (3 + 0.5f * level) * (1 + weapon.boost);
            }
            else
            {
                dmg = (3 + 0.5f * level);
            }
        }
    }
}
