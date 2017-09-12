using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XrnCourse.NativeServices.ViewModels;
using XrnCourse.NativeServices.Pages;
using XrnCourse.NativeServices.Services;

namespace XrnCourse.NativeServices
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            //register dependencies
            FreshIOC.Container.Register<IDeviceInfoService>(DependencyService.Get<IDeviceInfoService>());
            FreshIOC.Container.Register<ISoundPlayer>(DependencyService.Get<ISoundPlayer>());

            var mainview = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            MainPage = new FreshNavigationContainer(mainview);
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
