﻿using System.Web.Mvc;

namespace FortKnox.Areas.Procesos
{
    public class ProcesosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Procesos";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Procesos_default",
                "Procesos/{controller}/{action}/{id}",
                //new { action = "Index", id = UrlParameter.Optional }
                new { controller = "Area", action = "Index", id = UrlParameter.Optional }
             
            );
        }
    }
}