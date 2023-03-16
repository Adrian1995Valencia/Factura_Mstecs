namespace Factura_Mstecs
{
    partial class Agregar_Cliente
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
            this.lid = new System.Windows.Forms.Label();
            this.lnombre = new System.Windows.Forms.Label();
            this.lapellido = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.GridViewcliente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lid.Location = new System.Drawing.Point(99, 102);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(22, 16);
            this.lid.TabIndex = 0;
            this.lid.Text = "ID";
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombre.Location = new System.Drawing.Point(99, 150);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(72, 16);
            this.lnombre.TabIndex = 1;
            this.lnombre.Text = "NOMBRE";
            // 
            // lapellido
            // 
            this.lapellido.AutoSize = true;
            this.lapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapellido.Location = new System.Drawing.Point(102, 203);
            this.lapellido.Name = "lapellido";
            this.lapellido.Size = new System.Drawing.Size(79, 16);
            this.lapellido.TabIndex = 2;
            this.lapellido.Text = "APELLIDO";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(205, 102);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 3;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(205, 146);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxnombre.TabIndex = 4;
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Location = new System.Drawing.Point(205, 199);
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxapellido.TabIndex = 5;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnregistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(513, 50);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(157, 46);
            this.btnregistrar.TabIndex = 6;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnborrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(513, 118);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(157, 48);
            this.btnborrar.TabIndex = 7;
            this.btnborrar.Text = "BORRAR SELECCION";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnregresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(513, 184);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(157, 49);
            this.btnregresar.TabIndex = 8;
            this.btnregresar.Text = "REGRESAR";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // GridViewcliente
            // 
            this.GridViewcliente.AllowUserToAddRows = false;
            this.GridViewcliente.AllowUserToDeleteRows = false;
            this.GridViewcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GridViewcliente.Location = new System.Drawing.Point(80, 272);
            this.GridViewcliente.Name = "GridViewcliente";
            this.GridViewcliente.ReadOnly = true;
            this.GridViewcliente.Size = new System.Drawing.Size(643, 150);
            this.GridViewcliente.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "APELLIDO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Agregar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridViewcliente);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.textBoxapellido);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.lapellido);
            this.Controls.Add(this.lnombre);
            this.Controls.Add(this.lid);
            this.Name = "Agregar_Cliente";
            this.Text = "Agregar_Cliente";
            this.Load += new System.EventHandler(this.Agregar_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lid;
        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label lapellido;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxapellido;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.DataGridView GridViewcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}