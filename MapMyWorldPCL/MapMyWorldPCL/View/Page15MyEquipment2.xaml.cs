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
    public partial class Page15MyEquipment2 : ContentPage
    {
        public Page15MyEquipment2()
        {
            BindingContext = new form15Equipment2() { ID = App.Database.CurrentID };
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            form15Equipment2 model = await App.Database.GetPage15_2();
            if (model != null)
            {
                BindingContext = model;
            }
        }
        async void OnSaveAndNext(object sender, EventArgs e)
        {
            var model = (form15Equipment2)BindingContext;
            await App.Database.SavePage15_2(model);
            await Navigation.PushAsync(new Page16MyDreamGoals());
        }
        async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page15MyEquipment());
        }
    }
}
