using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class TestController : Controller
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly ShopContext _db;

        public TestController(IAsyncRepository<Category> categoryRepository, ShopContext db)
        {
            _categoryRepository = categoryRepository;
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var urunler = _db.Products.Where(x => x.CategoryId == 3);
            return View(await _categoryRepository.ListAllAsync());
        }
    }
}
