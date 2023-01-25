namespace Becomex.Robo.Domain.Models
{
    public class Robo
    {
        public Robo()
        {
            this.BracoEsquerdo = new Braco();
            this.BracoDireito = new Braco();
            this.Cabeca = new Cabeca();
        }

        public Braco BracoEsquerdo { get; set; }
        public Braco BracoDireito { get; set; }
        public Cabeca Cabeca { get; set; }
    }
}
