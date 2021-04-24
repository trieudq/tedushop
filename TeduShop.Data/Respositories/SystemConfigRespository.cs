using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface ISystemConfigRespository : IResponsitory<SystemCofig>
    {

    }
    public class SystemConfigRespository : RespositoryBase<SystemCofig>, ISystemConfigRespository
    {
        public SystemConfigRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
