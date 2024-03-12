using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loppuprojekti
{
    internal class dog : enemy
    {
        
        public dog(float hp, float dmg)
        {
            hp *= 5f;
            dmg *= 1f;
        }
    }
}
