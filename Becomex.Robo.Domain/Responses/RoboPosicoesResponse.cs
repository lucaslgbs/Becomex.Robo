namespace Becomex.Robo.Domain.Responses
{
    public class RoboPosicoesResponse
    {
        public RoboPosicoesResponse(Models.Robo robo)
        {
            BracoEsquerdo = new BracoPosicoesResponse(robo.BracoEsquerdo);
            BracoDireito = new BracoPosicoesResponse(robo.BracoDireito);
            Cabeca = new CabecaPosicoesResponse(robo.Cabeca);
        }

        public BracoPosicoesResponse BracoDireito { get; set; }
        public BracoPosicoesResponse BracoEsquerdo { get; set; }
        public CabecaPosicoesResponse Cabeca { get; set; }
    }
}
