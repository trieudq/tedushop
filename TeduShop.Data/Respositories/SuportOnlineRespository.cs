using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class SuportOnlineRespository : RespositoryBase<SuportOnline>
    {
        public interface ISuportOnlineRespository
        {

        }
        public SuportOnlineRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
