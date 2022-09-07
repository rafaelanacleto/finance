using Finance.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Application.Features.Contas.Commands
{
    public class ContaRemoveCommand : IRequest<Conta>
    {
        public int Id { get; set; }

        public ContaRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
