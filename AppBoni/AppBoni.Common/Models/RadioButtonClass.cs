using System;
using System.Collections.Generic;
using System.Text;

namespace AppBoni.Common.Models
{
    public class RadioButtonClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Override string and return what you want to be displayed
        public override string ToString() => Name;
    }
}
