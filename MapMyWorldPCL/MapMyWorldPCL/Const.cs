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
        Page8Daily1,
        Page9Daily2,
        Page10Daily3,
        Page11WeeklySupport1,
        Page12WeeklySupport2,
        Page13HealthWellBeing,
        Page14MyProgram1,
        Page14MyProgram2,
        Page15Equipment1,
        Page15Equipment2,
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
                case FormPage.Page8Daily1: return new Page8MyDailyActivities1();
                case FormPage.Page9Daily2: return new Page9MyDailyActivities2();
                case FormPage.Page10Daily3: return new Page10MyDailyActivities3();
                case FormPage.Page11WeeklySupport1: return new Page11MyWeeklySupports1();
                case FormPage.Page12WeeklySupport2: return new Page12MyWeeklySupport2();
                case FormPage.Page13HealthWellBeing: return new Page13MyHealthAndWellbeing();
                case FormPage.Page14MyProgram1: return new Page14MyProgramsTherapySupport();
                case FormPage.Page14MyProgram2: return new Page14MyProgramsTherapySupport2();
                case FormPage.Page15Equipment1: return new Page15MyEquipment();
                case FormPage.Page15Equipment2: return new Page15MyEquipment2();
                case FormPage.Page17MyWeekLooked: return new Page17MyWeek();
                case FormPage.Page18ShortDream: return new Page18ShortTerm();
                case FormPage.Page19LongDream: return new Page19LongTerm();
                case FormPage.Page20BucketList: return new Page20BucketList();
                default: return new MainPage();
            }
        }
    }
}
