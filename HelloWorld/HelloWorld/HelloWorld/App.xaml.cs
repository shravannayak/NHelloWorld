using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class App : Application
	{
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";
        private bool TostFlag
        {
            get;set;
        }
        public App ()
		{
			InitializeComponent();

            //MainPage = new NavigationPage(new PageNew()) { BarTextColor = Color.White,BarBackgroundColor=Color.FromHex("63ad72") };
            MainPage = new NavigationPage(new MainPage());
            /*{
                BarBackgroundColor = Color.Gray,
                BarTextColor=Color.White
            };*/
            //MainPage = new MasterDetailPage1();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();
                return "";
            }
            set
            {
                Properties[TitleKey] = value;
            }
        }

        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return (bool)Properties[NotificationsEnabledKey];
                return false;
            }
            set
            {
                Properties[NotificationsEnabledKey] = value;
            }
        }
	}
}
