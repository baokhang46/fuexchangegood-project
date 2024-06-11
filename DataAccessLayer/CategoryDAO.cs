using BussinessObject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            var listCategories = new List<Category>();
            try
            {
                using var db = new FugoodExchangeContext();
                listCategories = db.Categories.ToList();
            }
            catch (Exception e)
            {

            }
            return listCategories;
        }

        public static void CreateCategory(Category category)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                context.Categories.Add(category);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateCategory(Category category)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                context.Entry<Category>(category).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteCategory(Category category)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                var a = context.Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
                context.Categories.Remove(a);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Category GetCategoryById(int CategoryId)
        {
            using var db = new FugoodExchangeContext();
            return db.Categories.FirstOrDefault(c => c.CategoryId.Equals(CategoryId));
        }

        public static Category GetCategoryByName(string CategoryName)
        {
            using var db = new FugoodExchangeContext();
            return db.Categories.FirstOrDefault(c => c.CategoryName.Equals(CategoryName));
        }
    }
}
