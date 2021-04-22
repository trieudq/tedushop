using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class PostTagRespository : RespositoryBase<PostTag>
    {
        public interface IPostTagRespository
        {

        }
        public PostTagRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
