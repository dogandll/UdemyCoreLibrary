using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz";
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(x => x.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress().WithMessage("Email alanı doğru formatta olmalıdır !");
            RuleFor(x => x.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18, 60).WithMessage("Age alanı 18-60 yaş aralığında olmalıdır !");
            RuleFor(x => x.BirthDay).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
            {
                return DateTime.Now.AddDays(-18) >= x;
            }).WithMessage("Yaşınız 18'den büyük olmalıdır !");

            RuleFor(x => x.Gender).IsInEnum().WithMessage("{PropertyName} bu alan erkek için 1 bayan için 2 olmalıdır !");

            RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());
        }
    }
}
