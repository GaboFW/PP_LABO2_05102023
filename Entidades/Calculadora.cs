using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones; //COLECCION
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        static ESistema sistema;

        static Calculadora()
        {
            Calculadora.sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno)
            :this()
        {
            this.nombreAlumno = nombreAlumno;
        }

        public string NombreAlumno
        {
            get
            {
                return nombreAlumno;
            }
            set
            {
                nombreAlumno = value;
            }
        }

        public List<string> Operaciones
        {
            get
            {
                return operaciones;
            }
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
                segundoOperando = value;
            }
        }

        public Numeracion Resultado
        {
            get
            {
                return resultado;
            }
        }

        public ESistema Sistema
        {
            get
            {
                return sistema;
            }
            set
            {
                sistema = value;
            }
        }

        public void Calcular()
        {

        }

        public void Calcular(char operador)
        {
            double resultado = 0.0;

            switch (operador)
            {
                case '-':
                    resultado = this.primerOperando.ValorNumerico - this.segundoOperando.ValorNumerico;
                    break;

                case '/':
                    resultado = this.primerOperando.ValorNumerico / this.segundoOperando.ValorNumerico;
                    break;

                case '*':
                    resultado = this.primerOperando.ValorNumerico * this.segundoOperando.ValorNumerico;
                    break;

                default:
                    resultado = this.primerOperando.ValorNumerico + this.segundoOperando.ValorNumerico;
                    break;
            }

            this.resultado = this.MapeaResultado(resultado);
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"[{Calculadora.sistema}] => {this.primerOperando.Valor} {operador} {this.segundoOperando.Valor} = {this.resultado.Valor}");

            this.operaciones.Add(sb.ToString());
        }

        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }

        private Numeracion MapeaResultado(double valor)
        {
            Numeracion resultado = (SistemaDecimal)valor.ToString();

            return resultado.CambiarSistemaDeNumeracion(Calculadora.sistema);
        }
    }
}