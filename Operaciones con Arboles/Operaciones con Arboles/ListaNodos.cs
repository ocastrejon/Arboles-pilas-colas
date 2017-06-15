using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_con_Arboles
{
    class ListaNodos
    {
        private Nodo _inicio;
        public Nodo inicio { get { return _inicio; } }

        private Nodo _ultimo;
        public Nodo ultimo { get { return _ultimo; } }

        private int _aux;
        public int aux { get { return _aux; } set { _aux = value; } }

        public ListaNodos()
        {
            _inicio = null;
            _ultimo = null;
            _aux = 0;
        }

        public void agregarPrimero(Nodo n)
        {
            if (_inicio == null)
            {
                _inicio = n;
                _ultimo = n;
            }
            else
            {
                _inicio.anterior = n;
                n.siguiente = _inicio;
                _inicio = n;
            }
            _aux++;
        }

        public void agregarUltimo(Nodo n)
        {
            if (_inicio == null)
                _inicio = n;
            else
            {
                _ultimo.siguiente = n;
                n.anterior = _ultimo;
            }
            _ultimo = n;
            _aux++;
        }

        public void eliminarUltimo()
        {
            if (_inicio != null)
            {
                if (_ultimo == _inicio)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _ultimo.anterior.siguiente = null;
                    _ultimo = _ultimo.anterior;
                }
                _aux--;
            }
        }

        public void limpiar()
        {
            if (_inicio != null)
            {
                _inicio = null;
                _ultimo = null;
            }
        }
    }
}
