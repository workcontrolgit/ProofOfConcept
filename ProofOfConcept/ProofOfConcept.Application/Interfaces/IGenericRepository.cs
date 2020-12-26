using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProofOfConcept.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync(int pageNumber, int pageSize);
        Task<Guid> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(Guid id);
    }
}
