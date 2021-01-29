using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace photocopy
{
    public class Soubor : KomponentaFileSystemu
    {
        private string nazev;
        private bool jeAdresar;
        public Soubor(string nazev)
        {
            this.nazev = nazev;
            this.jeAdresar = false;
        }

        public void prohledejAPridej(List<KomponentaFileSystemu> seznamKomponent, string maska)
        {
            seznamKomponent.Add(this);
        }

        public string getNazev()
        {
          return this.nazev;
        }
        public bool getJeAdresar()
        {
            return this.jeAdresar;
        }

    }
}
