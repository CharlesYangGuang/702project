﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MapMyWorldPCL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page7MyHome : ContentPage
    {
        public Page7MyHome()
        {
            InitializeComponent();
        }

        async void OnSaveAndNext(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page8MyDailyActivities1());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page6Important());
        }
    }
}
