using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using IT_SPARE.Models.ViewModel;

namespace IT_SPARE.Models.DB
{
    public class DaoSystem
    {
        public static string GetAreaName(long CustomerID)
        {
            JADMEntities dbJadm = new JADMEntities();
            string Customer = "";

            var area = dbJadm.T022_AREA.FirstOrDefault(x => x.T022_IDAREA == CustomerID);

            if (area != null)
            {
                Customer = area.T022_DESCRICAO;
            }

            return Customer;
        }
        public List<ModelMenu> getMenu(ModelSystem system, int idPerfil)
        {
            try
            {
                List<ModelMenu> modelMenu = new List<ModelMenu>();
                using (SqlConnection connection = new SqlConnection(Constants.ConnJADM))
                {
                    modelMenu = connection.Query<ModelMenu>(
                        "SEARCH_MENU",
                        new { SYSTEM_NAME = Constants.SystemDatabase, ID_PERFIL = idPerfil },
                        commandType: CommandType.StoredProcedure
                    ).ToList();

                    return modelMenu;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}