using ECommerce.WebApi.Contexts;
using ECommerce.WebApi.Models;
using ECommerce.WebApi.Repository.Abstracts;
using ECommerce.WebApi.Services.Abstarcts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers;


[Route("api/[controller]")]
[ApiController]


public class ProductsController : ControllerBase
{

    private IProductService _productService;
    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }


    //MsSqlContext context=new MsSqlContext();
    //[HttpPost("add")]
    //public IActionResult Add([FromBody] Product product)
    //{
    //    //insert into Products(kolonlar) values(değerler)
    //    context.Products.Add(product);
    //    context.SaveChanges();
    //    return Ok(product);
    //}

    //[HttpGet("getall")]
    //public IActionResult GetAll()
    //{
    //    //select * from product
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<Product> products = _productService.GetAll();
        return Ok(products);
    }

    //[HttpGet("getbyid/{id:int}")]
    //public IActionResult  GetById([FromRoute]int id)
    //{
    //    Product product = context.Products.SingleOrDefault(x=>x.Id == id);


    //    if (product is null)
    //    {
    //        return NotFound("Ürün bulunamadı");
    //    }
    //    return Ok(product);
    //}
}
