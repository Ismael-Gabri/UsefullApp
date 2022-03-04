using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinal.Interfaces
{
    public interface IOperacoesMatematicas
    {
        public double RealizarSomaPrintarResultado();
        public double RealizarSubtracaoPrintarResultado();
        public double RealizarMultiplicacaoPrintarResultado();
        public double RealizarDivisaoPrintarResultado();
    }
}
