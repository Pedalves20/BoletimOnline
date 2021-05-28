using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimOnline.Controllers
{
    public class Pessoa
    {
        private long id;
        private String nome;
        public long Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
