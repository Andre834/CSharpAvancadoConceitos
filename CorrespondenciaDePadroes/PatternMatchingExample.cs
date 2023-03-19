using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrespondenciaDePadroes
{
    /*
     No C# 7, agora temos a capacidade de usar a correspondência de padrões. Usando padrões, podemos testar se um valor tem uma determinada forma e, em caso afirmativo, trabalhar com as informações dessa forma correspondente.

     verdade, você já está usando algoritmos de correspondência de padrões quando usa as instruções if e switch para testar valores. Se as instruções corresponderem, você pega o valor correspondente e extrai suas informações.

    No C# 7, você pode usar novos elementos de sintaxe que estendem as instruções is e switch com as quais você já está familiarizado. Vamos começar criando uma nova classe chamada PatternMatchingExample e adicionando nosso código a essa classe.
     
     */
    public class PatternMatchingExample
    {
        public enum UniversityCourses { Matemática, Química, Anatomia, LifeSkills }
        public enum UniversityDegree { BA, BSc }
    }
}
