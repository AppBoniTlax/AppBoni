using System.Threading.Tasks;
using AppBoni.Common.Helpers;
using AppBoni.XamForms.ViewModels;
using AppBoni.XamForms.Views;
using GalaSoft.MvvmLight.Messaging;
using Xamarin.Forms;

namespace AppBoni.XamForms.Services
{
    public class NavigationService
    {
        public async void Navigate(string pageName)
        {
            App.Master.IsPresented = false;

            switch (pageName)
            {
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
                case "MyProfilePage":
                    await App.Navigator.PopToRootAsync();//prueba
                    await Navigate(new MyProfilePage());
                    break;
                case "AlertsPage":
                    MainViewModel.GetInstance().MyAlerts = new AlertViewModel();
                    Messenger.Default.Send<bool>(true);
                    await App.Navigator.PopToRootAsync();//prueba
                    await Navigate(new AlertsPage());
                    break;
                case "DirectoryPage":
                    await App.Navigator.PopToRootAsync();//prueba
                    await Navigate(new DirectoryPage());
                    break;
                case "CollaboratorsPage":
                    await App.Navigator.PopToRootAsync();//prueba
                    await Navigate(new CollaboratorsPage());
                    break;
                case "PrivacyAdvicePage":
                    await App.Navigator.PopToRootAsync();//prueba
                    await Navigate(new PrivacyAdvicePage());
                    break;
                case "GeneralInfoPage":
                    await Navigate(new GeneralInfoPage());
                    break;
                case "AddressInfoPage":
                    await Navigate(new AddressInfoPage());
                    break;
                case "MedicalInfoPage":
                    await Navigate(new MedicalInfoPage());
                    break;
                case "SurveyPage":
                    await Navigate(new AttackPreventionPage());
                    break;
                case "DetailEmergencyContact":
                    await Navigate(new ContactDetailInfoPage());
                    break;
                case "AddEmergencyContact":
                    await Navigate(new AddEmergencyContact());
                    break;
                case "InstitutionsDirectoryPage":
                    await App.Navigator.PopToRootAsync();//prueba
                    await Navigate(new InstitutionsDirectoryPage());
                    break;

                case "AttackPreventionPage":
                    if (Settings.SurverAwaiting)
                    {
                        await Navigate(new AttackPreventionPage());
                    }
                    else
                    {
                        var dlg = new DialogService();
                        await dlg.ShowMessage("Usted no tiene encuestas pendientes.", "Información");
                    }
                    break;

                case "Tutorial2Page":
                    await Navigate(new Tutorial2Page());
                    break;

                case "Tutorial3Page":
                    await Navigate(new Tutorial3Page());
                    break;

                case "Tutorial4Page":
                    await Navigate(new Tutorial4Page());
                    break;

                case "Tutorial5Page":
                    await Navigate(new Tutorial5Page());
                    break;


                case "ContactsInfoPage":
                    MainViewModel.GetInstance().MyEmergencyContacts = new EmergencyContactViewModel();
                    Messenger.Default.Send<bool>(true);
                    await Navigate(new EmergencyContactsInfoPage());
                    break;
                //cerrar sesion
                default:
                    var dialog = new DialogService();
                    var resp = await dialog.ShowMessageConfirm("Advertencia", "¿Al cerrar la sesión NO podrá emitir alertas de Pánico?");
                    if (resp)
                    {

                        Settings.IsRemember = false;
                        Settings.Token = string.Empty;
                        Settings.UserCell = string.Empty;
                        Settings.UserPassword = string.Empty;
                        Settings.ShowTutorial = false;

                        MainViewModel.GetInstance().Login = new LoginViewModel();
                        Application.Current.MainPage = new NavigationPage(new LoginPage());
                    }

                    break;
            }
        }

        private static async Task Navigate<T>(T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false);
            NavigationPage.SetBackButtonTitle(page, "Atrás"); //iOs
            await App.Navigator.PushAsync(page);
        }

    }
}
