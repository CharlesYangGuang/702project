﻿using System;
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
    public partial class Page6Important : ContentPage
    {
        public Page6Important()
        {
            BindingContext = new form6Important() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form6Important model = await App.Database.GetPage6();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form6Important)BindingContext;
            await App.Database.SavePage6(model);
            await Navigation.PushAsync(new Page7MyHome());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5TheWay());
        }
    }
}
