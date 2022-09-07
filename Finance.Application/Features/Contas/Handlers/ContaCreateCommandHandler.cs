using Finance.Application.Features.Contas.Commands;
using Finance.Domain.Entities;
using Finance.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Application.Features.Contas.Handlers
{
    public class ContaCreateCommandHandler : IRequestHandler<ContaCreateCommand, Conta>
    {
        private readonly IContaRepository _contaRepository;

        public ContaCreateCommandHandler(IContaRepository contaRepository)
        {
           _contaRepository = contaRepository;
        }      

        public Task<Conta> Handle(ContaCreateCommand request, CancellationToken cancellationToken)
        {

            var conta = new Conta(request.Id, request.Nome, request.Saldo);



            throw new NotImplementedException();
        }
    }
}
