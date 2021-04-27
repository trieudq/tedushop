using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Respositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IErrorService
    {
        void Create(Error error);
        void Save();
    }
    class ErrorService : IErrorService
    {
        IErrorRespository _errorRespository;
        IUnitOfWork _unitOfWork;
             
        public ErrorService(IErrorRespository errorRespository, IUnitOfWork unitOfWork)
        {
            this._errorRespository = errorRespository;
            this._unitOfWork = unitOfWork;

        }
        public void Create(Error error)
        {
             _errorRespository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
