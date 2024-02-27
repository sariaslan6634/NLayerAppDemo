using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using System.Linq.Expressions;
using Northwind.DataAccess.Concrete.EntityFreamework;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntitiyRepositoryBase<Product,NorthwindContext>,IProduckDal
    {

    }
}
