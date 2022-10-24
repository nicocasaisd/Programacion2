namespace UI
{
    partial class Frm_Calculador
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
            this.lbl_kilometros = new System.Windows.Forms.Label();
            this.txt_kilometros = new System.Windows.Forms.TextBox();
            this.rtb_Calculador = new System.Windows.Forms.RichTextBox();
            this.txt_litros = new System.Windows.Forms.TextBox();
            this.lbl_litros = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kilometros
            // 
            this.lbl_kilometros.AutoSize = true;
            this.lbl_kilometros.Location = new System.Drawing.Point(27, 30);
            this.lbl_kilometros.Name = "lbl_kilometros";
            this.lbl_kilometros.Size = new System.Drawing.Size(64, 15);
            this.lbl_kilometros.TabIndex = 0;
            this.lbl_kilometros.Text = "Kilometros";
            // 
            // txt_kilometros
            // 
            this.txt_kilometros.Location = new System.Drawing.Point(27, 66);
            this.txt_kilometros.Name = "txt_kilometros";
            this.txt_kilometros.Size = new System.Drawing.Size(100, 23);
            this.txt_kilometros.TabIndex = 1;
            // 
            // rtb_Calculador
            // 
            this.rtb_Calculador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Calculador.Enabled = false;
            this.rtb_Calculador.Location = new System.Drawing.Point(179, 12);
            this.rtb_Calculador.Name = "rtb_Calculador";
            this.rtb_Calculador.Size = new System.Drawing.Size(146, 154);
            this.rtb_Calculador.TabIndex = 2;
            this.rtb_Calculador.Text = "";
            // 
            // txt_litros
            // 
            this.txt_litros.Location = new System.Drawing.Point(27, 143);
            this.txt_litros.Name = "txt_litros";
            this.txt_litros.Size = new System.Drawing.Size(100, 23);
            this.txt_litros.TabIndex = 3;
            // 
            // lbl_litros
            // 
            this.lbl_litros.AutoSize = true;
            this.lbl_litros.Location = new System.Drawing.Point(27, 116);
            this.lbl_litros.Name = "lbl_litros";
            this.lbl_litros.Size = new System.Drawing.Size(36, 15);
            this.lbl_litros.TabIndex = 4;
            this.lbl_litros.Text = "Litros";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(27, 185);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Frm_Calculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 230);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_litros);
            this.Controls.Add(this.txt_litros);
            this.Controls.Add(this.rtb_Calculador);
            this.Controls.Add(this.txt_kilometros);
            this.Controls.Add(this.lbl_kilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Calculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kilometros;
        private System.Windows.Forms.TextBox txt_kilometros;
        private System.Windows.Forms.RichTextBox rtb_Calculador;
        private System.Windows.Forms.TextBox txt_litros;
        private System.Windows.Forms.Label lbl_litros;
        private System.Windows.Forms.Button btn_Calcular;
    }
}
