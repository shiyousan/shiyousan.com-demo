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
        [CaptchaValidation("captchaCode", "exampleCaptchaId", "验证码输入错误！！！")]
        public ActionResult Index(string captchaCode)
        {

            if (ModelState.IsValid)
            {
                //验证码验证成功
                //如果之前验证码输入错误并显示信息，会自动隐藏错误信息
                //注意：验证码只要输入正确，结果会保存在会话中，
                //之后重复提交验证码会发现就算输入错误也会成功通过，因为已经有通过的会话记录。                
            }
            else
            {
                //验证码验证失败
                //视图界面需要调用@Html.ValidationMessage("对应输入框name")，才能显示属性中定义的错误信息
                //或者自己做处理
            }

            return View();
        }
    }
}