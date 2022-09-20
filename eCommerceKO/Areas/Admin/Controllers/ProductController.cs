using eCommerceKO.Data.Repository.IRepository;
using eCommerceKO.Data.ViewModels;
using eCommerceKO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eCommerceKO.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }


        public IActionResult Index()
        {
            var productList = _unitOfWork.Product.GetAll();

            return View(productList);
        }



        public IActionResult Crup(int? id)
        {
            ProductViewModel productVM = new()
            {
                Product = new(),
                CategoryList = _unitOfWork.Category.GetAll().Select(l => new SelectListItem
                {
                    Text = l.CategoryName,
                    Value = l.CategoryID.ToString()
                }),
                ColorList = _unitOfWork.ProductColor.GetAll().Select(l => new SelectListItem
                {
                    Text = l.ProductColorName,
                    Value = l.ProductColorID.ToString()
                }),
                DiscountList = _unitOfWork.Discount.GetAll().Select(l => new SelectListItem
                {
                    Text = l.DiscountAmounth.ToString(),
                    Value = l.DiscountID.ToString()
                }),
                SizeList = _unitOfWork.ProductSize.GetAll().Select(l => new SelectListItem
                {
                    Text = l.ProductSizeName,
                    Value = l.ProductSizeID.ToString()
                })
            };


            if (id == null || id <= 0)
            {
                return View(productVM);
            }

            productVM.Product = _unitOfWork.Product.GetFirstOrDefault(x => x.ProductID == id);

            if (productVM.Product == null)
            {
                return View(productVM);
            }

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Crup(ProductViewModel productVM, IFormFile file)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;

            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploadRoot = Path.Combine(wwwRootPath, @"img\products");
                var extension = Path.GetExtension(file.FileName);

                if (productVM.Product.ProductPic != null)
                {
                    var oldPicPath = Path.Combine(wwwRootPath, productVM.Product.ProductPic);
                    if (System.IO.File.Exists(oldPicPath))
                    {
                        System.IO.File.Delete(oldPicPath);
                    }
                }

                using (var fileStream = new FileStream(Path.Combine(uploadRoot, fileName + extension),
                     FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                productVM.Product.ProductPic = @"\img\products\" + fileName + extension;

            }

            if (productVM.Product.ProductID <= 0)
            {
                _unitOfWork.Product.Add(productVM.Product);
            }
            else
            {
                _unitOfWork.Product.Update(productVM.Product);
            }
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            var product = _unitOfWork.Product.GetFirstOrDefault(x => x.ProductID == id);
            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}