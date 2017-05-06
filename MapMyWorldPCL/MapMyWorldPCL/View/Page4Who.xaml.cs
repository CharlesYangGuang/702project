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
    public partial class Page4Who : ContentPage
    {
        public Page4Who()
        {
            BindingContext = new form4Who() { ID = App.Database.CurrentID };
            InitializeComponent();
        }

        public Page4Who(int curID)
        {
            BindingContext = new form4Who() { ID = curID };
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form4Who model = await App.Database.GetPage4();
            if (model != null)
            {
                BindingContext = model;
            }
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form4Who)BindingContext;
            await App.Database.SavePage4(model);
            await Navigation.PushAsync(new Page5TheWay());
        }

        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
