using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveStarHotal.Classes
{
    internal class MyConnection
    {
        public static class MyConnection2
        {

            public static string ConString = ConfigurationManager.ConnectionStrings["myConString"].ToString();
        }
    }
}
