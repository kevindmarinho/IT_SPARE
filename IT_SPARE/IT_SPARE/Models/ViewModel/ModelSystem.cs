using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_SPARE.Models.ViewModel
{
    public class ModelSystem
    {
        public string T007_IDSISTEMA { get; set; }
        public List<ModelMenu> T008_MENU = new List<ModelMenu>();
    }
    public class ModelMenu
    {
        public string T008_IDMENU { get; set; }
        public string T008_DESCRICAO { get; set; }
    }
}