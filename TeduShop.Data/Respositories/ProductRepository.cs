
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class ProductRepository : RespositoryBase<Product>
    {
        public interface IProductRespository
        {

        }
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
