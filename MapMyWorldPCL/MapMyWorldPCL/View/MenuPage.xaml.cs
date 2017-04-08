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
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
            Detail = new NavigationPage(new MainPage());

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainPage());
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page4Who());
            IsPresented = false;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page5TheWay());
            IsPresented = false;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page6Important());
            IsPresented = false;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page7MyHome());
            IsPresented = false;
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page8MyDailyActivities1());
            IsPresented = false;
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page11MyWeeklySupports1());
            IsPresented = false;
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page13MyHealthAndWellbeing());
            IsPresented = false;
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page14MyProgramsTherapySupport());
            IsPresented = false;
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page15MyEquipment());
            IsPresented = false;
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page17MyWeek());
            IsPresented = false;
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page18ShortTerm());
            IsPresented = false;
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page19LongTerm());
            IsPresented = false;
        }

        private void Button_Clicked_13(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page20BucketList());
            IsPresented = false;
        }
    }
}
