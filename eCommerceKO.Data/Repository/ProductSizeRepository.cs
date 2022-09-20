using eCommerceKO.Data.Repository.IRepository;
using eCommerceKO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Data.Repository
{
    public class ProductSizeRepository : Repository<ProductSize>, IProductSizeRepository
    {
        private ApplicationDbContext _context;
        public ProductSizeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}