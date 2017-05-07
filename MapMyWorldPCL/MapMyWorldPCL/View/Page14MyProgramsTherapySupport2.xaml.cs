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
    public partial class Page14MyProgramsTherapySupport2 : ContentPage
    {
        public Page14MyProgramsTherapySupport2()
        {
            BindingContext = new form14MyProgram2() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form14MyProgram2 model = await App.Database.GetPage14_2();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form14MyProgram2)BindingContext;
            await App.Database.SavePage14_2(model);
            await Navigation.PushAsync(new Page15MyEquipment());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page14MyProgramsTherapySupport());
        }
    }
}
