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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BoletimOnlineController> _logger;

        public BoletimOnlineController(ILogger<BoletimOnlineController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public void iniciar()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 1L;
            pessoa.Nome = "Pedro Alves Lucena";

            Console.WriteLine("Nome da Pessoa: " + pessoa.Nome);
        }

        public void getBoletimAluno()
        {
            // 1.   Criar uma lista de alunos;
            // 1.1. Criar um método generico que cria alunos aleatórios para cada turma;
            // 2. Pegar cada aluno e suas provas;
            // 3. Criar um boletim pra cada aluno;
            // 4. Uma lista de boletins de alunos;
            // 5. Pegar quem as melhores notas finais e separar os 5 primeiros alunos;
        }

        public Turma criarTurma()
        {

            Turma turma = new Turma();
            List<Aluno> alunos = new List<Aluno>();

            for (int i = 0; i < 20; i++)
            {
                Aluno aluno = new Aluno();
                aluno.Id = i;
                aluno.Nome = "nome_aluno_" + i;
                alunos.Add(aluno);
            }

            turma.Alunos = alunos;
            turma.Disciplina = "Matematica";
            turma.Periodo = "Manha";
            turma.Id = 1L;

            return turma;
        }

        public void calcularNotasAlunos()
        {
            // Implementação qualquer.
        }

        public void criarBoletimAluno()
        {
            // Implementar método de criação de boletim para o aluno.
        }


    }
}
