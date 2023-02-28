using DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;

namespace DA.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly webbanhangContext _context;

        public SearchController(webbanhangContext context)
        {
            _context = context;
        }

        //GET: /<controller>/
        [HttpPost]
        public IActionResult FindProduct(string keyword, int CateID = 0)
        {
            List<Product> ls = new List<Product>();

            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                ls = _context.Products.ToList();
                return PartialView("ListProductsSearchPartial",ls );

            }
            ls = _context.Products.AsNoTracking()
                                  .Include(a => a.Cate)
                                  .Where(x => x.ProductName.Contains(keyword))
                                  .OrderByDescending(x => x.ProductName)
                                  .Take(10)
                                  .ToList();
          
            if (ls == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", ls);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
