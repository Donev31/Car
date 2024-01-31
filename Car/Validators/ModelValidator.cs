using Car.Models;
using Car.Models.Models.Requests;
using FluentValidation;

namespace Car.Validators
{
    public class ModelValidator : AbstractValidator<Model>
    {
        public Modelvalidator()
        {
            RuleFor(x => x.BrandId).NotNull().GreaterThan(0);
            RuleFor(x => x.Mname).NotNull().MinimumLength(3);
            RuleFor(x => x.ReleaseDate).NotNull().LessThan(new DateTime(2002, 07, 11));
        }
    }
}
