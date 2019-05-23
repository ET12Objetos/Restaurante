using System;

namespace EjemploRestaurante.Biblioteca
{
    public class Comida
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Comida()
        {
            this.Nombre = String.Empty;
        }
    }
}
