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
                PctPreview.Image =
                    Image.FromFile(DlgApri.FileName);
                TxtRisultato.Text += $"Immagine caricata nelle dimensioni {PctPreview.Size}!";
            }
        }
    }
}
