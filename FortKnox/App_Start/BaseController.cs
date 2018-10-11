using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FortKnox.App_Start
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // ... log stuff after execution
            FNMenuModel mod = LoadMenu();

            ViewBag.HeaderModel = mod;
        }

        public FNMenuModel LoadMenu()
        {
            FNMenuModel fNModel = new FNMenuModel();

            return fNModel;


        }

    }

    public partial class FNMenuModel
    {
        public FNMenuModel()
        {

        }


    }
}