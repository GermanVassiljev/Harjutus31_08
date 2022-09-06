using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus31_08
{
    public abstract class isik
    {
        public string nimi;
        public int synniAasta;
        public enum sugus
        {
            Isane,
            Emane
        }
        public sugus sugu;
        public double kaal;
        public double pikkus;
        public string indeks;

        public isik()
        {

        }
        public isik(string nimi, int synniAasta, sugus sugu, double kaal, double pikkus)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.sugu = sugu;
            this.kaal = kaal;
            this.pikkus = pikkus;
        }
        public void muuda_Nimi(string uusNimi)
        {
            nimi = uusNimi;
        }

        public int arvutaVanus()
        {
            int tanaAasta = DateTime.Now.Year;
            int vanus = tanaAasta - synniAasta;
            return vanus;
        }
        public string KMI()
        {
            double kehamassiindeks = kaal / (pikkus * 2);
            if (kehamassiindeks<=16.5)
            {
                indeks = $"Äärmuslik kaalupuudus {kehamassiindeks}";
            }
            else if (kehamassiindeks>=16.4 && kehamassiindeks<=18.5)
            {
                indeks = $"Nalakaaluline {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 18.5 && kehamassiindeks <= 25)
            {
                indeks = $"Normalne {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 25 && kehamassiindeks <= 30.1)
            {
                indeks = $"Ülekaaluline {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 30.1 && kehamassiindeks <= 35)
            {
                indeks = $"Rasvumine (I klass) {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 35 && kehamassiindeks <= 40.1)
            {
                indeks = $"Rasvumine (II klass) {kehamassiindeks}";
            }
            else if (kehamassiindeks >= 40)
            {
                indeks = $"Rasvumine (III klass) {kehamassiindeks}";
            }
            return indeks;
        }

        public abstract void print_Info();
        
    }
}
