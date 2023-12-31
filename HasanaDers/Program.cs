
using System;

namespace HasanaDers
{
    internal class Program
    {
        static void HayvanKos(Hayvan hayvan)
        {
            hayvan.Kos();
        }
        static void Main(string[] args)
        {
            At at = new At();
            Köpek köpek=new Köpek();    
            Hayvan hayvan = new Hayvan();
            Hayvan hayvan2 = new At();
            HayvanKos(at);
            HayvanKos(köpek);
            HayvanKos(hayvan);
            Console.ReadLine();
        }
    }
}
