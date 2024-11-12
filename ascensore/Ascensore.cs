using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_idraulico
{
    internal class Ascensore
    {
        public string serialNumber;
        public string produttore;
        public int capacitaMax;
        public int speedMax;
        public int posizioneAttuale=0;
        public int maxFloor = 20;

        public Ascensore(string serialNumber, string produttore, int capacitaMax, int speedMax, int poszioneAttuale)
        {
            this.serialNumber = serialNumber;
            this.capacitaMax = capacitaMax;
            this.speedMax = speedMax;
            this.posizioneAttuale = poszioneAttuale;
        }

        public string SerialNumber
        {
            get {  return serialNumber; }
        }

        public string Produttore
        {
            get { return produttore; }
        }

        public int CapacitaMax
        {
            get { return capacitaMax; }
        }

        public int SpeedMax
        {
            get { return speedMax; }
        }

        public int PosizioneAttuale
        {
            get { return posizioneAttuale; }
        }

        public int Maxfloor
        {
            get { return maxFloor; }
        }
        /*
        public void salire(int piani)
        {
            if ((posizioneAttuale + piani <= maxFloor))
            {
                posizioneAttuale = piani;
            }
            else
                return;
        }

        public void scendere(int piani)
        {
            if ((posizioneAttuale - piani >= 0))
            {
                posizioneAttuale = piani;
            }
            else
                return;
        }*/

        public void cambiaPiano (int piani)
        {
            /*
            if (posizioneAttuale + piani <= maxFloor)
            {
                posizioneAttuale = piani;
            }
            else
                return;
            */
            posizioneAttuale = piani;
        }

        public void reset ()
        {
            posizioneAttuale = 0;
        }

        public int ConoscerePosizione()
        {
            return posizioneAttuale;
        }
    }
}
