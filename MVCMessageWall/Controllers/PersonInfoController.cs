using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCMessageWall.Controllers
{
    public class PersonInfoController : Controller
    {
        // GET: PersonInfoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonInfoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonInfoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonInfoController/Create
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

        // GET: PersonInfoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonInfoController/Edit/5
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

        // GET: PersonInfoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonInfoController/Delete/5
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
