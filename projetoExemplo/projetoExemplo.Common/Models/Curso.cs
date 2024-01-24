using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoExemplo.Common.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos {get;set;}

        public void AdicionaAluno(Pessoa pessoa) {
            Alunos.Add(pessoa);
        }

        public int ObterQuantidadeAlunos() {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa pessoa) {

            return Alunos.Remove(pessoa);
        }

        public void ListarAlunos()
        {
            foreach (Pessoa p in Alunos)
            {
                Console.WriteLine(p.Nome);
            }
        }
    }
}