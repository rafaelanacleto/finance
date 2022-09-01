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

        
    }
}