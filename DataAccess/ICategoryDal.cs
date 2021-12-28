using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccess
{
    public interface ICategoryDal
    {
        void Add(Category Entity);
        void Delete(Category Entity);
        void Update(Category Entity);
        Category Get(int id);
        List<Category> GetAll();

    }
}
