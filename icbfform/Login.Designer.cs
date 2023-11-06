namespace icbfform
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTIniciarSesion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtClaveLogin = new System.Windows.Forms.TextBox();
            this.txtDocLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(108, 151);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblTIniciarSesion
            // 
            this.lblTIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTIniciarSesion.AutoSize = true;
            this.lblTIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTIniciarSesion.Font = new System.Drawing.Font("Broadway", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIniciarSesion.Location = new System.Drawing.Point(9, 10);
            this.lblTIniciarSesion.Name = "lblTIniciarSesion";
            this.lblTIniciarSesion.Size = new System.Drawing.Size(265, 32);
            this.lblTIniciarSesion.TabIndex = 26;
            this.lblTIniciarSesion.Text = "INICIAR SESION";
            this.lblTIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtClaveLogin);
            this.panel1.Controls.Add(this.txtDocLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 100);
            this.panel1.TabIndex = 27;
            // 
            // txtClaveLogin
            // 
            this.txtClaveLogin.Location = new System.Drawing.Point(127, 62);
            this.txtClaveLogin.Name = "txtClaveLogin";
            this.txtClaveLogin.PasswordChar = '*';
            this.txtClaveLogin.Size = new System.Drawing.Size(100, 20);
            this.txtClaveLogin.TabIndex = 7;
            this.txtClaveLogin.UseSystemPasswordChar = true;
            // 
            // txtDocLogin
            // 
            this.txtDocLogin.Location = new System.Drawing.Point(127, 19);
            this.txtDocLogin.Name = "txtDocLogin";
            this.txtDocLogin.Size = new System.Drawing.Size(100, 20);
            this.txtDocLogin.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Documento";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 181);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTIniciarSesion);
            this.Controls.Add(this.btnLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 220);
            this.MinimumSize = new System.Drawing.Size(301, 220);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTIniciarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClaveLogin;
        private System.Windows.Forms.TextBox txtDocLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

