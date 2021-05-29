using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimOnline.Controllers
{
    public class Aluno : Pessoa
    {
        private string matricula;
        public string Matricula { get => matricula; set => matricula = value; }
    }
}
