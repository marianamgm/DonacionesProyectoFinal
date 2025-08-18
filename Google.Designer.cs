namespace DonacionesProyectoFinal
{
    partial class Google
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
            this.btnCrearcuenta = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearcuenta
            // 
            this.btnCrearcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCrearcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearcuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearcuenta.Location = new System.Drawing.Point(320, 380);
            this.btnCrearcuenta.Name = "btnCrearcuenta";
            this.btnCrearcuenta.Size = new System.Drawing.Size(148, 35);
            this.btnCrearcuenta.TabIndex = 0;
            this.btnCrearcuenta.Text = "Crear Cuenta";
            this.btnCrearcuenta.UseVisualStyleBackColor = false;
            this.btnCrearcuenta.Click += new System.EventHandler(this.btnCrearcuenta_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Location = new System.Drawing.Point(224, 117);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(38, 13);
            this.txtCorreo.TabIndex = 1;
            this.txtCorreo.Text = "Correo";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Location = new System.Drawing.Point(231, 180);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(61, 13);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "Contraseña";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(234, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Recordar Contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(148, 315);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(459, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Al crear esta cuenta usted estara aceptando los termino de servicios y politica d" +
    "e privacidad";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(227, 133);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(184, 20);
            this.textCorreo.TabIndex = 5;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(234, 214);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(177, 20);
            this.textContraseña.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(707, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGoogle.Location = new System.Drawing.Point(320, 26);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(106, 31);
            this.btnGoogle.TabIndex = 8;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = false;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // Google
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnCrearcuenta);
            this.Name = "Google";
            this.Text = "Google";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearcuenta;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtContraseña;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGoogle;
    }
}