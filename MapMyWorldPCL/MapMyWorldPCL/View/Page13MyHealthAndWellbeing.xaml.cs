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
    public partial class Page13MyHealthAndWellbeing : ContentPage
    {
        public Page13MyHealthAndWellbeing()
        {
            BindingContext = new form13HealthWellbeing() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form13HealthWellbeing model = await App.Database.GetPage13();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form13HealthWellbeing)BindingContext;
            await App.Database.SavePage13(model);
            await Navigation.PushAsync(new Page14MyProgramsTherapySupport());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page12MyWeeklySupport2());
        }
    }
}
