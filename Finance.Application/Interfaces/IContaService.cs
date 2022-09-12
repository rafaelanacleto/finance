using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finance.Application.DTOs;

namespace Finance.Application.Interfaces
{
    public interface IContaService
    {
        Task<IEnumerable<ContaDTO>> GetContas();
        Task<ContaDTO> GetContaById(int id);
        Task Add(ContaDTO contaDTO);
        Task Update(ContaDTO contaDTO);
        Task Remove(int id);

    }
}