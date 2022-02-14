using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Semana_1
{
    class Comments
    {


        public int Id { get; set; } 
        public DateTime Date { get; set; }  
        public string Comment { get; set; }
        public ICollection<Usuario> User { get; set; } = new List<Usuario>();

    }
}
