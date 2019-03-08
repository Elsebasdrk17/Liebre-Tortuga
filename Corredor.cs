using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carreraLiebreTortuga
{
    class Corredor
    {
        private int _numero;
        /// <summary>
        /// Se crea una variable protegida _posicion, para poder obtener el valor _posicion en las 
        /// clases Liebre y Tortuga
        /// </summary>
        protected int _posicion;
        public static Random aleatorio = new Random();
        /// <summary>
        /// Se crea el constructor del corredor para que no se pueda crear ningun corredor sin su numero
        /// </summary>
        /// <param name="numero">Recibe un numero entero para poder hacer un corredor</param>
        public Corredor(int numero)
        {
            _numero = numero;
            _posicion = 0;
        }
        /// <summary>
        /// Se tiene que poner la propiedad get tanto para el numero como la posicion, ya que solo se necesita el valor pero 
        /// se debe de modificar
        /// </summary>
        public int numero
        {
            get { return _numero; }
        }
        public int posicion
        {
            get { return _posicion; }
        }
        /// <summary>
        /// Acomodamos nuestro override de acuerdo a nuestras necesidades
        /// </summary>
        /// <returns>numero + (valor en _numero) + posicion + (valor en _posicion)"</returns>
        public override string ToString()
        {
            return "numero: " + _numero.ToString() +
                " esta en la posicion: " + _posicion.ToString();
        }
        /// <summary>
        /// Funcion correr para numero aleatorio
        /// </summary>
        /// <returns>Un numero aleatorio del 1 al 20</returns>
        public int correr()
        {
            return aleatorio.Next(1, 21);
        }
    }
}
