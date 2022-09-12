using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Finance.Application.DTOs;
using Finance.Application.Interfaces;
using MediatR;

namespace Finance.Application.Services
{
    public class ContaService : IContaService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ContaService(IMapper mapper, IMediator mediator)
        {
             _mediator = mediator;
            _mapper = mapper;
        }

        public Task Add(ContaDTO contaDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ContaDTO> GetContaById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContaDTO>> GetContas()
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ContaDTO contaDTO)
        {
            throw new NotImplementedException();
        }
    }
}