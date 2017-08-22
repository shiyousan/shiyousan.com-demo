using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AntiForgeryToken_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult TokenTest()
        {
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TokenTest(string msg)
        {
            ViewBag.Msg = msg;
            //System.Web.Helpers.AntiForgery
            //System.Web. / Helpers / AntiXsrf
            //AntiForgeryToken
            ViewBag.CookieToken = Request.Cookies["__RequestVerificationToken"]?.Value;
            return View("Index");
        }

        public ActionResult RefreshToken()
        {
            var tokenHtml = System.Web.Helpers.AntiForgery.GetHtml().ToString();
            return Content(tokenHtml);
        }


        //public ActionResult RefreshToken()
        //{
        //    string cookieToken;
        //    string formToken;
        //    System.Web.Helpers.AntiForgery.GetTokens(null, out cookieToken, out formToken);
        //    string cookieName = "__RequestVerificationToken";
        //    if (Response.Cookies.AllKeys.Contains(cookieName))
        //    {
        //        Response.Cookies[cookieName].Value = cookieToken;
        //    }
        //    else
        //    {
        //        Response.Cookies.Add(new HttpCookie(cookieName, cookieToken));
        //    }
        //    return Content(formToken);
        //}


        public ActionResult Test()
        {
            
            //System.Web.Helpers.AntiForgery.Validate()
            //HttpServerUtility.UrlTokenEncode
            return View();
        }
    }
}