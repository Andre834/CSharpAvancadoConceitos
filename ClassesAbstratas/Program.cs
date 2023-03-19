using ClassesAbstratas.ClassesAbstratasExemplos;
using System;

namespace ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DerivedClass classeDerivadaDeClasseAbstrata = new DerivedClass();
            Console.WriteLine(" Chamando Metodo da classe abstrata: " + classeDerivadaDeClasseAbstrata.PerformCalculationAB());

        }
    }
}
