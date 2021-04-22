using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class SlideRespository : RespositoryBase<Slide>
    {
        public interface ISlideRespository
        {

        }
        public SlideRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
