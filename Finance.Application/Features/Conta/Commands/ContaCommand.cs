using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance.Domain.Entities;

namespace Finance.Application.Features.Conta.Commands
{
    public abstract class ContaCommand : IRequest<Conta>
    {
    }
}
