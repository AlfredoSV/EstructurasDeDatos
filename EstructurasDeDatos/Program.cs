using System;
using EstructurasDeDatos.ListaEnlazadaEs;

namespace EstructurasDeDatos
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada listaEnlazada = new ListaEnlazada();


            listaEnlazada.AgregarNuevoElemento(4);
            /*listaEnlazada.AgregarNuevoElemento(900);
            listaEnlazada.AgregarNuevoElemento(6);
            listaEnlazada.AgregarNuevoElemento(0);
            */
            //listaEnlazada.RecorrerLista();

            /*Console.WriteLine("Se elimina el 6");
            listaEnlazada.EliminarElemento(6);
            Console.WriteLine("Se elimina el 0");
            listaEnlazada.EliminarElemento(0);*/
            Console.WriteLine("Se elimina el 4");
            listaEnlazada.EliminarElemento(4);
            /*Console.WriteLine("Se elimina el 900");
            listaEnlazada.EliminarElemento(900);*/

            listaEnlazada.RecorrerLista();
            //Console.WriteLine($"El 10 existe en la lista:{listaEnlazada.BuscarElemento(10)}");

            Console.WriteLine($"La lista está vacia:{listaEnlazada.ListaVacia()}");
        }
    }




}
