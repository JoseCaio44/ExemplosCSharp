using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoque
{
    internal interface IEstoque
    {
        void Exbir();
        void AdicionarEntrada();
        void AdicionarSaida();

    }
}
