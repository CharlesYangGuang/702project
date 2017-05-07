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
    public partial class Page10MyDailyActivities3 : ContentPage
    {
        public Page10MyDailyActivities3()
        {
            BindingContext = new form10DailyA3() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form10DailyA3 model = await App.Database.GetPage10();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form10DailyA3)BindingContext;
            await App.Database.SavePage10(model);
            await Navigation.PushAsync(new Page11MyWeeklySupports1());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page9MyDailyActivities2());
        }
    }
}
