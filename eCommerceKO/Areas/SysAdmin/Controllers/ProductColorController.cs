using eCommerceKO.Data.Repository.IRepository;
using eCommerceKO.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceKO.Areas.SysAdmin.Controllers
{
    [Area("SysAdmin")]
    public class ProductColorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductColorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<ProductColor> colorList = _unitOfWork.ProductColor.GetAll();
            return View(colorList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductColor productColor)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductColor.Add(productColor);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(productColor);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            var productColor = _unitOfWork.ProductColor.GetFirstOrDefault(x => x.ProductColorID == id);

            if (productColor == null)
            {
                return NotFound();
            }

            return View(productColor);
        }


        [HttpPost]
        public IActionResult Edit(int id, [Bind("ProductColorID,ProductColorName")] ProductColor productColor)
        {
            if (id != productColor.ProductColorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.ProductColor.Update(productColor);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            return View(productColor);
        }


        public IActionResult Delete(int id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }

            var productColor = _unitOfWork.ProductColor.GetFirstOrDefault(x => x.ProductColorID == id);

            if (productColor == null)
            {
                return NotFound();
            }

            _unitOfWork.ProductColor.Remove(productColor);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}