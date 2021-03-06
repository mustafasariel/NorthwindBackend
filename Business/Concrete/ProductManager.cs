﻿using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
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
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {

            // todo business rules, eklenmiş bir ürünü tekrar eklememek vs...
            _productDal.Add(product);
            return new SuccesResult(Messages.ProductAdd);
        }
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccesResult(Messages.ProductUpdated);
        }
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);

            return new SuccesResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
           return  new SuccessDataResult<Product> (_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int CategoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == CategoryId).ToList());
        }

      
    }
}
