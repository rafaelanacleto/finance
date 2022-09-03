using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Finance.Domain.Entities;
using Finance.Domain.Interface;
using Finance.Infra.Data.Context;

public class ContaRepository : IConta
{
    private ApplicationDbContext _contaContext;

    public ContaRepository(ApplicationDbContext context)
    {
        _contaContext = context;
    }

    public async Task<Conta> Create(Conta category)
    {
        _contaContext.Add(category);
        await _contaContext.SaveChangesAsync();
        return category;
    }

    public async Task<Conta> GetById(int id)
    {
        var retorno = await _contaContext.Contas.FindAsync(id);
        
        return retorno;
    }

    public async Task<IEnumerable<Conta>> GetCatories()
    {
        return await _contaContext.Contas.ToListAsync();
    }

    public Task<List<Conta>> GetContas()
    {
        throw new NotImplementedException();
    }

    public async Task<Conta> Remove(Conta Conta)
    {
        _contaContext.Remove(Conta);
        await _contaContext.SaveChangesAsync();
        return Conta;
    }

    public async Task<Conta> Update(Conta Conta)
    {
        _contaContext.Update(Conta);
        await _contaContext.SaveChangesAsync();
        return Conta;
    }
}