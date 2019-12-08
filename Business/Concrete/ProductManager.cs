using Business.Abstract;
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

        public void Add(Product product)
        {

            // todo business rules, eklenmiş bir ürünü tekrar eklememek vs...
            _efProductDal.Add(product);
        }

        public void Delete(Product product)
        {
            _efProductDal.Delete(product);
        }

        public Product GetById(int productId)
        {
           return _efProductDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetList()
        {
            return _efProductDal.GetList().ToList();
        }

        public List<Product> GetListByCategory(int CategoryId)
        {
            return _efProductDal.GetList(p => p.CategoryId == CategoryId).ToList();
        }

        public void Update(Product product)
        {
            _efProductDal.Update(product);
        }
    }
}
