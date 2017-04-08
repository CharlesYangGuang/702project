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
            //BindingContext = await App.Database.GetMainPage();
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var info = (Models.formMainPage)BindingContext;
            await App.Database.SaveMainPage(info);
            await Navigation.PushAsync(new Page4Who());
        }
    }
}
