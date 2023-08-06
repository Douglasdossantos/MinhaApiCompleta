using Doug.Business.Models;

namespace Doug.Business.Intefaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}