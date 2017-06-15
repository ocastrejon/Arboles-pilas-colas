using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_con_Arboles
{
    class FIFO
    {
        private ListaNodos _ln;
        public int aux { get { return _ln.aux; } }

        public FIFO()
        {
            _ln = new ListaNodos();
        }
        
        public void enqueue(Nodo n)
        {
            n.siguiente = null;
            n.anterior = null;
            _ln.agregarPrimero(n);
        }
        
        public Nodo peek()
        {
            return _ln.ultimo;
        }
        
        public Nodo dequeue()
        {
            Nodo n = _ln.ultimo;
            _ln.eliminarUltimo();

            return n;
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
