using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carreraLiebreTortuga
{
    /// <summary>
    /// La clase Liebre hereda los parametros de la clase padre Corredor
    /// </summary>
    class Liebre: Corredor
    {
        /// <summary>
        /// Hacemos el constructor para la clase Liebre
        /// </summary>
        /// <param name="numero">Obtiene el numero por herencia de la clase Corredor</param>
        public Liebre(int numero) : base(numero)
        {
            
        }
        /// <summary>
        /// Se crea una funcion correr con condiciones para saber que hacer acorde al numero aleatorio obtenido
        /// </summary>
        new public void correr()
        {
            // se hace una variable avanzar para obtener el numero aleatorio y guardarlo en esta misma
            int avanzar = base.correr();
            if (avanzar <= 3)
            {
                //15 % resbala 
                _posicion -= 4;
            }
            else if (avanzar <= 7)
            {
                //20% no avanza
                _posicion += 0;
            }
            else if (avanzar <= 11)
            {
                //20% corre
                _posicion += 5;
            }
            else if (avanzar <= 15)
            {
                //20% resbala
                _posicion -= 8;
            }
            else
            {
                //25% corre
                _posicion += 12;
            }
        }
        /// <summary>
        /// Simplemente es para agregar el texto "La liebre"
        /// </summary>
        /// <returns>
        /// La liebre + numero + (valor _numero) + posicion + (valor _posicion ambos valores obtenidos de la clase Corredor
        /// </returns>
        public override string ToString()
        {
            return "La liebre " + base.ToString();
        }
    }
}
