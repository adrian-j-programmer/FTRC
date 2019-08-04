using FTRC.Data;
using FTRC.Extensions;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTRC.Repositories
{
    public class RegimenRepository
    {
        public Regimen Get(int id) => Regimens.FirstOrDefault((x) => x.Id == id);
        public IEnumerable<Regimen> GetAll() => Regimens;
        public Regimen Add()
        {
            Regimen addedRegimen;
            using (var dbConnection = new SQLiteConnection(((App)App.Current).DBPath))
            {
                dbConnection.CreateTable<Regimen>();
                dbConnection.Insert(new Regimen());
                addedRegimen = dbConnection.Table<Regimen>().Last();
            }
            Regimens.Add(addedRegimen);
            return addedRegimen;
        }
        public void Remove(int id)
        {
            using (var dbConnection = new SQLiteConnection(((App)App.Current).DBPath))
            {
                dbConnection.Delete<Regimen>(id);
            }
            Regimens.RemoveSingle((x) => x.Id == id);
        }

        private static RegimenRepository m_instance;
        public static RegimenRepository Instance
        {
            get
            {
                if (m_instance == null)
                    m_instance = new RegimenRepository();
                return m_instance;
            }
        }

        private List<Regimen> Regimens { get; set; }

        private RegimenRepository()
        {
            using ( var dbConnection = new SQLiteConnection(((App)App.Current).DBPath))
            {
                dbConnection.CreateTable<Regimen>();
                Regimens = dbConnection.Table<Regimen>().ToList();
            }
        }
    }
}
