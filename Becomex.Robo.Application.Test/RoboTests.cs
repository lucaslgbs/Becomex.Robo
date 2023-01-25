namespace Becomex.Robo.Test
{
    public class RoboTests
    {
        private Domain.Models.Robo robo;

        [SetUp]
        public void Setup()
        {
            robo = new Domain.Models.Robo();
        }

        [Test]
        public void MovimentarCotovelo_Test()
        {
            robo.BracoDireito.Cotovelo.Avancar();
            var posicao = robo.BracoDireito.Cotovelo.GetPosisaoAtual();
            Assert.That(posicao.Ordem, Is.EqualTo(2));
        }

        [Test]
        public void InclinarCabeca_Test()
        {
            robo.Cabeca.Inclinacao.Avancar();
            var posicao = robo.Cabeca.Inclinacao.GetPosisaoAtual();
            Assert.That(posicao.Ordem, Is.EqualTo(3));
        }
    }
}