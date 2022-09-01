using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Finance.Domain.Validation;

namespace Finance.Domain.Entities
{
    public sealed class Conta : Entity
    {
        [Required(ErrorMessage = "Informe o Nome da Conta!")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Informe o Saldo da Conta!")]
        public double Saldo { get; set; }
        public int Usuario_Id { get; set; }


        public Conta(int id, string nome, double saldo, int usuario_id)
        {
            DomainExceptionValidation.When(id < 0, "Invalis Id 0");
            Id = id;
            ValidateDomain(nome);
        }

        public void Update(string nome)
        {
            ValidateDomain(nome);
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name.Name is required");

            DomainExceptionValidation.When(name.Length < 3,
               "Invalid name, too short, minimum 3 characters");

            Nome = name;
        }

    }

}