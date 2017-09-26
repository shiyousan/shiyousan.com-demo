using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace AntiForgeryToken_Demo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public MvcApplication()
        {
            BeginRequest += MvcApplication_BeginRequest;
            AuthenticateRequest += MvcApplication_AuthenticateRequest;
            PostAuthenticateRequest += MvcApplication_PostAuthenticateRequest;
            AuthorizeRequest += new EventHandler(MvcApplication_AuthorizeRequest);
            PostAuthorizeRequest += MvcApplication_PostAuthorizeRequest;
            
            //EndRequest += MvcApplication_EndRequest;
        }

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{            
        //    if (Context.User != null)
        //    {
        //        var id = Context.User.Identity as FormsIdentity;
        //        if (id != null && id.IsAuthenticated)
        //        {
        //            //    var roles = id.Ticket.UserData.Split(',').Select(m => HttpUtility.UrlDecode(m)).ToArray();
        //            //    Context.User = new GenericPrincipal(id, roles);
        //        }
        //    }
        //}

        private void MvcApplication_BeginRequest(object sender, EventArgs e)
        {
            if (Context.User != null)
            {
                var id = Context.User.Identity as FormsIdentity;
                if (id != null && id.IsAuthenticated)
                {
                    //    var roles = id.Ticket.UserData.Split(',').Select(m => HttpUtility.UrlDecode(m)).ToArray();
                    //    Context.User = new GenericPrincipal(id, roles);
                }
            }
        }

        private void MvcApplication_AuthenticateRequest(object sender, EventArgs e)
        {
            if (Context.User != null)
            {
                var id = Context.User.Identity as FormsIdentity;
                if (id != null && id.IsAuthenticated)
                {
                    //id.Name
                    //
                    //    var roles = id.Ticket.UserData.Split(',').Select(m => HttpUtility.UrlDecode(m)).ToArray();
                    //    Context.User = new GenericPrincipal(id, roles);
                }
            }
        }
        private void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
        {
            if (Context.User != null)
            {
                var TESET=Context.Request.IsAuthenticated;
                var id = Context.User.Identity as FormsIdentity;
                if (id != null && id.IsAuthenticated)
                {
                    //    var roles = id.Ticket.UserData.Split(',').Select(m => HttpUtility.UrlDecode(m)).ToArray();
                    //    Context.User = new GenericPrincipal(id, roles);
                }
            }
        }

        void MvcApplication_AuthorizeRequest(object sender, EventArgs e)
        {            
            var id = Context.User.Identity as FormsIdentity;
            if (id != null && id.IsAuthenticated)
            {
                //    var roles = id.Ticket.UserData.Split(',').Select(m => HttpUtility.UrlDecode(m)).ToArray();
                //    Context.User = new GenericPrincipal(id, roles);
            }
        }

        private void MvcApplication_PostAuthorizeRequest(object sender, EventArgs e)
        {
            var id = Context.User.Identity as FormsIdentity;
            if (id != null && id.IsAuthenticated)
            {
                //    var roles = id.Ticket.UserData.Split(',').Select(m => HttpUtility.UrlDecode(m)).ToArray();
                //    Context.User = new GenericPrincipal(id, roles);
            }
        }

        private void MvcApplication_EndRequest(object sender, EventArgs e)
        {
            var id = Context.User.Identity as FormsIdentity;
            if (id != null && id.IsAuthenticated)
            {                
                //    var roles = id.Ticket.UserData.Split(',').Select(m => HttpUtility.UrlDecode(m)).ToArray();
                //    Context.User = new GenericPrincipal(id, roles);
            }
        }

        




        protected void Application_End()
        {
            var id = Context.User.Identity as FormsIdentity;
            if (id != null && id.IsAuthenticated)
            {
                //    var roles = id.Ticket.UserData.Split(',').Select(m => HttpUtility.UrlDecode(m)).ToArray();
                //    Context.User = new GenericPrincipal(id, roles);
            }
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
