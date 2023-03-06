using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DA.Models;
using PagedList.Core;
using DA.Helpper;
using System.IO;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;

namespace DA.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductsController : Controller
    {
        private readonly webbanhangContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public INotyfService _notyfService { get; }
        public AdminProductsController(webbanhangContext context, INotyfService notyfService,IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminProducts
        public async Task<IActionResult> Index(int page = 1, int CateID = 0)
        {
            var pageNumber = page;
            var pageSize = 20;

            List<Product> IsProducts = new List<Product>();

            if (CateID != 0)
            {
                IsProducts = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CateId == CateID)
                    .Include(x => x.Cate)
                    .OrderBy(x => x.ProductId).ToList();
            }
            else
            {
                IsProducts = _context.Products
                    .AsNoTracking()
                    .Include(x => x.Cate)
                    .OrderBy(x => x.ProductId).ToList();
            }

            PagedList<Product> models = new PagedList<Product>(IsProducts.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentCateID = CateID;
            ViewBag.CurrentPage = pageNumber;
            var allProduct = _context.Products.Include(x => x.Cate);
            ViewData["Category"] = new SelectList(_context.ProductCategorys, "CateId", "CateName",CateID);//dropdown 

            return View(models);
        }

        public IActionResult Filtter(int CateID = 0)
        {

            var url = $"/Admin/AdminProducts?CateID={CateID}";
            if (CateID == 0)
            {
                url = $"/Admin/AdminProducts";
            }
            return Json(new { status = "success", redirectUrl = url });
        }

        // GET: Admin/AdminProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cate)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/AdminProducts/Create
        public IActionResult Create()
        {
            Product viewImg = new Product();
            ViewData["Category"] = new SelectList(_context.ProductCategorys, "CateId", "CateName");
            return View(viewImg);

        }

        // POST: Admin/AdminProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ShortDesc,Description,CateId,Price,Discount,Thumb,ImageFile,Video,DateCreate,DateModified,BestSalers,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitslnStock")] Product product, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
 

                string uniqueFileName = GetImageFileName(product);
                product.Thumb = uniqueFileName;

                _context.Add(product);
                await _context.SaveChangesAsync();



                product.DateCreate = DateTime.Now;


                _notyfService.Success("Thêm mới thành công");
                return RedirectToAction(nameof(Index));
            }
           
            ViewData["Category"] = new SelectList(_context.ProductCategorys, "CateId", "CateName", product.CateId);
            return View(product);
        }

        // GET: Admin/AdminProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Category"] = new SelectList(_context.ProductCategorys, "CateId", "CateName", product.CateId);
            return View(product);
        }

        // POST: Admin/AdminProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ShortDesc,Description,CateId,Price,Discount,Thumb,ImageFile,Video,DateCreate,DateModified,BestSalers,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitslnStock")] Product product/*, Microsoft.AspNetCore.Http.IFormFile ful*/)
        {


            if (id != product.ProductId)
            {

                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(product);
                await _context.SaveChangesAsync();

                try
                {
                    

                    //xử lý upload file
                    if (product.ImageFile != null)
                    {
                        ////xoá hình cũ
                        //var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/adminassets/img/products", product.Thumb);
                        //var path = Path.Combine(_webHostEnvironment.WebRootPath, "adminassets", "img", "products", product.Thumb);
                        //System.IO.File.Delete(path);
                        //var fileName = product.ProductId.ToString() + Path.GetExtension(product.ImageFile.FileName);//nối chuỗi -> đổi tên img
                        //var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "adminassets", "img", "products");// đường dẫn
                        //var filePath = Path.Combine(uploadPath, fileName);//đường dẫn đầy đủ c/a/b/2.jpg
                        //using (FileStream fs = System.IO.File.Create(filePath))
                        //{
                        //    product.ImageFile.CopyTo(fs);
                        //    fs.Flush();
                        //}
                        //product.Thumb = fileName;
                        //_context.Products.Update(product);
                        //await _context.SaveChangesAsync();

                        string uniqueFileName = GetImageFileName(product);
                        product.Thumb = uniqueFileName;

                    }
                    //_context.Update(product);

                 

                    product.DateModified = DateTime.Now;
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Thêm mới thành công");
                    return RedirectToAction(nameof(Index));

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            ViewData["Category"] = new SelectList(_context.ProductCategorys, "CateId", "CateName");
            return View(product);
        }

        // GET: Admin/AdminProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cate)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/AdminProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xoá thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        private string GetImageFileName(Product product)
        {
            string uniqueFileName = null;
            if (product.ImageFile != null)
            {

                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "adminassets", "img", "products");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + product.ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    product.ImageFile.CopyTo(fileStream);
                    fileStream.Flush();
                }
                product.Thumb = uniqueFileName;

            }



            _context.Products.Update(product);
            return uniqueFileName;
        }
    }
}
