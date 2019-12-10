using System;
using System.Collections.Generic;
using System.Text;
using AppBoni.XamForms.ViewModels;

namespace AppBoni.XamForms.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
