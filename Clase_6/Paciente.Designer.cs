namespace Clase_6
{
    partial class Form2
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
            this.lblPrimernom = new System.Windows.Forms.Label();
            this.lblSegundonom = new System.Windows.Forms.Label();
            this.lblPrimerape = new System.Windows.Forms.Label();
            this.lblSegundoape = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNomm = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtApee = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimernom
            // 
            this.lblPrimernom.AutoSize = true;
            this.lblPrimernom.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPrimernom.Location = new System.Drawing.Point(129, 46);
            this.lblPrimernom.Name = "lblPrimernom";
            this.lblPrimernom.Size = new System.Drawing.Size(117, 20);
            this.lblPrimernom.TabIndex = 0;
            this.lblPrimernom.Text = "Primer nombre";
            // 
            // lblSegundonom
            // 
            this.lblSegundonom.AutoSize = true;
            this.lblSegundonom.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSegundonom.Location = new System.Drawing.Point(129, 104);
            this.lblSegundonom.Name = "lblSegundonom";
            this.lblSegundonom.Size = new System.Drawing.Size(128, 20);
            this.lblSegundonom.TabIndex = 1;
            this.lblSegundonom.Text = "Segundo nombre";
            // 
            // lblPrimerape
            // 
            this.lblPrimerape.AutoSize = true;
            this.lblPrimerape.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPrimerape.Location = new System.Drawing.Point(129, 159);
            this.lblPrimerape.Name = "lblPrimerape";
            this.lblPrimerape.Size = new System.Drawing.Size(121, 20);
            this.lblPrimerape.TabIndex = 2;
            this.lblPrimerape.Text = "Primer apellido";
            // 
            // lblSegundoape
            // 
            this.lblSegundoape.AutoSize = true;
            this.lblSegundoape.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSegundoape.Location = new System.Drawing.Point(129, 215);
            this.lblSegundoape.Name = "lblSegundoape";
            this.lblSegundoape.Size = new System.Drawing.Size(132, 20);
            this.lblSegundoape.TabIndex = 3;
            this.lblSegundoape.Text = "Segundo apellido";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(269, 46);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(295, 23);
            this.txtNom.TabIndex = 4;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtNomm
            // 
            this.txtNomm.Location = new System.Drawing.Point(269, 104);
            this.txtNomm.Name = "txtNomm";
            this.txtNomm.Size = new System.Drawing.Size(295, 23);
            this.txtNomm.TabIndex = 5;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(269, 159);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(295, 23);
            this.txtApe.TabIndex = 6;
            // 
            // txtApee
            // 
            this.txtApee.Location = new System.Drawing.Point(269, 215);
            this.txtApee.Name = "txtApee";
            this.txtApee.Size = new System.Drawing.Size(295, 23);
            this.txtApee.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(167, 298);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(318, 68);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnl_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(167, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(318, 68);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(715, 504);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtApee);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNomm);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblSegundoape);
            this.Controls.Add(this.lblPrimerape);
            this.Controls.Add(this.lblSegundonom);
            this.Controls.Add(this.lblPrimernom);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPrimernom;
        private Label lblSegundonom;
        private Label lblPrimerape;
        private Label lblSegundoape;
        private TextBox txtNom;
        private TextBox txtNomm;
        private TextBox txtApe;
        private TextBox txtApee;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}