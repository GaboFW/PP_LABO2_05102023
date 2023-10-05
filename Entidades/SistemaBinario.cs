using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        sealed override double ValorNumerico
        {
            get
            {
                return;
            }
        }

        public SistemaBinario(string valor)
            : base(valor)
        {

        }

        private SistemaDecimal BinarioADecimal()
        {

        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            
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

        public static implicit operator SistemaBinario (string valor)
        {

        }
    }
}