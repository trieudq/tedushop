using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class PageRepository : RespositoryBase<Page>
    {
        public interface IPageRepository
        {

        }
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
