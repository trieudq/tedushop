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
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parentId);
        PostCategory GetById(int id);
        void Save();
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRespository _postCategoryRespository;
        IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRespository postCategoryRespository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRespository = postCategoryRespository;
            this._unitOfWork = unitOfWork;

        }

        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryRespository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRespository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRespository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            return _postCategoryRespository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRespository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRespository.Update(postCategory);
        }
    }
}
