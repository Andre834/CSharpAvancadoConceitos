using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas.MetodosComTuplas
{
    public static class MetodoComRetornoTipoTupla
    {
        public static (string, int) GetUsuario()
        {
            return("Paulo Santos", 6);
        }
        public static (string TipoProduto, int Quantidade) GetTipoProduto()
        {
            return("Carros", 100);
        }

    }
}
