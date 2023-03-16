using System;
using Tuplas.MetodosComTuplas;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = MetodoComRetornoTipoTupla.GetUsuario();
            Console.WriteLine("Aprendendo conceitos avançado de c#: TUPLAS!");
            Console.WriteLine($"Chamando uma função que tem como retorno uma tupla, item1: {result.Item1} "  );
            Console.WriteLine($"Chamando uma função que tem como retorno uma tupla, item2: {result.Item2} "  );

            #region Usando as variáveis ​​de tupla discretas

            (string TipoProduto, int Quantidade) = MetodoComRetornoTipoTupla.GetTipoProduto();
            var (TipoProduto1, Quantidade1) = MetodoComRetornoTipoTupla.GetUsuario();
            Console.WriteLine($"Tipo do Produto: {TipoProduto}");
            Console.WriteLine($"Quantidade: {Quantidade}");

            #endregion


        }
    }
}
