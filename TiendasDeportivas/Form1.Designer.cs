namespace TiendasDeportivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxComprarArticulo = new System.Windows.Forms.GroupBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GropuBoxVentasTiendas = new System.Windows.Forms.GroupBox();
            this.textTienda3 = new System.Windows.Forms.TextBox();
            this.textTienda2 = new System.Windows.Forms.TextBox();
            this.textTienda1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxVentasArticulos = new System.Windows.Forms.GroupBox();
            this.textArticulo3 = new System.Windows.Forms.TextBox();
            this.textArticulo2 = new System.Windows.Forms.TextBox();
            this.textArticulo1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxVentasTotales = new System.Windows.Forms.GroupBox();
            this.textVentasTotales = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.comboBoxtTienda = new System.Windows.Forms.ComboBox();
            this.textValorCompra = new System.Windows.Forms.TextBox();
            this.groupBoxComprarArticulo.SuspendLayout();
            this.GropuBoxVentasTiendas.SuspendLayout();
            this.groupBoxVentasArticulos.SuspendLayout();
            this.groupBoxVentasTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIENDA:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vender";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxComprarArticulo
            // 
            this.groupBoxComprarArticulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxComprarArticulo.Controls.Add(this.textValorCompra);
            this.groupBoxComprarArticulo.Controls.Add(this.comboBoxtTienda);
            this.groupBoxComprarArticulo.Controls.Add(this.comboBoxArticulo);
            this.groupBoxComprarArticulo.Controls.Add(this.button1);
            this.groupBoxComprarArticulo.Controls.Add(this.textCantidad);
            this.groupBoxComprarArticulo.Controls.Add(this.label4);
            this.groupBoxComprarArticulo.Controls.Add(this.label3);
            this.groupBoxComprarArticulo.Controls.Add(this.label2);
            this.groupBoxComprarArticulo.Controls.Add(this.label1);
            this.groupBoxComprarArticulo.Location = new System.Drawing.Point(31, 169);
            this.groupBoxComprarArticulo.Name = "groupBoxComprarArticulo";
            this.groupBoxComprarArticulo.Size = new System.Drawing.Size(359, 429);
            this.groupBoxComprarArticulo.TabIndex = 5;
            this.groupBoxComprarArticulo.TabStop = false;
            this.groupBoxComprarArticulo.Text = "Comprar Articulo ";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(156, 154);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(100, 20);
            this.textCantidad.TabIndex = 4;
            this.textCantidad.TextChanged += new System.EventHandler(this.textCantidad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "VALOR COMPRA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CANTIDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARTICULO:";
            // 
            // GropuBoxVentasTiendas
            // 
            this.GropuBoxVentasTiendas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GropuBoxVentasTiendas.Controls.Add(this.textTienda3);
            this.GropuBoxVentasTiendas.Controls.Add(this.textTienda2);
            this.GropuBoxVentasTiendas.Controls.Add(this.textTienda1);
            this.GropuBoxVentasTiendas.Controls.Add(this.label7);
            this.GropuBoxVentasTiendas.Controls.Add(this.label6);
            this.GropuBoxVentasTiendas.Controls.Add(this.label5);
            this.GropuBoxVentasTiendas.Location = new System.Drawing.Point(412, 169);
            this.GropuBoxVentasTiendas.Name = "GropuBoxVentasTiendas";
            this.GropuBoxVentasTiendas.Size = new System.Drawing.Size(284, 155);
            this.GropuBoxVentasTiendas.TabIndex = 6;
            this.GropuBoxVentasTiendas.TabStop = false;
            this.GropuBoxVentasTiendas.Text = "Ventas Tiendas";
            this.GropuBoxVentasTiendas.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textTienda3
            // 
            this.textTienda3.Location = new System.Drawing.Point(79, 103);
            this.textTienda3.Name = "textTienda3";
            this.textTienda3.Size = new System.Drawing.Size(100, 20);
            this.textTienda3.TabIndex = 5;
            // 
            // textTienda2
            // 
            this.textTienda2.Location = new System.Drawing.Point(79, 70);
            this.textTienda2.Name = "textTienda2";
            this.textTienda2.Size = new System.Drawing.Size(100, 20);
            this.textTienda2.TabIndex = 4;
            // 
            // textTienda1
            // 
            this.textTienda1.Location = new System.Drawing.Point(79, 42);
            this.textTienda1.Name = "textTienda1";
            this.textTienda1.Size = new System.Drawing.Size(100, 20);
            this.textTienda1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tienda 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tienda 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tienda 1:";
            // 
            // groupBoxVentasArticulos
            // 
            this.groupBoxVentasArticulos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxVentasArticulos.Controls.Add(this.textArticulo3);
            this.groupBoxVentasArticulos.Controls.Add(this.textArticulo2);
            this.groupBoxVentasArticulos.Controls.Add(this.textArticulo1);
            this.groupBoxVentasArticulos.Controls.Add(this.label8);
            this.groupBoxVentasArticulos.Controls.Add(this.label9);
            this.groupBoxVentasArticulos.Controls.Add(this.label10);
            this.groupBoxVentasArticulos.Location = new System.Drawing.Point(412, 337);
            this.groupBoxVentasArticulos.Name = "groupBoxVentasArticulos";
            this.groupBoxVentasArticulos.Size = new System.Drawing.Size(284, 155);
            this.groupBoxVentasArticulos.TabIndex = 7;
            this.groupBoxVentasArticulos.TabStop = false;
            this.groupBoxVentasArticulos.Text = "Ventas Articulos";
            // 
            // textArticulo3
            // 
            this.textArticulo3.Location = new System.Drawing.Point(79, 103);
            this.textArticulo3.Name = "textArticulo3";
            this.textArticulo3.Size = new System.Drawing.Size(100, 20);
            this.textArticulo3.TabIndex = 5;
            // 
            // textArticulo2
            // 
            this.textArticulo2.Location = new System.Drawing.Point(79, 70);
            this.textArticulo2.Name = "textArticulo2";
            this.textArticulo2.Size = new System.Drawing.Size(100, 20);
            this.textArticulo2.TabIndex = 4;
            // 
            // textArticulo1
            // 
            this.textArticulo1.Location = new System.Drawing.Point(79, 42);
            this.textArticulo1.Name = "textArticulo1";
            this.textArticulo1.Size = new System.Drawing.Size(100, 20);
            this.textArticulo1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Articulo 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Articulo 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Articulo 1:";
            // 
            // groupBoxVentasTotales
            // 
            this.groupBoxVentasTotales.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxVentasTotales.Controls.Add(this.textVentasTotales);
            this.groupBoxVentasTotales.Controls.Add(this.label11);
            this.groupBoxVentasTotales.Location = new System.Drawing.Point(412, 512);
            this.groupBoxVentasTotales.Name = "groupBoxVentasTotales";
            this.groupBoxVentasTotales.Size = new System.Drawing.Size(284, 86);
            this.groupBoxVentasTotales.TabIndex = 8;
            this.groupBoxVentasTotales.TabStop = false;
            this.groupBoxVentasTotales.Text = "Ventas totales";
            // 
            // textVentasTotales
            // 
            this.textVentasTotales.Location = new System.Drawing.Point(94, 40);
            this.textVentasTotales.Name = "textVentasTotales";
            this.textVentasTotales.Size = new System.Drawing.Size(100, 20);
            this.textVentasTotales.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ventas totales:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 611);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ir al inicio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Items.AddRange(new object[] {
            "Balon de futbol",
            "Pelota de tennis",
            "Balon de voleibol",
            "Balon de basquetbol"});
            this.comboBoxArticulo.Location = new System.Drawing.Point(156, 106);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArticulo.TabIndex = 8;
            // 
            // comboBoxtTienda
            // 
            this.comboBoxtTienda.FormattingEnabled = true;
            this.comboBoxtTienda.Items.AddRange(new object[] {
            "Tienda 1",
            "Tienda 2",
            "Tienda 3"});
            this.comboBoxtTienda.Location = new System.Drawing.Point(156, 62);
            this.comboBoxtTienda.Name = "comboBoxtTienda";
            this.comboBoxtTienda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxtTienda.TabIndex = 9;
            // 
            // textValorCompra
            // 
            this.textValorCompra.Location = new System.Drawing.Point(156, 210);
            this.textValorCompra.Name = "textValorCompra";
            this.textValorCompra.Size = new System.Drawing.Size(100, 20);
            this.textValorCompra.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxVentasTotales);
            this.Controls.Add(this.groupBoxVentasArticulos);
            this.Controls.Add(this.GropuBoxVentasTiendas);
            this.Controls.Add(this.groupBoxComprarArticulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxComprarArticulo.ResumeLayout(false);
            this.groupBoxComprarArticulo.PerformLayout();
            this.GropuBoxVentasTiendas.ResumeLayout(false);
            this.GropuBoxVentasTiendas.PerformLayout();
            this.groupBoxVentasArticulos.ResumeLayout(false);
            this.groupBoxVentasArticulos.PerformLayout();
            this.groupBoxVentasTotales.ResumeLayout(false);
            this.groupBoxVentasTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxComprarArticulo;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GropuBoxVentasTiendas;
        private System.Windows.Forms.TextBox textTienda3;
        private System.Windows.Forms.TextBox textTienda2;
        private System.Windows.Forms.TextBox textTienda1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxVentasArticulos;
        private System.Windows.Forms.TextBox textArticulo3;
        private System.Windows.Forms.TextBox textArticulo2;
        private System.Windows.Forms.TextBox textArticulo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxVentasTotales;
        private System.Windows.Forms.TextBox textVentasTotales;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxtTienda;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.TextBox textValorCompra;
    }
}

