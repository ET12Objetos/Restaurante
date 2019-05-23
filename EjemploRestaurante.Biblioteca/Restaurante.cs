using System;

namespace EjemploRestaurante.Biblioteca
{
    public class Restaurante
    {
        public Menu menu { get; set; }

        public Comida comida { get; set; }

        public Mesero mesero { get; set; }

        public void atenderA(Cliente unCliente)
        {
            Menu menu = unCliente.solicitarMenuA(mesero);

            Comida comida = unCliente.elegirComidaDel(menu);

            comida = unCliente.solicitarPedidoA(mesero, comida);

            Console.WriteLine($"Mesero: {mesero.Nombre} atendio al cliente: {unCliente.Nombre} que pidio: {comida.Nombre}");
        }
    }
}
