using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Interfaces;
public interface IBase<T> where T : class
{
    Task<IEnumerable<T>> GetAllData();
    Task<T> GetDataById(int Id);
    Task<T> Create(T model);
    Task<T> Update(T model, int Id);
    Task DeleteById(int Id);
}
