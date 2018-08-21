namespace BooksQueryDriver
{
    partial class BookService
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonFirstQuestion = new System.Windows.Forms.Button();
            this.buttonSecondQuestion = new System.Windows.Forms.Button();
            this.buttonThirdQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 112);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(655, 258);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonFirstQuestion
            // 
            this.buttonFirstQuestion.Location = new System.Drawing.Point(48, 43);
            this.buttonFirstQuestion.Name = "buttonFirstQuestion";
            this.buttonFirstQuestion.Size = new System.Drawing.Size(112, 23);
            this.buttonFirstQuestion.TabIndex = 1;
            this.buttonFirstQuestion.Text = "Question One";
            this.buttonFirstQuestion.UseVisualStyleBackColor = true;
            this.buttonFirstQuestion.Click += new System.EventHandler(this.ButtonFirstQuestion_Click);
            // 
            // buttonSecondQuestion
            // 
            this.buttonSecondQuestion.Location = new System.Drawing.Point(296, 43);
            this.buttonSecondQuestion.Name = "buttonSecondQuestion";
            this.buttonSecondQuestion.Size = new System.Drawing.Size(129, 23);
            this.buttonSecondQuestion.TabIndex = 2;
            this.buttonSecondQuestion.Text = "Question Two";
            this.buttonSecondQuestion.UseVisualStyleBackColor = true;
            this.buttonSecondQuestion.Click += new System.EventHandler(this.ButtonSecondQuestion_Click);
            // 
            // buttonThirdQuestion
            // 
            this.buttonThirdQuestion.Location = new System.Drawing.Point(535, 42);
            this.buttonThirdQuestion.Name = "buttonThirdQuestion";
            this.buttonThirdQuestion.Size = new System.Drawing.Size(120, 23);
            this.buttonThirdQuestion.TabIndex = 3;
            this.buttonThirdQuestion.Text = "Question Three";
            this.buttonThirdQuestion.UseVisualStyleBackColor = true;
            this.buttonThirdQuestion.Click += new System.EventHandler(this.ButtonThirdQuestion_Click);
            // 
            // BookService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 396);
            this.Controls.Add(this.buttonThirdQuestion);
            this.Controls.Add(this.buttonSecondQuestion);
            this.Controls.Add(this.buttonFirstQuestion);
            this.Controls.Add(this.dataGridView);
            this.Name = "BookService";
            this.Text = "Books - Frederico Alexandre 300974435";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonFirstQuestion;
        private System.Windows.Forms.Button buttonSecondQuestion;
        private System.Windows.Forms.Button buttonThirdQuestion;
    }
}

