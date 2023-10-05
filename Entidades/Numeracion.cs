using System;

namespace Entidades
{
    public enum ESistema { Decimal, Binario };

    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        public Numeracion(double valorNumerico, ESistema sistema)
        {
            this.sistema = sistema;
            this.valorNumerico = valorNumerico;
        }

        public Numeracion(string valor, ESistema eSistema)
        {
            InicializarValores(valor, eSistema);
        }

        public ESistema Sistema
        {
            get
            {
                return sistema;
            }

        }

        public string Valor
        {
            get
            {
                return valorNumerico.ToString();
            }
        }

        /// <summary>
        /// Convertir el valor decimal a binario y viceversa
        /// </summary>
        /// <param name="eSistema"></param>
        /// <returns></returns>
        public string ConvertirA(ESistema sistema)
        {
            // Decimal a binario
            if (sistema == ESistema.Binario)
            {
                return this.DecimalABinario(this.Valor);
            }
            else
            {
                return this.Valor;
            }
        }

        /// <summary>
        /// De binario a decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private double BinarioADecimal(string valor)
        {
            if (EsBinario(valor) == true)
            {
                return Convert.ToDouble(valor);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Metodo decimal a binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private string DecimalABinario(int valor)
        {
            if (valor > 0)
            {
                string binario = "";

                while (valor > 0)
                {
                    binario = valor % 2 + binario;
                    valor /= 2;
                }

                return binario;
            }
            else
            {
                return "Valor invalido";
            }
        }

        /// <summary>
        /// De decimal a Binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private string DecimalABinario(string valor)
        {
            if (int.TryParse(valor, out int numeroDecimal))
            {
                if (numeroDecimal > 0)
                {
                    string binario = "";

                    while (numeroDecimal > 0)
                    {
                        binario = numeroDecimal % 2 + binario;
                        numeroDecimal /= 2;
                    }

                    return binario;
                }
                else
                {
                    return "Valor invalido";
                }
            }
            else
            {
                return "Valor invalido";
            }
        }

        /// <summary>
        /// Logica para saber si es o no binario
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' || c != '1')
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;
        }

        /// <summary>
        /// Si los valores decimales que se vuelvan decimales
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        private void InicializarValores(string valor, ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if (sistema == ESistema.Decimal)
            {
                try
                {
                    this.valorNumerico = double.Parse(valor);
                }
                catch (FormatException)
                {
                    this.valorNumerico = double.NaN;
                }
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }
        }

        // Sobrecarga de Operadores Comparativos
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return numeracion.sistema != sistema;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return n1.sistema != n2.sistema;
        }

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return numeracion.sistema == sistema;
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }

        // Sobrecarga de Operadores Logicos
        public static double operator -(Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico - n2.valorNumerico;
        }

        public static double operator *(Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico * n2.valorNumerico;
        }

        public static double operator /(Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico / n2.valorNumerico;
        }

        public static double operator +(Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico + n2.valorNumerico;
        }
    }
}