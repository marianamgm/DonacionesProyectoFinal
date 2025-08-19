namespace DonacionesProyectoFinal
{
    partial class DonacionesRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonacionesRegistro));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevoD = new System.Windows.Forms.ToolStripButton();
            this.btnGuardarD = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarD = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cd_categoria = new System.Windows.Forms.TextBox();
            this.cd_direccion = new System.Windows.Forms.TextBox();
            this.cd_descripcion = new System.Windows.Forms.TextBox();
            this.cd_telefono = new System.Windows.Forms.TextBox();
            this.cd_curp = new System.Windows.Forms.TextBox();
            this.cd_email = new System.Windows.Forms.TextBox();
            this.cd_nombre = new System.Windows.Forms.TextBox();
            this.cd_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.GridD = new System.Windows.Forms.DataGridView();
            this.dId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emaild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridD)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoD,
            this.btnGuardarD,
            this.btnEliminarD,
            this.btnListar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevoD
            // 
            this.btnNuevoD.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoD.Image")));
            this.btnNuevoD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevoD.Name = "btnNuevoD";
            this.btnNuevoD.Size = new System.Drawing.Size(76, 24);
            this.btnNuevoD.Text = "Nuevo";
            this.btnNuevoD.Click += new System.EventHandler(this.btnNuevoD_Click);
            // 
            // btnGuardarD
            // 
            this.btnGuardarD.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarD.Image")));
            this.btnGuardarD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarD.Name = "btnGuardarD";
            this.btnGuardarD.Size = new System.Drawing.Size(86, 24);
            this.btnGuardarD.Text = "Guardar";
            this.btnGuardarD.Click += new System.EventHandler(this.btnGuardarD_Click);
            // 
            // btnEliminarD
            // 
            this.btnEliminarD.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarD.Image")));
            this.btnEliminarD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarD.Name = "btnEliminarD";
            this.btnEliminarD.Size = new System.Drawing.Size(87, 24);
            this.btnEliminarD.Text = "Eliminar";
            this.btnEliminarD.Click += new System.EventHandler(this.btnEliminarD_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cd_categoria);
            this.panel1.Controls.Add(this.cd_direccion);
            this.panel1.Controls.Add(this.cd_descripcion);
            this.panel1.Controls.Add(this.cd_telefono);
            this.panel1.Controls.Add(this.cd_curp);
            this.panel1.Controls.Add(this.cd_email);
            this.panel1.Controls.Add(this.cd_nombre);
            this.panel1.Controls.Add(this.cd_id);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 173);
            this.panel1.TabIndex = 1;
            // 
            // cd_categoria
            // 
            this.cd_categoria.Location = new System.Drawing.Point(469, 122);
            this.cd_categoria.Name = "cd_categoria";
            this.cd_categoria.Size = new System.Drawing.Size(170, 22);
            this.cd_categoria.TabIndex = 33;
            // 
            // cd_direccion
            // 
            this.cd_direccion.Location = new System.Drawing.Point(469, 91);
            this.cd_direccion.Name = "cd_direccion";
            this.cd_direccion.Size = new System.Drawing.Size(243, 22);
            this.cd_direccion.TabIndex = 32;
            // 
            // cd_descripcion
            // 
            this.cd_descripcion.Location = new System.Drawing.Point(469, 60);
            this.cd_descripcion.Name = "cd_descripcion";
            this.cd_descripcion.Size = new System.Drawing.Size(243, 22);
            this.cd_descripcion.TabIndex = 31;
            // 
            // cd_telefono
            // 
            this.cd_telefono.Location = new System.Drawing.Point(469, 26);
            this.cd_telefono.Name = "cd_telefono";
            this.cd_telefono.Size = new System.Drawing.Size(170, 22);
            this.cd_telefono.TabIndex = 30;
            // 
            // cd_curp
            // 
            this.cd_curp.Location = new System.Drawing.Point(91, 122);
            this.cd_curp.Name = "cd_curp";
            this.cd_curp.Size = new System.Drawing.Size(242, 22);
            this.cd_curp.TabIndex = 29;
            // 
            // cd_email
            // 
            this.cd_email.Location = new System.Drawing.Point(91, 91);
            this.cd_email.Name = "cd_email";
            this.cd_email.Size = new System.Drawing.Size(237, 22);
            this.cd_email.TabIndex = 28;
            // 
            // cd_nombre
            // 
            this.cd_nombre.Location = new System.Drawing.Point(91, 60);
            this.cd_nombre.Name = "cd_nombre";
            this.cd_nombre.Size = new System.Drawing.Size(263, 22);
            this.cd_nombre.TabIndex = 27;
            // 
            // cd_id
            // 
            this.cd_id.Location = new System.Drawing.Point(91, 26);
            this.cd_id.Name = "cd_id";
            this.cd_id.Size = new System.Drawing.Size(170, 22);
            this.cd_id.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "CURP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Location = new System.Drawing.Point(29, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 83);
            this.panel2.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(593, 36);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 36);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // GridD
            // 
            this.GridD.AllowUserToAddRows = false;
            this.GridD.AllowUserToDeleteRows = false;
            this.GridD.AllowUserToResizeRows = false;
            this.GridD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dId,
            this.dNombre,
            this.dCURP,
            this.dTelefono,
            this.Emaild,
            this.dDireccion,
            this.dDescripcion,
            this.dCategoria});
            this.GridD.Location = new System.Drawing.Point(33, 209);
            this.GridD.Name = "GridD";
            this.GridD.RowHeadersVisible = false;
            this.GridD.RowHeadersWidth = 51;
            this.GridD.RowTemplate.Height = 24;
            this.GridD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridD.Size = new System.Drawing.Size(733, 207);
            this.GridD.TabIndex = 3;
            this.GridD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridD_CellContentClick);
            // 
            // dId
            // 
            this.dId.DataPropertyName = "dId";
            this.dId.HeaderText = "ID";
            this.dId.MinimumWidth = 6;
            this.dId.Name = "dId";
            this.dId.Width = 125;
            // 
            // dNombre
            // 
            this.dNombre.DataPropertyName = "dNombre";
            this.dNombre.HeaderText = "Nombre";
            this.dNombre.MinimumWidth = 6;
            this.dNombre.Name = "dNombre";
            this.dNombre.Width = 225;
            // 
            // dCURP
            // 
            this.dCURP.DataPropertyName = "dCURP";
            this.dCURP.HeaderText = "CURP";
            this.dCURP.MinimumWidth = 6;
            this.dCURP.Name = "dCURP";
            this.dCURP.Width = 250;
            // 
            // dTelefono
            // 
            this.dTelefono.DataPropertyName = "dTelefono";
            this.dTelefono.HeaderText = "Telefono";
            this.dTelefono.MinimumWidth = 6;
            this.dTelefono.Name = "dTelefono";
            this.dTelefono.Width = 200;
            // 
            // Emaild
            // 
            this.Emaild.DataPropertyName = "Emaild";
            this.Emaild.HeaderText = "Email";
            this.Emaild.MinimumWidth = 6;
            this.Emaild.Name = "Emaild";
            this.Emaild.Width = 125;
            // 
            // dDireccion
            // 
            this.dDireccion.DataPropertyName = "dDireccion";
            this.dDireccion.HeaderText = "Direccion";
            this.dDireccion.MinimumWidth = 6;
            this.dDireccion.Name = "dDireccion";
            this.dDireccion.Width = 200;
            // 
            // dDescripcion
            // 
            this.dDescripcion.DataPropertyName = "dDescripcion";
            this.dDescripcion.HeaderText = "Descripcion";
            this.dDescripcion.MinimumWidth = 6;
            this.dDescripcion.Name = "dDescripcion";
            this.dDescripcion.Width = 300;
            // 
            // dCategoria
            // 
            this.dCategoria.DataPropertyName = "dCategoria";
            this.dCategoria.HeaderText = "Categoria";
            this.dCategoria.MinimumWidth = 6;
            this.dCategoria.Name = "dCategoria";
            this.dCategoria.Width = 130;
            // 
            // btnListar
            // 
            this.btnListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(48, 24);
            this.btnListar.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // DonacionesRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.GridD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonacionesRegistro";
            this.Text = "DonacionesRegistro";
            this.Load += new System.EventHandler(this.DonacionesRegistro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevoD;
        private System.Windows.Forms.ToolStripButton btnGuardarD;
        private System.Windows.Forms.ToolStripButton btnEliminarD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox cd_categoria;
        private System.Windows.Forms.TextBox cd_direccion;
        private System.Windows.Forms.TextBox cd_descripcion;
        private System.Windows.Forms.TextBox cd_telefono;
        private System.Windows.Forms.TextBox cd_curp;
        private System.Windows.Forms.TextBox cd_email;
        private System.Windows.Forms.TextBox cd_nombre;
        private System.Windows.Forms.TextBox cd_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCURP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emaild;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCategoria;
        private System.Windows.Forms.ToolStripButton btnListar;
    }
}