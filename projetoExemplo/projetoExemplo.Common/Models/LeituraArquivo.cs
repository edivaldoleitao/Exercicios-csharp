using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoExemplo.Common.Models
{
    public class LeituraArquivo
    {
        // retorna uma tupla
        public (bool sucesso, string[] linhas,int quantidadeLinhas) lerARquivo(string caminho) 
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                int quantidadeLinhas = linhas.Length;
                bool sucesso = true;
                return (sucesso, linhas, quantidadeLinhas);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return (false, new string[0], 0);
            }
            

        }
    }
}