using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.PilaEs
{
    public class Nodo
    {
        private Nodo _siguiente;
        private int _valor;

        public Nodo Siguiente { get => _siguiente; set => _siguiente = value; }
        public int Valor { get => _valor; set => _valor = value; }

        public Nodo(Nodo siguiente, int valor)
        {
            this.Siguiente = siguiente;
            this.Valor = valor;
        }
    }
}
