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
    public partial class Page7MyHome : ContentPage
    {
        public Page7MyHome()
        {
            BindingContext = new form7MyHome() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form7MyHome model = await App.Database.GetPage7();
            if (model != null)
            {
                BindingContext = model;
            }
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form7MyHome)BindingContext;
            await App.Database.SavePage7(model);
            await Navigation.PushAsync(new Page8MyDailyActivities1());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page6Important());
        }
    }
}
