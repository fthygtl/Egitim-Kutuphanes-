using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryRepository : GenericRepository<Category>
    {
        DataContext db = new DataContext();
        public List<Thesis> CategoryDetails(int id)
        {
            return db.Thesis.Where(x => x.CategoryID== id).ToList();
        }
        //public List<Education> CategoryDetails(int id)
        //{
        //    return db.Thesis.Where(x => x.CategoryId == id).ToList();
        //}
    }
}
