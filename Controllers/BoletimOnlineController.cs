using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimOnline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoletimOnlineController : ControllerBase
    {

        private readonly ILogger<BoletimOnlineController> _logger;

        [HttpGet]
        public List<Boletim> Get()
        {
            List<Boletim> boletins = new List<Boletim>();
            Turma turmaManha = GetTurma("Matematica", "Manha", 1L);
            Turma turmaTarde = GetTurma("Matematica", "Tarde", 2L);
            Turma turmaNoite = GetTurma("Matematica", "Noite", 3L);

            boletins.AddRange(GetBoletinsAlunos(turmaManha));
            boletins.AddRange(GetBoletinsAlunos(turmaTarde));
            boletins.AddRange(GetBoletinsAlunos(turmaNoite));

            List<Boletim> osMelhores = new List<Boletim>();
            osMelhores = GetMelhoresAlunos(boletins);
            foreach (Boletim boletim in osMelhores)
            {
                Console.WriteLine("Aluno: " + boletim.Aluno.Nome + " Media Final: " + boletim.NotaFinal + " Turma: " + boletim.IdTurma);
            }

            return boletins;
        }

        public List<Boletim> GetBoletinsAlunos(Turma turma)
        {
            List<Boletim> boletins = new List<Boletim>();
            foreach (Aluno aluno in turma.Alunos)
            {
                Boletim boletim = new Boletim(aluno, getProvasAluno(aluno.Id), turma.Id);                
                boletins.Add(boletim);
            }
            return boletins;
        }

        public List<Prova> getProvasAluno(long idAluno)
        {
            List<Prova> provasAluno = new List<Prova>();
            provasAluno.Add(new Prova(idAluno, EnumProva.PROVA1));
            provasAluno.Add(new Prova(idAluno, EnumProva.PROVA2));
            provasAluno.Add(new Prova(idAluno, EnumProva.PROVA3));
            return provasAluno;
        }

        private Prova GetProvaAluno(long idAluno, EnumProva classificacao)
        {
            return new Prova(idAluno, classificacao);
        }

        public void GetBoletimAluno()
        {
  
        }

        private static Turma GetTurma(string disciplina, string periodo, long idTurma)
        {
            return new Turma(idTurma, GetRandomAlunos(idTurma), disciplina, periodo);            
        }

        private static List<Aluno> GetRandomAlunos(long idTurma)
        {
            List<Aluno> alunos = new List<Aluno>();

            for (int i = 0; i < 20; i++)
            {
                Aluno aluno = new Aluno();
                aluno.Id = i;
                aluno.Nome = "nome_aluno_" + i + "_idTurma_" + idTurma;
                aluno.Matricula = "M000" + i;
                alunos.Add(aluno);
            }
            return alunos;
        }

        public List<Boletim> GetMelhoresAlunos(List<Boletim> boletins)
        {
            boletins.Sort();
            // pegar os 5 melhore alunos
            return boletins;
        }

    }
}
