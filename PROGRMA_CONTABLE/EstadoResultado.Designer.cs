
namespace PROGRMA_CONTABLE
{
    partial class EstadoResultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtValorCuentas = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcularVN = new System.Windows.Forms.Button();
            this.btnCalcularCT = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnMD = new System.Windows.Forms.Button();
            this.btnCostoVentas = new System.Windows.Forms.Button();
            this.btnUB = new System.Windows.Forms.Button();
            this.btnUO = new System.Windows.Forms.Button();
            this.btnUtilidadCI = new System.Windows.Forms.Button();
            this.btnUtilidadAI = new System.Windows.Forms.Button();
            this.btnUtilidadNP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ventas Totales",
            "Devoluciones sobre ventas",
            "Descuentos sobre ventas",
            "INVENTARIO INICIAL",
            "Compras",
            "Gastos sobre compras",
            "Devoluciones sobre compras",
            "Descuento sobre compras",
            "Inventario final",
            "Gastos de venta",
            "Gastos de administración",
            "Gastos Financieros",
            "Productos Financieros",
            "Otros Gastos",
            "Otros Productos"});
            this.comboBox1.Location = new System.Drawing.Point(41, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "SELECCIONA LA CUENTA A SALDAR";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(511, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 37);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValorCuentas
            // 
            this.txtValorCuentas.Location = new System.Drawing.Point(344, 38);
            this.txtValorCuentas.Name = "txtValorCuentas";
            this.txtValorCuentas.Size = new System.Drawing.Size(121, 23);
            this.txtValorCuentas.TabIndex = 5;
            this.txtValorCuentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(301, 41);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 15);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            this.lblValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvCuentas.Location = new System.Drawing.Point(169, 102);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.RowTemplate.Height = 25;
            this.dgvCuentas.Size = new System.Drawing.Size(545, 336);
            this.dgvCuentas.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "CUENTAS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 84;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 38;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 38;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 38;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 38;
            // 
            // btnCalcularVN
            // 
            this.btnCalcularVN.Location = new System.Drawing.Point(615, 28);
            this.btnCalcularVN.Name = "btnCalcularVN";
            this.btnCalcularVN.Size = new System.Drawing.Size(99, 41);
            this.btnCalcularVN.TabIndex = 8;
            this.btnCalcularVN.Text = "Calcular ventas netas";
            this.btnCalcularVN.UseVisualStyleBackColor = true;
            this.btnCalcularVN.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalcularCT
            // 
            this.btnCalcularCT.Location = new System.Drawing.Point(719, 102);
            this.btnCalcularCT.Name = "btnCalcularCT";
            this.btnCalcularCT.Size = new System.Drawing.Size(132, 46);
            this.btnCalcularCT.TabIndex = 9;
            this.btnCalcularCT.Text = "CALCULAR COMPRAS TOTALES";
            this.btnCalcularCT.UseVisualStyleBackColor = true;
            this.btnCalcularCT.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCN
            // 
            this.btnCN.Location = new System.Drawing.Point(719, 154);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(132, 48);
            this.btnCN.TabIndex = 10;
            this.btnCN.Text = "Compras netas";
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMD
            // 
            this.btnMD.Location = new System.Drawing.Point(720, 208);
            this.btnMD.Name = "btnMD";
            this.btnMD.Size = new System.Drawing.Size(131, 47);
            this.btnMD.TabIndex = 11;
            this.btnMD.Text = "Mercancias disponibles";
            this.btnMD.UseVisualStyleBackColor = true;
            this.btnMD.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCostoVentas
            // 
            this.btnCostoVentas.Location = new System.Drawing.Point(719, 258);
            this.btnCostoVentas.Name = "btnCostoVentas";
            this.btnCostoVentas.Size = new System.Drawing.Size(131, 48);
            this.btnCostoVentas.TabIndex = 12;
            this.btnCostoVentas.Text = "COSTO DE VENTAS";
            this.btnCostoVentas.UseVisualStyleBackColor = true;
            this.btnCostoVentas.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnUB
            // 
            this.btnUB.Location = new System.Drawing.Point(720, 312);
            this.btnUB.Name = "btnUB";
            this.btnUB.Size = new System.Drawing.Size(131, 47);
            this.btnUB.TabIndex = 13;
            this.btnUB.Text = "Utilidad bruta";
            this.btnUB.UseVisualStyleBackColor = true;
            this.btnUB.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnUO
            // 
            this.btnUO.Location = new System.Drawing.Point(720, 368);
            this.btnUO.Name = "btnUO";
            this.btnUO.Size = new System.Drawing.Size(130, 48);
            this.btnUO.TabIndex = 14;
            this.btnUO.Text = "Utilidad de operacion";
            this.btnUO.UseVisualStyleBackColor = true;
            this.btnUO.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnUtilidadCI
            // 
            this.btnUtilidadCI.Location = new System.Drawing.Point(41, 102);
            this.btnUtilidadCI.Name = "btnUtilidadCI";
            this.btnUtilidadCI.Size = new System.Drawing.Size(122, 47);
            this.btnUtilidadCI.TabIndex = 15;
            this.btnUtilidadCI.Text = "Utilidad por costo integral";
            this.btnUtilidadCI.UseVisualStyleBackColor = true;
            this.btnUtilidadCI.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnUtilidadAI
            // 
            this.btnUtilidadAI.Location = new System.Drawing.Point(41, 155);
            this.btnUtilidadAI.Name = "btnUtilidadAI";
            this.btnUtilidadAI.Size = new System.Drawing.Size(122, 51);
            this.btnUtilidadAI.TabIndex = 16;
            this.btnUtilidadAI.Text = "Utilidad antes de impuesto";
            this.btnUtilidadAI.UseVisualStyleBackColor = true;
            this.btnUtilidadAI.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnUtilidadNP
            // 
            this.btnUtilidadNP.Location = new System.Drawing.Point(41, 212);
            this.btnUtilidadNP.Name = "btnUtilidadNP";
            this.btnUtilidadNP.Size = new System.Drawing.Size(122, 51);
            this.btnUtilidadNP.TabIndex = 17;
            this.btnUtilidadNP.Text = "Utilida Neta del Periodo";
            this.btnUtilidadNP.UseVisualStyleBackColor = true;
            this.btnUtilidadNP.Click += new System.EventHandler(this.button11_Click);
            // 
            // EstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.btnUtilidadNP);
            this.Controls.Add(this.btnUtilidadAI);
            this.Controls.Add(this.btnUtilidadCI);
            this.Controls.Add(this.btnUO);
            this.Controls.Add(this.btnUB);
            this.Controls.Add(this.btnCostoVentas);
            this.Controls.Add(this.btnMD);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnCalcularCT);
            this.Controls.Add(this.btnCalcularVN);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValorCuentas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.comboBox1);
            this.Name = "EstadoResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadoResultado";
            this.Load += new System.EventHandler(this.EstadoResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtValorCuentas;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnCalcularVN;
        private System.Windows.Forms.Button btnCalcularCT;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnMD;
        private System.Windows.Forms.Button btnCostoVentas;
        private System.Windows.Forms.Button btnUB;
        private System.Windows.Forms.Button btnUO;
        private System.Windows.Forms.Button btnUtilidadCI;
        private System.Windows.Forms.Button btnUtilidadAI;
        private System.Windows.Forms.Button btnUtilidadNP;
    }
}