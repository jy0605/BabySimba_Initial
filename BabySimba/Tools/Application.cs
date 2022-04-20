using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySimba.Tools
{
    public static class Application
    {
        public static string Root
        {
            get
            {
                string root = AppDomain.CurrentDomain.BaseDirectory;
                return root;
            }
        }
    }
}
