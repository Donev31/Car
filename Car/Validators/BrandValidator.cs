using Car.Models;
using Car.Users.Models;
using FluentValidation;

namespace Car.Validators
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
        }
    }
}
