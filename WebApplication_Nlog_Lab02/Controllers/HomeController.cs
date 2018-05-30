using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_Nlog_Lab02.Controllers
{
    public class HomeController : Controller
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            logger.Trace("我是Trace");
            logger.Debug("我是Debug");
            logger.Info("我是Info");
            logger.Warn("我是Warn");
            logger.Error("我是Error");
            logger.Fatal("我是Fatal");

            return View();
        }

        public ActionResult About()
        {
            // ViewBag.Message = "Your application description page.";

            try
            {
                int a = 6;
                int b = 0;
                int result = a / b;
            }
            catch(Exception ex)
            {
                logger.Fatal(ex);
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}