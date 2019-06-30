using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeekNineteenMVC.Controllers
{
  public class MyBooksController : Controller
  {
    // GET: MyBooks
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult MyBooksLinks()
    {
      ViewBag.Message = "Wellcome to the Books gallaries";
      return View();
    }
  }
}