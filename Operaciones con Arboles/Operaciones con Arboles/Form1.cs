using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones_con_Arboles
{
    public partial class Form1 : Form
    {
        ListaNodos llst = new ListaNodos();
        Arbol arbol;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnEvaluar_Click(object sender, EventArgs e)
        {
            arbol = new Arbol(llst);
            llst.limpiar();

            txtBxInOrder.Text = arbol.InOrder();

            txtBxPreOrder.Text = arbol.PreOrder();
            //txtBxMostrarPila.Text = binaryTree.ToStringStack();
            txtBxPreOrderRes.Text = Convert.ToString(arbol.CalculoPreOrder());

            txtBxPostOrder.Text = arbol.PostOrder();
            //txtMostrarCola.Text = binaryTree.ToStringQueue();
            txtBxPostOrderRes.Text = Convert.ToString(arbol.CalculoPostOrder());
        }

        private void txtBxOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter && (e.KeyChar == 42 || e.KeyChar == 43 || e.KeyChar == 45 || e.KeyChar == 47 || char.IsNumber(e.KeyChar)))
            {
                Nodo n = new Nodo(e.KeyChar.ToString());
                llst.agregarUltimo(n);
            }
            else
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (llst.aux != 0)
                    {
                        bttnEvaluar.PerformClick();
                        bttnEvaluar.Focus();
                    }
                }
                else if (e.KeyChar == 8)
                    llst.eliminarUltimo();
                else
                    e.Handled = true;
            }
        }
    }
}
