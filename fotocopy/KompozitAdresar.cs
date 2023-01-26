using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace photocopy
{
    public class KompozitAdresar:KomponentaFileSystemu
    {
        private string nazev;
        private bool jeAdresar;

        public KompozitAdresar(string nazev)
        {
            this.nazev = nazev;
            this.jeAdresar = true;
        }

	public void prohledejAPridej(List<KomponentaFileSystemu> seznamKomponent, string[] maska) {
		string [] soubory;
		string [] adresare;

		soubory = Directory.GetFiles(this.getNazev(), maska[1]);
		foreach(string nazevSouboru in soubory)
		{
            Soubor soubor = new Soubor(nazevSouboru);
            soubor.prohledejAPridej(seznamKomponent,maska);
		}

        adresare = Directory.GetDirectories(this.getNazev(), maska[0]+"*");
        foreach (string nazevAdresare in adresare)
        {
            KompozitAdresar adresar = new KompozitAdresar(nazevAdresare);
            adresar.prohledejAPridej(seznamKomponent,maska);
        }
		
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
