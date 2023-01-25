using Becomex.Robo.Domain.Models;

namespace Becomex.Robo.Domain.Responses
{
    public class PosicaoParteMovelResponse
    {
        public PosicaoParteMovelResponse(ParteMovel? parteMovel)
        {
            Ordem = parteMovel.GetPosisaoAtual().Ordem;
            Descricao = parteMovel.GetPosisaoAtual().Descricao;
            Avancar = new MovimentoResponse(parteMovel.Proximo());
            Voltar = new MovimentoResponse(parteMovel.Anterior());
        }

        public string? Descricao { get; set; }
        public int? Ordem { get; set; }
        public MovimentoResponse Avancar { get; set; }
        public MovimentoResponse Voltar { get; set; }
    }
}
