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
            BindingContext = new form4Who();
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5TheWay());
        }
    }
}
