using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x => x.Description1).MaximumLength(50).WithMessage("Lütfen Açıklamayı Kısaltın");
            RuleFor(x => x.Description2).MaximumLength(25).WithMessage("Lütfen Açıklamayı Kısaltın");
            RuleFor(x => x.Description3).MaximumLength(25).WithMessage("Lütfen Açıklamayı Kısaltın");
            RuleFor(x => x.Description4).MaximumLength(25).WithMessage("Lütfen Açıklamayı Kısaltın");

        }

    }
}
