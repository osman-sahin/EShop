using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity  //BaseEntityden miras alan classların kullanabileceği generic repo
    {
        Task<IReadOnlyList<T>> ListAllAsync();
    }
}
