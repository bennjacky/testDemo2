using Demo2.Models;
using Demo2.Services;
using System.Web.Mvc;

namespace Demo2.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service = new ProductService();

        public ActionResult Index() => View(_service.GetAll());

        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _service.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public ActionResult Edit(int id) => View(_service.GetById(id));

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _service.Update(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

    }
}