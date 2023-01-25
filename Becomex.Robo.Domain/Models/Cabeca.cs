using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Models
{
    public class Cabeca
    {
        public Cabeca()
        {
            Inclinacao = new CabecaInclinacao();
            Rotacao = new CabecaRotacao();
        }
        public CabecaInclinacao Inclinacao { get; set; }
        public CabecaRotacao Rotacao { get; set; }
    }
}
