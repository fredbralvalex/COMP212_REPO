namespace Frederico_Alexandre_Lab06_Ex01
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
            this.GenerateIntBtn = new System.Windows.Forms.Button();
            this.ArrayListElements = new System.Windows.Forms.TextBox();
            this.GenerateDoubleBtn = new System.Windows.Forms.Button();
            this.FindNumberTextBox = new System.Windows.Forms.TextBox();
            this.FindNumberBtn = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.labelElements = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateIntBtn
            // 
            this.GenerateIntBtn.Location = new System.Drawing.Point(12, 12);
            this.GenerateIntBtn.Name = "GenerateIntBtn";
            this.GenerateIntBtn.Size = new System.Drawing.Size(154, 23);
            this.GenerateIntBtn.TabIndex = 0;
            this.GenerateIntBtn.Text = "Generate Int Array Elements";
            this.GenerateIntBtn.UseVisualStyleBackColor = true;
            this.GenerateIntBtn.Click += new System.EventHandler(this.GenerateIntBtn_Click);
            // 
            // ArrayListElements
            // 
            this.ArrayListElements.Enabled = false;
            this.ArrayListElements.Location = new System.Drawing.Point(13, 66);
            this.ArrayListElements.Name = "ArrayListElements";
            this.ArrayListElements.Size = new System.Drawing.Size(374, 20);
            this.ArrayListElements.TabIndex = 1;
            this.ArrayListElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenerateDoubleBtn
            // 
            this.GenerateDoubleBtn.Location = new System.Drawing.Point(212, 11);
            this.GenerateDoubleBtn.Name = "GenerateDoubleBtn";
            this.GenerateDoubleBtn.Size = new System.Drawing.Size(175, 23);
            this.GenerateDoubleBtn.TabIndex = 2;
            this.GenerateDoubleBtn.Text = "Generate Double Array Elements";
            this.GenerateDoubleBtn.UseVisualStyleBackColor = true;
            this.GenerateDoubleBtn.Click += new System.EventHandler(this.GenerateDoubleBtn_Click);
            // 
            // FindNumberTextBox
            // 
            this.FindNumberTextBox.Location = new System.Drawing.Point(164, 99);
            this.FindNumberTextBox.MaxLength = 5;
            this.FindNumberTextBox.Name = "FindNumberTextBox";
            this.FindNumberTextBox.Size = new System.Drawing.Size(60, 20);
            this.FindNumberTextBox.TabIndex = 3;
            this.FindNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FindNumberBtn
            // 
            this.FindNumberBtn.Location = new System.Drawing.Point(68, 98);
            this.FindNumberBtn.Name = "FindNumberBtn";
            this.FindNumberBtn.Size = new System.Drawing.Size(75, 23);
            this.FindNumberBtn.TabIndex = 4;
            this.FindNumberBtn.Text = "Search";
            this.FindNumberBtn.UseVisualStyleBackColor = true;
            this.FindNumberBtn.Click += new System.EventHandler(this.FindNumberBtn_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.ResultTextBox.Location = new System.Drawing.Point(68, 137);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(232, 13);
            this.ResultTextBox.TabIndex = 5;
            // 
            // labelElements
            // 
            this.labelElements.AutoSize = true;
            this.labelElements.Location = new System.Drawing.Point(13, 47);
            this.labelElements.Name = "labelElements";
            this.labelElements.Size = new System.Drawing.Size(50, 13);
            this.labelElements.TabIndex = 6;
            this.labelElements.Text = "Elements";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 170);
            this.Controls.Add(this.labelElements);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.FindNumberBtn);
            this.Controls.Add(this.FindNumberTextBox);
            this.Controls.Add(this.GenerateDoubleBtn);
            this.Controls.Add(this.ArrayListElements);
            this.Controls.Add(this.GenerateIntBtn);
            this.Name = "Form1";
            this.Text = "Frederico Alexandre - 300974435";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateIntBtn;
        private System.Windows.Forms.TextBox ArrayListElements;
        private System.Windows.Forms.Button GenerateDoubleBtn;
        private System.Windows.Forms.TextBox FindNumberTextBox;
        private System.Windows.Forms.Button FindNumberBtn;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label labelElements;
    }
}

