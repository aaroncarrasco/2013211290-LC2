﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013211290_ENT
{
    public class Volante 
    {
        public int VolanteId { get; set; }
        public string NumSerie { get; set; }

        public ICollection<Carro> Carro { get; set; }

        public Volante()
        {
            Carro = new List<Carro>();
        }
    }
}
