namespace C05b_Ejercicio02
{
    partial class Form1
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.lstPais = new System.Windows.Forms.ListBox();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.nudEdad);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Location = new System.Drawing.Point(27, 24);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(212, 127);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Detalles de usuario";
            // 
            // grpGenero
            // 
            this.grpGenero.Location = new System.Drawing.Point(257, 24);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(110, 100);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // lstPais
            // 
            this.lstPais.FormattingEnabled = true;
            this.lstPais.ItemHeight = 15;
            this.lstPais.Location = new System.Drawing.Point(27, 180);
            this.lstPais.Name = "lstPais";
            this.lstPais.Size = new System.Drawing.Size(212, 94);
            this.lstPais.TabIndex = 2;
            // 
            // grpCursos
            // 
            this.grpCursos.Location = new System.Drawing.Point(257, 141);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(110, 100);
            this.grpCursos.TabIndex = 3;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(292, 262);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 66);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(79, 98);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 23);
            this.nudEdad.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 315);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.lstPais);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpDatos;
        private GroupBox grpGenero;
        private NumericUpDown nudEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private ListBox lstPais;
        private GroupBox grpCursos;
        private Button btnIngresar;
    }
}