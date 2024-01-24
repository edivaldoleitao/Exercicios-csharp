using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoExemplo.Models
{
    //o nome começa com 'I', é um contrato que as classes que implementam são obrigadas a ter
    //é possível implementar múltiplas interfaces de uma vez
    public interface ICalculadora
    {
        // não tem modificadores de acesso, se entende como público
        //se o método tem corpo com implementação ele não é obrigatório
        int Somar(int valor1, int valor2);
        int Subtrair(int valor1, int valor2);
        int Multiplicar(int valor1, int valor2);
        int Dividir(int valor1, int valor2);
    }
}