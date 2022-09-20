using eCommerceKO.Data.Repository.IRepository;
using eCommerceKO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Data.Repository
{
    public class ProductColorRepository : Repository<ProductColor>, IProductColorRepository
    {
        private ApplicationDbContext _context;
        public ProductColorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}