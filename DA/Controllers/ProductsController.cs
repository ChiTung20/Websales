using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DA.Models;
using PagedList.Core;

namespace DA.Controllers
{
    public class ProductsController : Controller
    {
        private readonly webbanhangContext _context;
        public ProductsController(webbanhangContext context)
        {
            _context = context;
        }


        [Route("shop.html", Name = ("ShopProduct"))]
        // GET: Products
        public async Task<IActionResult> Index(int? page)
        {
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
                var pageSize = 10;
                var lsProducts = _context.Products
                    .AsNoTracking()
                    .OrderBy(x => x.DateCreate);
                PagedList<Product> models = new PagedList<Product>(lsProducts, pageNumber, pageSize);

                ViewBag.CurrentPage = pageNumber;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }


        [Route("danhmuc/{Alias}", Name = ("ListProduct"))]
        public async Task<IActionResult> List(string Alias, int page =1)
        {
            try
            {
                var pageSize = 10;
                var danhmuc = _context.ProductCategorys.AsNoTracking().SingleOrDefault(x => x.Asas == Alias);

                var lsTinDangs = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CateId == danhmuc.CateId)
                    .OrderByDescending(x => x.DateCreate);
                PagedList<Product> models = new PagedList<Product>(lsTinDangs, page, pageSize);
                ViewBag.CurrentPage = page;
                ViewBag.CurrentCat = danhmuc;
                return View(models);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }

        }

        [Route("/{Alias}-{id}.html", Name = ("ProductDetails"))]
        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                var product = _context.Products.Include(x => x.Cate).FirstOrDefault(x => x.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CateId == product.CateId && x.ProductId != id && x.Active == true)
                    .Take(4)
                    .OrderByDescending(x => x.DateCreate)
                    .ToList();
                ViewBag.SanPham = lsProduct;
                return View(product);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            };
        }

     
    }
}
