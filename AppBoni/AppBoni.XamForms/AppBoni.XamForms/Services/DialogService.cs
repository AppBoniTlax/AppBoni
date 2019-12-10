using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppBoni.XamForms.Services
{
    public class DialogService
    {
        public async Task ShowMessage(string message, string title)
        {
            await App.Navigator.DisplayAlert(title, message, "OK");
        }

        public async Task<bool> ShowMessageConfirm(string message, string title)
        {
            var x = await App.Navigator.DisplayAlert(title, message, "Si", "No");
            return x;
        }
    }
}
