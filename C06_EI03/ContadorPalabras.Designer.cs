namespace C06_EI03
{
    partial class ContadorPalabras
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
            this.rtx_Palabras = new System.Windows.Forms.RichTextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtx_Palabras
            // 
            this.rtx_Palabras.Location = new System.Drawing.Point(12, 12);
            this.rtx_Palabras.Name = "rtx_Palabras";
            this.rtx_Palabras.Size = new System.Drawing.Size(434, 202);
            this.rtx_Palabras.TabIndex = 0;
            this.rtx_Palabras.Text = "";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(361, 238);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 287);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rtx_Palabras);
            this.Name = "Form1";
            this.Text = "Contador de palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtx_Palabras;
        private Button btn_Calcular;
    }
}