using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace Harjutus31_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<isik> inimesed = new List<isik>();
            Opilane opilane = new Opilane("Ahmed", 2010, isik.sugus.Emane, "TMRG", "5B", "Ggrupp", 65, 1.85);
            tootaja tootaja = new tootaja("Martin", 2004, isik.sugus.Isane, "Mac", "Teine kassas", 650, 58, 1.64);
            Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("Ilja", 2004, isik.sugus.Isane, "TTHK", "TARpv21", true, 87, 1.78);

            inimesed.Add(kutsekooliopilane);
            inimesed.Add(tootaja);
            inimesed.Add(opilane);

            StreamWriter viilima = new StreamWriter(@"..\..\..\Inimesed.txt", false);
            foreach (isik p in inimesed)
            {
                p.print_Info();
                viilima.WriteLine(p.nimi + ", " + p.arvutaVanus() + ", " + p.sugu + ";");
            }
            viilima.Close();
            List<isik> LoetudFailist = new List<isik>();
            StreamReader sr = new StreamReader(@"..\..\..\Inimesed.txt");
            List<string> lines=new List<string>();
            int n= sr.ReadToEnd().Split(new char[] { '\n'}).Length;
            Console.WriteLine("-----"+n+"-------");
            StreamReader failist = new StreamReader(@"..\..\..\Inimesed.txt");
            string tekst = failist.ReadToEnd();
            Console.WriteLine(tekst);
            Console.ReadKey();
        }
    }
}

