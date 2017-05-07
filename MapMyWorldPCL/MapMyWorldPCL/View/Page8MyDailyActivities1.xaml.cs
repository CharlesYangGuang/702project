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
    public partial class Page8MyDailyActivities1 : ContentPage
    {
        public Page8MyDailyActivities1()
        {
            BindingContext = new form8DailyA1() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form8DailyA1 model = await App.Database.GetPage8();
            if (model != null)
            {
                BindingContext = model;
            }
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form8DailyA1)BindingContext;
            await App.Database.SavePage8(model);
            await Navigation.PushAsync(new Page9MyDailyActivities2());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page7MyHome());
        }
    }
}
