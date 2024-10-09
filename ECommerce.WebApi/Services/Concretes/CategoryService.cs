using ECommerce.WebApi.Models;
using ECommerce.WebApi.Repository.Abstracts;
using ECommerce.WebApi.Services.Abstarcts;

namespace ECommerce.WebApi.Services.Concretes;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _categoryrepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryrepository = categoryRepository;
    }

    public Category Add(Category category)
    {
        Category added= _categoryrepository.Add(category);
        return added;
    }

    public Category? Delete(int id)
    {
        Category category = _categoryrepository.Delete(id);
        return category;

    }

    public List<Category> GetAll()
    {
        return _categoryrepository.GetAll();

    }

    public Category? GetById(int id)
    {
        Category category= _categoryrepository.GetById(id);
        return category;
    }

    public Category Update(Category category)
    {
        category = _categoryrepository.Update(category);
        return category;
    }
}
