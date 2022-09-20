using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceKO.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICartRepository Cart { get;}
        ICategoryRepository Category { get;}
        IDiscountRepository Discount { get;}
        IOrderDetailRepository OrderDetail { get;}
        IOrderProductRepository OrderProduct { get;}
        IProductRepository Product { get; }
        IProductColorRepository ProductColor { get;}
        IProductCommentRepository ProductComment { get;}
        IProductSizeRepository ProductSize { get;}
        IWebUserRepository WebUser { get;}

        void Save();
    }
}
