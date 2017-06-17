using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_con_Arboles
{
    class LIFO
    {
        private ListaNodos _ln;
        public int aux { get { return _ln.aux; } }

        public LIFO()
        {
            _ln = new ListaNodos();
        }

        public Nodo pop()
        {
            Nodo temp = _ln.ultimo;
            _ln.eliminarUltimo();
            return temp;
        }

        public Nodo peek()
        {
            return _ln.ultimo;
        }

        public void push(Nodo n)
        {
            n.siguiente = null;
            n.anterior = null;
            _ln.agregarUltimo(n);
        }

        public void limpiar()
        {
            _ln.limpiar();
        }

        public override string ToString()
        {
            string res = "";
            Nodo n = _ln.ultimo;
            while (n != null)
            {
                res += n.datos + Environment.NewLine;
                n = n.anterior;
            }
            return res;
        }
    }
}
