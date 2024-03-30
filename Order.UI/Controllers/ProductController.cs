using Microsoft.AspNetCore.Mvc;
using Order.Entity;
using Order.Service;
using Order.Service.Concrete;
using Order.Service.Interfaces;

namespace Order.UI.Controllers
{
	public class ProductController : Controller
	{
		private readonly IService<Product> _productService;

		public ProductController(IService<Product> productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			_productService.GetAll();	
		return View();
		}
		
		
				// Use the injected IService<Product> in the controller actions
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var product = await _productService.GetById(id.Value);
			if (product == null)
			{
				return NotFound();
			}

			return View(product);
		}

		[HttpPost]
		public async Task<IActionResult> Create(Product product)
		{
			if (ModelState.IsValid)
			{
				await _productService.Add(product);
				return RedirectToAction(nameof(Index));
			}

			return View(product);
		}

	}
}
