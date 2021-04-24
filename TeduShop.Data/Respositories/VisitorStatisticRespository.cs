using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface IVisitorStatisticRespository : IResponsitory<VisitorStatistic>
    {

    }
    public class VisitorStatisticRespository : RespositoryBase<VisitorStatistic>, IVisitorStatisticRespository
    {
        public VisitorStatisticRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
