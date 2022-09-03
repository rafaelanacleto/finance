using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finance.Domain.Entities;

namespace Finance.Domain.Interface
{
    public interface IConta
    {
        Task<List<Conta>> GetContas();
        Task<Conta> GetById(int id);
        Task<Conta> Create(Conta conta);
        Task<Conta> Update(Conta conta);
        Task<Conta> Remove(Conta conta);
    }
}