namespace exerciciosVSTO
{
    partial class SearchView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_FindWhat = new System.Windows.Forms.TextBox();
            this.bnt_FindNext = new System.Windows.Forms.Button();
            this.panel_Find = new System.Windows.Forms.Panel();
            this.btn_ReplaceAll = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.text_ReplaceFor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkbox_MatchCase = new System.Windows.Forms.CheckBox();
            this.panel_Find.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find What:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find and Replace";
            // 
            // text_FindWhat
            // 
            this.text_FindWhat.Location = new System.Drawing.Point(84, 48);
            this.text_FindWhat.Name = "text_FindWhat";
            this.text_FindWhat.Size = new System.Drawing.Size(221, 22);
            this.text_FindWhat.TabIndex = 2;
            this.text_FindWhat.TextChanged += new System.EventHandler(this.text_FindWhat_TextChanged);
            // 
            // bnt_FindNext
            // 
            this.bnt_FindNext.Location = new System.Drawing.Point(3, 34);
            this.bnt_FindNext.Name = "bnt_FindNext";
            this.bnt_FindNext.Size = new System.Drawing.Size(100, 23);
            this.bnt_FindNext.TabIndex = 3;
            this.bnt_FindNext.Text = "Find Next";
            this.bnt_FindNext.UseVisualStyleBackColor = true;
            this.bnt_FindNext.Click += new System.EventHandler(this.bnt_FindNext_Click);
            // 
            // panel_Find
            // 
            this.panel_Find.Controls.Add(this.btn_ReplaceAll);
            this.panel_Find.Controls.Add(this.btn_Replace);
            this.panel_Find.Controls.Add(this.text_ReplaceFor);
            this.panel_Find.Controls.Add(this.label3);
            this.panel_Find.Controls.Add(this.checkbox_MatchCase);
            this.panel_Find.Controls.Add(this.bnt_FindNext);
            this.panel_Find.Enabled = false;
            this.panel_Find.Location = new System.Drawing.Point(6, 76);
            this.panel_Find.Name = "panel_Find";
            this.panel_Find.Size = new System.Drawing.Size(319, 94);
            this.panel_Find.TabIndex = 4;
            // 
            // btn_ReplaceAll
            // 
            this.btn_ReplaceAll.Location = new System.Drawing.Point(215, 34);
            this.btn_ReplaceAll.Name = "btn_ReplaceAll";
            this.btn_ReplaceAll.Size = new System.Drawing.Size(100, 23);
            this.btn_ReplaceAll.TabIndex = 9;
            this.btn_ReplaceAll.Text = "Replace All";
            this.btn_ReplaceAll.UseVisualStyleBackColor = true;
            this.btn_ReplaceAll.Click += new System.EventHandler(this.btn_ReplaceAll_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Location = new System.Drawing.Point(109, 34);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(100, 23);
            this.btn_Replace.TabIndex = 8;
            this.btn_Replace.Text = "Replace";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // text_ReplaceFor
            // 
            this.text_ReplaceFor.Location = new System.Drawing.Point(78, 0);
            this.text_ReplaceFor.Name = "text_ReplaceFor";
            this.text_ReplaceFor.Size = new System.Drawing.Size(221, 22);
            this.text_ReplaceFor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Replace for:";
            // 
            // checkbox_MatchCase
            // 
            this.checkbox_MatchCase.AutoSize = true;
            this.checkbox_MatchCase.Location = new System.Drawing.Point(3, 63);
            this.checkbox_MatchCase.Name = "checkbox_MatchCase";
            this.checkbox_MatchCase.Size = new System.Drawing.Size(104, 21);
            this.checkbox_MatchCase.TabIndex = 5;
            this.checkbox_MatchCase.Text = "Match Case";
            this.checkbox_MatchCase.UseVisualStyleBackColor = true;
            // 
            // FindPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel_Find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_FindWhat);
            this.Name = "FindPanel";
            this.Size = new System.Drawing.Size(325, 279);
            this.panel_Find.ResumeLayout(false);
            this.panel_Find.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_FindWhat;
        private System.Windows.Forms.Button bnt_FindNext;
        private System.Windows.Forms.Panel panel_Find;
        private System.Windows.Forms.CheckBox checkbox_MatchCase;
        private System.Windows.Forms.Button btn_ReplaceAll;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.TextBox text_ReplaceFor;
        private System.Windows.Forms.Label label3;
    }
}
