using System;

namespace EjemploRestaurante.Biblioteca
{
    public class Cliente
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Cliente()
        {
            this.nombre = String.Empty;
        }

        public Menu solicitarMenuA(Mesero unMesero)
        {
            return unMesero.traerMenu();
        }

        public Comida elegirComidaDel(Menu menu)
        {
            return menu.seleccionarUnaComida();
        }

        public Comida solicitarPedidoA(Mesero unMesero, Comida unaComida)
        {
            return unMesero.traerComida(unaComida);
        }
    }
}
