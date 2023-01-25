using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Models
{
    public class CabecaInclinacao : ParteMovel
    {
        public CabecaInclinacao()
        {
            Movimentos = new List<Movimento> {
                new Movimento { Ordem = 1, Descricao = "Para Cima" },
                new Movimento { Ordem = 2, Descricao = "Em Repouso" },
                new Movimento { Ordem = 3, Descricao = "Para Baixo" }
            };

            PosicaoAtual = this.Movimentos.First(x => x.Ordem == 2);
        }
    }
}
