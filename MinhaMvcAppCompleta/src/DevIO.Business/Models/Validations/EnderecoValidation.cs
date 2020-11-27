using FluentValidation;
using static DevIO.Business.Models.Validations.Documentos.ValidacaoDocs;

namespace DevIO.Business.Models.Validations
{
    public class ForncecedorValidation: AbstractValidator<Fornecedor>
    {
        public ForncecedorValidation()
        {
            RuleFor(f => f.Nome).NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100).WithMessage("O Campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoFisica, () => 
            {
                RuleFor(f => f.Documento.Length).Equal(11)
                    .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f => ValidaCPF.IsCpf(f.Documento)).Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () => 
            {
                RuleFor(f => f.Documento.Length).Equal(14)
                   .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f => ValidaCNPJ.IsCnpj(f.Documento)).Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });
        }
    }
}
