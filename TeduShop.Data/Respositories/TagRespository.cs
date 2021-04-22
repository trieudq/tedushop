using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class TagRespository : RespositoryBase<Tag>
    {
        public interface ITagRespository
        {

        }
        public TagRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
