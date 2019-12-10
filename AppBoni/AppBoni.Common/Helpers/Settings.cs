using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace AppBoni.Common.Helpers
{
    public class Settings
    {
        private const string token = "token";

        private const string userCell = "userEmail";

        private const string userPassword = "userPassword";

        private const string isRemember = "isRemember";

        private const string requiredValidation = "validation";

        public const string telephone = "phone";

        public const string showTutorial = "showTutorial";

        public const string surveyAwait = "surveyAwait";

        public const string powerOnOff = "powerOnOff";

        private static readonly string stringDefault = string.Empty;

        private static readonly bool boolDefault = false;

        private static ISettings AppSettings => CrossSettings.Current;

        public static string Token
        {
            get => AppSettings.GetValueOrDefault(token, stringDefault);
            set => AppSettings.AddOrUpdateValue(token, value);
        }

        public static string UserCell
        {
            get => AppSettings.GetValueOrDefault(userCell, stringDefault);
            set => AppSettings.AddOrUpdateValue(userCell, value);
        }

        public static string UserPassword
        {
            get => AppSettings.GetValueOrDefault(userPassword, stringDefault);
            set => AppSettings.AddOrUpdateValue(userPassword, value);
        }

        public static bool IsRemember
        {
            get => AppSettings.GetValueOrDefault(isRemember, boolDefault);
            set => AppSettings.AddOrUpdateValue(isRemember, value);
        }

        public static bool RequiredValidation
        {
            get => AppSettings.GetValueOrDefault(requiredValidation, boolDefault);
            set => AppSettings.AddOrUpdateValue(requiredValidation, value);
        }
        
        public static string Telephone
        {
            get => AppSettings.GetValueOrDefault(telephone, stringDefault);
            set => AppSettings.AddOrUpdateValue(telephone, value);
        }

        public static bool ShowTutorial
        {
            get => AppSettings.GetValueOrDefault(showTutorial, true);
            set => AppSettings.AddOrUpdateValue(showTutorial, value);
        }

        public static bool SurverAwaiting
        {
            get => AppSettings.GetValueOrDefault(surveyAwait, boolDefault);
            set => AppSettings.AddOrUpdateValue(surveyAwait, value);
        }

        public static int PowerOnOff
        {
            get => AppSettings.GetValueOrDefault(powerOnOff, 0);
            set => AppSettings.AddOrUpdateValue(powerOnOff, value);
        }
    }
}
