using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class VisitorStatisticRespository : RespositoryBase<VisitorStatistic>
    {
        public interface IVisitorStatisticRespository
        {

        }
        public VisitorStatisticRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
