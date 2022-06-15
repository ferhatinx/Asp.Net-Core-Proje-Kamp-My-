using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidation : AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            RuleFor(x => x.WriterNAME).NotEmpty().WithMessage("Yazar adı boş geçilemez.");
            RuleFor(x => x.WriterMAIL).NotEmpty().WithMessage("Mail boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.WriterNAME).MinimumLength(2).WithMessage("Lütfen en az 2 Karakter giriniz. ");
            RuleFor(x => x.WriterNAME).MaximumLength(20).WithMessage("Lütfen en fazla 20 Karakter giriniz. ");
        }
    }
}
