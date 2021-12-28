using Entity;

namespace Business
{
    public interface ICategoryService
    {
        void Add(Category entity);
        void Delete(Category entity);
        void Update(Category entity);
        Category Get(int id);
        List<Category> GetAll();
    }
}
