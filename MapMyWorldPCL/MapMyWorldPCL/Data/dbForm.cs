﻿using MapMyWorldPCL.Models;
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
        }

        public Task<List<formMainPage>> GetFormList()
        {
            return database.Table<formMainPage>().Where(x => !x.formDeleted).ToListAsync();
        }

        public async Task DeleteFrom(formMainPage form)
        {
            form.formDeleted = true;
            SaveMainPage(form);
        }

        public Task<formMainPage> GetMainPage(int id = 0)
        {
            return database.Table<formMainPage>().Where(x => x.ID == id).FirstOrDefaultAsync();
        }

        public void SaveMainPage(formMainPage model)
        {
            if (model.ID != 0)
            {
                database.UpdateAsync(model);
                CurrentID = model.ID;
            }
            else
            {
                database.InsertAsync(model).ContinueWith(t => {
                    CurrentID = model.ID;
                });
            }
        }

        public Task<form4Who> GetPage4()
        {
            Task<form4Who> model = null;
            if (CurrentID > 0)
            {
                model = database.Table<form4Who>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            }
            return model;
        }

        public void SavePage4(form4Who model)
        {
            var data = database.Table<form4Who>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync().Result;
            if (data != null)
            {
                database.UpdateAsync(model);
            }
            else
            {
                database.InsertAsync(model);
            }
        }
    }
}
