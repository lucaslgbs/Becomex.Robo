using Becomex.Robo.Domain.Requests;
using Becomex.Robo.Domain.Responses;

namespace Becomex.Robo.Application.Interfaces
{
    public interface IRoboService
    {
        RoboPosicoesResponse GetPosicoes();
        RoboPosicoesResponse MovimentarPulso(MovimentoBracoRequest request);
        RoboPosicoesResponse MovimentarCotovelo(MovimentoBracoRequest request);
        RoboPosicoesResponse RotacionarCabeca(MovimentoCabecaRequest request);
        RoboPosicoesResponse InclinarCabeca(MovimentoCabecaRequest request);
        RoboPosicoesResponse ReiniciarRobo();
    }
}
