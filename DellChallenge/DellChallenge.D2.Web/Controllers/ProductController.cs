using DellChallenge.D2.Web.Models;
using DellChallenge.D2.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DellChallenge.D2.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        var model = _productService.GetAll();

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewProductModel newProduct)
        {
        	if(newProduct != null && newProduct.Name == null)
            	_productService.Add(newProduct);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(int id, string text, bool isName = true)
        {
        //todo
        	if(!String.IsNullOrWhiteSpace(text)) 
        	{
            	_productService.Add(newProduct);
        	}
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
        //todo
        	if(newProduct != null && newProduct.Name == null)
            	_productService.Add(newProduct);
            return RedirectToAction("Index");
        }
    }
}
