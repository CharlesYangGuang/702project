using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using SQLite;

namespace MapMyWorldPCL.Models
{
    public class formMainPage
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
        public bool formDeleted { get; set; } = false;

        public ICommand DeleteThisForm
        {
            get
            {
                return new Command(() =>
                {
                    App.Database.DeleteFrom(this).Wait();
                });
            }
        }

    }
}
