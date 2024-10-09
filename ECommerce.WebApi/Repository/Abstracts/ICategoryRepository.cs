using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Repository.Abstracts;

public interface ICategoryRepository
{
    List<Category> GetAll();
    Category? GetById(int id);
    Category Add(Category category);
    Category Update(Category category);
    Category? Delete(int id);


}
