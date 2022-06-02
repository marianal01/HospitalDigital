namespace Clase_6
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCuadroUsuario = new System.Windows.Forms.TextBox();
            this.lblSelección = new System.Windows.Forms.Label();
            this.cmbSelección = new System.Windows.Forms.ComboBox();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(103, 99);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 15);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Label";
            // 
            // txtCuadroUsuario
            // 
            this.txtCuadroUsuario.Location = new System.Drawing.Point(103, 117);
            this.txtCuadroUsuario.Name = "txtCuadroUsuario";
            this.txtCuadroUsuario.Size = new System.Drawing.Size(373, 23);
            this.txtCuadroUsuario.TabIndex = 1;
            // 
            // lblSelección
            // 
            this.lblSelección.AutoSize = true;
            this.lblSelección.BackColor = System.Drawing.Color.White;
            this.lblSelección.Location = new System.Drawing.Point(103, 153);
            this.lblSelección.Name = "lblSelección";
            this.lblSelección.Size = new System.Drawing.Size(57, 15);
            this.lblSelección.TabIndex = 2;
            this.lblSelección.Text = "Selección";
            // 
            // cmbSelección
            // 
            this.cmbSelección.FormattingEnabled = true;
            this.cmbSelección.Location = new System.Drawing.Point(103, 171);
            this.cmbSelección.Name = "cmbSelección";
            this.cmbSelección.Size = new System.Drawing.Size(373, 23);
            this.cmbSelección.TabIndex = 3;
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.BackColor = System.Drawing.SystemColors.Info;
            this.cmdSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmdSiguiente.ForeColor = System.Drawing.Color.Black;
            this.cmdSiguiente.Location = new System.Drawing.Point(22, 261);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(165, 61);
            this.cmdSiguiente.TabIndex = 1;
            this.cmdSiguiente.Text = "Siguiente";
            this.cmdSiguiente.UseVisualStyleBackColor = false;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.SystemColors.Info;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmdSalir.ForeColor = System.Drawing.Color.Black;
            this.cmdSalir.Location = new System.Drawing.Point(230, 261);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(165, 61);
            this.cmdSalir.TabIndex = 1;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmdSiguiente);
            this.groupBox1.Controls.Add(this.cmdSalir);
            this.groupBox1.Location = new System.Drawing.Point(81, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(729, 492);
            this.Controls.Add(this.cmbSelección);
            this.Controls.Add(this.lblSelección);
            this.Controls.Add(this.txtCuadroUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsuario;
        private TextBox txtCuadroUsuario;
        private Label lblSelección;
        private ComboBox cmbSelección;
        private Button cmdSiguiente;
        private Button cmdSalir;
        private GroupBox groupBox1;
    }
}