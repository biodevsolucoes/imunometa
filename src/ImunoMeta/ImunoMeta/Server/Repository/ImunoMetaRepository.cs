using ImunoMeta.Server.Data;
using ImunoMeta.Server.Interfaces;
using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ImunoMeta.Server.Repository
{
    public class ImunoMetaRepository<T> : IRepository<T> where T : BaseModel
    {
        private readonly DbContext _context;
        public IQueryable<T> _tableAsNoTracking { get; private set; }

        public ImunoMetaRepository(ApplicationDbContext context)
        {
            _context = context;
            _tableAsNoTracking = _context.Set<T>()
                                    .AsNoTracking()
                                    .Where(x => !x.Removido);
        }
        public async Task<T> Adicionar(T obj, bool salvar = false)
        {
            await _context.Set<T>().AddAsync(obj);

            if (salvar)
                await CommitAsync();

            return obj;
        }

        public async Task<T?> Obter(Guid id, Expression<Func<T, object>>? includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
                query = query.Include(includes);

            return await query.FirstOrDefaultAsync(x => x.Id == id && !x.Removido);
        }

        public async Task<IEnumerable<T>> ObterLista(int pagina = 0, int quantidade = 20)
        {
            return await _tableAsNoTracking
                                    .Where(x => !x.Removido)
                                    .Skip(pagina * quantidade)
                                    .Take(quantidade).ToListAsync();
        }

        public async Task<IEnumerable<T>> ObterLista(Expression<Func<T, bool>> filtro, int pagina = 0, int quantidade = 20, Expression<Func<T, object>>? includes = null)
        {
            IQueryable<T> query = _tableAsNoTracking;

            if (includes != null)
                query = query.Include(includes);

            return await query
                            .Where(x => !x.Removido)
                            .Where(filtro)
                            .Skip(pagina * quantidade)
                            .Take(quantidade).ToListAsync();
        }

        public async Task Excluir(Guid id, bool salvar = false)
        {
            var obj = await Obter(id);

            if (obj != null)
                await Excluir(obj, salvar);

        }

        public async Task Excluir(T obj, bool salvar = false)
        {
            obj.Excluir();
            await Atualizar(obj);

            if (salvar)
                await CommitAsync();
        }

        public async Task Atualizar(T obj, bool salvar = false)
        {
            _context.Update<T>(obj);

            if (salvar)
                await CommitAsync();
        }

        public async Task<bool> CommitAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public void Dispose() => _context?.Dispose();
    }
}
