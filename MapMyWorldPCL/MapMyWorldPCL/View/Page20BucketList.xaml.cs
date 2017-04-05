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
    public partial class Page20BucketList : ContentPage
    {
        public Page20BucketList()
        {
            BindingContext = new form20BucketList();
            InitializeComponent();
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page21Congratulations());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page19LongTerm());
        }
    }
}
