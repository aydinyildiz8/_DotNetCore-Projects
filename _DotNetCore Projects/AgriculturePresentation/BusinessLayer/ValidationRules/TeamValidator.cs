using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez...");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Daha Az Veri Girişi Yapınız...");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen 5 Karakterden Daha Fazla Veri Girişi Yapınız...");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev Alanı Boş Geçilemez...");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu Boş Geçilemez...");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Daha Az Veri Girişi Yapınız...");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen 5 Karakterden Daha Fazla Veri Girişi Yapınız...");
        }
    }
}
