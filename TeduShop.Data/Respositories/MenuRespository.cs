using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface IMenuRespository : IResponsitory<Menu>
    {

    }
    public class MenuRespository : RespositoryBase<Menu>, IMenuRespository
    {
        public MenuRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
