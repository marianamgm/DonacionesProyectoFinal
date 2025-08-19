namespace DonacionesProyectoFinal
{
    partial class Correo
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
            this.btnCorreo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.btnCrearcuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCorreo
            // 
            this.btnCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCorreo.Location = new System.Drawing.Point(255, 22);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(106, 31);
            this.btnCorreo.TabIndex = 17;
            this.btnCorreo.Text = "Correo";
            this.btnCorreo.UseVisualStyleBackColor = false;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(642, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(169, 210);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(177, 20);
            this.textContraseña.TabIndex = 15;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(162, 129);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(184, 20);
            this.textCorreo.TabIndex = 14;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(83, 311);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(459, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Al crear esta cuenta usted estara aceptando los termino de servicios y politica d" +
    "e privacidad";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(169, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Recordar Contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Location = new System.Drawing.Point(166, 176);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(61, 13);
            this.txtContraseña.TabIndex = 11;
            this.txtContraseña.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Location = new System.Drawing.Point(159, 113);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(38, 13);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.Text = "Correo";
            // 
            // btnCrearcuenta
            // 
            this.btnCrearcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCrearcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearcuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearcuenta.Location = new System.Drawing.Point(255, 376);
            this.btnCrearcuenta.Name = "btnCrearcuenta";
            this.btnCrearcuenta.Size = new System.Drawing.Size(148, 35);
            this.btnCrearcuenta.TabIndex = 9;
            this.btnCrearcuenta.Text = "Crear Cuenta";
            this.btnCrearcuenta.UseVisualStyleBackColor = false;
            this.btnCrearcuenta.Click += new System.EventHandler(this.btnCrearcuenta_Click);
            // 
            // Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnCrearcuenta);
            this.Name = "Correo";
            this.Text = "Correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Button btnCrearcuenta;
    }
}