using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimOnline.Controllers
{
    public class Prova
    {
        private long idAluno;
        private double nota;
        private EnumProva classificacao;

        public Prova(long idAluno, EnumProva classificacao)
        {
            this.idAluno = idAluno;
            this.classificacao = classificacao;

            if (classificacao.Equals(EnumProva.PROVA1)) {
                this.nota = GetRandomNota(3.0, 10.0);
            } else if(classificacao.Equals(EnumProva.PROVA2)) {
                this.nota = GetRandomNota(3.0, 10.0)*2;
            } else if(classificacao.Equals(EnumProva.PROVA3)) {
                this.nota = GetRandomNota(3.0, 10.0)*3;
            }
        }

        public double GetRandomNota(double min, double max)
        {
            Random rand = new Random();
            return rand.NextDouble() * (max - min) + min;
        }

        public double Nota { get => nota; set => nota = value; }
        public long IdAluno { get => idAluno; set => idAluno = value; }
        internal EnumProva Classificacao { get => classificacao; set => classificacao = value; }
    }
}
