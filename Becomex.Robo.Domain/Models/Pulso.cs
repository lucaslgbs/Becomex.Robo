using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Models
{
    public class Pulso : ParteMovel
    {
        public Pulso()
        {
            Movimentos = new List<Movimento> {
                new Movimento { Ordem = 1, Descricao = "Rotação para -90º" },
                new Movimento { Ordem = 2, Descricao = "Rotação para -45º" },
                new Movimento { Ordem = 3, Descricao = "Em Repouso" },
                new Movimento { Ordem = 4, Descricao = "Rotação para 45º" },
                new Movimento { Ordem = 5, Descricao = "Rotação para 90º" },
                new Movimento { Ordem = 6, Descricao = "Rotação para 135º" },
                new Movimento { Ordem = 7, Descricao = "Rotação para 180º" }
            };

            PosicaoAtual = this.Movimentos.First(x => x.Ordem == 3);
        }
    }
}
