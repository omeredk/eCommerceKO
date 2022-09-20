using eCommerceKO.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public ICartRepository Cart => new CartRepository(_context);
        public ICategoryRepository Category => new CategoryRepository(_context);
        public IDiscountRepository Discount => new DiscountRepository(_context);
        public IOrderDetailRepository OrderDetail => new OrderDetailRepository(_context);
        public IOrderProductRepository OrderProduct => new OrderProductRepository(_context);
        public IProductColorRepository ProductColor => new ProductColorRepository(_context);
        public IProductCommentRepository ProductComment => new ProductCommentRepository(_context);
        public IProductSizeRepository ProductSize => new ProductSizeRepository(_context);
        public IWebUserRepository WebUser => new WebUserRepository(_context);

        public IProductRepository Product => new ProductRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
