using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.ListaEnlazadaEs
{
    public class ListaEnlazada
    {
        private Nodo _nodoLista;
        public Nodo NodoLista { get => _nodoLista; set => _nodoLista = value; }
        public void AgregarNuevoElemento(int valor)
        {

            if (ListaVacia())
            {
                NodoLista = new Nodo(null, valor);
            }
            else
            {
                var nuevoNodo = new Nodo(null, valor);

                var nodoActual = NodoLista;

                while (true)
                {

                    if (nodoActual.Siguiente == null)
                    {
                        nodoActual.Siguiente = nuevoNodo;

                        break;
                    }
                    nodoActual = nodoActual.Siguiente;

                }


            }

        }
        public bool ListaVacia()
        {
            return NodoLista == null;
        }
        public void RecorrerLista()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista se encuentra vacia.");
            }
            else
            {
                var nodoActual = NodoLista;
                while (true)
                {

                    Console.WriteLine(nodoActual.Valor);

                    if (nodoActual.Siguiente == null)
                        break;
                    nodoActual = nodoActual.Siguiente;
                }
            }
        }
        public bool BuscarElemento(int i)
        {
            var existe = false;
            if (ListaVacia())
            {
                Console.WriteLine("La lista se encuentra vacia.");
            }
            else
            {
                var nodoActual = NodoLista;
                while (true)
                {



                    if (nodoActual.Valor == i)
                    {
                        existe = true;
                        break;
                    }

                    if (nodoActual.Siguiente == null)
                        break;

                    nodoActual = nodoActual.Siguiente;
                }
            }

            return existe;
        }
        public void EliminarElemento(int i)
        {
            Nodo nodoAnterior = NodoLista;
            if (ListaVacia())
            {
                Console.WriteLine("La lista se encuentra vacia.");
            }
            else if (NodoLista.Valor == i)
            {
                NodoLista = NodoLista.Siguiente;
            }
            else
            {
                var nodoActual = NodoLista;
                while (true)
                {



                    if (nodoActual.Valor == i)
                    {

                        nodoAnterior.Siguiente = nodoActual.Siguiente;


                        break;
                    }

                    if (nodoActual.Siguiente == null)
                        break;
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.Siguiente;

                }
            }


        }

    }
}
