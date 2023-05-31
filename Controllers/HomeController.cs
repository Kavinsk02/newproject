using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;
using WebApplication13.Repository;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        UserDBcontext dbcontext = new UserDBcontext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Contact(Signup signup)
        {
            bool IsInserted = false;
            try
            {
                if (ModelState.IsValid)
                {
                    IsInserted = dbcontext.AddUser(signup);
                    if (IsInserted)
                    {
                        TempData["SuccessMessage"] = "Inserted successfully...";
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Name is Already Exit";
                    }

                }
                return RedirectToAction("Signup","Index");

            }
            catch (Exception ex)
            {

                TempData["Errormessage"] = ex.Message;
                return View();
            }
        }


        // GET: Contact/ThankYou
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}