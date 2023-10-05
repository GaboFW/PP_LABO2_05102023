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
                return;
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

        }

        protected override bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private bool EsSistemaDecimalValido(string valor)
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
                    return Numeracion.msgError;
                }
            }
            else
            {
                return Numeracion.msgError;
            }
            
            //TERMINAR!!
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new Numeracion(valor);
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new Numeracion(valor);
        }
    }
}