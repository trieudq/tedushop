using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class MenuRespository : RespositoryBase<Menu>
    {
        public interface IMenuRespository
        {

        }
        public MenuRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
