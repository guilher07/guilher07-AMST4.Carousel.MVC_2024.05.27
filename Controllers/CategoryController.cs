using AMST4.Carousel.MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace AMST4.Carousel.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDataContext _context;
        public CategoryController(ApplicationDataContext context)
        {
            _context = context; 
        }
        public IActionResult CategoryList()
        {
            var Categories = _context.Category.ToList();
            return View(Categories);
        }
    }
}
