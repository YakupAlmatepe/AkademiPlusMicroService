using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusunessLayer.Abstract
{
	public interface IGenericService<T>
	{
		Task TCreateAsync(T entity);
		Task TUpdateAsync(T entity);
		Task TDeleteAsync(T entity);
		Task<T> TGetAsync(int id);
		Task<List<T>> TGetAllAsync();
	}
}