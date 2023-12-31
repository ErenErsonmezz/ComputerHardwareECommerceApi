

using System;

namespace HasanaDers
{
    public class Hayvan
    {
        public int AyakSayisi {  get; set; }
        public int GozSayisi { get; set; }
        public bool Nefes {  get; set; }

        public void SesÇıkar()
        {
            Console.WriteLine("Ses Çıkar");
        }
        public virtual void Kos()
        {
            Console.WriteLine("Koş");
        }
    
    }
}
