using Entities.Concrete;
using FluentValidation;

namespace Business.Validation.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.ProfessionId).NotEmpty();
            RuleFor(p => p.ProfessionId).GreaterThan(0);
            RuleFor(p => p.CompanyId).NotEmpty();
            RuleFor(p => p.CompanyId).GreaterThan(0);
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(3);
            RuleFor(p => p.FirstName).Must(NotStartWith);
            RuleFor(p => p.LastName).MinimumLength(3);
            RuleFor(p => p.LastName).Must(NotStartWith);

        }

        private bool NotStartWith(string str)
        {
            return !(str.StartsWith("ı")
                     | str.StartsWith("I")
                     | str.StartsWith("ğ")
                     | str.StartsWith("Ğ"));
        }
    }
}
