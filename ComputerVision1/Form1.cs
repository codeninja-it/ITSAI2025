namespace ComputerVision1
{
    public partial class Form1 : Form
    {
        private string[] argomenti;

        public Form1(string[] inIngresso)
        {
            InitializeComponent();
            argomenti = inIngresso;
            BtnCalcola.Text = "Apri immagine";
        }

        private void BtnCalcola_Click(object sender, EventArgs e)
        {
            if(DlgApri.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Hai scelto di aprire il file {DlgApri.FileName}!");
                if (DlgApri.FileName.EndsWith(".txt"))
                {
                    TxtRisultato.Text = File.ReadAllText(DlgApri.FileName);
                }
            }
        }
    }
}
