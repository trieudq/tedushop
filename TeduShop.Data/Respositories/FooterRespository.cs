using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public class FooterRespository : RespositoryBase<Footer>
    {
        public interface IFooterRespository
        {

        }
        public FooterRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
