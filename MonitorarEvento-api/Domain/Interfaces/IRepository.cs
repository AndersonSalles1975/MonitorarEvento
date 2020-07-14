using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface IRepository<T> {

        Task<T> InsertAsync(T item);

        //Para futura implementa��o
        //Task<T> UpdateAsync(T item);

        Task<bool> DeleteAsync();

        //Para futura implementa��o
        //Task<T> SelectAsync(Guid id);

        Task<IEnumerable<T>> SelectAsync();
    }
}
