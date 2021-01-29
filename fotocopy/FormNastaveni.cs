using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fotocopy
{
    public partial class FormNastaveni : Form
    {
        public FormNastaveni()
        {
            InitializeComponent();
            textBoxTypySouboruFotek.Text = Nastaveni.typySouboruFotek;
            textBoxTypySouboruRaw.Text = Nastaveni.typySouboruRawy;
            textBoxTypySouboruVideo.Text = Nastaveni.typySouboruVidea;
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            Nastaveni.typySouboruFotek=textBoxTypySouboruFotek.Text;
            Nastaveni.typySouboruRawy=textBoxTypySouboruRaw.Text;
            Nastaveni.typySouboruVidea=textBoxTypySouboruVideo.Text;
            this.Close();
        }
    }
}
