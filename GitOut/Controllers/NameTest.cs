using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers
{
    public class NameTest : Controller
    {
        public JsonResult Name()
        {
            string output = false ? "Sydney Jacob" : "Sydney Jacob";
            return Json(output);
        }
        //source used: https://www.c-sharpcorner.com/UploadFile/2ed7ae/jsonresult-type-in-mvc/
    }
}
