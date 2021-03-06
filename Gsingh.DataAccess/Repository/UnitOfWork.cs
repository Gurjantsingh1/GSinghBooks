using Gsingh.DataAccess.Repository.IRepository;
using GSinghBooks.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gsingh.DataAccess.Repository
{
    public class IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IUnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepostiory(_db);
            SP_Call = new SP_Call(_db);
        }
        public ICategoryRepostiory Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
