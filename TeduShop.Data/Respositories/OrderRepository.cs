using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class OrderRepository : RespositoryBase<Order>
    {
        public interface IOrderRepository
        {

        }
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
