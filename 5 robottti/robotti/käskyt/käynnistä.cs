﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotti
{
    internal class käynnistä : RobottiKäsky
    {
        public override void Suorita(Robotti toimija)
        {
            toimija.OnKäynnissä = true;
        }
    }
}
