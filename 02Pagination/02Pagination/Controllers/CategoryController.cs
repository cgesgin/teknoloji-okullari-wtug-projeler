using _02Pagination.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList.Extensions;

namespace _02Pagination.Controllers
{
    public class CategoryController : Controller
    {
       
        public IActionResult Index()
        {
            return View(GetCategories());
        }

        public IActionResult IndexPagination(int page=1)
        {
            return View(GetCategories().ToPagedList(page,5));
        }

        private List<Category> GetCategories()
        {
            List<Category> data = new List<Category>();
            for (int i = 1; i <= 100; i++)
            {
                data.Add(new Category
                {
                    Id = i,
                    Name = $"Category {i}",
                    Description = $"Description for Category {i}"
                });
            }
            return data;
        }
    }
}
