using ComputerHardwareECommerceApi.Application.DataServices;
using ComputerHardwareECommerceApi.Application.Dtos.Product;
using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputerHardwareECommerceApi.Api.Controllers
{
   
    public class ProductsController : CustomBaseController
    {
        private readonly IProductDataService _productService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductsController(IProductDataService productService,IWebHostEnvironment webHostEnvironment)
        {
           _productService= productService;
            _webHostEnvironment= webHostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] Pagination pagination)
        {
           return CreateActionResult(await _productService.GetAllAsync(pagination));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProduct(string id)
        {
            return CreateActionResult(await _productService.GetByIdAsync(id));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory([FromQuery] Pagination pagination)
        {
            var products= await _productService.GetProductsWithCategoryAsync(pagination);   
            return CreateActionResult(products);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductCreateDto product)
        {
            return CreateActionResult(await _productService.AddAsync(product));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            return CreateActionResult(await _productService.DeleteAsync(id));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto product)
        {
            return CreateActionResult(await _productService.UpdateAsync(product));
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
            try
            {
                string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "resource/product-images");


                foreach (var formFile in Request.Form.Files)
                {
                    if (formFile.Length > 0)
                    {
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(formFile.FileName);
                        string fullPath = Path.Combine(uploadPath, fileName);

                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            await formFile.CopyToAsync(memoryStream);

                            // Dosyayı disk üzerine yazma işlemi
                            using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
                            {
                                memoryStream.Seek(0, SeekOrigin.Begin);
                                await memoryStream.CopyToAsync(fileStream);
                            }
                        }
                    }
                }




                return Ok();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                return StatusCode(500, "Internal server error");
            }
        }


    }
}
