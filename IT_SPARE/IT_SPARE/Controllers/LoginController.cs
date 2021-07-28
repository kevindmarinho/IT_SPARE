using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IT_SPARE.Models.DB;
using IT_SPARE.Models.ViewModel;
using System.Configuration;

namespace IT_SPARE.Controllers
{
    public class LoginController : Controller
    {
        private DaoUser daoUser;
        private DaoSystem daoSystem;
        public LoginController()
        {
            daoUser = new DaoUser();
            daoSystem = new DaoSystem();
        }

        public ActionResult Index()
        {
            Session["AppName"] = ConfigurationManager.AppSettings["SystemNameView"].ToString();

            return View();
        }

        [HttpPost]
        public ActionResult Authentication(ModelLogin user)
        {
            try
            {
                bool isDev = true;

                //if (AuthAD.isUserExists(user.T001_LOGIN, user.T001_SENHA) && isDev)
                //{

                //}
                //else
                //{
                //    TempData["Erro"] = true;
                //    TempData["Message"] = "Login não encontrado no AD!";
                //}

                ModelUser modelUser = daoUser.getUserByLogin(user);
                ModelSystem modelSystem = new ModelSystem();

                if (modelUser != null)
                {
                    modelUser.T009_PERFIL = daoUser.getProfileUser(modelUser);
                    modelUser.T022_AREA = daoUser.getAreaUser(modelUser.T001_IDCOLABORADOR);

                    if (modelUser.T009_PERFIL != null)
                    {
                        modelSystem.T007_IDSISTEMA = Constants.SystemDatabase;

                        foreach (var perfil in modelUser.T009_PERFIL)
                        {
                            modelSystem.T008_MENU.AddRange(daoSystem.getMenu(modelSystem, perfil.T009_IDPERFIL));
                        }

                        setSessions(modelUser, modelSystem);

                        return RedirectToAction("Index", "StartView");
                    }
                    else
                    {
                        TempData["Erro"] = true;
                        TempData["Message"] = "Login não possui perfil no sistema!";
                    }
                }
                else
                {
                    TempData["Erro"] = true;
                    TempData["Message"] = "Login não encontrado na base de dados!";
                }
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("Index", "Login");
        }

        public void setSessions(ModelUser user, ModelSystem modelSystem)
        {
            ModelSession model = new ModelSession();
            model.modelUser = user;
            model.modelSystem = modelSystem;

            Session["ModelSession"] = model;
        }

        public ActionResult LogOff()
        {
            Session.Clear();

            return RedirectToAction("Index", "Login");
        }
    }
}