using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFreamework
{
    public class EfCategoryDal:EfEntitiyRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {

    }
}
