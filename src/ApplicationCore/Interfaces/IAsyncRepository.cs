﻿using ApplicationCore.Entities;
using Ardalis.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity  //BaseEntityden miras alan classların kullanabileceği generic repo
    {
        Task<T> GetByIdAsync(int id);

        Task<IReadOnlyList<T>> ListAllAsync();

        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> specification);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<int> CountAsync(ISpecification<T> specification);

        Task<T> FirstAsync(ISpecification<T> specification);

        Task<T> FirstOrDefaultAsync(ISpecification<T> specification);
    }
}
