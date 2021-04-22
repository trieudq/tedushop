using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class PostRespository : RespositoryBase<Post>
    {
        public interface IPostRespository
        {

        }
        public PostRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
