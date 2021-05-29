using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimOnline.Controllers
{
	public class Boletim : IComparable<Boletim>
	{
		private Aluno aluno;
		private string resultado;
		private List<Prova> provas;
		private double notaFinal;
		private long idTurma;

		public Boletim(Aluno aluno, List<Prova> provas, long idTurma) {
			this.aluno = aluno;
			this.provas = provas;
			this.idTurma = idTurma;
			GetMediaFinal();
			getSituacaoAluno();
		}

        public List<Prova> Provas { get => provas; set => provas = value; }
        public double NotaFinal { get => notaFinal; set => notaFinal = value; }
        public Aluno Aluno { get => aluno; set => aluno = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public long IdTurma { get => idTurma; set => idTurma = value; }

        /**
		 * Recupera situação de aprovação do aluno
		 * @return situacao
		 */
        public void getSituacaoAluno()
		{
			this.resultado = this.NotaFinal >= 6 ? "APROVADO" : "RECUPERACAO";
		}

		/**
		 * Get Media Final.
		 * @return media final
		 */
		public void GetMediaFinal()
		{
			this.NotaFinal = 0.0;
			foreach (Prova prova in this.Provas)
			{
				this.NotaFinal += prova.Nota;
			}
			this.notaFinal = this.NotaFinal / 6;
		}

        public int CompareTo(Boletim other)
        {
			var index = NotaFinal.CompareTo(other.NotaFinal);
			return index;
		}

		public override string ToString()
		{
			return $"{NotaFinal}";
		}
	}
}
