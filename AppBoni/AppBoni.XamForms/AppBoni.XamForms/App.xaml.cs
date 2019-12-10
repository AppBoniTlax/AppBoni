using System;
using AppBoni.Common.Helpers;
using AppBoni.Common.Models;
using AppBoni.XamForms.Services;
using AppBoni.XamForms.ViewModels;
using AppBoni.XamForms.Views;
using Matcha.BackgroundService;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppBoni.XamForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Settings.RequiredValidation && Settings.UserCell != "")
            {
                MainViewModel.GetInstance().ValidateAccount = new ValidateAccountViewModel(Settings.UserCell);
                MainPage = new NavigationPage(new ValidateAccountPage());
            }
            else if (Settings.IsRemember)
            {
                 
                    var mainViewModel = MainViewModel.GetInstance();
                    
                    mainViewModel.UserCell = Settings.UserCell;
                    mainViewModel.UserPassword = Settings.UserPassword;
                    mainViewModel.Principal = new PrincipalViewModel();
                    mainViewModel.MyProfile = new MyProfileViewModel();
                    if (Settings.ShowTutorial)
                    {
                        mainViewModel.Tutorial = new TutorialViewModel();
                        this.MainPage = new TutorialPage();
                        return;
                    }
                    this.MainPage = new MasterPage();
                    return;
                
            }
            else
            {
                MainViewModel.GetInstance().Login = new LoginViewModel();
                MainPage = new NavigationPage(new LoginPage());
                MainViewModel.GetInstance().ValidateAccount = new ValidateAccountViewModel();
            }
        }

        public static NavigationPage Navigator { get; set; }

        public static MasterPage Master { get; set; }

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
            try
            {
                // Handle when your app resumes
                //Register Periodic Tasks
                BackgroundAggregatorService.Add(() => new PeriodicCall(3));


                //Start the background service
                BackgroundAggregatorService.StartBackgroundService();
            }
            catch (Exception ex)
            {
 
            }
        }
    }
}
