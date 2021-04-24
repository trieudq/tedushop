using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface ITagRespository : IResponsitory<Tag>
    {

    }
    public class TagRespository : RespositoryBase<Tag>, ITagRespository
    {
        public TagRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
