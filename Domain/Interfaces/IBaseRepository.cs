using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    //T representa o usuario 
   // A nossa base de repositorio é do tipo T onde T é do tipo BaseEntity
    public interface IBaseRepository<T> where T: BaseEntity
    {
        //Definição de  contracto
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(Guid id, CancellationToken cancellationToken);
    }

}
