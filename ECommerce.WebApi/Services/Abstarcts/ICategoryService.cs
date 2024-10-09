using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Services.Abstarcts;

public interface ICategoryService
{
    List<Category> GetAll();
    Category? GetById(int id);
    Category Add(Category category);
    Category Update(Category category);
    Category? Delete(int id);
}
