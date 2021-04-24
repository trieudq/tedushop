using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface ISuportOnlineRespository : IResponsitory<SuportOnline>
    {

    }
    public class SuportOnlineRespository : RespositoryBase<SuportOnline>, ISuportOnlineRespository
    {
        public SuportOnlineRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
