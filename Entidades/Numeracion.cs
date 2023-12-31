﻿using System;

namespace Entidades
{
    public enum ESistema { Decimal, Binario };

    public abstract class Numeracion
    {
        protected string msgError;
        protected string valor;

        private ESistema sistema;

        private Numeracion()
        {
            this.msgError = "Numero invalido";
        }

        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }

        public string Valor
        {
            get
            {
                return valor;
            }
        }

        internal abstract double ValorNumerico
        {
            get;
        }

        public virtual Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            return this;
        }

        protected virtual bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = "Numero invalido";
            }
        }

        public static explicit operator double(Numeracion numeracion)
        {
            double.TryParse(numeracion.valor, out double result);

            return result;
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1 == n2;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return n1 != n2;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}