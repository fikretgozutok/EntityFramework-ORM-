using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EfCategoryDal : ICategoryDal
    {
       public void Add(Category entity)
        {
            using (var context = new NorthwindContext())
            {
                var addedEntity = context.Add(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (var context = new NorthwindContext())
            {
                var deletedEntity = context.Remove(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Category entity)
        {
            using (var context = new NorthwindContext())
            {
                var modifiedEntity = context.Update(entity);
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Category Get(int id)
        {
            using (var context = new NorthwindContext())
            {
                return context.Set<Category>().SingleOrDefault(c => c.CategoryId == id);
            }
        }

        public List<Category> GetAll()
        {
            using (var context = new NorthwindContext())
            {
                var data = from c in context.Categories
                           select new Category
                           {
                               CategoryId = c.CategoryId,
                               CategoryName = c.CategoryName,
                               Description = c.Description,
                           };
                return data.ToList();

                //return context.Set<Category>().Select(c => new Category
                //{
                //    CategoryId = c.CategoryId,
                //    CategoryName = c.CategoryName,
                //    Description = c.Description
                //}).ToList();
            }
        }
    }
}
