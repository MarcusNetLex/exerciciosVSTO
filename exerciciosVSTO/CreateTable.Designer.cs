namespace exerciciosVSTO
{
    partial class CreateTable
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
            this.numLinhas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numColunas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // numLinhas
            // 
            this.numLinhas.Location = new System.Drawing.Point(114, 46);
            this.numLinhas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numLinhas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLinhas.Name = "numLinhas";
            this.numLinhas.Size = new System.Drawing.Size(57, 20);
            this.numLinhas.TabIndex = 0;
            this.numLinhas.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numLinhas.ValueChanged += new System.EventHandler(this.numLinhas_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Linhas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de Colunas:";
            // 
            // numColunas
            // 
            this.numColunas.Location = new System.Drawing.Point(114, 79);
            this.numColunas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numColunas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColunas.Name = "numColunas";
            this.numColunas.Size = new System.Drawing.Size(57, 20);
            this.numColunas.TabIndex = 3;
            this.numColunas.UseWaitCursor = true;
            this.numColunas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numColunas.ValueChanged += new System.EventHandler(this.numColunas_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Por favor, digite as informações necessárias abaixo:";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(203, 115);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 5;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(284, 115);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 149);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numColunas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numLinhas);
            this.Name = "CreateTable";
            this.Text = "Criar Tabela";
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numLinhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numColunas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnCancelar;
    }
}