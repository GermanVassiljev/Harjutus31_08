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

        public isik()
        {

        }
        public isik(string nimi, int synniAasta, sugus sugu)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            
        }
        public void muuda_Nimi(string uusNimi)
        {
            nimi = uusNimi;
        }
        public void muuda_Aasta(int uusAasta)
        {
            synniAasta = uusAasta;
        }
        public int arvutaVanus()
        {
            int tanaAasta = DateTime.Now.Year;
            int vanus = tanaAasta - synniAasta;
            return vanus;
        }

        public abstract void print_Info();
        
    }
}
