using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class SystemConfigRespository : RespositoryBase<SystemCofig>
    {
        public interface ISystemConfigRespository
        {

        }
        public SystemConfigRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
