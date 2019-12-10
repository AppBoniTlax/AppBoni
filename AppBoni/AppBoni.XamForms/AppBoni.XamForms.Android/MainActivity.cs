using System;
using Android;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Widget;
using Android.OS;
using AppBoni.XamForms.Services;
using Matcha.BackgroundService.Droid;

namespace AppBoni.XamForms.Droid
{
    [Activity(Label = "AppBoni", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ScreenListener.ScreenStateListener
    {
        private ScreenListener _mScreenListener;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TryToGetPermissions();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            BackgroundAggregator.Init(this);
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            Plugin.InputKit.Platforms.Droid.Config.Init(this, savedInstanceState); // < ---- Add here

            _mScreenListener = new ScreenListener(this);

            LoadApplication(new App());
        }

        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}


        #region RuntimePermissions
        readonly string[] PermissionsGroupLocation =
                   {
                            //TODO add more permissions
                            Manifest.Permission.AccessCoarseLocation,
                            Manifest.Permission.AccessFineLocation,
                            Manifest.Permission.CallPhone,
                            Manifest.Permission.CallPrivileged,
                            Manifest.Permission.ModifyPhoneState,
                        //    Manifest.Permission.ProcessOutgoingCalls,
                            Manifest.Permission.ReadPhoneState,
             };
        void TryToGetPermissions()
        {
            if ((int)Build.VERSION.SdkInt < 23) return;
            //GetPermissions(PermissionsGroupLocation[2]);
            //GetPermissions(PermissionsGroupLocation[3]);
            GetPermissions(PermissionsGroupLocation[2]);
            //GetPermissions(PermissionsGroupLocation[5]);
            //GetPermissions(PermissionsGroupLocation[6]);
            return;


        }
        const int RequestLocationId = 0;



        public void GetPermissions(string permissionRequest)
        {
            string permission = permissionRequest;

            if (CheckSelfPermission(permission) == (int)Permission.Granted)
            {
                //TODO change the message to show the permissions name
                Toast.MakeText(this, "Permiso Concedido", ToastLength.Short).Show();
                return;
            }

            if (ShouldShowRequestPermissionRationale(permission))
            {
                //set alert for executing the task
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Permiso Requerido");
                alert.SetMessage("La aplicación requiere un permiso para continuar");
                alert.SetPositiveButton("Solicita Permiso", (senderAlert, args) =>
                {
                    RequestPermissions(PermissionsGroupLocation, RequestLocationId);
                });

                alert.SetNegativeButton("Cancel", (senderAlert, args) =>
                {
                    Toast.MakeText(this, "Cancelado!", ToastLength.Short).Show();
                });

                Dialog dialog = alert.Create();
                dialog.Show();
                return;
            }

            RequestPermissions(PermissionsGroupLocation, RequestLocationId);

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            switch (requestCode)
            {
                case RequestLocationId:
                    {
                        if (grantResults[0] == (int)Android.Content.PM.Permission.Granted)
                        {
                            Toast.MakeText(this, "Permiso Concedido", ToastLength.Short).Show();

                        }
                        else
                        {
                            //Permission Denied :(
                            Toast.MakeText(this, "Permiso Denegado", ToastLength.Short).Show();

                        }
                    }
                    break;
            }
            //base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        #endregion


        protected override void OnResume()
        {
            base.OnResume();
            _mScreenListener.begin(this);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            _mScreenListener.unregisterListener();
        }

        public void onScreenOn()
        {
            Console.WriteLine("onScreenOn");
        }

        public void onScreenOff()
        {
            Console.WriteLine("onScreenOff");
        }

        public void onUserPresent()
        {

            Console.WriteLine("onUserPresent");
        }
    }
}