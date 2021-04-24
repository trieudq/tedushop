using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface ISlideRespository : IResponsitory<Slide>
    {

    }
    public class SlideRespository : RespositoryBase<Slide>
    {
        public SlideRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
