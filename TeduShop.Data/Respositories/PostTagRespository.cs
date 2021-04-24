using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface IPostTagRespository : IResponsitory<PostTag>
    {

    }
    public class PostTagRespository : RespositoryBase<PostTag>, IPostTagRespository
    {
        public PostTagRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
