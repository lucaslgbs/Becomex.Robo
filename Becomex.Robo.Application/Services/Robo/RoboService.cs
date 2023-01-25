using Becomex.Robo.Application.Interfaces;
using Becomex.Robo.Domain.Models;
using Becomex.Robo.Domain.Requests;
using Becomex.Robo.Domain.Responses;

namespace Becomex.Robo.Application.Services.Robo
{
    public class RoboService : IRoboService
    {
        public Domain.Models.Robo Robo { get; set; }

        public RoboService()
        {
            this.Robo = new Domain.Models.Robo();
        }

        public RoboPosicoesResponse GetPosicoes() => new RoboPosicoesResponse(this.Robo);

        public RoboPosicoesResponse MovimentarPulso(MovimentoBracoRequest request)
        {
            if (!ValidarMovimentoPulso(request))
                throw new Exception("Movimento inválido.");

            if (request.Hemisferio == Domain.Enums.EHemisferio.Direito)
            {
                if (request.Sentido == Domain.Enums.ESentidoMovimento.Avancar)
                {
                    Robo.BracoDireito.Pulso.Avancar();
                }
                else
                {
                    Robo.BracoDireito.Pulso.Voltar();
                }
            }
            else
            {
                if (request.Sentido == Domain.Enums.ESentidoMovimento.Avancar)
                {
                    Robo.BracoEsquerdo.Pulso.Avancar();
                }
                else
                {
                    Robo.BracoEsquerdo.Pulso.Voltar();
                }
            }

            return GetPosicoes();
        }

        public RoboPosicoesResponse MovimentarCotovelo(MovimentoBracoRequest request)
        {
            if(!ValidarPosicaoPulso(request))
                throw new Exception("Movimento inválido.");

            if (request.Hemisferio == Domain.Enums.EHemisferio.Direito)
            {
                if (request.Sentido == Domain.Enums.ESentidoMovimento.Avancar)
                {
                    Robo.BracoDireito.Cotovelo.Avancar();
                }
                else
                {
                    Robo.BracoDireito.Cotovelo.Voltar();
                }
            }
            else
            {
                if (request.Sentido == Domain.Enums.ESentidoMovimento.Avancar)
                {
                    Robo.BracoEsquerdo.Cotovelo.Avancar();
                }
                else
                {
                    Robo.BracoEsquerdo.Cotovelo.Voltar();
                }
            }

            return GetPosicoes();
        }

        public RoboPosicoesResponse RotacionarCabeca(MovimentoCabecaRequest request)
        {
            if (!ValidarRotacaoCabeca())
                throw new Exception("Movimento inválido.");
            if (request.Sentido == Domain.Enums.ESentidoMovimento.Avancar)
            {
                Robo.Cabeca.Rotacao.Avancar();
            }
            else
            {
                Robo.Cabeca.Rotacao.Voltar();
            }
            return GetPosicoes();
        }

        public RoboPosicoesResponse InclinarCabeca(MovimentoCabecaRequest request)
        {
            if (request.Sentido == Domain.Enums.ESentidoMovimento.Avancar)
            {
                Robo.Cabeca.Inclinacao.Avancar();
            }
            else
            {
                Robo.Cabeca.Inclinacao.Voltar();
            }
            return GetPosicoes();
        }

        public RoboPosicoesResponse ReiniciarRobo()
        {
            Robo = new Domain.Models.Robo();
            return GetPosicoes();
        }

        private bool ValidarMovimentoPulso(MovimentoBracoRequest request)
        {
            if (request.Hemisferio == Domain.Enums.EHemisferio.Direito)
            {
                return Robo.BracoDireito.Cotovelo.GetPosisaoAtual().Ordem == 4;
            }
            else
            {
                return Robo.BracoEsquerdo.Cotovelo.GetPosisaoAtual().Ordem == 4;
            }
        }

        private bool ValidarRotacaoCabeca()
        {
            return Robo.Cabeca.Inclinacao.GetPosisaoAtual().Ordem != 3;
        }

        private bool ValidarPosicaoPulso(MovimentoBracoRequest request)
        {
            Movimento posicaoCotovelo;
            Movimento posicaoPulso;
            if (request.Hemisferio == Domain.Enums.EHemisferio.Direito)
            {
                posicaoCotovelo = Robo.BracoDireito.Cotovelo.GetPosisaoAtual();
                posicaoPulso = Robo.BracoDireito.Pulso.GetPosisaoAtual();
            }
            else
            {
                posicaoCotovelo = Robo.BracoEsquerdo.Cotovelo.GetPosisaoAtual();
                posicaoPulso = Robo.BracoEsquerdo.Pulso.GetPosisaoAtual();
            }

            return !(posicaoPulso.Ordem != 3 && posicaoCotovelo.Ordem == 4);
        }
    }
}
