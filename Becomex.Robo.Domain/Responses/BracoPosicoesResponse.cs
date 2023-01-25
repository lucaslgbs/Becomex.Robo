using Becomex.Robo.Domain.Models;

namespace Becomex.Robo.Domain.Responses
{
    public class BracoPosicoesResponse
    {
        public BracoPosicoesResponse(Braco braco)
        {
            this.Cotovelo = new PosicaoParteMovelResponse(braco.Cotovelo);
            this.Pulso = new PosicaoParteMovelResponse(braco.Pulso);

            if (Cotovelo.Ordem != 4)
            {
                this.Pulso.Avancar.Ativo = false;
                this.Pulso.Voltar.Ativo = false;
            }

            if(Pulso.Ordem != 3)
            {
                this.Cotovelo.Avancar.Ativo = false;
                this.Cotovelo.Voltar.Ativo = false;
            }
        }
        public PosicaoParteMovelResponse Cotovelo { get; set; }
        public PosicaoParteMovelResponse Pulso { get; set; }
    }
}
