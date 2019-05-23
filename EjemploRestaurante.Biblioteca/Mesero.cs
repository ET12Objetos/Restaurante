using System;

namespace EjemploRestaurante.Biblioteca
{
    public class Mesero
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Menu menu { get; set; }

        public Mesero()
        {
            this.nombre = String.Empty;
        }

        public Menu traerMenu()
        {
            return menu;
        }

        public Comida traerComida(Comida unaComida)
        {
            return menu.comida;
        }
    }
}
