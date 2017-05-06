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
    public partial class Page5TheWay : ContentPage
    {
        public Page5TheWay()
        {
            BindingContext = new form5TheWay() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form5TheWay model = await App.Database.GetPage5();
            if (model != null)
            {
                BindingContext = model;
            }
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form5TheWay)BindingContext;
            await App.Database.SavePage5(model);
            await Navigation.PushAsync(new Page6Important());
        }

        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4Who());
        }
    }
}
