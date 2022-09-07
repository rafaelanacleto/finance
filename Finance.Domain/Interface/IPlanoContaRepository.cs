using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Interface
{
    public interface IPlanoContaRepository
    {
        Task<List<PlanoConta>> GetContas();
        Task<PlanoConta> GetById(int? id);
        Task<PlanoConta> Create(PlanoConta planoConta);
        Task<PlanoConta> Update(PlanoConta planoConta);
        Task<PlanoConta> Remove(PlanoConta planoConta);
    }
}
