using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeraMathiasExamenP2.Models;

namespace VeraMathiasExamenP2.Repositories
{
    public class RecargasRepositorio
    {
        public VeraMathiasRecarga DevuelveInfoRecarga()
        {
            return new VeraMathiasRecarga()
            {
                Id = 1,
                Numero=0979386716,
                Nombre="Mathias"
            };

            
        }
    }
}
