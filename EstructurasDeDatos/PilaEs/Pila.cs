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

        public void Pop()
        {
            var nodAux = _nodo;
            var nodAuxAnt = _nodo;

            while (true)
            {
                if (_nodo.Siguiente == null)
                    _nodo = null;

                if (nodAux.Siguiente == null)
                {
                    nodAuxAnt.Siguiente = null;
                    break;
                }
                nodAuxAnt = nodAux;
                nodAux = nodAux.Siguiente;

            }
        }


    }
}
