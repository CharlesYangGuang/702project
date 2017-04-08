using MapMyWorldPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MapMyWorldPCL.Data
{
    public class dbForm
    {
        readonly SQLiteAsyncConnection database;

        public dbForm(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<formMainPage>().Wait();
        }

        public Task<int> SaveMainPage(formMainPage info)
        {
            if (info.ID != 0)
            {
                return database.UpdateAsync(info);
            }
            else
            {
                return database.InsertAsync(info);
            }
        }

        public Task<formMainPage> GetMainPage(int id = 0)
        {
            return database.Table<formMainPage>().FirstOrDefaultAsync();
        }
    }
}
