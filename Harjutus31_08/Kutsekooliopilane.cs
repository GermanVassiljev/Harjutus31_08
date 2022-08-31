using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Harjutus31_08.isik;

namespace Harjutus31_08
{
    public class Kutsekooliopilane : isik
    {
        string oppeasutus;
        string erialakursus;
        bool toetus;
        public Kutsekooliopilane() { }
        public Kutsekooliopilane(string nimi,int synniAasta,sugus sugu,string oppeasutus = "---", string erialakursus = "---", bool toetus= true) :base(nimi, synniAasta, sugu)
        {
            this.oppeasutus = oppeasutus;
            this.erialakursus = erialakursus;
            this.toetus = toetus;
        }
        public override void print_Info()
        {
            Console.WriteLine("Nimi: {0}", nimi);
            Console.WriteLine("Koolinimi: {0}", oppeasutus);
            Console.WriteLine("Klaas: {0}", erialakursus);
            Console.WriteLine("toetus: {0}", toetus);
            Console.WriteLine($"Vanus: {arvutaVanus()}");
            Console.WriteLine("Sugu: {0}", sugus.Isane);
        }
    }
}
