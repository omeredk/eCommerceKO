using eCommerceKO.Data.Repository.IRepository;
using eCommerceKO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Data.Repository
{
    public class ProductCommentRepository : Repository<ProductComment>, IProductCommentRepository
    {
        private ApplicationDbContext _context;
        public ProductCommentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}