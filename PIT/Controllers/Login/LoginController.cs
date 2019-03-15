using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PIT.Controllers.Login
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public JsonResult Logar([FromBody] Models.Usuario u)
        {

            //Deserializando os dados na model
            string msg = "";
            bool ok = u.Logar(u, out msg);

            var obj = new
            {
                operacao = ok,
                msg = msg
            };

            return Json(obj);
        }
    }
}