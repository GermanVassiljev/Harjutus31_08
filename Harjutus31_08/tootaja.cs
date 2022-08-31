using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus31_08
{
    public class tootaja : isik
    {
        string asut;
        string amet;
        int tootasu;


        public tootaja() { }

        public tootaja(string nimi,int synniAasta, sugus sugu, string asut = "---", string amet = "---", int tootasu = 0) : base(nimi, synniAasta, sugu)
        {
            this.asut = asut;
            this.amet = amet;
            this.tootasu = tootasu;
        }

        public double arvutiSissetulek(double maksuvaba, double tulumaks)
        {
            double netopalk = ((tootasu - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk; 
        }
        public override void print_Info()
        {
            Console.WriteLine("Nimi: {0}", nimi);
            Console.WriteLine("Asut nimi: {0}", asut);
            Console.WriteLine("amet: {0}", amet);
            Console.WriteLine($"Netopalk& {arvutiSissetulek(500,20)}");
            Console.WriteLine($"Vanus: {arvutaVanus()}");
            Console.WriteLine("Sugu: {0}", sugu);
        }
    }
}
