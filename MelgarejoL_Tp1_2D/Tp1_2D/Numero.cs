using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu
{
    public class Numero
    {
        private double numero;


        #region Metodos

        public double getNumero()
        {
            return this.numero;
        }

        public Numero()  // constructor por defecto que inicializa numero en 0
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)  // recibe un string  q validara y cargara en numero
        {
            this.numero = (validarNUmero(numero));
 
        }

        private void setNumero(string numero)
        {
            this.numero = Numero.validarNUmero(numero);
        }

        private static double validarNUmero(string numeroString) // valida q sea doble y en caso contrario retornara 0
        { 
            double num;
            bool n = double.TryParse(numeroString, out num);


            if (n)
            {
                Console.WriteLine("numero doble");
                return double.Parse(numeroString);
            }
            else
            {
                Console.WriteLine("no es un numero de tipo double");
                return 0;
            }
        
        }

        #endregion
    }
    }
