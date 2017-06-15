namespace Operaciones_con_Arboles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxOperacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnEvaluar = new System.Windows.Forms.Button();
            this.txtBxPreOrder = new System.Windows.Forms.TextBox();
            this.txtBxPostOrder = new System.Windows.Forms.TextBox();
            this.txtBxInOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxPreOrderRes = new System.Windows.Forms.TextBox();
            this.txtBxPostOrderRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBxOperacion
            // 
            this.txtBxOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxOperacion.Location = new System.Drawing.Point(32, 51);
            this.txtBxOperacion.Name = "txtBxOperacion";
            this.txtBxOperacion.Size = new System.Drawing.Size(298, 34);
            this.txtBxOperacion.TabIndex = 0;
            this.txtBxOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxOperacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operación a realizar:";
            // 
            // bttnEvaluar
            // 
            this.bttnEvaluar.AutoSize = true;
            this.bttnEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEvaluar.Location = new System.Drawing.Point(370, 46);
            this.bttnEvaluar.Name = "bttnEvaluar";
            this.bttnEvaluar.Size = new System.Drawing.Size(103, 39);
            this.bttnEvaluar.TabIndex = 2;
            this.bttnEvaluar.Text = "Evaluar";
            this.bttnEvaluar.UseVisualStyleBackColor = true;
            this.bttnEvaluar.Click += new System.EventHandler(this.bttnEvaluar_Click);
            // 
            // txtBxPreOrder
            // 
            this.txtBxPreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPreOrder.Location = new System.Drawing.Point(175, 178);
            this.txtBxPreOrder.Name = "txtBxPreOrder";
            this.txtBxPreOrder.Size = new System.Drawing.Size(298, 34);
            this.txtBxPreOrder.TabIndex = 3;
            // 
            // txtBxPostOrder
            // 
            this.txtBxPostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPostOrder.Location = new System.Drawing.Point(175, 234);
            this.txtBxPostOrder.Name = "txtBxPostOrder";
            this.txtBxPostOrder.Size = new System.Drawing.Size(298, 34);
            this.txtBxPostOrder.TabIndex = 4;
            // 
            // txtBxInOrder
            // 
            this.txtBxInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxInOrder.Location = new System.Drawing.Point(175, 119);
            this.txtBxInOrder.Name = "txtBxInOrder";
            this.txtBxInOrder.Size = new System.Drawing.Size(298, 34);
            this.txtBxInOrder.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "In Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pre Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Post Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultados";
            // 
            // txtBxPreOrderRes
            // 
            this.txtBxPreOrderRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPreOrderRes.Location = new System.Drawing.Point(503, 178);
            this.txtBxPreOrderRes.Name = "txtBxPreOrderRes";
            this.txtBxPreOrderRes.Size = new System.Drawing.Size(129, 34);
            this.txtBxPreOrderRes.TabIndex = 10;
            // 
            // txtBxPostOrderRes
            // 
            this.txtBxPostOrderRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPostOrderRes.Location = new System.Drawing.Point(503, 234);
            this.txtBxPostOrderRes.Name = "txtBxPostOrderRes";
            this.txtBxPostOrderRes.Size = new System.Drawing.Size(129, 34);
            this.txtBxPostOrderRes.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 316);
            this.Controls.Add(this.txtBxPostOrderRes);
            this.Controls.Add(this.txtBxPreOrderRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxInOrder);
            this.Controls.Add(this.txtBxPostOrder);
            this.Controls.Add(this.txtBxPreOrder);
            this.Controls.Add(this.bttnEvaluar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxOperacion);
            this.Name = "Form1";
            this.Text = "Árboles con pilas y colas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnEvaluar;
        private System.Windows.Forms.TextBox txtBxPreOrder;
        private System.Windows.Forms.TextBox txtBxPostOrder;
        private System.Windows.Forms.TextBox txtBxInOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxPreOrderRes;
        private System.Windows.Forms.TextBox txtBxPostOrderRes;
    }
}

