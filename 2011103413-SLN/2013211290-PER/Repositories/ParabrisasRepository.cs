﻿using _2013211290_ENT;
using _2013211290_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2013211290_PER.Repositories
{
    public class ParabrisasRepository : Repository<Parabrisas>, IParabrisasRepository
    {
        public ParabrisasRepository(EnsambladoraDbContext context) : base(context)
        {
        }
    }
}
