using loppuprojekti.equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loppuprojekti
{
    internal class Player

    {
        public float hp;
        public float dmg;
        public int level;
        public string name;
        public int raha;

        public List<Equipment> equip_inventory;
        public List<item> item_inventory;
        public Equipment armor;
        public Equipment weapon;

        public void attack()
        {

        }

        public void use_item()
        {

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

        public void calculate_stats(Equipment armor, Equipment weapon, int level)
        {
            hp = (10 + 2 * level) * (1 + armor.boost);
            dmg = (3 + 0.5f * level) * (1 + weapon.boost);
        }
    }
}
