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
    public partial class Page11MyWeeklySupports1 : ContentPage
    {
        public Page11MyWeeklySupports1()
        {
            BindingContext = new form11WeeklySupport1() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form11WeeklySupport1 model = await App.Database.GetPage11();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form11WeeklySupport1)BindingContext;
            await App.Database.SavePage11(model);
            await Navigation.PushAsync(new Page12MyWeeklySupport2());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page10MyDailyActivities3());
        }
    }
}
