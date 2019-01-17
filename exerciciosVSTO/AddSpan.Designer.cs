namespace exerciciosVSTO
{
    partial class AddSpan
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_AddSpan = new System.Windows.Forms.TextBox();
            this.btn_AddSpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Span:";
            // 
            // text_AddSpan
            // 
            this.text_AddSpan.Location = new System.Drawing.Point(54, 30);
            this.text_AddSpan.Name = "text_AddSpan";
            this.text_AddSpan.Size = new System.Drawing.Size(209, 22);
            this.text_AddSpan.TabIndex = 1;
            // 
            // btn_AddSpan
            // 
            this.btn_AddSpan.Location = new System.Drawing.Point(269, 30);
            this.btn_AddSpan.Name = "btn_AddSpan";
            this.btn_AddSpan.Size = new System.Drawing.Size(40, 23);
            this.btn_AddSpan.TabIndex = 2;
            this.btn_AddSpan.Text = "OK";
            this.btn_AddSpan.UseVisualStyleBackColor = true;
            this.btn_AddSpan.Click += new System.EventHandler(this.btn_AddSpan_Click);
            // 
            // AddSpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 83);
            this.Controls.Add(this.btn_AddSpan);
            this.Controls.Add(this.text_AddSpan);
            this.Controls.Add(this.label1);
            this.Name = "AddSpan";
            this.Text = "AddSpan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_AddSpan;
        private System.Windows.Forms.Button btn_AddSpan;
    }
}