using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.ListaEnlazadaEsGenerica
{
    public class Nodo<T>
    {
        private Nodo<T> _siguiente;
        private T _valor;

        public Nodo<T> Siguiente { get => _siguiente; set => _siguiente = value; }
        public T Valor { get => _valor; set => _valor = value; }

        public Nodo(Nodo<T> siguiente, T valor)
        {
            this.Siguiente = siguiente;
            this.Valor = valor;
        }
    }
}
