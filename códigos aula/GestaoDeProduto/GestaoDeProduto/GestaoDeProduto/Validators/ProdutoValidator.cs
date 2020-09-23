using FluentValidation;
using GestaoDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDeProduto.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.nome)
               .NotEmpty().WithMessage("Nome obrigatório.")
               .NotNull().WithMessage("Nome obrigatório.");
        }
    }
}
