using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RegistroImoveis.Model;
using RegistroImoveis.Controllers;
using RegistroImoveis.Models;

namespace RegistroImoveis.Model
{
        public class CustomValidator : ValidationAttribute
        {
            private string FildName { get; set; }
            public CustomValidator(string fild)
            {
                FildName = fild;
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                 RegistroImoveisContext db = new RegistroImoveisContext();

                if (FildName == "Nome")
                {

                    if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                        return new ValidationResult("Usuario já Cadastrado");
                }
                if (FildName == "Email")
                {

                    if (db.Proprietarios.FirstOrDefault(x => x.Email == value.ToString()) != null)
                        return new ValidationResult("Email Já cadastrado");
                }
                if (FildName == "DataNascimento")
                {

                    var dataInformada = DateTime.Parse(value.ToString());

                    var idade = DateTime.Now.Year - dataInformada.Year;

                    if (idade < 18)
                        return new ValidationResult("É preciso ser maior ou igual a 18 anos.");

                    if (idade > 150)
                        return new ValidationResult("Idade maior que o máximo suportado.");

                    //DateTime dtV = (DateTime)value;
                    //long lTicks = DateTime.Now.Ticks - dtV.Ticks;
                    //DateTime dtAge = new DateTime(lTicks);
                    //string sErrorMessage = "Idade >=18 and Idade <=150";

                    //if (!(dtAge.Year >= 18 && dtAge.Year <= 150))
                    //{
                    //    return new ValidationResult(sErrorMessage);
                    //}

                    ////    DateTime d = Convert.ToDateTime(value);
                    ////    return d >= DateTime.Now;

                    //if (DateTime.Now.AddYears(-18).ToShortDateString() &&  >  )
                    //    return new ValidationResult("data invalida");
                }

                return ValidationResult.Success;
            }
        }
    }