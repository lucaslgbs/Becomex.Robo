using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Models
{
    public class CabecaRotacao : ParteMovel
    {
        public CabecaRotacao()
        {
            Movimentos = new List<Movimento> {
                new Movimento { Ordem = 1, Descricao = "Rotação -90º" },
                new Movimento { Ordem = 2, Descricao = "Rotação -45º" },
                new Movimento { Ordem = 3, Descricao = "Em Repouso" },
                new Movimento { Ordem = 4, Descricao = "Rotação 45º" },
                new Movimento { Ordem = 5, Descricao = "Rotação 90º" }
            };

            PosicaoAtual = this.Movimentos.First(x => x.Ordem == 3);
        }
    }
}
