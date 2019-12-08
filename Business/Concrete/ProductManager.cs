using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int ProductId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetListByCategory(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
