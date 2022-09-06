using Finance.Domain.Entities;
using MediatR;

namespace Finance.Application.Features.Contas.Commands
{
    public abstract class ContaCommand : IRequest<Conta>
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public double Saldo { get; set; }
    }
}
