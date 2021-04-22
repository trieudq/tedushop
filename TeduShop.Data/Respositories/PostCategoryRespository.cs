using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class PostCategoryRespository : RespositoryBase<PostCategory>
    {
        public interface IPostCategoryRespository
        {

        }
        public PostCategoryRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
