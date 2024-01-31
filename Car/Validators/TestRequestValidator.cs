using Car.Models.Models.Requests;
using FluentValidation;

namespace Car.Validators
{
    public class GetModelByBrandRequestValidator : AbstractValidator<GetModelByBrandRequest>
    {
        public GetModelByBrandRequestValidator()
        {
            RuleFor(test => test.Id)
                .NotNull()
                .GreaterThan(0)
                .LessThan(10);
            RuleFor(test => test.AfterDate)
                .NotNull()
                .NotEmpty()
                .LessThan(new DateTime(2019, 04, 20));

        }
    }
}