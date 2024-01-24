using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoExemplo.Models
{
    public class Pessoa
    {
       
        private string _nome;
        public string Nome { 
        // body expression
        get => _nome; 
        set => _nome = value; 
        }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }
        // palavra virtual diz que pode ter override na classe filha
        public virtual void Apresentar() {
            Console.WriteLine($"nome {Nome}, idade {Idade}");
        }
    }
}