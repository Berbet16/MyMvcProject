using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.ValidationRules
{
    //category için gerekli olan doğrulama kurallarını yazıyoruz
    //T değeri olarak ise üzerinde çalıştığımız sınıfı göndermeliyiz
    public class CategoryValidatior : AbstractValidator<Category>
    {
        //kullanacağımız kuralları constuctor içine yazmalıyız
        public CategoryValidatior()
        {
            //doğrulama kuralı 'not empty'
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla girmeyiniz");


        }
    }
}
