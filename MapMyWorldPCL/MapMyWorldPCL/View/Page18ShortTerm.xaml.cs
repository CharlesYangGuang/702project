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
    public partial class Page18ShortTerm : ContentPage
    {
        public Page18ShortTerm()
        {
            InitializeComponent();
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page19LongTerm());
        }
    }
}
