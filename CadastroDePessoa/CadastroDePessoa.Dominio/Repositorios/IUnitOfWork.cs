using System.Threading;
using System.Threading.Tasks;

namespace CadastroDePessoa.Dominio.Repositorios
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync(CancellationToken cancellationToken = default);
        Task RollbackAsync(CancellationToken cancellationToken = default);
    }
}
