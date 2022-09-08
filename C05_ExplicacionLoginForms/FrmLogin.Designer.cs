namespace C05_ExplicacionLoginForms
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
            this.btn_loguearse = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(400, 230);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(164, 65);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_loguearse
            // 
            this.btn_loguearse.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_loguearse.Location = new System.Drawing.Point(317, 231);
            this.btn_loguearse.Name = "btn_loguearse";
            this.btn_loguearse.Size = new System.Drawing.Size(159, 83);
            this.btn_loguearse.TabIndex = 0;
            this.btn_loguearse.Text = "Loguearse";
            this.btn_loguearse.UseVisualStyleBackColor = true;
            this.btn_loguearse.Click += new System.EventHandler(this.btn_loguearse_Click);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(317, 75);
            this.tb_user.Name = "tb_user";
            this.tb_user.PlaceholderText = "Ingrese usuario";
            this.tb_user.Size = new System.Drawing.Size(168, 23);
            this.tb_user.TabIndex = 1;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(317, 122);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.PlaceholderText = "Ingrese password";
            this.tb_pass.Size = new System.Drawing.Size(168, 23);
            this.tb_pass.TabIndex = 2;
            // 
            // FormularioLogin
            // 
            this.ClientSize = new System.Drawing.Size(744, 373);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.btn_loguearse);
            this.Name = "FormularioLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_loguearse;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
    }
}
