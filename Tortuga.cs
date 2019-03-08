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
    class Tortuga : Corredor
    {
        /// <summary>
        /// Hacemos el constructor para la clase Tortuga
        /// </summary>
        /// <param name="numero">Obtiene el numero por herencia de la clase Corredor</param>
        public Tortuga(int numero)
            :base(numero)
        {

        }
        /// <summary>
        /// Se crea una funcion correr con condiciones para saber que hacer acorde al numero aleatorio obtenido
        /// de acuerdo a un porcentaje
        /// </summary>
        new public void correr()
        {
            // se hace una variable avanzar para obtener el numero aleatorio y guardarlo en esta misma
            int avanzar = base.correr();
            if (avanzar <= 4)
            {
                // 20% resbala
                _posicion -= 9;
                //_posicion-=10; //quitar comentario para cambiar valor para que gane Tortuga o Liebre
            }
            else if (avanzar <= 8)
            {
                // 20% resbala
                _posicion += -5;
            }
            else if (avanzar <= 12)
            {
                // 20% avanza
                _posicion += 6;
            }
            else
            {
                // 40% resbala
                _posicion -= 3;
                //_posicion+=10; //quitar comentario para cambiar valor para que gane Tortuga o Liebre
            }
        }
        public override string ToString()
        {
            return "La tortuga " + base.ToString();
        }
    }
}
