using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace fotocopy
{
    public partial class Form1 : Form
    {
        static String stringRegistry = "Software\\carlosso\\photocopy";
        static List<String> typySouboruVse;
        static List<String> typySouboruFotky;
        static List<String> typySouboruRawy;
        static List<String> typySouboruVideo;
        static Int32 konstSirkaSloupce = 40;
        public Form1(String vychoziAdresar)
        {
            InitializeComponent();
            /*----nacteni hodnot z registry---*/
            labelExt.Text = "";

            /*---nejdriv musi byt maska, podle ni se nacitaji soubory--*/
            Nastaveni.typySouboruFotek = nactiHodnotuZRegistry("EXTFOTO");
            if (Nastaveni.typySouboruFotek == "")
            {
                Nastaveni.typySouboruFotek = "jpg";
            }
            Nastaveni.typySouboruRawy = nactiHodnotuZRegistry("EXTRAW");
            if (Nastaveni.typySouboruRawy == "")
            {
                Nastaveni.typySouboruRawy = "cr2 arw";
            }
            Nastaveni.typySouboruVidea = nactiHodnotuZRegistry("EXTVIDEO");
            if (Nastaveni.typySouboruVidea == "")
            {
                Nastaveni.typySouboruVidea = "avi mts mov mp4";
            }
            typySouboruVse = new List<String>();
            typySouboruVse.AddRange(Nastaveni.typySouboruFotek.Split(' '));
            typySouboruVse.AddRange(Nastaveni.typySouboruRawy.Split(' '));
            typySouboruVse.AddRange(Nastaveni.typySouboruVidea.Split(' '));

            typySouboruFotky = new List<String>();
            typySouboruFotky.AddRange(Nastaveni.typySouboruFotek.Split(' '));

            typySouboruRawy = new List<String>();
            typySouboruRawy.AddRange(Nastaveni.typySouboruRawy.Split(' '));

            typySouboruVideo = new List<String>();
            typySouboruVideo.AddRange(Nastaveni.typySouboruVidea.Split(' '));

            textBoxMaska.Text = nactiHodnotuZRegistry("MASKA");
            textBoxCilJpg.Text = nactiHodnotuZRegistry("CIL1");
            textBoxCilRaw.Text = nactiHodnotuZRegistry("CIL2");
            textBoxCilVideo.Text = nactiHodnotuZRegistry("CIL3");
            textBoxRawyMaska.Text = nactiHodnotuZRegistry("RAWMASKA");

            if (textBoxMaska.Text == "")
            {
                textBoxMaska.Text = "yyyy_MM_dd";
            }

            foreach (String typ in typySouboruVse)
            {
                ColumnHeader sloupec = listViewSouboryZdrojove.Columns.Add(typ);
                sloupec.Width = konstSirkaSloupce;
            }
            nastavControlyProZdroje();
            NactiVsechnySouboryZeZdroju();
        }
        private void nastavControlyProZdroje()
        {
            List<TextBox> zdrojeTB = vratTextBoxyZdroje();
            foreach(TextBox zdrojTB in zdrojeTB)
            {
                int index = zdrojeTB.IndexOf(zdrojTB);
                String klic = "ZDROJ" + index.ToString();
                zdrojTB.Text= nactiHodnotuZRegistry(klic);
                zdrojTB.TextChanged += textBoxZdrojTextZmenen;
                zdrojTB.DragEnter += textBoxZdrojVse_DragEnter;
                zdrojTB.DragDrop += textBoxZdrojVse_DragDrop;
            }
            List<Button> zdrojeButtony = vratButtonyZdroje();
            foreach(Button zdrojButton in zdrojeButtony)
            {
                zdrojButton.Click+= vyberZdroj;
            }
        }

        private void ulozHodnotyProZdroje()
        {
            List<TextBox> zdrojeTB = vratTextBoxyZdroje();
            foreach (TextBox zdrojTB in zdrojeTB)
            {
                int index = zdrojeTB.IndexOf(zdrojTB);
                String klic = "ZDROJ" + index.ToString();
                ulozHodnotuDoRegistry(klic,zdrojTB.Text);
            }
        }

        List<TextBox> vratTextBoxyZdroje()
        {
            List<TextBox> textBoxyZdroje = new List<TextBox>();
            for(int i=0;i<9;i++)
            {
               String nazevControlu = "textBoxZdroj" + i.ToString();
               TextBox txtBox = this.Controls.Find(nazevControlu,true).FirstOrDefault() as TextBox;
               if (txtBox == null) break;
               textBoxyZdroje.Add(txtBox);
            }
            return textBoxyZdroje;
        }
        List<Button> vratButtonyZdroje()
        {
            List<Button> buttonyZdroje = new List<Button>();
            for (int i = 0; i < 9; i++)
            {
                String nazevControlu = "buttonVyberZdroje" + i.ToString();
                Button button = this.Controls.Find(nazevControlu, true).FirstOrDefault() as Button;
                if (button == null) break;
                buttonyZdroje.Add(button);
            }
            return buttonyZdroje;
        }


        private String nactiHodnotuZRegistry(String nazevHodnoty)
        {
            String hodnota;
            try
            {
                RegistryKey klic = Registry.CurrentUser.OpenSubKey(stringRegistry);
                hodnota = klic.GetValue(nazevHodnoty).ToString();
                klic.Close();
            }
            catch (Exception)
            {
                hodnota = "";
            }
            return hodnota;
        }

        private void ulozHodnotuDoRegistry(String nazevHodnoty,String hodnota)
        {
            RegistryKey klic = Registry.CurrentUser.CreateSubKey(stringRegistry);
            klic.SetValue(nazevHodnoty, hodnota);
            klic.Close();
        }

        private void vyberZdroj(object sender, EventArgs e)
        {
            String volajiciButton = ((Button)sender).Name;
            String index = volajiciButton.Substring(volajiciButton.Length - 1, 1);
            Control[] control = this.Controls.Find("textBoxZdroj"+index,true);
            TextBox textBoxSCestou = (TextBox)control[0];
            /*----vyber zdrojoveho adresare1--*/
            if (textBoxSCestou.Text != "")
            {
                folderBrowserDialog1.SelectedPath = textBoxSCestou.Text;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxSCestou.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonVyberCileJpg_Click(object sender, EventArgs e)
        {
            /*----vyber ciloveho adresare pro *.jpg--*/
            if (textBoxCilJpg.Text != "")
            {
                folderBrowserDialog1.SelectedPath = textBoxCilJpg.Text;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxCilJpg.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void buttonVyberCileRaw_Click(object sender, EventArgs e)
        {
            /*----vyber ciloveho adresare pro *.cr2 a *.arw--*/
            if (textBoxCilRaw.Text != "")
            {
                folderBrowserDialog1.SelectedPath = textBoxCilRaw.Text;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxCilRaw.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonVyberCileVideo_Click(object sender, EventArgs e)
        {
            /*----vyber ciloveho adresare pro *.avi mov mp4 mts --*/
            if (textBoxCilVideo.Text != "")
            {
                folderBrowserDialog1.SelectedPath = textBoxCilRaw.Text;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxCilVideo.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void buttonNacti_Click(object sender, EventArgs e)
        {
            /*---nacte pocty do listview---*/
            listViewSouboryZdrojove.Items.Clear();
            NactiVsechnySouboryZeZdroju();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*----ulozeni hodnot do registry---*/
            ulozHodnotyProZdroje();
            ulozHodnotuDoRegistry("CIL1", textBoxCilJpg.Text);
            ulozHodnotuDoRegistry("CIL2", textBoxCilRaw.Text);
            ulozHodnotuDoRegistry("CIL3", textBoxCilVideo.Text);
            ulozHodnotuDoRegistry("MASKA", textBoxMaska.Text);
            ulozHodnotuDoRegistry("RAWMASKA", textBoxRawyMaska.Text);
            ulozHodnotuDoRegistry("EXTFOTO", Nastaveni.typySouboruFotek);
            ulozHodnotuDoRegistry("EXTRAW", Nastaveni.typySouboruRawy);
            ulozHodnotuDoRegistry("EXTVIDEO", Nastaveni.typySouboruVidea);
        }
        private String DejDatumSouboru(String soubor)
        {
            /*----vrati nazev adresare - podle data souboru---*/
            DateTime datum = File.GetLastWriteTime(soubor);
            String datumZobraz = datum.ToString(textBoxMaska.Text);
            return datumZobraz;
        }
        private void NactiVsechnySouboryZeZdroju()
        {
            /*----nacte vsechny druhy souboru ze zdrojoveho adresare---*/
            foreach (String ext in typySouboruVse)
            {
                NactiSouboruZeZdrojuJedneExtenze(ext);
            }
        }
        private void NactiSouboruZeZdrojuJedneExtenze(String ext)
        {
            Int16 pocet;
            List<string> soubory = VratSouboryVeZdrojovychAdresarichJedneExtenze(ext);

            foreach (String soubor in soubory)
            {
                /*---zjitim pozici extenze v poli, podle toho urcim sloupec v listView---*/
                Int32 sloupec = typySouboruVse.FindIndex(pol=>pol.Equals(ext));
                String datumZobraz = DejDatumSouboru(soubor);
                ListViewItem polozka = listViewSouboryZdrojove.FindItemWithText(datumZobraz);
                if (polozka == null)
                {
                    polozka = listViewSouboryZdrojove.Items.Add(datumZobraz);
                    foreach (String typ in typySouboruVse)
                    {
                        polozka.SubItems.Add("");
                    }
                }
                try
                {
                    pocet = Int16.Parse(polozka.SubItems[sloupec + 1].Text);
                }
                catch (Exception)
                {
                    pocet = 0;
                }
                pocet++;
                polozka.SubItems[sloupec + 1].Text = pocet.ToString();
            }
        }

        private int VratPocetSouboruVeZdrojovychAdresarich()
        {
            int pocetSouboru = 0;
            foreach (String ext in typySouboruVse)
            {
                List<String> soubory = VratSouboryVeZdrojovychAdresarichJedneExtenze(ext);
                pocetSouboru += soubory.Count;
            }
            return pocetSouboru;
        }

        private List<string> VratSouboryVeZdrojovychAdresarichJedneExtenze(string ext)
        {
            String zdrojovyAdresar = "";
            List<String> soubory = new List<String>();
            /*----nacte soubory ze zdrojovych adresaru-------*/
            List<TextBox> zdrojeTB = vratTextBoxyZdroje();
            foreach (TextBox zdrojTB in zdrojeTB)
            {
                try
                {
                    if (zdrojTB.Text.Trim() != "")
                    {
                        zdrojovyAdresar = zdrojTB.Text;
                        if (Directory.Exists(zdrojovyAdresar))
                        {
                            String[] soubory1 = Directory.GetFiles(zdrojovyAdresar, "*." + ext, SearchOption.AllDirectories);
                            soubory.AddRange(soubory1);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("CHYBA: Chyba při hledání ve zdrojovém adresáři: " + zdrojovyAdresar);
                }

            }
            soubory = soubory.Distinct().ToList();
            return soubory;
        }

        private void NadKopiruj()
        {
            /*-----spusteni kopirovani----*/
            if (textBoxCilJpg.Text == "" && textBoxCilRaw.Text == "" && textBoxCilVideo.Text == "")
            {
                MessageBox.Show("CHYBA: Není zadán ani jeden z cílových adresářů.");
                return;
            }
            Int32 pocetZkopirovanych;
            try
            {
                pocetZkopirovanych = 0;
                foreach (String ext in typySouboruVse)
                {
                    pocetZkopirovanych += Kopiruj(ext);
                }

                if (pocetZkopirovanych > 0)
                {
                    MessageBox.Show("Vše OK. Soubory zkopírovány. Počet: " + pocetZkopirovanych.ToString() + ".");
                }
                else
                {
                    MessageBox.Show("Nebyly nalezeny žádné soubory ke zkopírování.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chyba při kopírování.");
            }
        }
        private Int32 Kopiruj(String ext)
        {
            /*------zkopiruje soubory dane extenze do cilovych adresaru---*/
            Int32 pocetCelkem = 0;
            Int32 pocitadlo = 0;
            labelExt.Text = "*." + ext;
            labelExt.Refresh();

            List<string> soubory = VratSouboryVeZdrojovychAdresarichJedneExtenze(ext);
            foreach (String soubor in soubory)
            {
                pocetCelkem = soubory.Count();
                progressBar1.Maximum = pocetCelkem;
                progressBar1.Value = pocitadlo;
                String zdrojovySoubor = soubor;
                String cesta = Path.GetDirectoryName(soubor);
                String datumString = DejDatumSouboru(soubor);
                String rok = datumString.Substring(0, 4);
                String mezi = "";
                labelKopirovanySoubor.Text = "Probíhá kopírování souboru: " + soubor;
                if (textBoxMeziadresar.Text.Trim() != "")
                {
                    mezi = textBoxMeziadresar.Text.Trim() + @"\";
                }
                String cilovyAdresar;
                String cilovyAdresarZaklad;
                if(typySouboruRawy.FindIndex(pol => pol.Equals(ext))>=0)
                {
                    //-----raw----
                    cilovyAdresarZaklad = textBoxCilRaw.Text;
                }
                else
                {
                    if (typySouboruFotky.FindIndex(pol => pol.Equals(ext)) >= 0)
                    {
                        //----jpg-----
                        cilovyAdresarZaklad = textBoxCilJpg.Text;
                    }
                    else
                    {
                        //---video---
                        cilovyAdresarZaklad = textBoxCilVideo.Text;
                    }
                }
                cilovyAdresar= cilovyAdresarZaklad +@"\" + rok + @"\" + mezi + datumString;

                if (!Directory.Exists(cilovyAdresar))
                {
                    Directory.CreateDirectory(cilovyAdresar);
                }
                String cilovySoubor = cilovyAdresar + @"\" + Path.GetFileName(soubor);
                try
                {
                    File.Copy(zdrojovySoubor, cilovySoubor, true);
                    pocitadlo++;
                }
                catch (IOException ex)
                {
                    const long ERROR_HANDLE_DISK_FULL = 0x27;
                    const long ERROR_DISK_FULL = 0x70;
                    long win32ErrorCode = Marshal.GetHRForException(ex) & 0xFFFF;
                    if (win32ErrorCode == ERROR_HANDLE_DISK_FULL || win32ErrorCode == ERROR_DISK_FULL)
                    {
                        MessageBox.Show("CHYBA: Nedostatek místa na disku.");
                        throw ex;
                        // Error is due to "out of disk space"
                    }
                }
            }
            labelExt.Text = "";
            progressBar1.Value = pocetCelkem;
            labelKopirovanySoubor.Text = "";
            return pocitadlo;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerCopy.IsBusy == false)
            {
                backgroundWorkerCopy.RunWorkerAsync();
            }
        }

        private void NadSmaz()
        {
            Int32 pocetNeuspesneCelkem = 0;
            Int32 pocetUspesneCelkem = 0;
            Int32 pocetNeuspesne;
            Int32 pocetUspesne;
            Int32 pocetKeSmazaniCelkem = VratPocetSouboruVeZdrojovychAdresarich();
            if (pocetKeSmazaniCelkem < 0)
            {
                MessageBox.Show("Chyba při hledání souborů, co se mají smazat!");
                return;
            }
            if (pocetKeSmazaniCelkem == 0)
            {
                MessageBox.Show("Nebyl nalezen žádný soubor, co by se měl smazat.");
                return;
            }
            DialogResult res = MessageBox.Show("Opravdu smazat? Počet souborů: " + pocetKeSmazaniCelkem.ToString() + ".", "Dotaz", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Int32 pocitadlo = 0;
                progressBar1.Maximum = pocetKeSmazaniCelkem;
                /*-----smazani zdrojovych souboru---*/
                pocetNeuspesne = 0;
                pocetUspesne = 0;
                foreach (String ext in typySouboruVse)
                {
                    Smaz(ext, ref pocetUspesne, ref pocetNeuspesne, ref pocitadlo);
                    pocetUspesneCelkem += pocetUspesne;
                    pocetNeuspesneCelkem += pocetNeuspesne;
                }
                if (pocetUspesne == 0)
                {
                    MessageBox.Show("Nebyly nalezeny žádné soubory ke smazání.");
                }
                else
                {
                    if (pocetNeuspesne == 0)
                    {
                        MessageBox.Show("Vše OK. Soubory smazány.");
                    }
                    else
                    {
                        MessageBox.Show("CHYBA. Počet neúspěšně smazaných: " + pocetNeuspesne.ToString() + ".");
                    }
                    NactiVsechnySouboryZeZdroju();
                }
            }
        }

        private void Smaz(String ext, ref Int32 pocetUspesne, ref Int32 pocetNeuspesne, ref Int32 pocitadlo)
        {
            String[] soubory;
            /*-----spusteni smazani zdrojovych souboru---*/
            /*----nacte soubory ze zdrojovych adresaru-------*/
            List<TextBox> zdrojeTB = vratTextBoxyZdroje();
            foreach (TextBox zdrojTB in zdrojeTB)
            {
                try
                {
                    soubory = Directory.GetFiles(zdrojTB.Text, "*." + ext, SearchOption.AllDirectories);
                }
                catch (DirectoryNotFoundException)
                {
                    return;
                }
                foreach (String soubor in soubory)
                {
                    try
                    {
                        File.Delete(soubor);
                        pocitadlo++;
                        progressBar1.Value = pocitadlo;
                    }
                    catch (Exception)
                    {
                        pocetNeuspesne++;
                    }
                    pocetUspesne++;
                }
            }
            return;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerDelete.IsBusy == false)
            {
                backgroundWorkerDelete.RunWorkerAsync();
            }
        }

        private void textBoxZdrojTextZmenen(object sender, EventArgs e)
        {
            listViewSouboryZdrojove.Items.Clear();
            NactiVsechnySouboryZeZdroju();
        }


        private void textBoxMaska_TextChanged(object sender, EventArgs e)
        {
            /*--otestuji, jestli je maska zadana dobre---*/
            DateTime ted = DateTime.Now;
            String retez;
            try
            {
                retez = ted.ToString(textBoxMaska.Text);
                labelPriklad.Text = retez;

            }
            catch (Exception)
            {
                MessageBox.Show("CHYBA. Takto to nemůže být zadáno.");
            }
        }

        private void textBoxCil1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                textBoxCilJpg.Text = a.GetValue(0).ToString();
            }

        }

        private void textBoxCil1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private void textBoxZdrojVse_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void textBoxZdrojVse_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                TextBox textBoxZdroj=(TextBox)sender;
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                textBoxZdroj.Text = a.GetValue(0).ToString();
            }
        }

        private void textBoxCil2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                textBoxCilRaw.Text = a.GetValue(0).ToString();
            }

        }

        private void textBoxCil2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerCopy_DoWork(object sender, DoWorkEventArgs e)
        {
            NadKopiruj();
        }

        private void backgroundWorkerDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            NadSmaz();

        }

        private void textBoxCilVideo_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                textBoxCilVideo.Text = a.GetValue(0).ToString();
            }

        }

        private void textBoxCilVideo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void buttonSmazRawy_Click(object sender, EventArgs e)
        {
            /*----smaze na PC rawy, ktere nemaji odpovidajici *.jpg soubor
 * tyka se to souboru na cilovych cestach---*/
            /*----vyber adresare, kde jsou na PC rawy --*/
            DialogResult result;
            /*---kontrola, zda je adresar zadan---*/
            if (textBoxCilRaw.Text == "")
            {
                MessageBox.Show("CHYBA: Základní adresář, kde se mají hledat rawy není zadán.");
                return;
            }
            if (textBoxCilJpg.Text == "")
            {
                MessageBox.Show("CHYBA: Základní adresář, kde se mají hledat *.jpg není zadán.");
                return;
            }
            /*
            if (textBoxKonec.Text == "")
            {
                MessageBox.Show("CHYBA: Podadresář, kde se mají mazat rawy není zadán.");
                return;
            }
            */

            /*---kontrola, zda je adresar existuje---*/

            Int32 budeSmazano = DelRaw.ProjdiSmaz(textBoxCilRaw.Text, false, textBoxCilRaw.Text, textBoxCilJpg.Text, textBoxRawyMaska.Text);
            if (budeSmazano > 0)
            {

                result = MessageBox.Show("Počet souborů, který bude smazán: " + budeSmazano.ToString() + ". Pokračovat?", "Dotaz", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Int32 byloSmazano = DelRaw.ProjdiSmaz(textBoxCilRaw.Text, true, textBoxCilRaw.Text, textBoxCilJpg.Text, textBoxRawyMaska.Text);
                    MessageBox.Show("Počet souborů, který byl smazán: " + byloSmazano.ToString() + ".");

                }
            }
            else
            {
                if (budeSmazano == 0)
                {
                    MessageBox.Show("Nebyly nalezeny žádné soubory ke smazání.");
                }
                else
                {
                    MessageBox.Show("CHYBA při čtení z adresáře pro rawy.");
                }
            }

        }

        private void buttonNastaveni_Click(object sender, EventArgs e)
        {
            FormNastaveni formNastaveni = new FormNastaveni();
            formNastaveni.ShowDialog();
        }
    }
}
