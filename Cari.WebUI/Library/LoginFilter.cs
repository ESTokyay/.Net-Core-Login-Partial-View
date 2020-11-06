using Cari.Business.Abstract;
using Cari.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cari.WebUI.Library
{
    public class LoginFilter : IAuthorizationFilter
    {
       
        public void Yonlendir(AuthorizationFilterContext context)
        {
            context.Result = new RedirectResult("/Login/Index");
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userSession = context.HttpContext.Session.GetJson<Users>("user");
            if (userSession==null)
            {
                Yonlendir(context);
            }
        }
    }
}
