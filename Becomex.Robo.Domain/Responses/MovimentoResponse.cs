using Becomex.Robo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Responses
{
    public class MovimentoResponse
    {
        public MovimentoResponse(Movimento? movimento)
        {
            if (movimento == null)
                Ativo = false;
            else
            {
                Ordem = movimento.Ordem;
                Descricao = movimento.Descricao;
                Ativo = true;
            }

        }

        public int? Ordem { get; set; }
        public string? Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
