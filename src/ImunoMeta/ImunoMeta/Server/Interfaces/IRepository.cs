using ImunoMeta.Shared.Models;
using System.Linq.Expressions;

namespace ImunoMeta.Server.Interfaces
{
    public interface IRepository<T> : IDisposable where T : BaseModel
    {
        Task<T> Adicionar(T obj, bool salvar = false);

        Task<T?> Obter(Guid id, Expression<Func<T, object>>? includes = null);
        Task<IEnumerable<T>> ObterLista(int pagina = 0, int quantidade = 20);
        Task<IEnumerable<T>> ObterLista(Expression<Func<T, bool>> filtro, int pagina = 0, int quantidade = 20, Expression<Func<T, object>>? includes = null);

        Task Excluir(Guid id, bool salvar = false);
        Task Excluir(T obj, bool salvar = false);

        Task Atualizar(T obj, bool salvar = false);

        IQueryable<T> _tableAsNoTracking { get; }
    }
}
