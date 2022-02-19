﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.FinalProject.WebApi.Application.ViewModels.BrandsViewModel;

namespace UnluCo.FinalProject.WebApi.Application.Validators.Brands
{
    public class DeleteProductViewValidator:AbstractValidator<DeleteBrandViewModel>
    {
        public DeleteProductViewValidator()
        {
            RuleFor(b => b.Id).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}
