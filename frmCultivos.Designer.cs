namespace prySchneiderSP1
{
    partial class frmCultivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCultivos));
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCrearLocalidad = new System.Windows.Forms.Button();
            this.txtCultivo = new System.Windows.Forms.TextBox();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(26, 85);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(150, 20);
            this.txtIdentificador.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingrese el Identificador";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(26, 117);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 32);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCrearLocalidad
            // 
            this.btnCrearLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearLocalidad.Location = new System.Drawing.Point(26, 155);
            this.btnCrearLocalidad.Name = "btnCrearLocalidad";
            this.btnCrearLocalidad.Size = new System.Drawing.Size(150, 28);
            this.btnCrearLocalidad.TabIndex = 14;
            this.btnCrearLocalidad.Text = "Crear";
            this.btnCrearLocalidad.UseVisualStyleBackColor = true;
            // 
            // txtCultivo
            // 
            this.txtCultivo.Location = new System.Drawing.Point(26, 32);
            this.txtCultivo.Name = "txtCultivo";
            this.txtCultivo.Size = new System.Drawing.Size(150, 20);
            this.txtCultivo.TabIndex = 13;
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivo.Location = new System.Drawing.Point(22, 9);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(154, 20);
            this.lblCultivo.TabIndex = 12;
            this.lblCultivo.Text = "Ingrese un Cultivo";
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 193);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCrearLocalidad);
            this.Controls.Add(this.txtCultivo);
            this.Controls.Add(this.lblCultivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCultivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCrearLocalidad;
        private System.Windows.Forms.TextBox txtCultivo;
        private System.Windows.Forms.Label lblCultivo;
    }
}