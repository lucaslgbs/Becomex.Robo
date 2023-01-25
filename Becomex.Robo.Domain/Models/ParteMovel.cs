using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Models
{
    public class ParteMovel
    {
        protected List<Movimento> Movimentos { get; set; }

        protected Movimento PosicaoAtual { get; set; }

        public virtual Movimento? Proximo() => Movimentos.FirstOrDefault(x => x.Ordem == PosicaoAtual.Ordem + 1);

        public virtual Movimento? Anterior() => Movimentos.FirstOrDefault(x => x.Ordem == PosicaoAtual.Ordem - 1);

        public virtual void Voltar()
        {
            var posicao = Movimentos.FirstOrDefault(x => x.Ordem == PosicaoAtual.Ordem - 1);
            if (posicao == null)
                throw new Exception("Movimento inválido");
            PosicaoAtual = posicao;
        }

        public virtual void Avancar()
        {
            var posicao = Movimentos.FirstOrDefault(x => x.Ordem == PosicaoAtual.Ordem + 1);
            if (posicao == null)
                throw new Exception("Movimento inválido");
            PosicaoAtual = posicao;
        }

        public Movimento GetPosisaoAtual() => PosicaoAtual;
    }
}
