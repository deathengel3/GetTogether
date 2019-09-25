using GetTogether.Core.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Core.Persistance.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbcontext _context;

        public BaseRepository(AppDbcontext context)
        {
            _context = context;
        }
    }
}
