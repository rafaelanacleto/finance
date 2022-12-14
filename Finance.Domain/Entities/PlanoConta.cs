using Finance.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace Finance.Domain.Entities
{
    public sealed class PlanoConta : Entity
    {
        [Required(ErrorMessage = "Informe a Descrição!")]
        public string? Descricao { get; set; }

        public string? Tipo { get; set; }

        public PlanoConta(int id, string descricao)
        {
            DomainExceptionValidation.When(id < 0, "Invalis Id 0");
            Id = id;
            ValidateDomain(descricao);
        }

        private void ValidateDomain(string descricao)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(descricao),
                "Invalid Descricao is required");

            DomainExceptionValidation.When(descricao.Length < 3,
               "Invalid Descricao, too short, minimum 3 characters");

            Descricao = descricao;
        }


        //ver o update TRODO



    }
}
