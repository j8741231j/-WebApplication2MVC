using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication2MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

        // GET: HelloWorldController
        public ActionResult Index()
        {
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
