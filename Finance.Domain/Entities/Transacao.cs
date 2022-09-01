using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Entities
{
    public sealed class Transacao : Entity
    {
        [Required(ErrorMessage = "Informe a Data!")]
        public string Data { get; set; }
        public string DataFinal { get; set; } 
        public string Tipo { get; set; }
        public double Valor { get; set; }
        [Required(ErrorMessage = "Informe a Descrição!")]
        public string Descricao { get; set; }
        public int Conta_Id { get; set; }
        public string NomeConta { get; set; }
        public int Plano_Contas_Id { get; set; }
        public string DescricaoPlanoConta { get; set; }


        public Transacao()
        {

        }
    }
}
