using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Utils
    {
        public static  bool Tem_virgula(string texto)
        {
            if (texto == "")
            {
                return false;
            }

            foreach (var item in texto)
            {
                if (item == ',')
                {
                    return false;
                }
            }

            return true;
        }

        public static string Somar(string valor1, string valor2)
        {
            var resultado = Convert.ToDouble(valor1) + Convert.ToDouble(valor2);
            return resultado.ToString();
        }

        public static string Subtrair(string valor1, string valor2)
        {
            var resultado = Convert.ToDouble(valor1) - Convert.ToDouble(valor2);
            return resultado.ToString();
        }

        public static string Multiplicar(string valor1, string valor2)
        {
            var resultado = Convert.ToDouble(valor1) * Convert.ToDouble(valor2);
            return resultado.ToString();
        }

        public static string Dividir(string valor1, string valor2)
        {
            var resultado = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
            return resultado.ToString();
        }

        public static string RQuad(string valor)
        {
            var resultado = Math.Sqrt(Convert.ToDouble(valor));
            return resultado.ToString();
        }

        public static string IdentificaOperacao(string valor1, string valor2, string operacao)
        {
            if (valor2 == "" && valor1 == "")
            {
                return "a";
            }
            else if (valor2.Length > 0 && valor1 == "")
            {
                return "b";
            }
            else if (valor2 == "" && operacao.Length > 0 )
            {
                return "c";
            }
            else
            {
                if (operacao == "+")
                {
                    return Somar(valor1, valor2);
                }
                else if (operacao == "-")
                {
                    return Subtrair(valor1, valor2);
                }
                else if (operacao == "*")
                {
                    return Multiplicar(valor1, valor2);
                }
                else
                {
                    return Dividir(valor1, valor2);
                }
            }
        }

        public static string Returner(string valor1, string valor2, string operacao)
        {
            if (valor2 == "" && valor1 == "")
            {
                return null;
            }
            else if (valor2.Length > 0 && valor1 == "")
            {
                return null;
            }
            else if (valor2 == "" && operacao.Length > 0)
            {
                return null;
            }
            else
            {
                if (operacao == "+")
                {
                    return Somar(valor1, valor2);
                }
                else if (operacao == "-")
                {
                    return Subtrair(valor1, valor2);
                }
                else if (operacao == "*")
                {
                    return Multiplicar(valor1, valor2);
                }
                else
                {
                    return Dividir(valor1, valor2);
                }
            }
        }

        public static string CRQuad(string valor1, string valor2, string operacao)
        {
            if (valor2 == "" && valor1 == "")
            {
                return null;
            }
            else if (valor2.Length > 0 && valor1 == "")
            {
                return RQuad(valor2);
            }
            else if (valor2 == "" && operacao.Length > 0)
            {
                return null;
            }
            else
            {
                if (operacao == "+")
                {
                    return RQuad(Somar(valor1, valor2));
                }
                else if (operacao == "-")
                {
                    return RQuad(Subtrair(valor1, valor2));
                }
                else if (operacao == "*")
                {
                    return RQuad(Multiplicar(valor1, valor2));
                }
                else
                {
                    return RQuad(Dividir(valor1, valor2));
                }
            }
        }
    }
}
