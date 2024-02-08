using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;
using WebApplication2MVC.Data;
using WebApplication2MVC.Models;

namespace WebApplication2MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly PostgresDBContext _context;
        public HelloWorldController(PostgresDBContext context)
        {
            _context = context;
        }
        public string? Welcome(string name = "Frank", int ID = 1)
        {
            //_context.Site.Add(new Site()
            //{
            //    City = "Taichung",
            //    Name = "朝馬站",
            //    Address = "台中市西屯區朝富路22號",
            //    Leader = "Frank Chen"
            //});
            //_context.SaveChanges();
            var result = _context.Site.FirstOrDefault(s => s.Id == 4);
            if (result != null)
            {
                result.Leader = "Jacky Chen";
                _context.SaveChanges();
            }
            return _context.Site.OrderByDescending(s => s.Id).FirstOrDefault()?.Leader;

            //return _context.Site.FirstOrDefault()?.Name;
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

        // GET: HelloWorldController
        public ActionResult Index(string name = "Frank", int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        // GET: HelloWorldController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloWorldController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloWorldController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloWorldController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloWorldController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloWorldController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloWorldController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
