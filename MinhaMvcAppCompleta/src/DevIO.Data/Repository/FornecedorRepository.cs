using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context):base(context) { }
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db?.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(e => e.Id == id);
        
        }
        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db?.Fornecedores.AsNoTracking()
                .Include(a => a.Produtos)
                .Include(b => b.Endereco)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
