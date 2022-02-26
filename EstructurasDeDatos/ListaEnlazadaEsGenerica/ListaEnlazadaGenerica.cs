using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.ListaEnlazadaEsGenerica
{
    public class ListaEnlazadaGenerica<T>
    {
        private Nodo<T> _nodoLista;
        public Nodo<T> NodoLista { get => _nodoLista; set => _nodoLista = value; }
        public void AgregarNuevoElemento(T valor)
        {

            if (ListaVacia())
            {
                NodoLista = new Nodo<T>(null, valor);
            }
            else
            {
                var nuevoNodo = new Nodo<T>(null, valor);

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
        public bool BuscarElemento(T i)
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



                    if (nodoActual.Valor.Equals(i))
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
        public void EliminarElemento(T i)
        {
            Nodo<T> nodoAnterior = NodoLista;
            if (ListaVacia())
            {
                Console.WriteLine("La lista se encuentra vacia.");
            }
            else if (NodoLista.Valor.Equals(i))
            {
                NodoLista = NodoLista.Siguiente;
            }
            else
            {
                var nodoActual = NodoLista;
                while (true)
                {



                    if (nodoActual.Valor.Equals(i))
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
