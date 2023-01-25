using Becomex.Robo.Domain.Models;

namespace Becomex.Robo.Domain.Responses
{
    public class CabecaPosicoesResponse
    {
        public CabecaPosicoesResponse(Cabeca cabeca)
        {
            Rotacao = new PosicaoParteMovelResponse(cabeca.Rotacao);
            Inclinacao = new PosicaoParteMovelResponse(cabeca.Inclinacao);

            if(Inclinacao.Ordem == 3)
            {
                Rotacao.Avancar.Ativo = false;
                Rotacao.Voltar.Ativo = false;
            }

            if(Rotacao.Ordem != 3 && Inclinacao.Ordem == 2)
            {
                Inclinacao.Avancar.Ativo = false;
            }
        }

        public PosicaoParteMovelResponse Rotacao { get; set; }
        public PosicaoParteMovelResponse Inclinacao { get; set; }
    }
}
