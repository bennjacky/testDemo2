using Demo2.Models;
using Demo2.Services;
using System.Web.Mvc;

namespace Demo2.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service = new ProductService();

        public ActionResult Index() => View(_service.GetAll());

    }
}