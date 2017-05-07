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
    public partial class Page15MyEquipment : ContentPage
    {
        public Page15MyEquipment()
        {
            BindingContext = new form15Equipment1() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form15Equipment1 model = await App.Database.GetPage15();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form15Equipment1)BindingContext;
            await App.Database.SavePage15(model);
            await Navigation.PushAsync(new Page15MyEquipment2());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page14MyProgramsTherapySupport2());
        }
    }
}
