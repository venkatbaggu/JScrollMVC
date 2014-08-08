using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JScroll.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Users(int pageID)
        {
           UserModel model = new UserModel();

            //Get users from the database
           List<Users> usersList = new List<Users>();
           usersList.Add(new Users { UserName = pageID.ToString() });

           model.Users = usersList;

           //increment page count here
           model.PageCount = pageID + 20;

            //return model to partialView

           return PartialView("_UsersPartial", model);
        }
    }


    public class UserModel
    {
        public List<Users> Users { get; set; }
        public int PageCount { get; set; }
    }

    public class Users
    {
        public string UserName { get; set; }
    }
}