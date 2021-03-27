using Business.Constants;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        IProductDal _productDal = new EfProductDal();
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(3).WithMessage(Messages.ProductNameSyllableError);
            RuleFor(p => p.ProductName).NotEmpty().WithMessage(Messages.ProductNameEmptyError);
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage(Messages.ProductPriceEmptyError);
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage(Messages.ProductPriceZeroError);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1).WithMessage(Messages.ProductPriceLowError);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage(Messages.ProductNameLetterError);
            RuleFor(p => p.ProductName).Must(CheckIfProductNameExist).WithMessage(Messages.ProductNameAlreadyExist);
            RuleFor(p => p.CategoryId).Must(CheckIfProductCountOfCategoryCorrect).WithMessage(Messages.ProductCountOfCategoryError);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }

        private bool CheckIfProductNameExist(string args)
        {
            Console.WriteLine(_productDal.GetAll().ToString());
            return !(_productDal.GetAll(pro => pro.ProductName == args).Any());
        }

        private bool CheckIfProductCountOfCategoryCorrect(int arg)
        {
            var result = _productDal.GetAll(p => p.CategoryId == arg).Count;
            if (result > 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
