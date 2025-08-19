namespace DonacionesProyectoFinal
{
    partial class Tipo_de_cuenta
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
            this.btngoogle = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.btnContinuarcon = new System.Windows.Forms.Button();
            this.btncrearcuenta = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngoogle
            // 
            this.btngoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngoogle.Location = new System.Drawing.Point(446, 264);
            this.btngoogle.Name = "btngoogle";
            this.btngoogle.Size = new System.Drawing.Size(200, 74);
            this.btngoogle.TabIndex = 18;
            this.btngoogle.Text = "Google";
            this.btngoogle.UseVisualStyleBackColor = true;
            this.btngoogle.Click += new System.EventHandler(this.btngoogle_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorreo.Location = new System.Drawing.Point(163, 264);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(211, 74);
            this.btnCorreo.TabIndex = 17;
            this.btnCorreo.Text = "Correo";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // btnContinuarcon
            // 
            this.btnContinuarcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnContinuarcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContinuarcon.Location = new System.Drawing.Point(340, 149);
            this.btnContinuarcon.Name = "btnContinuarcon";
            this.btnContinuarcon.Size = new System.Drawing.Size(122, 33);
            this.btnContinuarcon.TabIndex = 16;
            this.btnContinuarcon.Text = "Continuar Con";
            this.btnContinuarcon.UseVisualStyleBackColor = false;
            this.btnContinuarcon.Click += new System.EventHandler(this.btnContinuarcon_Click);
            // 
            // btncrearcuenta
            // 
            this.btncrearcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btncrearcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearcuenta.ForeColor = System.Drawing.SystemColors.Window;
            this.btncrearcuenta.Location = new System.Drawing.Point(239, 77);
            this.btncrearcuenta.Name = "btncrearcuenta";
            this.btncrearcuenta.Size = new System.Drawing.Size(312, 22);
            this.btncrearcuenta.TabIndex = 15;
            this.btncrearcuenta.Text = "                           Crear cuenta";
            this.btncrearcuenta.TextChanged += new System.EventHandler(this.btncrearcuenta_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(666, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 33);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Tipo_de_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btngoogle);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.btnContinuarcon);
            this.Controls.Add(this.btncrearcuenta);
            this.Name = "Tipo_de_cuenta";
            this.Text = "Tipo_de_cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btngoogle;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Button btnContinuarcon;
        private System.Windows.Forms.TextBox btncrearcuenta;
        private System.Windows.Forms.Button btnSalir;
    }
}