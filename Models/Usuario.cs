using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Semana_1
{
  class Usuario
    {

        public int id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; } 

     public Posts Posts { get; set; }

        public Comments Comments { get; set; }
    }
}
