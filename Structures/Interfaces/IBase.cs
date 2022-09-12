using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Interfaces;
public interface IBase<T, U> where T : class where U : class
{
    Task<IEnumerable<U>> GetAllData();
    Task<U> GetDataById(int Id);
    Task<T> Create(T model);
    Task<T> Update(T model, int Id);
    Task DeleteById(int Id);
}
