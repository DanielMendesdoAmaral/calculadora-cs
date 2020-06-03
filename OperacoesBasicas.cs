namespace calculadora_cs
{
    public class OperacoesBasicas
    {
        protected string[] botoes = {"7", "8", "9", "/", "4", "5", "6", "x", "1", "2", "3", "-", ".", "0", "=", "+"};

        protected double Divisao(double a, double b) {
            return a/b;
        }

        protected double Multiplicacao(double a, double b) {
            return a*b;
        }

        protected double Subtracao(double a, double b) {
            return a-b;
        }

        protected double Soma(double a, double b) {
            return a+b;
        }
    }
}