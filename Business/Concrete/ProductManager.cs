using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        readonly EfProductDal _efProductDal;

        public ProductManager(EfProductDal efProductDal )
        {
            _efProductDal = efProductDal;
        }

        public IResult Add(Product product)
        {

            // todo business rules, eklenmiş bir ürünü tekrar eklememek vs...
            _efProductDal.Add(product);
            return new SuccesResult(Messages.ProductAdd);
        }

        public IResult Delete(Product product)
        {
            _efProductDal.Delete(product);

            return new SuccesResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
           return  new SuccessDataResult<Product> (_efProductDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_efProductDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int CategoryId)
        {
            return new SuccessDataResult<List<Product>>(_efProductDal.GetList(p => p.CategoryId == CategoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _efProductDal.Update(product);
            return new SuccesResult(Messages.ProductUpdated);
        }
    }
}
