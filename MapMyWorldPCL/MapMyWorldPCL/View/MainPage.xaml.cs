using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MapMyWorldPCL.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new Models.formMainPage();
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (App.Database.CurrentID != 0)
            {
                BindingContext = await App.Database.GetMainPage(App.Database.CurrentID);
            }
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (Models.formMainPage)BindingContext;
            int modelID = await App.Database.SaveMainPage(model);
            await Navigation.PushAsync(new Page4Who(modelID));
        }
    }
}
