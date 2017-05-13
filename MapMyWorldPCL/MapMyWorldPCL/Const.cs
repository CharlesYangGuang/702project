using MapMyWorldPCL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MapMyWorldPCL
{

    public enum FormPage
    {
        MainPage,
        Page4Who,
        Page5TheWay,
        Page6Important,
        Page7MyHome,
        Page8Daily,
        Page11WeeklySupport,
        Page13HealthWellBeing,
        Page14MyProgram,
        Page15Equipment,
        Page17MyWeekLooked,
        Page18ShortDream,
        Page19LongDream,
        Page20BucketList
    }

    public static class MyExtentions
    {
        public static ContentPage GetPage(this FormPage page)
        {
            switch (page)
            {
                case FormPage.Page4Who: return new Page4Who();
                case FormPage.Page5TheWay: return new Page5TheWay();
                case FormPage.Page6Important: return new Page6Important();
                case FormPage.Page7MyHome: return new Page7MyHome();
                default: return new MainPage();
            }
        }
    }
}
