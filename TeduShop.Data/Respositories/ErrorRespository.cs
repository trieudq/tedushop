using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Respositories
{
    public interface IErrorRespository : IResponsitory<Error>
    {

    }
    public class ErrorRespository : RespositoryBase<Error>, IErrorRespository 
    {
        public ErrorRespository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
