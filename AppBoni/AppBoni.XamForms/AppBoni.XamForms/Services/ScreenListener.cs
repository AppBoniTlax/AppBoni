using Android.Content;
using System;
using Android.OS;
using AppBoni.Common.Helpers;
using AppBoni.XamForms.ViewModels;

namespace AppBoni.XamForms.Services
{
    public class ScreenListener
    {
        private readonly Context _mContext;
        private readonly ScreenBroadcastReceiver _mScreenReceiver;
        private static ScreenStateListener _mScreenStateListener;

        public ScreenListener(Context context)
        {
            _mContext = context;
            _mScreenReceiver = new ScreenBroadcastReceiver();
        }

        /**
    * screen BroadcastReceiver
    */
        private class ScreenBroadcastReceiver : BroadcastReceiver
        {
            private String _action = null;

            public override void OnReceive(Context context, Intent intent)
            {
                try
                {
                    _action = intent.Action;
                    if (Intent.ActionScreenOn == _action)
                    {
                        // screen on
                        // _mScreenStateListener.onScreenOn();
                        Settings.PowerOnOff += 1;
                        if (Settings.UserCell != "" && Settings.PowerOnOff >= 4)
                        {
                            MainViewModel.GetInstance().Principal.EmergencyAlert();
                            Settings.PowerOnOff = 0;
                        }
                    }
                    else if (Intent.ActionScreenOff == _action)
                    {
                        // screen off
                        // _mScreenStateListener.onScreenOff();
                    }
                    else if (Intent.ActionUserPresent == _action)
                    {
                        // unlock
                        // _mScreenStateListener.onUserPresent();
                        Settings.PowerOnOff = 0;
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        /**
         * begin to listen screen state
         *
         * @param listener
         */
        public void begin(ScreenStateListener listener)
        {
            _mScreenStateListener = listener;
            registerListener();
            getScreenState();
        }

        /**
         * get screen state
         */
        private void getScreenState()
        {
            PowerManager manager = (PowerManager)_mContext
                .GetSystemService(Context.PowerService);
            if (manager.IsScreenOn)
            {
                if (_mScreenStateListener != null)
                {
                    _mScreenStateListener.onScreenOn();
                }
            }
            else
            {
                if (_mScreenStateListener != null)
                {
                    _mScreenStateListener.onScreenOff();
                }
            }
        }

        /**
         * stop listen screen state
         */
        public void unregisterListener()
        {
            _mContext.UnregisterReceiver(_mScreenReceiver);
        }

        /**
         * regist screen state broadcast
         */
        private void registerListener()
        {
            IntentFilter filter = new IntentFilter();
            filter.AddAction(Intent.ActionScreenOn);
            filter.AddAction(Intent.ActionScreenOff);
            filter.AddAction(Intent.ActionUserPresent);
            _mContext.RegisterReceiver(_mScreenReceiver, filter);
        }

        public interface ScreenStateListener
        {
            // Returns screen status information to the caller
            void onScreenOn();

            void onScreenOff();

            void onUserPresent();
        }
    }
}