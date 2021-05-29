﻿using System;
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
            
            // atualizar nota de acordo com a classificao > nota de acordo com peso 

            this.nota = GetRandomNota(3.0, 10.0);
        }

        /**
         * Get Nota aleatória.
         * @return valor aleatorio de nota.
         */
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
