using FluentValidation;
using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Validators
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {

        public CategoriaValidator()
        {
            RuleFor(p => p.titulo)
               .NotEmpty().WithMessage("Nome obrigatório.")
               .NotNull().WithMessage("Nome obrigatório.")
               .Must(nomeValido).WithMessage("Nome contem números , só é permitido letras");
        }

        private bool nomeValido(string nome)
        {
            return nome.All(Char.IsLetter);
        }
    }
}
