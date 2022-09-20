using eCommerceKO.Data.Repository.IRepository;
using eCommerceKO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Data.Repository
{
    public class WebUserRepository : Repository<WebUser>, IWebUserRepository
    {
        private ApplicationDbContext _context;
        public WebUserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
