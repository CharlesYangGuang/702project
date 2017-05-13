using MapMyWorldPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MapMyWorldPCL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView1 : ContentPage
    {
        bool IsDelete;
        public LoginView1(bool isDelete)
        {
            InitializeComponent();
            IsDelete = isDelete;
            App.ValidUser = false;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            RequestInfo.IsVisible = false;
        }

        async void OnConfirm(object sender, EventArgs e)
        {
            formMainPage model = await App.Database.GetMainPage(App.Database.CurrentID);
            if (UserKey.Text == model.Password)
            {
                App.ValidUser = true;
                if (IsDelete)
                {
                    App.Database.DeleteFrom(model);
                    await Navigation.PushAsync(new CustomerTable());
                }
                else
                {
                    var page = (FormPage)model.LastPageFinished;
                    await Navigation.PushAsync(page.GetPage());
                }
            }
            else
            {
                RequestInfo.IsVisible = true;
            }
        }
    }
}
