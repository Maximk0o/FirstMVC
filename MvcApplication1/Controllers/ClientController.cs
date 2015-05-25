using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBConnection;
using System.Data;

namespace MvcApplication1.Controllers
{
    public class ClientController : Controller
    {

        public ActionResult Index()
        {
            TaskTable tasks = new TaskTable();

            return View(tasks.SelectAll());
        }

    }
}
