using System;
using System.Threading.Tasks;
using AppBoni.Common.Helpers;
using AppBoni.Common.Services;
using AppBoni.XamForms.ViewModels;
using GalaSoft.MvvmLight.Messaging;
using Matcha.BackgroundService;
using Xamarin.Forms;

namespace AppBoni.XamForms.Services
{
    public class PeriodicCall : IPeriodicTask
    {
        private readonly ApiService _apiService;

        public async Task<bool> StartJob()
        {
            var url = Application.Current.Resources["UrlApi"].ToString();
            var response = await _apiService.GetSurveyWithoutAnswerAsync(
                url,
                "/api",
                "/Survey/",
                Settings.UserCell,
                "bearer",
                MainViewModel.GetInstance().Token.Token);
            Settings.SurverAwaiting = response.IsSuccess;
            if (Settings.SurverAwaiting)
            {
                Messenger.Default.Send<bool>(true);
            }
            return false;
        }

        public TimeSpan Interval { get; set; }


        public PeriodicCall(int seconds)
        {
            _apiService = new ApiService();
            Interval = TimeSpan.FromMinutes(seconds);
        }
    }
}
