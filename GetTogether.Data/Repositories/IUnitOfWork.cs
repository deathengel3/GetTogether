using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repositories
{
    public interface IUnitOfWork
    {
        Task CompletarTareaAsync();
    }
}
