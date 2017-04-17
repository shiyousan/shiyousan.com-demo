using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BotDetect.Web.Mvc;

namespace BotDetect_CAPTCHA_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [CaptchaValidation("CaptchaCode", "ExampleCaptcha", "验证码输入错误！！！")]
        public ActionResult Index(string msg, string CaptchaCode)
        {
            //ExampleCaptcha.SoundEnabled = false; 
            
            /*
             (Option) CAPTCHA Validation Separate From Model State Validation

If, for any reason, you want to check Captcha validity separately from ModelState, you can simply use an additional action parameter (which must be called captchaValid) and make the validation logic explicit
public ActionResult ExampleAction(ExampleModel model, bool captchaValid)
{
    if (captchaValid)
    {
    
        […]
             */
            //if (!ModelState.IsValid)
            //{
            //    // TODO: Captcha validation failed, show error message      
            //    ViewBag.Msg = CaptchaCode;
            //}
            //else
            //{
            //    // TODO: Captcha validation passed, proceed with protected action  
            //    ViewBag.Msg = msg;
            //}

            return View();
        }
    }
}