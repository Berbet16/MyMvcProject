using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidatior : AbstractValidator<Writer>
    {
        public WriterValidatior()
        {
            //doğrulama kuralı 'not empty'
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("En Az 3 Karakter Girişi Yapın.");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("En Fazla 20 Karakter Girişi Yapın.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterAbout).Must(MustBeA).WithMessage("Hakkında Kısmında A Harfi Olmalıdır.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Mail Adresi Türünde Olmalıdır.");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Fotoğraf Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifreyi Boş Geçemezsiniz");
            RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("En Az 3 Karakter Girişi Yapınız.");
        }
        private bool MustBeA(string arg)
        {
            return arg.Contains("A");
        }
    }
}
