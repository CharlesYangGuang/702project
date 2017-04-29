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

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetFormList();
        }


        private async void OnDeleted(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomerTable());
        }
        
    }
}
