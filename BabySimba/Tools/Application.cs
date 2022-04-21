using System;

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
