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
            database.CreateTableAsync<form6Important>().Wait();
            database.CreateTableAsync<form7MyHome>().Wait();
            database.CreateTableAsync<form8DailyA1>().Wait();
            database.CreateTableAsync<form9DailyA2>().Wait();
            database.CreateTableAsync<form10DailyA3>().Wait();
            database.CreateTableAsync<form11WeeklySupport1>().Wait();
            database.CreateTableAsync<form12WeeklySupport2>().Wait();
            database.CreateTableAsync<form13HealthWellbeing>().Wait();
            database.CreateTableAsync<form14MyProgram1>().Wait();
            database.CreateTableAsync<form14MyProgram2>().Wait();
            database.CreateTableAsync<form15Equipment1>().Wait();
            database.CreateTableAsync<form15Equipment2>().Wait();
            database.CreateTableAsync<form17MyWeekLooked>().Wait();
            database.CreateTableAsync<form18ShortDream>().Wait();
            database.CreateTableAsync<form19LongDream>().Wait();
            database.CreateTableAsync<form20BucketList>().Wait();



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

        public Task<form6Important> GetPage6()
        {
            Task<form6Important> model = null;
            model = database.Table<form6Important>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage6(form6Important model)
        {
            var data = await database.Table<form6Important>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form7MyHome> GetPage7()
        {
            Task<form7MyHome> model = null;
            model = database.Table<form7MyHome>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage7(form7MyHome model)
        {
            var data = await database.Table<form7MyHome>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form8DailyA1> GetPage8()
        {
            Task<form8DailyA1> model = null;
            model = database.Table<form8DailyA1>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage8(form8DailyA1 model)
        {
            var data = await database.Table<form8DailyA1>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form9DailyA2> GetPage9()
        {
            Task<form9DailyA2> model = null;
            model = database.Table<form9DailyA2>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage9(form9DailyA2 model)
        {
            var data = await database.Table<form9DailyA2>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form10DailyA3> GetPage10()
        {
            Task<form10DailyA3> model = null;
            model = database.Table<form10DailyA3>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage10(form10DailyA3 model)
        {
            var data = await database.Table<form10DailyA3>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form11WeeklySupport1> GetPage11()
        {
            Task<form11WeeklySupport1> model = null;
            model = database.Table<form11WeeklySupport1>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage11(form11WeeklySupport1 model)
        {
            var data = await database.Table<form11WeeklySupport1>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form12WeeklySupport2> GetPage12()
        {
            Task<form12WeeklySupport2> model = null;
            model = database.Table<form12WeeklySupport2>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage12(form12WeeklySupport2 model)
        {
            var data = await database.Table<form12WeeklySupport2>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form13HealthWellbeing> GetPage13()
        {
            Task<form13HealthWellbeing> model = null;
            model = database.Table<form13HealthWellbeing>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage13(form13HealthWellbeing model)
        {
            var data = await database.Table<form13HealthWellbeing>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form14MyProgram1> GetPage14()
        {
            Task<form14MyProgram1> model = null;
            model = database.Table<form14MyProgram1>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage14(form14MyProgram1 model)
        {
            var data = await database.Table<form14MyProgram1>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form14MyProgram2> GetPage14_2()
        {
            Task<form14MyProgram2> model = null;
            model = database.Table<form14MyProgram2>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage14_2(form14MyProgram2 model)
        {
            var data = await database.Table<form14MyProgram2>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form15Equipment1> GetPage15()
        {
            Task<form15Equipment1> model = null;
            model = database.Table<form15Equipment1>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage15(form15Equipment1 model)
        {
            var data = await database.Table<form15Equipment1>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form15Equipment2> GetPage15_2()
        {
            Task<form15Equipment2> model = null;
            model = database.Table<form15Equipment2>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage15_2(form15Equipment2 model)
        {
            var data = await database.Table<form15Equipment2>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form17MyWeekLooked> GetPage17()
        {
            Task<form17MyWeekLooked> model = null;
            model = database.Table<form17MyWeekLooked>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage17(form17MyWeekLooked model)
        {
            var data = await database.Table<form17MyWeekLooked>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form18ShortDream> GetPage18()
        {
            Task<form18ShortDream> model = null;
            model = database.Table<form18ShortDream>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage18(form18ShortDream model)
        {
            var data = await database.Table<form18ShortDream>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form19LongDream> GetPage19()
        {
            Task<form19LongDream> model = null;
            model = database.Table<form19LongDream>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage19(form19LongDream model)
        {
            var data = await database.Table<form19LongDream>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            if (data != null)
            {
                await database.UpdateAsync(model);
            }
            else
            {
                await database.InsertAsync(model);
            }
        }

        public Task<form20BucketList> GetPage20()
        {
            Task<form20BucketList> model = null;
            model = database.Table<form20BucketList>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
            return model;
        }
        public async Task SavePage20(form20BucketList model)
        {
            var data = await database.Table<form20BucketList>().Where(x => x.ID == CurrentID).FirstOrDefaultAsync();
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
