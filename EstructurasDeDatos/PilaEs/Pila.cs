using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.PilaEs
{
    public class Pila
    {

        private Nodo _nodo;

        public Pila()
        {
            _nodo = null;
        }

        public bool PilaVacia() => _nodo == null;

        public void Push(int i)
        {
            if (PilaVacia())
            {
                _nodo = new Nodo(null, i);
            }
            else
            {
                var nodAux = _nodo;

                while (true)
                {
                    if (nodAux.Siguiente == null)
                    {
                        nodAux.Siguiente = new Nodo(null, i);
                        break;
                    }

                    nodAux = nodAux.Siguiente;
                }


            }
        }




    }
}
