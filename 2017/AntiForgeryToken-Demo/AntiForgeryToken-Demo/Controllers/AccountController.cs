using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AntiForgeryToken_Demo.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            if (User.Identity.IsAuthenticated)
            {
                //防止欺诈跳转（回调地址为空也会等于false）
                if (Url.IsLocalUrl(ReturnUrl))
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string ReturnUrl, string UserName ="test")
        {        
            FormsAuthentication.SetAuthCookie(UserName , true);
            //return View("Login");
            //防止欺诈跳转
            if (!Url.IsLocalUrl(ReturnUrl))
            {
                return Redirect("/Home/Index");
            }
            else
            {
                return Redirect(ReturnUrl);
            }
        }

        /// <summary>
        /// 账号注销
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SignOut()
        {                                   
            FormsAuthentication.SignOut();
            //方法一
            return Redirect("/Login");
            //方法二，需要在配置文件设置默认登录页面
            //FormsAuthentication.RedirectToLoginPage();
            //return null;            
            //方法三
            //return Redirect("/Home/Index");            
            //HttpContext.User = new System.Security.Principal.GenericPrincipal(new System.Security.Principal.GenericIdentity(string.Empty), null);            
            //return View("Login");
        }

        public ActionResult RefreshToken()
        {
            //Request.IsSecureConnection
            //Request.IsSecureConnection
            //return PartialView();
            var tokenHtml = System.Web.Helpers.AntiForgery.GetHtml().ToString();
            return Content(tokenHtml);
        }
    }
}