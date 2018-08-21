namespace frederico_alexandre_Sec002_COMP212_Ex_01
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
            this.LinkedListValGb = new System.Windows.Forms.GroupBox();
            this.LargestBtn = new System.Windows.Forms.Button();
            this.RemoveFrontBtn = new System.Windows.Forms.Button();
            this.AddFrontBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.LinkListValLb = new System.Windows.Forms.ListBox();
            this.ProductSortedDicGb = new System.Windows.Forms.GroupBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CompanyTb = new System.Windows.Forms.TextBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.IDTb = new System.Windows.Forms.TextBox();
            this.CompanyLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            this.OutputTb = new System.Windows.Forms.TextBox();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.LinkedListValGb.SuspendLayout();
            this.ProductSortedDicGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinkedListValGb
            // 
            this.LinkedListValGb.Controls.Add(this.LargestBtn);
            this.LinkedListValGb.Controls.Add(this.RemoveFrontBtn);
            this.LinkedListValGb.Controls.Add(this.AddFrontBtn);
            this.LinkedListValGb.Controls.Add(this.GenerateBtn);
            this.LinkedListValGb.Controls.Add(this.LinkListValLb);
            this.LinkedListValGb.Location = new System.Drawing.Point(294, 12);
            this.LinkedListValGb.Name = "LinkedListValGb";
            this.LinkedListValGb.Size = new System.Drawing.Size(273, 150);
            this.LinkedListValGb.TabIndex = 0;
            this.LinkedListValGb.TabStop = false;
            this.LinkedListValGb.Text = "LinkedList of Values";
            // 
            // LargestBtn
            // 
            this.LargestBtn.Location = new System.Drawing.Point(140, 117);
            this.LargestBtn.Name = "LargestBtn";
            this.LargestBtn.Size = new System.Drawing.Size(113, 23);
            this.LargestBtn.TabIndex = 4;
            this.LargestBtn.Text = "Largest";
            this.LargestBtn.UseVisualStyleBackColor = true;
            this.LargestBtn.Click += new System.EventHandler(this.LargestBtn_Click);
            // 
            // RemoveFrontBtn
            // 
            this.RemoveFrontBtn.Location = new System.Drawing.Point(140, 88);
            this.RemoveFrontBtn.Name = "RemoveFrontBtn";
            this.RemoveFrontBtn.Size = new System.Drawing.Size(113, 23);
            this.RemoveFrontBtn.TabIndex = 3;
            this.RemoveFrontBtn.Text = "Remove from Front";
            this.RemoveFrontBtn.UseVisualStyleBackColor = true;
            this.RemoveFrontBtn.Click += new System.EventHandler(this.RemoveFrontBtn_Click);
            // 
            // AddFrontBtn
            // 
            this.AddFrontBtn.Location = new System.Drawing.Point(140, 58);
            this.AddFrontBtn.Name = "AddFrontBtn";
            this.AddFrontBtn.Size = new System.Drawing.Size(113, 23);
            this.AddFrontBtn.TabIndex = 2;
            this.AddFrontBtn.Text = "Add at Front";
            this.AddFrontBtn.UseVisualStyleBackColor = true;
            this.AddFrontBtn.Click += new System.EventHandler(this.AddFrontBtn_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(140, 29);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(113, 23);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // LinkListValLb
            // 
            this.LinkListValLb.FormattingEnabled = true;
            this.LinkListValLb.Location = new System.Drawing.Point(7, 20);
            this.LinkListValLb.Name = "LinkListValLb";
            this.LinkListValLb.Size = new System.Drawing.Size(71, 121);
            this.LinkListValLb.TabIndex = 0;
            // 
            // ProductSortedDicGb
            // 
            this.ProductSortedDicGb.Controls.Add(this.PrintBtn);
            this.ProductSortedDicGb.Controls.Add(this.SearchBtn);
            this.ProductSortedDicGb.Controls.Add(this.RemoveBtn);
            this.ProductSortedDicGb.Controls.Add(this.AddBtn);
            this.ProductSortedDicGb.Controls.Add(this.CompanyTb);
            this.ProductSortedDicGb.Controls.Add(this.PriceTb);
            this.ProductSortedDicGb.Controls.Add(this.NameTb);
            this.ProductSortedDicGb.Controls.Add(this.IDTb);
            this.ProductSortedDicGb.Controls.Add(this.CompanyLbl);
            this.ProductSortedDicGb.Controls.Add(this.PriceLbl);
            this.ProductSortedDicGb.Controls.Add(this.NameLbl);
            this.ProductSortedDicGb.Controls.Add(this.IDLbl);
            this.ProductSortedDicGb.Location = new System.Drawing.Point(12, 12);
            this.ProductSortedDicGb.Name = "ProductSortedDicGb";
            this.ProductSortedDicGb.Size = new System.Drawing.Size(265, 150);
            this.ProductSortedDicGb.TabIndex = 1;
            this.ProductSortedDicGb.TabStop = false;
            this.ProductSortedDicGb.Text = "Product Info-Sorted Dictionary";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(184, 113);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(75, 23);
            this.PrintBtn.TabIndex = 11;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(184, 84);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(184, 53);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 9;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(184, 21);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CompanyTb
            // 
            this.CompanyTb.Location = new System.Drawing.Point(73, 115);
            this.CompanyTb.MaxLength = 25;
            this.CompanyTb.Name = "CompanyTb";
            this.CompanyTb.Size = new System.Drawing.Size(100, 20);
            this.CompanyTb.TabIndex = 7;
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(73, 86);
            this.PriceTb.MaxLength = 18;
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(100, 20);
            this.PriceTb.TabIndex = 6;
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(73, 55);
            this.NameTb.MaxLength = 25;
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(100, 20);
            this.NameTb.TabIndex = 5;
            // 
            // IDTb
            // 
            this.IDTb.Location = new System.Drawing.Point(73, 22);
            this.IDTb.MaxLength = 5;
            this.IDTb.Name = "IDTb";
            this.IDTb.Size = new System.Drawing.Size(100, 20);
            this.IDTb.TabIndex = 4;
            // 
            // CompanyLbl
            // 
            this.CompanyLbl.AutoSize = true;
            this.CompanyLbl.Location = new System.Drawing.Point(13, 117);
            this.CompanyLbl.Name = "CompanyLbl";
            this.CompanyLbl.Size = new System.Drawing.Size(54, 13);
            this.CompanyLbl.TabIndex = 3;
            this.CompanyLbl.Text = "Company:";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(13, 88);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(34, 13);
            this.PriceLbl.TabIndex = 2;
            this.PriceLbl.Text = "Price:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(13, 58);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name:";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(13, 29);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(21, 13);
            this.IDLbl.TabIndex = 0;
            this.IDLbl.Text = "ID:";
            // 
            // OutputTb
            // 
            this.OutputTb.AcceptsReturn = true;
            this.OutputTb.Location = new System.Drawing.Point(12, 207);
            this.OutputTb.Multiline = true;
            this.OutputTb.Name = "OutputTb";
            this.OutputTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTb.Size = new System.Drawing.Size(555, 105);
            this.OutputTb.TabIndex = 2;
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Location = new System.Drawing.Point(13, 188);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(39, 13);
            this.OutputLbl.TabIndex = 3;
            this.OutputLbl.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 324);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.OutputTb);
            this.Controls.Add(this.ProductSortedDicGb);
            this.Controls.Add(this.LinkedListValGb);
            this.Name = "Form1";
            this.Text = "TEST 02-COMP212-Sec002";
            this.LinkedListValGb.ResumeLayout(false);
            this.ProductSortedDicGb.ResumeLayout(false);
            this.ProductSortedDicGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LinkedListValGb;
        private System.Windows.Forms.Button LargestBtn;
        private System.Windows.Forms.Button RemoveFrontBtn;
        private System.Windows.Forms.Button AddFrontBtn;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.ListBox LinkListValLb;
        private System.Windows.Forms.GroupBox ProductSortedDicGb;
        private System.Windows.Forms.TextBox OutputTb;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.Label CompanyLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox CompanyTb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox IDTb;
    }
}

