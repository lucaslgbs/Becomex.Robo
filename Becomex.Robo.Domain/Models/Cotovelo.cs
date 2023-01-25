using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Models
{
    public class Cotovelo : ParteMovel
    {
        public Cotovelo()
        {
            Movimentos = new List<Movimento> { 
                new Movimento { Ordem = 1, Descricao = "Em Repouso" },
                new Movimento { Ordem = 2, Descricao = "Levemente Contraído" },
                new Movimento { Ordem = 3, Descricao = "Contraído" },
                new Movimento { Ordem = 4, Descricao = "Fortemente Contraído" }
            };

            PosicaoAtual = this.Movimentos.First(x => x.Ordem == 1);
        }
    }
}
