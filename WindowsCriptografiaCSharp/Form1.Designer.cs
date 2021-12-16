
namespace WindowsCriptografiaCSharp
{
    partial class Form1
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
            this.btnCodificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodificado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecodificado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCodificar
            // 
            this.btnCodificar.Location = new System.Drawing.Point(409, 27);
            this.btnCodificar.Name = "btnCodificar";
            this.btnCodificar.Size = new System.Drawing.Size(75, 23);
            this.btnCodificar.TabIndex = 0;
            this.btnCodificar.Text = "Codificar";
            this.btnCodificar.UseVisualStyleBackColor = true;
            this.btnCodificar.Click += new System.EventHandler(this.btnCodificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original:";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(119, 29);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(273, 20);
            this.txtOriginal.TabIndex = 2;
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.Location = new System.Drawing.Point(409, 64);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(75, 23);
            this.btnDecodificar.TabIndex = 0;
            this.btnDecodificar.Text = "Decodificar";
            this.btnDecodificar.UseVisualStyleBackColor = true;
            this.btnDecodificar.Click += new System.EventHandler(this.btnDecodificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codificado:";
            // 
            // txtCodificado
            // 
            this.txtCodificado.Location = new System.Drawing.Point(119, 66);
            this.txtCodificado.Name = "txtCodificado";
            this.txtCodificado.Size = new System.Drawing.Size(273, 20);
            this.txtCodificado.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Decodificado:";
            // 
            // txtDecodificado
            // 
            this.txtDecodificado.Location = new System.Drawing.Point(119, 96);
            this.txtDecodificado.Name = "txtDecodificado";
            this.txtDecodificado.Size = new System.Drawing.Size(273, 20);
            this.txtDecodificado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 151);
            this.Controls.Add(this.txtDecodificado);
            this.Controls.Add(this.txtCodificado);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecodificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCodificar);
            this.Name = "Form1";
            this.Text = "Aplicação de Exemplo Criptografia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCodificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodificado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecodificado;
    }
}

