using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;

namespace Business
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _entityDal;

        public CategoryManager()
        {
            _entityDal = new EfCategoryDal();
        }

        public void Add(Category entity)
        {
            _entityDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _entityDal.Delete(entity);
        }

        public void Update(Category entity)
        {
            _entityDal.Update(entity);
        }

        public Category Get(int id)
        {
            return _entityDal.Get(id);
        }

        public List<Category> GetAll()
        {
            return _entityDal.GetAll();
        }
    }
}
