namespace ComputerVision1
{
    public partial class Form1 : Form
    {
        private string[] argomenti;

        public Form1(string[] inIngresso)
        {
            InitializeComponent();
            argomenti = inIngresso;
            BtnCalcola.Text = $"{inIngresso[0]} x {inIngresso[1]}";
        }

        private void BtnCalcola_Click(object sender, EventArgs e)
        {
            Form1 nuovaFinestra = new Form1(argomenti);
            nuovaFinestra.Show();
        }
    }
}
