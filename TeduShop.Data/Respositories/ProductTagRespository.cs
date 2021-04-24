using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface IProductTagRespository : IResponsitory<ProductTag>
    {

    }
    public class ProductTagRespository : RespositoryBase<ProductTag>, IProductTagRespository
    {
        public ProductTagRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
