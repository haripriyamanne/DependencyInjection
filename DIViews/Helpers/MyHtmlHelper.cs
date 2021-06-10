using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIViews.Helpers
{
    public class MyHtmlHelper
    {
        public MyHtmlHelper()
        {
            Value = "Hello from MyHtmlHelper";
        }
        public string Value { get; set; }
    }
}
