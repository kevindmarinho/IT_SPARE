using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace IT_SPARE.Models.ViewModel
{
    public class Constants
    {
        public static string SystemDatabase = ConfigurationManager.AppSettings["SystemNameDatabase"].ToString();
        public static string SystemView = ConfigurationManager.AppSettings["SystemNameView"].ToString();
        public static string ConnJADM = ConfigurationManager.ConnectionStrings["JADM"].ToString();
        //public static string ConnSPARE = ConfigurationManager.ConnectionStrings["ITSPARE"].ToString();
        
    }
}