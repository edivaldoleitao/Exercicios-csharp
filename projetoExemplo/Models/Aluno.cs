using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoExemplo.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        // palavra override para sobrescrever
        public override void Apresentar()
        {
            Console.WriteLine("metodo sobrescrito");
        }
    }
}