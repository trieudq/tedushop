using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface IMenuGroupReponsitory : IResponsitory<MenuGroup>
    {

    }
    public class MenuGroupReponsitory : RespositoryBase<MenuGroup>, IMenuGroupReponsitory
    {
        public MenuGroupReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
