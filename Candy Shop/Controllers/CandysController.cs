using Candy_Shop.Models;
using Candy_Shop.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Candy_Shop.Controllers
{
    public class CandysController : Controller
    {
        // GET: CandysController

        private readonly CandyRepo _CandyRepo = new CandyRepo();

        // GET: StudentsController
        public ActionResult<IEnumerable<Candy>> Index()
        {
            return View(_CandyRepo.GetCandies());
        }


                
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CandysController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandysController/Create
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

        // GET: CandysController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CandysController/Edit/5
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

        // GET: CandysController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CandysController/Delete/5
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
