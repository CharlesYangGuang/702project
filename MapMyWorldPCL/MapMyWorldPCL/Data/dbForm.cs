using MapMyWorldPCL.Models;
using System;
using System.Diagnostics;
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
        public int CurrentID;

        public dbForm(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<formMainPage>().Wait();
            database.CreateTableAsync<form4Who>().Wait();
            database.CreateTableAsync<form5TheWay>().Wait();
        }

        public Task<List<formMainPage>> GetFormList()
        {
            return database.Table<formMainPage>().Where(x => !x.formDeleted).ToListAsync();
        }

        public void DeleteFrom(formMainPage form)
        {
            form.formDeleted = true;
            database.UpdateAsync(form);
        }

        public Task<formMainPage> GetMainPage(int id = 0)
        {
            return database.Table<formMainPage>().Where(x => x.ID == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveMainPage(formMainPage model)
        {
            if (model.ID != 0)
            {
                await database.UpdateAsync(model);
                CurrentID = model.ID;
            }
            else
            {
                await database.InsertAsync(model).ContinueWith(t => {
                    CurrentID = model.ID;
                });
            }
            return CurrentID;
        }

        public Task<form4Who> GetPage4()
        {
            Task<form4Who> model = null;
            model = database.Table<form4Who>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }

        public async Task SavePage4(form4Who model)
        {
            var data = await database.Table<form4Who>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form5TheWay> GetPage5()
        {
            Task<form5TheWay> model = null;
            model = database.Table<form5TheWay>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }

        public async Task SavePage5(form5TheWay model)
        {
            var data = await database.Table<form5TheWay>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }
    }
}
