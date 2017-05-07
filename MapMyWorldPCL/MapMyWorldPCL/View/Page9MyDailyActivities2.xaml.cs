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
    public partial class Page9MyDailyActivities2 : ContentPage
    {
        public Page9MyDailyActivities2()
        {
            BindingContext = new form9DailyA2() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form9DailyA2 model = await App.Database.GetPage9();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form9DailyA2)BindingContext;
            await App.Database.SavePage9(model);
            await Navigation.PushAsync(new Page10MyDailyActivities3());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page8MyDailyActivities1());
        }
    }
}
