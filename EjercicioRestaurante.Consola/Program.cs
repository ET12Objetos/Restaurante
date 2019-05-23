using EjemploRestaurante.Biblioteca;
using ET12.Aleatorio;
using System;

namespace EjercicioRestaurante.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Comida unaComida = new Comida() { Nombre = "Asado" };

            Menu unMenu = new Menu() { comida = unaComida };

            Mesero unMesero = new Mesero() { Nombre = Persona.CrearNombre(), menu = unMenu };

            Cliente unCliente = new Cliente() { Nombre = Persona.CrearNombre() };

            Restaurante restaurante = new Restaurante() { mesero = unMesero, menu = unMenu, comida = unaComida };
            
            restaurante.atenderA(unCliente);
        }
    }
}
