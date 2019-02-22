namespace exerciciosVSTO
{
    partial class QualView
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
            this.text_Contato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddQualificacao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Representante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_Contato
            // 
            this.text_Contato.Location = new System.Drawing.Point(79, 19);
            this.text_Contato.Name = "text_Contato";
            this.text_Contato.Size = new System.Drawing.Size(186, 22);
            this.text_Contato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contato:";
            // 
            // btn_AddQualificacao
            // 
            this.btn_AddQualificacao.Location = new System.Drawing.Point(111, 89);
            this.btn_AddQualificacao.Name = "btn_AddQualificacao";
            this.btn_AddQualificacao.Size = new System.Drawing.Size(43, 23);
            this.btn_AddQualificacao.TabIndex = 4;
            this.btn_AddQualificacao.Text = "OK";
            this.btn_AddQualificacao.UseVisualStyleBackColor = true;
            this.btn_AddQualificacao.Click += new System.EventHandler(this.btn_AddQualificacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Representante:";
            // 
            // text_Representante
            // 
            this.text_Representante.Location = new System.Drawing.Point(124, 48);
            this.text_Representante.Name = "text_Representante";
            this.text_Representante.Size = new System.Drawing.Size(141, 22);
            this.text_Representante.TabIndex = 6;
            // 
            // Qualificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 124);
            this.Controls.Add(this.text_Representante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AddQualificacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Contato);
            this.Name = "Qualificacao";
            this.Text = "Qualificacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Contato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddQualificacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Representante;
    }
}