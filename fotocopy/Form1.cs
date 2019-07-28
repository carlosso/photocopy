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

namespace fotocopy
{
    public partial class Form1 : Form
    {
        static String stringRegistry = "Software\\carlosso\\photocopy";
        static String[] typy = { "jpg", "cr2", "avi", "mov", "mp4","arw","mts" };
        static Int32 konstSirkaSloupce = 40;
        public Form1(String vychoziAdresar)
        {
            InitializeComponent();
            /*----nacteni hodnot z registry---*/
            labelExt.Text = "";
            try
            {
                RegistryKey klic = Registry.CurrentUser.OpenSubKey(stringRegistry);
                /*---nejdriv musi byt maska, podle ni se nacitaji souboru--*/
                textBoxMaska.Text = klic.GetValue("MASKA").ToString();
                textBoxZdroj.Text = klic.GetValue("ZDROJ").ToString();
                textBoxCilJpg.Text = klic.GetValue("CIL1").ToString();
                textBoxCilRaw.Text = klic.GetValue("CIL2").ToString();
                textBoxCilVideo.Text = klic.GetValue("CIL3").ToString();
                klic.Close();
            }
            catch (Exception)
            {

            }
            if (textBoxMaska.Text == "")
            {
                textBoxMaska.Text = "yyyy_MM_dd";
            }

            foreach (String typ in typy)
            {
                ColumnHeader sloupec = listView1.Columns.Add(typ);
                sloupec.Width = konstSirkaSloupce;
            }
        }


