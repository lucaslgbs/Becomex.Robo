using Becomex.Robo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Becomex.Robo.Domain.Requests
{
    public class MovimentoBracoRequest : MovimentoRequest
    {
        public EHemisferio Hemisferio { get; set; }
    }
}
