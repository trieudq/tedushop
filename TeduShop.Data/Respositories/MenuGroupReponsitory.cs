using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class MenuGroupReponsitory : RespositoryBase<MenuGroup>
    {
        public interface IMenuGroupReponsitory
        {

        }
        public MenuGroupReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
