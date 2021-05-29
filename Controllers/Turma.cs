﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimOnline.Controllers
{
    public class Turma
    {
        private long id;
        private List<Aluno> alunos;
        private String disciplina;
        private String periodo;

        public Turma(long id, List<Aluno> alunos, string disciplina, string periodo)
        {
            this.id = id;
            this.alunos = alunos;
            this.disciplina = disciplina;
            this.periodo = periodo;
        }

        public long Id { get => id; set => id = value; }
        public List<Aluno> Alunos { get => alunos; set => alunos = value; }
        public string Disciplina { get => disciplina; set => disciplina = value; }
        public string Periodo { get => periodo; set => periodo = value; }
    }
}
