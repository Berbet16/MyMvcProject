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
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("En Az 2 Karakter Girişi Yapın.");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("En Fazla 50 Karakter Girişi Yapın.");
            RuleFor(x => x.WriterTitle).MaximumLength(20).WithMessage("Ünvan kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Boş Geçemezsiniz").Must(x => x.Contains('A')).WithMessage("Hakkında bilgisinde A karakteri olmak zorundadır.");
            
            
            
            //RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz");
            //RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Mail Adresi Türünde Olmalıdır.");
            //RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Fotoğraf Kısmını Boş Geçemezsiniz");
            //RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifreyi Boş Geçemezsiniz");
            //RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("En Az 3 Karakter Girişi Yapınız.");
        }
    }
}
