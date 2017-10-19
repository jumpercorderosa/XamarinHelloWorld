using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XF.HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //NavigationPage ==> criou a pilha de activitys e com isso posso usar o foward page/back
            MainPage = new NavigationPage(new XF.HelloWorld.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
