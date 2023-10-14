using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                return (double)this;
            }
        }

        public SistemaBinario(string valor)
            : base(valor)
        {

        }

        private SistemaDecimal BinarioADecimal()
        {
            if (this.valor != base.msgError)
            {
                return (SistemaDecimal)this.CambiarSistemaDeNumeracion(ESistema.Decimal);
            }

            return (SistemaDecimal)this.CambiarSistemaDeNumeracion(ESistema.Binario);
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            // Decimal a binario
            if (sistema == ESistema.Binario)
            {
                return this.CambiarSistemaDeNumeracion(ESistema.Binario);
            }
            else
            {
                return this;
            }
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private bool EsSistemaBinarioValido(string valor)
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

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}