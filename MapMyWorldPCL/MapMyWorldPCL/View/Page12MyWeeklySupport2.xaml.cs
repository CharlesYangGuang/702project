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
    public partial class Page12MyWeeklySupport2 : ContentPage
    {
        public Page12MyWeeklySupport2()
        {
            BindingContext = new form12WeeklySupport2();
            InitializeComponent();
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page13MyHealthAndWellbeing());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page11MyWeeklySupports1());
        }
    }
}
