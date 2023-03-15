using System;
using Tuplas.MetodosComTuplas;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendo conceitos avançado de c#: TUPLAS!");
            Console.WriteLine("Chamando uma função que tem como retorno uma tupla: " + MetodoComRetornoTipoTupla.GetUsuario());

            
        }
    }
}
