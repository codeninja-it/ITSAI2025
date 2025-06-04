using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVision1
{
    public partial class BloccoNote : Form
    {
        public BloccoNote()
        {
            InitializeComponent();
        }

        private void BloccoNote_Leave(object sender, EventArgs e)
        {

        }

        private void BloccoNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = 
                MessageBox.Show("Se sicuro?", 
                                "Chisura finetra", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question
                ) == DialogResult.No;    
        }

        private void BtnApri_Click(object sender, EventArgs e)
        {
            if (DlgApri.ShowDialog() == DialogResult.OK)
            {
                TxtFile.Text =
                    File.ReadAllText(DlgApri.FileName);
            }
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            if (DlgSalva.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(DlgSalva.FileName, TxtFile.Text);
            }
        }

        private void BtnNuovo_Click(object sender, EventArgs e)
        {
            BloccoNote nuovaIstanza = new BloccoNote();
            nuovaIstanza.Show();
        }
    }
}
