using System;

namespace EjemploRestaurante.Biblioteca
{
    public class Menu
    {
        public Comida comida { get; set; }

        public Comida seleccionarUnaComida()
        {
            return comida;
        }
    }
}
