using BuggyBits.Models;
using BuggyBits.ViewModels;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

namespace BuggyBits.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            ThreadPool.GetMinThreads(out int minWorker, out int minIo);
            ThreadPool.GetMaxThreads(out int maxWorker, out int maxIo);
            
            ViewData["minWorker"] = minWorker;
            ViewData["maxWorker"] = maxWorker;
            ViewData["minIo"] = minIo;
            ViewData["maxIo"] = maxIo;

            ViewData["serverName"] = System.Net.Dns.GetHostName();

            var isRefresh = Request.Query["refresh"] == "1";

            if (isRefresh)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

            var model = new ReviewsViewModel();

            Review rev = new Review();
            rev.GenerateReview1();
            model.Review1 = new HtmlString("<I>" + rev.quote + "</I>");
            model.Source1 = new HtmlString("&nbsp;&nbsp;-" + rev.source);
            rev.ClearReview();

            Review rev2 = new Review();
            rev2.GenerateReview2();
            model.Review2 = new HtmlString("<I>" + rev2.quote + "</I>");
            model.Source2 = new HtmlString("&nbsp;&nbsp;-" + rev2.source);
            rev2.ClearReview();

            return View(model);
        }
    }
}
