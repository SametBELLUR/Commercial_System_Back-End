using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("Ürün Adı 2 Harften Daha Uzun Olmalı");
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Olamaz");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Ürün Fiyatı Boş Olamaz");
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Ürün Fiyatı 0 Dan Fazla Olmalı");
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1).WithMessage("Ürün Fiyatı 10 dan büyük olmalı");
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A Harfi İle Başlamalıdır");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