        private void buttonVyberZdroje_Click(object sender, EventArgs e)
        {
            /*----vyber zdrojoveho adresare--*/
            if (textBoxZdroj.Text != "")
            {
                folderBrowserDialog1.SelectedPath = textBoxZdroj.Text;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxZdroj.Text = folderBrowserDialog1.SelectedPath;
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
            listView1.Items.Clear();
            if (!NactiVsechnySoubory())
            {
                MessageBox.Show("Adresář, odkud se má kopírovat, neexistuje!");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*----ulozeni hodnot do registry---*/
            RegistryKey klic = Registry.CurrentUser.CreateSubKey(stringRegistry);
            klic.SetValue("ZDROJ", textBoxZdroj.Text);
            klic.SetValue("CIL1", textBoxCilJpg.Text);
            klic.SetValue("CIL2", textBoxCilRaw.Text);
            klic.SetValue("CIL3", textBoxCilVideo.Text);
            klic.SetValue("MASKA", textBoxMaska.Text);
            klic.Close();
        }
        private String DejDatumSouboru(String soubor)
        {
            /*----vrati nazev adresare - podle data souboru---*/
            DateTime datum = File.GetLastWriteTime(soubor);
            String datumZobraz = datum.ToString(textBoxMaska.Text);
            return datumZobraz;
        }
        private Boolean NactiVsechnySoubory()
        {
            /*----nacte vsechny druhy souboru ze zdrojoveho adresare, vrati true pokud adresar existuje, false pokud neexistuje---*/
            if (Directory.Exists(textBoxZdroj.Text))
            {
                foreach (String ext in typy)
                {
                    NactiZdroj(ext);
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        private void NactiZdroj(String ext)
        {
            Int16 pocet;
            /*----nacte soubory ze zdrojoveho adresare, naplni listview--*/
            String[] soubory = Directory.GetFiles(textBoxZdroj.Text, "*." + ext, SearchOption.AllDirectories);

            foreach (String soubor in soubory)
            {
                /*---zjitim pozici extenze v poli, podle toho urcim sloupec v listView---*/
                Int32 sloupec = Array.IndexOf<String>(typy, ext);
                String datumZobraz = DejDatumSouboru(soubor);
                ListViewItem polozka = listView1.FindItemWithText(datumZobraz);
                if (polozka == null)
                {
                    polozka = listView1.Items.Add(datumZobraz);
                    foreach (String typ in typy)
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
        private void NadKopiruj()
        {
            /*-----spusteni kopirovani----*/
            if (textBoxCilJpg.Text == "" && textBoxCilRaw.Text == "")
            {
                MessageBox.Show("CHYBA: Není zadán ani jeden z cílových adresářů.");
                return;
            }
            if (Directory.Exists(textBoxZdroj.Text))
            {
                Int32 pocetZkopirovanych;
                try
                {
                    pocetZkopirovanych = 0;
                    foreach (String ext in typy)
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
            else
            {
                MessageBox.Show("Zdrojový adresář neexistuje!");
            }
        }
        private Int32 Kopiruj(String ext)
        {
            /*------zkopiruje soubory dane extenze do cilovych adresaru---*/
            Int32 pocetCelkem =0 ;
            String[] souboryMov;
            Int32 pocitadlo = 0;
            labelExt.Text = "*." + ext;
            labelExt.Refresh();

            String[] soubory = Directory.GetFiles(textBoxZdroj.Text, "*." + ext, SearchOption.AllDirectories);
            if (ext == "jpg")
            {
                /*---nactu movy----*/
                souboryMov = Directory.GetFiles(textBoxZdroj.Text, "*.mov", SearchOption.AllDirectories);
            }
            else
            {
                souboryMov = null;
            }
            foreach (String soubor in soubory)
            {
                pocetCelkem = soubory.Count();
                progressBar1.Maximum = pocetCelkem;
                progressBar1.Value = pocitadlo;
                String zdrojovySoubor = soubor;
                String cesta = Path.GetDirectoryName(soubor);
                String datumString = DejDatumSouboru(soubor);
                String mezi = "";
                labelKopirovanySoubor.Text = "Probíhá kopírování souboru: " +soubor;
                if (textBoxMeziadresar.Text.Trim() != "")
                {
                    mezi = textBoxMeziadresar.Text.Trim() + @"\";
                }
                String cilovyAdresar;
                switch (ext) {
                    case "arw":
                    case "cr2":
                        cilovyAdresar = textBoxCilRaw.Text + @"\" + mezi + datumString;
                        break;
                    case "jpg":
                        cilovyAdresar = textBoxCilJpg.Text + @"\" + mezi + datumString;
                        /*--u jpegu se podivam, jestli neexistuje video se stejnym jmenem
                         pokud ano, tak ho nekopiruji
                         */
                        if (checkBoxVynechtJpg.Checked)
                        {
                            String souborVidea = zdrojovySoubor.Substring(0, zdrojovySoubor.Length - 3) + "MOV";
                            if (Array.IndexOf(souboryMov, souborVidea) >= 0)
                            {
                                /*---soubor existuje, jpg, nekopiruji----*/
                                continue;
                            }
                        }
                        break;
                    default:
                        cilovyAdresar = textBoxCilVideo.Text + @"\" + mezi + datumString;
                        break;
                }

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
            Int32 pocetKeSmazaniCelkem = DejPocetKeSmazani();
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
            DialogResult res = MessageBox.Show("Opravdu smazat data? Počet souborů: " + pocetKeSmazaniCelkem.ToString() + ".", "Dotaz", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Int32 pocitadlo = 0;
                progressBar1.Maximum = pocetKeSmazaniCelkem;
                /*-----smazani zdrojovych souboru---*/
                pocetNeuspesne = 0;
                pocetUspesne = 0;
                foreach (String ext in typy)
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
                    NactiVsechnySoubory();
                }
            }
        }

        private void Smaz(String ext, ref Int32 pocetUspesne, ref Int32 pocetNeuspesne, ref Int32 pocitadlo)
        {
            String[] soubory;
            /*-----spusteni smazani zdrojovych souboru---*/
            try
            {
                soubory = Directory.GetFiles(textBoxZdroj.Text, "*." + ext, SearchOption.AllDirectories);
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
            return;
        }
        private Int32 DejPocetKeSmazani()
        {
            Int32 celkem = 0;
            foreach (String ext in typy)
            {
                String[] soubory;
                try
                {
                    soubory = Directory.GetFiles(textBoxZdroj.Text, "*." + ext, SearchOption.AllDirectories);
                    celkem += soubory.Length;
                }
                catch (DirectoryNotFoundException)
                {
                    celkem = -1;
                    break;
                }
            }
            return celkem;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerDelete.IsBusy == false)
            {
                backgroundWorkerDelete.RunWorkerAsync();
            }
        }

        private void textBoxZdroj_TextChanged(object sender, EventArgs e)
        {
            if (textBoxZdroj.Text != "")
            {
                listView1.Items.Clear();
                NactiVsechnySoubory();
            }
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

        private void textBoxZdroj_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void textBoxZdroj_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                textBoxZdroj.Text = a.GetValue(0).ToString();
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

    }
}
