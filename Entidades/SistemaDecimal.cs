using System;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor)
            : base(valor)
        {

        }

        internal override double ValorNumerico
        {
            get
            {
                return (double)this;
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return this.DecimalABinario();
            }
            else
            {
                return this;
            }
        }

        private SistemaBinario DecimalABinario()
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

        protected override bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
    }
}