using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class OrderDetailRepository : RespositoryBase<OrderDetail>
    {
        public interface IOrderDetailRepository
        {

        }
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
