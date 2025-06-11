using CRM.Strutture;

namespace CRM
{
    public partial class Form1 : Form
    {
        private Archivio db;
        public Form1(Archivio bancaDati)
        {
            db = bancaDati;
            InitializeComponent();
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            if (LstContatti.SelectedItem != null)
            {
                Contatto daModificare = (Contatto)LstContatti.SelectedItem;
                daModificare.Nome = TxtNome.Text;
                daModificare.Cognome = TxtCognome.Text;
                daModificare.Email = TxtTelefono.Text;
                db.Contatti.Update(daModificare);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Contatti.Add(new Contatto()
            {
                Nome = TxtNome.Text,
                Cognome = TxtCognome.Text,
                Email = TxtTelefono.Text
            });
            db.SaveChanges();
            AggiornaLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LstContatti.SelectedItem != null && db.Contatti.Contains(LstContatti.SelectedItem))
            {
                db.Contatti.Remove((Contatto)LstContatti.SelectedItem);
                db.SaveChanges();
                AggiornaLista();
            }
        }

        private void AggiornaLista()
        {
            LstContatti.Items.Clear();
            foreach (Contatto singolo in db.Contatti)
            {
                LstContatti.Items.Add(singolo);
            }
        }

        private void LstContatti_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTelefono.Text = ((Contatto)LstContatti.SelectedItem).Email;
            TxtNome.Text = ((Contatto)LstContatti.SelectedItem).Nome;
            TxtCognome.Text = ((Contatto)LstContatti.SelectedItem).Cognome;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaLista();
        }
    }
}
