using Gsingh.DataAccess.Repository.IRepository;
using Gsingh.Models;
using GSinghBooks.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gsingh.DataAccess.Repository
{
    public class CategoryRepostiory : Repository<Category>, ICategoryRepostiory
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepostiory(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // throw new NotImplementedException();
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb !=null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
