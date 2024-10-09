using ECommerce.WebApi.Models;
using ECommerce.WebApi.Repository.Abstracts;
using ECommerce.WebApi.Repository.Concretes;
using ECommerce.WebApi.Services.Abstarcts;

namespace ECommerce.WebApi.Services.Concretes;

public class ProductService : IProductService
{
    private IProductRepository _productrepository;

    public ProductService(IProductRepository productRepository)
    {
        _productrepository = productRepository; 
    }


    public Product Add(Product product)
    {
        Product added=_productrepository.Add(product);
        return added;
    }

    public Product? Delete(int id)
    {
        Product product = _productrepository.Delete(id);
        return product;
    }

    public List<Product> GetAll()
    {
        return _productrepository.GetAll();
    }

    public Product? GetById(int id)
    {
        Product product= _productrepository.GetById(id);
        return product;
    }

    public Product Update(Product product)
    {
        Product updated = _productrepository.Update(product);
        return updated;
    }
}
