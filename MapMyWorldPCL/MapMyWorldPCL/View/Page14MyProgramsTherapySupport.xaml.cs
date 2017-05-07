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
    public partial class Page14MyProgramsTherapySupport : ContentPage
    {
        public Page14MyProgramsTherapySupport()
        {
            BindingContext = new form14MyProgram1() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form14MyProgram1 model = await App.Database.GetPage14();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form14MyProgram1)BindingContext;
            await App.Database.SavePage14(model);
            await Navigation.PushAsync(new Page14MyProgramsTherapySupport2());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page13MyHealthAndWellbeing());
        }
    }
}
