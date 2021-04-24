
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface IProductRespository : IResponsitory<Product>
    {

    }
    public class ProductRepository : RespositoryBase<Product>, IProductRespository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
