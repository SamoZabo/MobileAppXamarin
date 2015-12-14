using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;
namespace Countries.Interface
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
