using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using IT_SPARE.Models.ViewModel;

namespace IT_SPARE.Models.DB
{
    public class DaoUser
    {
        public ModelUser getUserByLogin(ModelLogin user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Constants.ConnJADM))
                {
                    ModelUser model = connection.QuerySingle<ModelUser>(
                        "SEARCH_EMPLOYEE_BY_LOGIN",
                        new { T001_LOGIN = user.T001_LOGIN },
                        commandType: CommandType.StoredProcedure
                    );

                    if (model != null)
                    {
                        return model;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ModelUser getUserByID(long UserID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Constants.ConnJADM))
                {
                    ModelUser model = connection.QuerySingle<ModelUser>(
                        "SEARCH_EMPLOYEE_BY_ID",
                        new { T001_IDCOLABORADOR = UserID },
                        commandType: CommandType.StoredProcedure
                    );

                    if (model != null)
                    {
                        return model;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<ModelProfile> getProfileUser(ModelUser user)
        {
            try
            {
                List<ModelProfile> model;

                using (SqlConnection connection = new SqlConnection(Constants.ConnJADM))
                {
                    model = connection.Query<ModelProfile>(
                        "SEARCH_EMPLOYEE_PROFILE",
                        new { SYSTEM_NAME = Constants.SystemDatabase, T001_IDCOLABORADOR = user.T001_IDCOLABORADOR },
                        commandType: CommandType.StoredProcedure
                    ).ToList();

                    if (model.Count > 0)
                    {
                        return model;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<string> getusersGroup()
        {
            try
            {
                string groupName = ConfigurationManager.AppSettings["GroupNameEmail"].ToString();
                List<string> model = new List<string>();

                using (SqlConnection connection = new SqlConnection(Constants.ConnJADM))
                {
                    model = connection.Query<string>(
                        "SEARCH_USERS_BY_GROUP",
                        new { GroupName = groupName },
                        commandType: CommandType.StoredProcedure
                    ).ToList();

                    return model;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<ModelArea> getAreaUser(long UserID)
        {
            try
            {
                string SystemName = ConfigurationManager.AppSettings["SystemNameDatabase"].ToString();
                List<ModelArea> model = new List<ModelArea>();

                using (SqlConnection connection = new SqlConnection(Constants.ConnJADM))
                {
                    model = connection.Query<ModelArea>(
                        "SEARCH_EMPLOYEE_AREA",
                        new { SYSTEM_NAME = SystemName, T001_IDCOLABORADOR = UserID },
                        commandType: CommandType.StoredProcedure
                    ).ToList();

                    return model;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}