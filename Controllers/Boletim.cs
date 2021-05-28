using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimOnline.Controllers
{
    public class Boletim
    {
		private Aluno aluno;
		private String resultado;
		private List<Prova> provas;
		private double notaFinal;

        public List<Prova> Provas { get => provas; set => provas = value; }
        public double NotaFinal { get => notaFinal; set => notaFinal = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        /**
		 * Recupera situação de aprovação do aluno
		 * @return situacao
		 */
        public String getSituacaoAluno()
		{
			return this.NotaFinal > 5 ? "APROVADO" : "REPROVADO";
		}

		public double getMediaFinal()
		{
			this.NotaFinal = 0.0;
			for (Prova prova : this.Provas)
			{
				this.NotaFinal = this.NotaFinal + prova.);
			}
			return this.notaFinal / 3;
		}

		public double getMediaFinal(List<Prova> provas)
		{
			this.notaFinal = 0.0;
			for (Prova prova : provas)
			{
				this.notaFinal = this.NotaFinal + prova.getNota();
			}
			return this.notaFinal / 3;
		}
	}
}
