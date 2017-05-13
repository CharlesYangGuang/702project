using MapMyWorldPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MapMyWorldPCL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerTable : ContentPage
    {
        public CustomerTable()
        {
            InitializeComponent();
            App.ValidUser = false;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetFormList();
        }


        private async void OnDeleted(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginView1(true));
        }

        private async void viewButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginView1(false));
        }

        private async void OnAddNew(object sender, EventArgs e)
        {
            App.Database.CurrentID = 0;
            await Navigation.PushAsync(new MainPage());
        }
    }
}
