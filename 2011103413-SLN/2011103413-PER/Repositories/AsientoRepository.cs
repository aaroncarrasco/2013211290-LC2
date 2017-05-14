using _2013211290_ENT;
using _2013211290_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013211290_PER.Repositories
{
    public class AsientoRepository : Repository <Asiento>, IAsientoRepository
    {
        private readonly EnsambladoraDbContext _Context;

        private AsientoRepository()
        {
        }

        public AsientoRepository(EnsambladoraDbContext context)
        {
            _Context = context;
        }

    }
}
