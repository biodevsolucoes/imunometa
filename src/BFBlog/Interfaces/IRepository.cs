using BFBlog.Data.Entities;
using System.Linq.Expressions;

namespace BFBlog.Interfaces
{
    public interface IRepository<T> : IDisposable where T : BaseEntity
    {
        Task<T> Adicionar(T obj, bool salvar = true);

        Task<T?> Obter(Guid id, Expression<Func<T, object>>? includes = null);
        Task<IEnumerable<T>> ObterLista(int pagina = 0, int quantidade = 20);
        Task<IEnumerable<T>> ObterLista(Expression<Func<T, bool>> filtro, int pagina = 0, int quantidade = 20, Expression<Func<T, object>>? includes = null);

        Task Excluir(Guid id, bool salvar = true);
        Task Excluir(T obj, bool salvar = true);

        Task Atualizar(T obj, bool salvar = true);

        IQueryable<T> _tableAsNoTracking { get; }
    }
}
