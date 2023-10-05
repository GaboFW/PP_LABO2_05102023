using System;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }
            set
            {
                primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }

        public Numeracion Operar(char operador)
        {
            double resultado = 0.0;

            switch (operador)
            {
                case '-':
                    resultado = this.primerOperando - this.segundoOperando;
                    break;

                case '/':
                    try
                    {
                        resultado = this.primerOperando / this.segundoOperando;
                    }
                    catch (DivideByZeroException)
                    {
                        return new Numeracion(double.NaN, ESistema.Decimal);
                    }
                    break;

                case '*':
                    resultado = this.primerOperando * this.segundoOperando;
                    break;

                default:
                    resultado = this.primerOperando + this.segundoOperando;
                    break;
            }

            return new Numeracion(resultado, ESistema.Decimal);
        }
    }
}