using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    //Usada para coordenadas as operações de persistencia


    public interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken); //Salvar as operações
    }
}
