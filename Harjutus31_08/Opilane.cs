using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus31_08
{
    public class Opilane : isik
    {
        string koolinimi;
        string klaas;
        string spetsialiseerumine;
        public Opilane() { }
        public Opilane(string nimi,int synniAasta, sugus sugu, string koolinimi="---", string klaas="---", string spetsialiseerumine = "---") :base(nimi,synniAasta, sugu)
        {
            this.koolinimi = koolinimi;
            this.klaas = klaas;
            this.spetsialiseerumine = spetsialiseerumine;
        }
        public override void print_Info()
        {
            Console.WriteLine("Nimi: {0}",nimi);
            Console.WriteLine("Koolinimi: {0}", koolinimi);
            Console.WriteLine("Klaas: {0}", klaas);
            Console.WriteLine("Spetsialiseerumine: {0}",spetsialiseerumine);
            Console.WriteLine($"Vanus: {arvutaVanus}");
            Console.WriteLine("Sugu: {0}", sugu);
        }
    }
}
