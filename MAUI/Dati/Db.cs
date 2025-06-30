using MAUI.Dati.Strutture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MAUI.Dati
{
    public class Db : IDisposable
    {
        public List<Progetto> progetti { get;set; } = new List<Progetto>();

        public Db() {
            this.Load();
        }

        public void Load()
        {
            if (File.Exists("db.json"))
            {
                progetti = JsonSerializer.Deserialize<List<Progetto>>(File.ReadAllText("db.json"));
            }
            else
            {
                progetti = new List<Progetto>();
            }
        }

        public void Save()
        {
            File.WriteAllText("db.json", JsonSerializer.Serialize(progetti));
        }

        public void Dispose()
        {
            this.Save();
            Dispose();
        }

    }
}
