using System.Collections.Generic;

namespace calculadora_cs
{
    public class OperacoesEstatisticas : OperacoesBasicas
    {
        protected string sinal = "avg";

        protected double Media(List<double> v) {
            double somaNumeros =0;
            int auxiliar=0;

            for (int c=0; c<v.Count; c++) {
                somaNumeros+=v[c];
                auxiliar++;
            }

            return somaNumeros/auxiliar;
        }
    }
}