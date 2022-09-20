using eCommerceKO.Data.Repository.IRepository;
using eCommerceKO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Data.Repository
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {
        private ApplicationDbContext _context;
        public DiscountRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}