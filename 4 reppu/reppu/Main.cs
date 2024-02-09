using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reppu
{
    internal class Homma
    {
        static void Main(string[] args)
        {
            float maxtilavuus = 15;
            float maxpaino = 20;
            int maxtavarat = 10;

            Reppu reppu = new Reppu(maxtilavuus,maxpaino,maxtavarat);

            while (true)
            {
                Console.WriteLine("moro");
                Console.WriteLine($"repussa on {reppu.tavaramaara}/{maxtavarat} tavaraa, {reppu.paino}/{maxpaino} painoa ja {reppu.tilavuus}/{maxtilavuus} tilavuutta");

                Console.WriteLine("Mitä haluat lisätä?");
                Console.WriteLine("1 - Nuoli");
                Console.WriteLine("2 - Jousi");
                Console.WriteLine("3 - Köysi");
                Console.WriteLine("4 - Vettå");
                Console.WriteLine("5 - Ruoka");
                Console.WriteLine("6 - Miekka");

                int valinta = Convert.ToInt32(Console.ReadLine());

                switch(valinta)
                {
                    case 1: 
                        reppu.lisää_tavara(new Nuoli());
                        break;

                    case 2: 
                        reppu.lisää_tavara(new Jousi());
                        break;

                    case 3:
                        reppu.lisää_tavara(new Köysi());
                        break;

                    case 4:
                        reppu.lisää_tavara(new Vesi());
                        break;

                    case 5:
                        reppu.lisää_tavara(new ruoka_annos());
                        break;

                    case 6:
                        reppu.lisää_tavara(new Miekka());
                        break;

                    default:
                        Console.WriteLine("täh piti pistööö nomero");
                        break;
                }
            }
        }
    }
}
