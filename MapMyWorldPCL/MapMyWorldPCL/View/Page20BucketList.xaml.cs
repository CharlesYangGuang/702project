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
    public partial class Page20BucketList : ContentPage
    {
        public Page20BucketList()
        {
            InitializeComponent();
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page21Congratulations());
        }
    }
}
