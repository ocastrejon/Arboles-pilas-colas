using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_con_Arboles
{
    class Arbol
    {
        private Nodo _raiz;
        private ListaNodos _le;
        private LIFO _pila;
        private FIFO _cola;
        private int _aux;
        public int aux { get { return _aux; } }

        public Arbol(ListaNodos listaEnlazada)
        {
            _le = listaEnlazada;
            _raiz = null;
            _aux = _le.aux;
            _pila = new LIFO();
            _cola = new FIFO();
            arbolBi();
        }

        private void arbolBi()
        {
            if (_le.aux != 0)
            {
                arbolBi(_le.inicio, "*", "/");
                arbolBi(_le.inicio, "+", "-");
            }
        }
        private void arbolBi(Nodo n, string a, string b)
        {
            if (n != null)
            {
                _raiz = n;
                if (_raiz.datos.Equals(a) || _raiz.datos.Equals(b))
                {
                    _raiz.hizq = _raiz.anterior;
                    _raiz.anterior = _raiz.hizq.anterior;

                    if (_raiz.anterior != null)
                        _raiz.anterior.siguiente = _raiz;

                    _raiz.hder = _raiz.siguiente;
                    _raiz.siguiente = _raiz.hder.siguiente;
                    _raiz.hder.siguiente = null;
                    _raiz.hder.anterior = null;

                    if (_raiz.siguiente != null)
                        _raiz.siguiente.anterior = _raiz;
                }
                arbolBi(n.siguiente, a, b);
            }
        }

        public string InOrder()
        {
            if (_raiz != null)
                return InOrder(_raiz);

            return string.Empty;
        }
        private string InOrder(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                if (raiz.hizq != null)
                    res += InOrder(raiz.hizq);

                res += raiz.ToString();

                if (raiz.hder != null)
                    res += InOrder(raiz.hder);
            }
            return res;
        }

        public string PreOrder()
        {
            _pila.limpiar();

            if (_raiz != null)
                return PreOrden(_raiz);

            return string.Empty;
        }
        private string PreOrden(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                res += raiz.ToString();
                _pila.push(raiz);


                if (raiz.hizq != null)
                    res += PreOrden(raiz.hizq);

                if (raiz.hder != null)
                    res += PreOrden(raiz.hder);
            }
            return res;
        }

        public string PostOrder()
        {
            _cola.limpiar();

            if (_raiz != null)
                return PostOrden(_raiz);

            CalculoPostOrder();

            return string.Empty;
        }
        private string PostOrden(Nodo raiz)
        {
            string res = string.Empty;

            if (raiz != null)
            {
                if (raiz.hizq != null)
                    res += PostOrden(raiz.hizq);

                if (raiz.hder != null)
                    res += PostOrden(raiz.hder);

                res += raiz.ToString();
                _cola.enqueue(raiz);
            }
            return res;
        }

        public double CalculoPostOrder()
        {
            LIFO auxCola = new LIFO();

            return Convert.ToDouble(CalculoPostOrder(_cola, auxCola).datos);
        }
        private Nodo CalculoPostOrder(FIFO cola, LIFO auxCola)
        {
            Nodo temp = new Nodo("");
            double num1 = 0;
            double num2 = 0;

            if (cola.peek() != null)
            {
                if (char.IsNumber(Convert.ToChar(cola.peek().datos)))
                {
                    auxCola.push(cola.dequeue());

                    temp = CalculoPostOrder(cola, auxCola);
                }
                else
                {
                    num1 = Convert.ToDouble(auxCola.pop().datos.ToString());
                    num2 = Convert.ToDouble(auxCola.pop().datos.ToString());

                    if (cola.peek().datos.Equals("+"))
                        temp.datos = Convert.ToString(num2 + num1);
                    else if (cola.peek().datos.Equals("-"))
                        temp.datos = Convert.ToString(num2 - num1);
                    else if (cola.peek().datos.Equals("*"))
                        temp.datos = Convert.ToString(num2 * num1);
                    else if (cola.peek().datos.Equals("/"))
                        temp.datos = Convert.ToString(num2 / num1);

                    cola.dequeue();
                    auxCola.push(temp);

                    if (cola.peek() != null)
                        temp = CalculoPostOrder(cola, auxCola);
                    else
                        temp = auxCola.pop();
                }
            }
            return temp;
        }

        public double CalculoPreOrder()
        {
            LIFO auxPila = new LIFO();

            return Convert.ToDouble(CalculoPreOrder(_pila, auxPila).datos);
        }
        private Nodo CalculoPreOrder(LIFO pila, LIFO auxPila)
        {
            Nodo temp = new Nodo("");
            double num1 = 0;
            double num2 = 0;

            if (pila.peek() != null)
            {
                if (char.IsNumber(Convert.ToChar(pila.peek().datos)))
                {
                    auxPila.push(pila.pop());

                    temp = CalculoPreOrder(pila, auxPila);
                }
                else
                {
                    num1 = Convert.ToDouble(auxPila.pop().datos.ToString());
                    num2 = Convert.ToDouble(auxPila.pop().datos.ToString());

                    if (pila.peek().datos.Equals("+"))
                        temp.datos = Convert.ToString(num1 + num2);
                    else if (pila.peek().datos.Equals("-"))
                        temp.datos = Convert.ToString(num1 - num2);
                    else if (pila.peek().datos.Equals("*"))
                        temp.datos = Convert.ToString(num1 * num2);
                    else if (pila.peek().datos.Equals("/"))
                        temp.datos = Convert.ToString(num1 / num2);

                    pila.pop();
                    auxPila.push(temp);

                    if (pila.peek() != null)
                        temp = CalculoPreOrder(pila, auxPila);
                    else
                        temp = auxPila.pop();
                }
            }
            return temp;
        }

        public string ToStringStack()
        {
            return _pila.ToString();
        }

        public string ToStringQueue()
        {
            return _cola.ToString();
        }
    }
}
