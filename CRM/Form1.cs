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
    }
}
