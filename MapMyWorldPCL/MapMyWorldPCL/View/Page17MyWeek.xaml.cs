using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MapMyWorldPCL.Models;

namespace MapMyWorldPCL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page17MyWeek : ContentPage
    {
        public Page17MyWeek()
        {
            BindingContext = new form17MyWeekLooked() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form17MyWeekLooked model = await App.Database.GetPage17();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form17MyWeekLooked)BindingContext;
            await App.Database.SavePage17(model);
            await Navigation.PushAsync(new Page18ShortTerm());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page16MyDreamGoals());
        }
    }
}
