using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseAdminController : Controller
    {

        //public IActionResult Index()
        //{
        //    return View();
        //}


        internal dynamic GetSuccessErrorMsg(int statusCode,string Message,dynamic Data = null)
        {
            var MsgObj = new { status = statusCode, message = Message, data = Data };
            return MsgObj;
        }
    }
}