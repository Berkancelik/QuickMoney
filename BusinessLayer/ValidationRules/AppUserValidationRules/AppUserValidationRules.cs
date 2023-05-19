using DtoLayer.DTOs.AppUserDtos;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserValidationRules:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserValidationRules()
        {
            RuleFor(x=> x.Name).NotEmpty().WithMessage("Ad alanı boşgeçilemez");
            RuleFor(x=> x.Surname).NotEmpty().WithMessage("Soyad alanı boşgeçilemez");
            RuleFor(x=> x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boşgeçilemez");
            RuleFor(x=> x.Email).NotEmpty().WithMessage("Email alanı boşgeçilemez");
            RuleFor(x=> x.Password).NotEmpty().WithMessage("Şifre alanı boşgeçilemez");
            RuleFor(x=> x.ConfirmPassword).NotEmpty().WithMessage("Şifre doğrulama alanı boşgeçilemez");

            RuleFor(x=> x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz");
            RuleFor(x=> x.Name).MinimumLength(5).WithMessage("Lütfen en fazla 5 karakter giriniz");

            RuleFor(x=> x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Parolalarınız eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");
        
        }
    }
}
