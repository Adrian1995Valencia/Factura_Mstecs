namespace Factura_Mstecs
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lprecio = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.lcodigo = new System.Windows.Forms.Label();
            this.textcantidad = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.textefectivo = new System.Windows.Forms.TextBox();
            this.cmb_Productos = new System.Windows.Forms.ComboBox();
            this.devolu = new System.Windows.Forms.Label();
            this.tpagar = new System.Windows.Forms.Label();
            this.ldevolucion = new System.Windows.Forms.Label();
            this.lefectivo = new System.Windows.Forms.Label();
            this.ltotalpagar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.griewlista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnvender = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lcliente = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griewlista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lcliente);
            this.panel1.Controls.Add(this.lprecio);
            this.panel1.Controls.Add(this.lnombre);
            this.panel1.Controls.Add(this.lcodigo);
            this.panel1.Controls.Add(this.textcantidad);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.textefectivo);
            this.panel1.Controls.Add(this.cmb_Productos);
            this.panel1.Controls.Add(this.devolu);
            this.panel1.Controls.Add(this.tpagar);
            this.panel1.Controls.Add(this.ldevolucion);
            this.panel1.Controls.Add(this.lefectivo);
            this.panel1.Controls.Add(this.ltotalpagar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.griewlista);
            this.panel1.Location = new System.Drawing.Point(103, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 471);
            this.panel1.TabIndex = 0;
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.Location = new System.Drawing.Point(126, 129);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(11, 13);
            this.lprecio.TabIndex = 20;
            this.lprecio.Text = "*";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(126, 90);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(11, 13);
            this.lnombre.TabIndex = 19;
            this.lnombre.Text = "*";
            // 
            // lcodigo
            // 
            this.lcodigo.AutoSize = true;
            this.lcodigo.Location = new System.Drawing.Point(126, 48);
            this.lcodigo.Name = "lcodigo";
            this.lcodigo.Size = new System.Drawing.Size(11, 13);
            this.lcodigo.TabIndex = 18;
            this.lcodigo.Text = "*";
            // 
            // textcantidad
            // 
            this.textcantidad.Location = new System.Drawing.Point(129, 168);
            this.textcantidad.Name = "textcantidad";
            this.textcantidad.Size = new System.Drawing.Size(172, 20);
            this.textcantidad.TabIndex = 17;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(403, 75);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(154, 46);
            this.btneliminar.TabIndex = 16;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnagregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(403, 16);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(154, 52);
            this.btnagregar.TabIndex = 15;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // textefectivo
            // 
            this.textefectivo.Location = new System.Drawing.Point(267, 437);
            this.textefectivo.Name = "textefectivo";
            this.textefectivo.Size = new System.Drawing.Size(152, 20);
            this.textefectivo.TabIndex = 14;
            this.textefectivo.TextChanged += new System.EventHandler(this.textefectivo_TextChanged);
            // 
            // cmb_Productos
            // 
            this.cmb_Productos.FormattingEnabled = true;
            this.cmb_Productos.Items.AddRange(new object[] {
            "Laptop",
            "Mouse",
            "Teclado",
            "Monitor",
            "USB",
            "Audifonos",
            "Cargador"});
            this.cmb_Productos.Location = new System.Drawing.Point(129, 16);
            this.cmb_Productos.Name = "cmb_Productos";
            this.cmb_Productos.Size = new System.Drawing.Size(190, 21);
            this.cmb_Productos.TabIndex = 13;
            this.cmb_Productos.SelectedIndexChanged += new System.EventHandler(this.cmb_Productos_SelectedIndexChanged);
            // 
            // devolu
            // 
            this.devolu.AutoSize = true;
            this.devolu.Location = new System.Drawing.Point(483, 444);
            this.devolu.Name = "devolu";
            this.devolu.Size = new System.Drawing.Size(11, 13);
            this.devolu.TabIndex = 12;
            this.devolu.Text = "*";
            // 
            // tpagar
            // 
            this.tpagar.AutoSize = true;
            this.tpagar.Location = new System.Drawing.Point(153, 444);
            this.tpagar.Name = "tpagar";
            this.tpagar.Size = new System.Drawing.Size(11, 13);
            this.tpagar.TabIndex = 9;
            this.tpagar.Text = "*";
            // 
            // ldevolucion
            // 
            this.ldevolucion.AutoSize = true;
            this.ldevolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldevolucion.Location = new System.Drawing.Point(460, 394);
            this.ldevolucion.Name = "ldevolucion";
            this.ldevolucion.Size = new System.Drawing.Size(97, 17);
            this.ldevolucion.TabIndex = 8;
            this.ldevolucion.Text = "Devolucion:";
            // 
            // lefectivo
            // 
            this.lefectivo.AutoSize = true;
            this.lefectivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lefectivo.Location = new System.Drawing.Point(308, 394);
            this.lefectivo.Name = "lefectivo";
            this.lefectivo.Size = new System.Drawing.Size(73, 17);
            this.lefectivo.TabIndex = 7;
            this.lefectivo.Text = "Efectivo:";
            // 
            // ltotalpagar
            // 
            this.ltotalpagar.AutoSize = true;
            this.ltotalpagar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotalpagar.Location = new System.Drawing.Point(126, 394);
            this.ltotalpagar.Name = "ltotalpagar";
            this.ltotalpagar.Size = new System.Drawing.Size(114, 17);
            this.ltotalpagar.TabIndex = 6;
            this.ltotalpagar.Text = "Total a pagar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos:";
            // 
            // griewlista
            // 
            this.griewlista.AllowUserToAddRows = false;
            this.griewlista.AllowUserToDeleteRows = false;
            this.griewlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.griewlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griewlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.griewlista.Location = new System.Drawing.Point(33, 215);
            this.griewlista.Name = "griewlista";
            this.griewlista.ReadOnly = true;
            this.griewlista.RowHeadersVisible = false;
            this.griewlista.Size = new System.Drawing.Size(548, 150);
            this.griewlista.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnvender
            // 
            this.btnvender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnvender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvender.Location = new System.Drawing.Point(350, 525);
            this.btnvender.Name = "btnvender";
            this.btnvender.Size = new System.Drawing.Size(170, 46);
            this.btnvender.TabIndex = 17;
            this.btnvender.Text = "VENDER";
            this.btnvender.UseVisualStyleBackColor = false;
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(319, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 30);
            this.label13.TabIndex = 18;
            this.label13.Text = "Factura MSTECS";
            // 
            // lcliente
            // 
            this.lcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lcliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcliente.Location = new System.Drawing.Point(403, 136);
            this.lcliente.Name = "lcliente";
            this.lcliente.Size = new System.Drawing.Size(154, 52);
            this.lcliente.TabIndex = 19;
            this.lcliente.Text = "AGREGAR CLIENTE";
            this.lcliente.UseVisualStyleBackColor = false;
            this.lcliente.Click += new System.EventHandler(this.lcliente_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnexit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(619, 536);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(162, 23);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "CERRAR PROGRAMA";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnvender);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura Mstecs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griewlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label lcodigo;
        private System.Windows.Forms.TextBox textcantidad;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox textefectivo;
        private System.Windows.Forms.ComboBox cmb_Productos;
        private System.Windows.Forms.Label devolu;
        private System.Windows.Forms.Label tpagar;
        private System.Windows.Forms.Label ldevolucion;
        private System.Windows.Forms.Label lefectivo;
        private System.Windows.Forms.Label ltotalpagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView griewlista;
        private System.Windows.Forms.Button btnvender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button lcliente;
        private System.Windows.Forms.Button btnexit;
    }
}

