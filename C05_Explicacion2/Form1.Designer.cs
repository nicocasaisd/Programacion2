namespace C05_Explicacion2
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(307, 203);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(101, 43);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Loguearse";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(307, 87);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.PlaceholderText = "Ingrese usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 23);
            this.tb_usuario.TabIndex = 1;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(307, 139);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.PlaceholderText = "Ingrese pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 23);
            this.tb_pass.TabIndex = 2;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.btn_login);
            this.Name = "FrmLogin";
            this.Text = "Formulario de login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_pass;
    }
}
