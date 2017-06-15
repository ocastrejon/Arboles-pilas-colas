using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_con_Arboles
{
    class Nodo
    {
        private string _datos;
        public string datos { get { return _datos; } set { _datos = value; } }
        private Nodo _hder;
        public Nodo hder { get { return _hder; } set { _hder = value; } }
        private Nodo _hizq;
        public Nodo hizq { get { return _hizq; } set { _hizq = value; } }
        private Nodo _siguiente;
        public Nodo siguiente { get { return _siguiente; } set { _siguiente = value; } }
        private Nodo _anterior;
        public Nodo anterior { get { return _anterior; } set { _anterior = value; } }


        public Nodo(string datos)
        {
            _datos = datos;
            _hizq = null;
            _hder = null;
        }

        public override string ToString()
        {
            return Convert.ToString(_datos);
        }
    }
}
