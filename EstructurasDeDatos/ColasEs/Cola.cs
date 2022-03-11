using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasDeDatos.ColasEs
{
    public class Cola
    {
        private Nodo _nodo = null;
        public void Push(int i)
        {
            if (!Vacia())
            {
                Nodo aux = _nodo;

                while (true)
                {
                    if (aux.Siguiente == null)
                    {
                        aux.Siguiente = new Nodo(null, i);
                        break;
                    }

                    aux = _nodo.Siguiente;

                }


            }
            else
            {
                _nodo = new Nodo(null, i);
            }
        }

        public void Pull() =>_nodo = !Vacia() ?  _nodo.Siguiente : null;     
        public bool Vacia() => _nodo == null;

    }
}
