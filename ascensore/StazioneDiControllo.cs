using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_idraulico
{
    internal class StazioneDiControllo
    {
        private string serialNumber;
        private Ascensore ascensore1;


        public StazioneDiControllo(string serialNumber)
        {
            this.serialNumber = serialNumber;
            
        }

        public string SerialNumber
        {
            get { return serialNumber; }
        }
        public Ascensore Ascensore1
        {
            get { return ascensore1; }
            set { ascensore1 = value; }
        }


        public void SalireAscensore(Ascensore ascensore, int piani)
        {
            ascensore.salire(piani);
        }

        public void ScendereAscensore(Ascensore ascensore, int piani)
        {
            ascensore.scendere(piani);
        }

        public void Reset (Ascensore ascensore)
        {
            ascensore.reset();
        }

        public void posizioneAttuale (Ascensore ascensore)
        {
            ascensore.ConoscerePosizione();
        }

    }
}
