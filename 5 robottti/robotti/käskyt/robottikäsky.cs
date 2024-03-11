using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotti
{
    public abstract class RobottiKäsky
    {
        public abstract void Suorita(Robotti toimija);

        protected string nimi;

        public string annanimi()
        {
            return nimi;
        }
    }
}
