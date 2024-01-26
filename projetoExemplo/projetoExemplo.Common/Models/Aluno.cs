using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoExemplo.Common.Models
{
    /// <summary>
    /// Classe que representa um aluno
    /// </summary>
    public class Aluno : Pessoa
    {
        /// <summary>
        /// Inicializa dados do aluno
        /// </summary>
        /// <param name="nome">nome do aluno</param>
        /// <param name="idade">idade do aluno</param>
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        // palavra override para sobrescrever
        /// <summary>
        /// Apresenta os dados do aluno
        /// </summary>
        public override void Apresentar()
        {
            Console.WriteLine("metodo sobrescrito");
        }

        // método deconstruct
        public void Deconstruct(out string nome, out int idade)
        {
            nome = Nome;
            idade = Idade;
        }
    }
}