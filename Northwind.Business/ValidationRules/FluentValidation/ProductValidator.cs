using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //p icin ici boş olmasın
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz.");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.ProductName).NotEmpty();
            //Fiyatı 0 dan büyük olsun
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            //stok 0 dan büyük olsun
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            //categoryid == 2 ise unitprice 10 dan büyük olmalı
            //RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);

            //kendi kuralını koyma
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün adı A ile başlamalı");

        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
