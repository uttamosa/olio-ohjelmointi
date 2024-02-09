using System.ComponentModel.DataAnnotations;

namespace reppu
{
    class Reppu
    {
        float _maxtilavuus;
        float _maxpaino;
        int _maxtavarat;

        List<Tavara> tavarat = new List<Tavara>();
        public float tilavuus
        {
            get 
            {
                if (tavarat == null)
                {
                    return 0;
                }
                else
                {
                    float tilavuus = 0;
                    foreach (Tavara tavara in tavarat)
                    {
                        tilavuus += tavara.tilavuus;
                    }
                    return tilavuus;
                }
            }
        }
        public float paino
        {
            get
            {
                if (tavarat == null)
                {
                    return 0;
                }
                else
                {
                    float paino = 0;
                    foreach (Tavara tavara in tavarat)
                    {
                        paino += tavara.paino;
                    }
                    return paino;
                }
            }
        }
        public int tavaramaara
        {
            get
            {
                if (tavarat == null)
                {
                    return 0;
                }
                else
                {
                    return tavarat.Count();
                }
            }
        }
        public Reppu(float maxtilavuus, float maxpaino, int maxtavara)
        {
            _maxtilavuus = maxtilavuus;
            _maxpaino = maxpaino;
            _maxtavarat = maxtavara;
        }

        public bool lisää_tavara(Tavara homma)
        {
            Console.WriteLine(homma);
            Console.WriteLine(tavarat);
            if (tilavuus + homma.tilavuus <= _maxtilavuus && paino + homma.paino <= _maxpaino && tavaramaara + 1 <= _maxtavarat)
            {
                tavarat.Add(homma);
                return true;
            }
            else 
            {
                Console.WriteLine("ei onnistunu. joko liikaa tavaroita tai liian painava taai liian tilavia tavaroita");
                return false; 
            }
        }
    }
}