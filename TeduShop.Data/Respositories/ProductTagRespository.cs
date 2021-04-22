using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class ProductTagRespository : RespositoryBase<ProductTag>
    {
        public interface IProductTagRespository
        {

        }
        public ProductTagRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
