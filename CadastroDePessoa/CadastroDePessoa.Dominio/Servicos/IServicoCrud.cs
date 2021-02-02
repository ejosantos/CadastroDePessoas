using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CadastroDePessoa.Dominio.Entidades;

namespace CadastroDePessoa.Dominio.Servicos
{
   
    public interface IServicoCrud<TKey, TEntity> where TKey : struct where TEntity : EntidadeBase<TKey>
    {
        Task<TEntity> AddAsync(TEntity obj);
        Task<TEntity> DeleteAsync(TKey id);
        Task<TEntity> GetAsync(TKey id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> UpdateAsync(TEntity obj);
    }
}
