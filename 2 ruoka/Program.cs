using System.Runtime.InteropServices;

class holmeli
{
    enum raaka { kana, jäätelö, puolukka }
    enum lisukkeet { konvehtirasia, ruoho, kananmuna}
    enum kastike { tomaatti, jauheliha, suklaakastike}

    struct annos
    {
        public string raaka;
        public string lisuke;
        public string 
    }

    static void Main(string[] args)
    {
        Console.WriteLine("mikä raakaaine syömiseen");
        string raaka = Console.ReadLine();

        Console.WriteLine("mikä raakaaine syömiseen");
        string lisuke = Console.ReadLine();

        Console.WriteLine("mikä raakaaine syömiseen");
        string kastike = Console.ReadLine();
    }
}