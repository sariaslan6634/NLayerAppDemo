using Northwind.DataAccess;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using System.Runtime.Serialization;
using FluentValidation;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;

namespace Northwind.Business.Concrete
{
    
    public class ProductManager:IProductServices
    {
        private IProduckDal _productDal;

        public ProductManager(IProduckDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            //ValidationTool.Validate(new ProductValidator(),product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Silme işlemi gercekleşemedi!");
            }
        }

        public void Update(Product product)
        {
            //ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        //listeleme mothodu
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

    }

    [Serializable]
    internal class DbUpdateException : Exception
    {
        public DbUpdateException()
        {
        }

        public DbUpdateException(string message) : base(message)
        {
        }

        public DbUpdateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbUpdateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
