using BLL;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryBs CategoryBs;

        public CategoryController(CategoryBs categoryBs)
        {
            CategoryBs = categoryBs;
        }

        public IActionResult Index()
        {
            return View(CategoryBs.GetAll().ToList());
        }
    }
}
