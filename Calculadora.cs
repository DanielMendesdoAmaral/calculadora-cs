using System;
using System.Collections.Generic;

namespace calculadora_cs
{
    public class Calculadora : OperacoesEstatisticas
    {
        public void ConstruirCalculadora() {
            string resultado = null;
            string[] resultadosV = null;

            Console.Clear();
            System.Console.WriteLine("1- PARA CÁLCULOS DE MÉDIA, COLOQUE OS NÚMEROS SEPARADOS POR UM ESPAÇO E NO FINAL DIGITE 'avg'. Ex: '10 5 avg' retorna 7,5.");
            Console.WriteLine("2- PARA SAIR APERTE ESC.");
            System.Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("|                        |");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"|                 {sinal}    |");
            for (int c=0; c<16; c++) {
                if (c==0 || c==4 || c==8 || c==12)
                    System.Console.Write("|");
                Console.Write($"    {botoes[c]}");
                if (c==3 || c==7 || c==11 || c==15)
                    System.Console.WriteLine("    |");
            }
            Console.WriteLine("--------------------------");

            System.Console.Write("OPERAÇÃO: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            resultado = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            System.Console.Write("RESULTADO: ");
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(CalculaResultado(resultado, resultadosV)); 
            Console.ForegroundColor = ConsoleColor.White;
        }

        private string CalculaResultado(string r, string[] rs) {
            for (int c=0; c<r.Length; c++) {
                switch (r[c]) {
                    case '/':
                        rs = r.Split("/");
                        return Convert.ToString(Divisao(Convert.ToDouble(rs[0]), Convert.ToDouble(rs[1])));
                    break;
                    case '*':
                        rs = r.Split("*");
                        return Convert.ToString(Multiplicacao(Convert.ToDouble(rs[0]), Convert.ToDouble(rs[1])));
                    break;
                    case '-':
                        rs = r.Split("-");
                        return Convert.ToString(Subtracao(Convert.ToDouble(rs[0]), Convert.ToDouble(rs[1])));
                    break;
                    case '+':
                        rs = r.Split("+");
                        return Convert.ToString(Soma(Convert.ToDouble(rs[0]), Convert.ToDouble(rs[1])));
                    break;
                }
            }

            List<double> numerosAvg = new List<double>();

            if (r.Contains("avg")) {
                rs = r.Split(" ");
                for (int c=0; c<rs.Length-1; c++) {
                    numerosAvg.Add(Convert.ToDouble(rs[c]));
                }
                return Convert.ToString(Media(numerosAvg));
            }

            return ""; //Gambiarra
        }

        private void CorLetra(string c, string t) {
            switch (c) {
                case "Amarelo":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(t);
                    Console.ForegroundColor = ConsoleColor.White;
                break;

                case "Verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(t);
                    Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
    }
}