using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appTerceira.Models
{
    public class Juridica : Pessoa
    {
        public Int64 Cnpj { get; set; }
        public Int64 IE { get; set; }
    }
}