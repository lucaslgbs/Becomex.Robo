using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Models
{
    public class Braco
    {
        public Braco()
        {
            Cotovelo = new Cotovelo();
            Pulso = new Pulso();
        }

        public Cotovelo Cotovelo { get; set; }

        public Pulso Pulso { get; set; }
    }
}
