enum ovitila { auki, kiinni, lukossa};

class oviholmeli
{
    static void Main(string[] args)
    {
        ovitila tila = ovitila.auki;
        Console.WriteLine(tila);
        while (true) {

            string toiminto = Console.ReadLine();
               
            if (toiminto == "avaa" && tila == ovitila.kiinni)
            {
                tila = ovitila.auki;
                Console.WriteLine("on auki");
            }

            else if (toiminto == "sulje" && tila == ovitila.auki)
            {
                tila = ovitila.kiinni;
                Console.WriteLine("on kiinni");
            }

            else if (toiminto == "lukitse" && tila == ovitila.kiinni)
            {
                tila = ovitila.lukossa;
                Console.WriteLine("on lukissa");
            }
            else
            {
                Console.WriteLine("eipä timinu");
            }
        }
    }
}
