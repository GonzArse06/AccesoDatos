namespace NLayer.Formularios
{
    partial class FrmInicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.btnIngresarCuenta = new System.Windows.Forms.Button();
            this.btnListarCuentas = new System.Windows.Forms.Button();
            this.btnAcercade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "LISTA CLIENTES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.Location = new System.Drawing.Point(13, 108);
            this.btnIngresarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(284, 63);
            this.btnIngresarCliente.TabIndex = 2;
            this.btnIngresarCliente.Text = "INGRESAR CLIENTE";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // btnIngresarCuenta
            // 
            this.btnIngresarCuenta.Location = new System.Drawing.Point(381, 108);
            this.btnIngresarCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarCuenta.Name = "btnIngresarCuenta";
            this.btnIngresarCuenta.Size = new System.Drawing.Size(284, 63);
            this.btnIngresarCuenta.TabIndex = 5;
            this.btnIngresarCuenta.Text = "INGRESAR CUENTA";
            this.btnIngresarCuenta.UseVisualStyleBackColor = true;
            this.btnIngresarCuenta.Click += new System.EventHandler(this.btnIngresarCuenta_Click);
            // 
            // btnListarCuentas
            // 
            this.btnListarCuentas.Location = new System.Drawing.Point(381, 24);
            this.btnListarCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarCuentas.Name = "btnListarCuentas";
            this.btnListarCuentas.Size = new System.Drawing.Size(284, 63);
            this.btnListarCuentas.TabIndex = 3;
            this.btnListarCuentas.Text = "LISTA CUENTAS";
            this.btnListarCuentas.UseVisualStyleBackColor = true;
            this.btnListarCuentas.Click += new System.EventHandler(this.btnListarCuentas_Click);
            // 
            // btnAcercade
            // 
            this.btnAcercade.Location = new System.Drawing.Point(557, 248);
            this.btnAcercade.Name = "btnAcercade";
            this.btnAcercade.Size = new System.Drawing.Size(108, 33);
            this.btnAcercade.TabIndex = 6;
            this.btnAcercade.Text = "Acerca de";
            this.btnAcercade.UseVisualStyleBackColor = true;
            this.btnAcercade.Click += new System.EventHandler(this.btnAcercade_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 302);
            this.Controls.Add(this.btnAcercade);
            this.Controls.Add(this.btnIngresarCuenta);
            this.Controls.Add(this.btnListarCuentas);
            this.Controls.Add(this.btnIngresarCliente);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Button btnIngresarCuenta;
        private System.Windows.Forms.Button btnListarCuentas;
        private System.Windows.Forms.Button btnAcercade;
    }
}