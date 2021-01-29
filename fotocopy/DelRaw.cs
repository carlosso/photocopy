using photocopy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fotocopy
{
    class DelRaw
    {
        private static String PremenCestuKRawuNaCestuKJpg(String celaCestaKSouboruCr2, String horniCastyCestyKRaw, String horniCastCestyKJgp)
        {
            /*---vrati jmeno (s cestou) odpovidajiciho jpg souboru--*/
            /*---musim odriznout horni cast cesty k rawu a nahradit ji horni casti cesty k jpg---*/
            String celaCestaKSouboruJpg = "";
            celaCestaKSouboruJpg = celaCestaKSouboruCr2.Replace(horniCastyCestyKRaw, horniCastCestyKJgp);
            celaCestaKSouboruJpg = celaCestaKSouboruJpg.Substring(0, celaCestaKSouboruJpg.Length - 3);
            celaCestaKSouboruJpg += "jpg";
            return celaCestaKSouboruJpg;
        }

        public static Int32 ProjdiSmaz(String kdeMazat, Boolean mazat, String horniCastyCestyKRaw, String horniCastCestyKJgp)
        {
            Int32 pocetSmazat = 0;
            List<string> soubory;
            List<string> souboryJednaPripona;
            soubory = new List<string>();
            try
            {
                souboryJednaPripona = vratVyhledejAVratSouboryRekurzivne(kdeMazat, "*.cr2");
                soubory.AddRange(souboryJednaPripona);
                souboryJednaPripona = vratVyhledejAVratSouboryRekurzivne(kdeMazat, "*.arw");
                soubory.AddRange(souboryJednaPripona);
            }
            catch (Exception)
            {
                return -1;
            }
            foreach (String soubor in soubory)
            {
                /*----podivam se jestli existuje odpovidajici *.jpg----*/
                String jmenoJpg = PremenCestuKRawuNaCestuKJpg(soubor, horniCastyCestyKRaw, horniCastCestyKJgp);
                if (File.Exists(jmenoJpg))
                {
                    continue;
                }
                else
                {
                    pocetSmazat++;
                    if (mazat)
                    {
                        File.Delete(soubor);
                    }
                }
            }
            return pocetSmazat;
        }

        private static List<String> vratVyhledejAVratSouboryRekurzivne(String kdeHledat, String maska)
        {

            List<KomponentaFileSystemu> seznamKomponent = new List<KomponentaFileSystemu>();
            KompozitAdresar vychoziBod = new KompozitAdresar(kdeHledat);
            seznamKomponent.Add(vychoziBod);
            (seznamKomponent[0]).prohledejAPridej(seznamKomponent, maska);

            List<String> nalezeneSoubory = new List<String>();
            foreach (KomponentaFileSystemu komponenta in seznamKomponent)
            {
                if (komponenta.getJeAdresar() == false)
                {
                    nalezeneSoubory.Add(komponenta.getNazev());
                }
            }
            return nalezeneSoubory;
        }

        private void buttonSmazSirotky_Click(object sender, EventArgs e)
        {


        }

        public static String UrizniVrch(String Vrsek, String celaCesta)
        {
            String vrat;
            //----podivam se, zda je v retezci obsazena adresar pro rawy. Musi byt na pozici 0. Jinak je to spatne.
            if (Vrsek == celaCesta)
            {
                return "";
            }
            if (celaCesta.IndexOf(Vrsek) == 0)
            {
                vrat = celaCesta.Substring(Vrsek.Length + 1);
            }
            else
            {
                vrat = "";
            }
            return vrat;
        }

    }
}
