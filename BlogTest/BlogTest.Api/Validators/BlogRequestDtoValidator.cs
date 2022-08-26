using BlogTest.Service.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogTest.Api.Validators
{
    public class BlogRequestDtoValidator : AbstractValidator<BlogDto>
    {
        public BlogRequestDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty();1
            //RuleFor(x => x.WeightTotal).GreaterThan(0);
            //RuleFor(x => x.WeightTotal).GreaterThan(0);
            //RuleFor(x => x.WeightCar).GreaterThan(3);
            2
            3
            45
        }
    }
}
