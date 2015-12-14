using Countries.Interface;
using Countries.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Countries.DB
{
    public class CountryDatabase
    {
        SQLiteConnection db;
        object locker = new object();
        public CountryDatabase()
        {
            db = DependencyService.Get<ISQLite>().GetConnection();
           // db.CreateTable<Country>();
        }

        public void Save(Country country)
        {
            lock (locker)
            {
                    db.Insert(country);
            }
        }

        public IList<Country> GetAll()
        {
            lock (locker)
            {
                return db.Table<Country>().
                        Where(c => c.capital != string.Empty).ToList(); 
            }
        }
    }
}
