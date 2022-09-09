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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoNoBinario = new System.Windows.Forms.RadioButton();
            this.chkCS = new System.Windows.Forms.CheckBox();
            this.chkCPP = new System.Windows.Forms.CheckBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.grpDatos.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblEdad);
            this.grpDatos.Controls.Add(this.lblDireccion);
            this.grpDatos.Controls.Add(this.lblNombre);
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
            this.grpGenero.Controls.Add(this.rdoNoBinario);
            this.grpGenero.Controls.Add(this.rdoFemenino);
            this.grpGenero.Controls.Add(this.rdoMasculino);
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
            this.grpCursos.Controls.Add(this.chkJavaScript);
            this.grpCursos.Controls.Add(this.chkCPP);
            this.grpCursos.Controls.Add(this.chkCS);
            this.grpCursos.Location = new System.Drawing.Point(257, 141);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(110, 100);
            this.grpCursos.TabIndex = 3;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(273, 264);
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 69);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(18, 98);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(10, 24);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdoMasculino.TabIndex = 0;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(10, 49);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdoFemenino.TabIndex = 1;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoNoBinario
            // 
            this.rdoNoBinario.AutoSize = true;
            this.rdoNoBinario.Location = new System.Drawing.Point(10, 75);
            this.rdoNoBinario.Name = "rdoNoBinario";
            this.rdoNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdoNoBinario.TabIndex = 2;
            this.rdoNoBinario.TabStop = true;
            this.rdoNoBinario.Text = "No binario";
            this.rdoNoBinario.UseVisualStyleBackColor = true;
            // 
            // chkCS
            // 
            this.chkCS.AutoSize = true;
            this.chkCS.Location = new System.Drawing.Point(10, 28);
            this.chkCS.Name = "chkCS";
            this.chkCS.Size = new System.Drawing.Size(41, 19);
            this.chkCS.TabIndex = 0;
            this.chkCS.Text = "C#";
            this.chkCS.UseVisualStyleBackColor = true;
            // 
            // chkCPP
            // 
            this.chkCPP.AutoSize = true;
            this.chkCPP.Location = new System.Drawing.Point(10, 53);
            this.chkCPP.Name = "chkCPP";
            this.chkCPP.Size = new System.Drawing.Size(50, 19);
            this.chkCPP.TabIndex = 1;
            this.chkCPP.Text = "C++";
            this.chkCPP.UseVisualStyleBackColor = true;
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.Location = new System.Drawing.Point(10, 78);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(78, 19);
            this.chkJavaScript.TabIndex = 2;
            this.chkJavaScript.Text = "JavaScript";
            this.chkJavaScript.UseVisualStyleBackColor = true;
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
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
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
        private Label lblEdad;
        private Label lblDireccion;
        private Label lblNombre;
        private RadioButton rdoNoBinario;
        private RadioButton rdoFemenino;
        private RadioButton rdoMasculino;
        private CheckBox chkJavaScript;
        private CheckBox chkCPP;
        private CheckBox chkCS;
    }
}