namespace C05_Vistas
{
    partial class FrmMiForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblIngreseSuNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSaludarForm = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(32, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Saludar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIngreseSuNombre
            // 
            this.lblIngreseSuNombre.AutoSize = true;
            this.lblIngreseSuNombre.Location = new System.Drawing.Point(33, 32);
            this.lblIngreseSuNombre.Name = "lblIngreseSuNombre";
            this.lblIngreseSuNombre.Size = new System.Drawing.Size(105, 15);
            this.lblIngreseSuNombre.TabIndex = 1;
            this.lblIngreseSuNombre.Text = "Ingrese su nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // btnSaludarForm
            // 
            this.btnSaludarForm.Location = new System.Drawing.Point(138, 136);
            this.btnSaludarForm.Name = "btnSaludarForm";
            this.btnSaludarForm.Size = new System.Drawing.Size(85, 55);
            this.btnSaludarForm.TabIndex = 3;
            this.btnSaludarForm.Text = "Saludar desde otro Form";
            this.btnSaludarForm.UseVisualStyleBackColor = true;
            this.btnSaludarForm.Click += new System.EventHandler(this.btnSaludarForm_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(39, 235);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 15);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "...";
            // 
            // FrmMiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 284);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSaludarForm);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngreseSuNombre);
            this.Controls.Add(this.button1);
            this.Name = "FrmMiForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label lblIngreseSuNombre;
        private TextBox txtNombre;
        private Button btnSaludarForm;
        private Label lblResultado;
    }
}