using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Interface
{
    public interface ITransacao
    {
        Task<List<Transacao>> GetContas();
        Task<Transacao> GetById(int? id);
        Task<Transacao> Create(Transacao transacao);
        Task<Transacao> Update(Transacao transacao);
        Task<Transacao> Remove(Transacao transacao);

    }
}
