using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DA.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using PagedList.Core;
using System.IO;
using DA.Helpper;

namespace DA.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductCategoriesController : Controller
    {
        private readonly webbanhangContext _context;
        public INotyfService _notyfService { get; }

        public AdminProductCategoriesController(webbanhangContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminProductCategories
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;
            var lsCategorys = _context.ProductCategorys
                .AsNoTracking()
                .OrderBy(x => x.CateId);
            PagedList<ProductCategory> models = new PagedList<ProductCategory>(lsCategorys, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        // GET: Admin/AdminProductCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCategory = await _context.ProductCategorys
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (productCategory == null)
            {
                return NotFound();
            }

            return View(productCategory);
        }

        // GET: Admin/AdminProductCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminProductCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CateId,CateName,Description,ParentId,Levels,Ordering,Published,Thumb,Title,Asas,MetaDesc,MetaKey,Cover,SchemaMarkup")] ProductCategory productCategory, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                //Xu ly Thumb
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string imageName = Utilities.SEOUrl(productCategory.CateName) + extension;
                    productCategory.Thumb = await Utilities.UploadFile(fThumb, @"category", imageName.ToLower());
                }
                if (string.IsNullOrEmpty(productCategory.Thumb)) productCategory.Thumb = "default.jpg";
                productCategory.Asas = Utilities.SEOUrl(productCategory.CateName);
                _context.Add(productCategory);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm mới thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(productCategory);
        }

        // GET: Admin/AdminProductCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCategory = await _context.ProductCategorys.FindAsync(id);
            if (productCategory == null)
            {
                return NotFound();
            }
            return View(productCategory);
        }

        // POST: Admin/AdminProductCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CateId,CateName,Description,ParentId,Levels,Ordering,Published,Thumb,Title,Asas,MetaDesc,MetaKey,Cover,SchemaMarkup")] ProductCategory productCategory, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != productCategory.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string imageName = Utilities.SEOUrl(productCategory.CateName) + extension;
                        productCategory.Thumb = await Utilities.UploadFile(fThumb, @"category", imageName.ToLower());
                    }
                    if (string.IsNullOrEmpty(productCategory.Thumb)) productCategory.Thumb = "default.jpg";
                    _context.Update(productCategory);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Chỉnh sửa thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductCategoryExists(productCategory.CateId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productCategory);
        }

        // GET: Admin/AdminProductCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCategory = await _context.ProductCategorys
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (productCategory == null)
            {
                return NotFound();
            }

            return View(productCategory);
        }

        // POST: Admin/AdminProductCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productCategory = await _context.ProductCategorys.FindAsync(id);
            _context.ProductCategorys.Remove(productCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductCategoryExists(int id)
        {
            return _context.ProductCategorys.Any(e => e.CateId == id);
        }
    }
}
