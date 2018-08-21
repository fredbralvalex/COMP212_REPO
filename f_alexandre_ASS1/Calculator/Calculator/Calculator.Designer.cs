namespace Calculator
{
    partial class Calculator
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
            this.visor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnslash = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btneql = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visor
            // 
            this.visor.BackColor = System.Drawing.SystemColors.Window;
            this.visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visor.Location = new System.Drawing.Point(20, 19);
            this.visor.MaxLength = 16;
            this.visor.Name = "visor";
            this.visor.ReadOnly = true;
            this.visor.Size = new System.Drawing.Size(405, 26);
            this.visor.TabIndex = 0;
            this.visor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnback, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnsqrt, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnlog, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnx, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnplus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnminus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnmult, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnslash, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btneql, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btndot, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 168);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Image = global::Calculator.Properties.Resources.back;
            this.btnback.Location = new System.Drawing.Point(327, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 36);
            this.btnback.TabIndex = 17;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnsqrt
            // 
            this.btnsqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsqrt.Image = global::Calculator.Properties.Resources.sqrt;
            this.btnsqrt.Location = new System.Drawing.Point(327, 45);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(75, 36);
            this.btnsqrt.TabIndex = 18;
            this.btnsqrt.UseVisualStyleBackColor = true;
            this.btnsqrt.Click += new System.EventHandler(this.btnsqrt_Click);
            // 
            // btnlog
            // 
            this.btnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.Location = new System.Drawing.Point(327, 87);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(75, 36);
            this.btnlog.TabIndex = 19;
            this.btnlog.Text = "log";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnx
            // 
            this.btnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.Location = new System.Drawing.Point(327, 129);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(75, 36);
            this.btnx.TabIndex = 20;
            this.btnx.Text = "1/x";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(246, 3);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 36);
            this.btnplus.TabIndex = 13;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(246, 45);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 36);
            this.btnminus.TabIndex = 14;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmult
            // 
            this.btnmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.Location = new System.Drawing.Point(246, 87);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(75, 36);
            this.btnmult.TabIndex = 15;
            this.btnmult.Text = "*";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnslash
            // 
            this.btnslash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnslash.Location = new System.Drawing.Point(246, 129);
            this.btnslash.Name = "btnslash";
            this.btnslash.Size = new System.Drawing.Size(75, 36);
            this.btnslash.TabIndex = 16;
            this.btnslash.Text = "/";
            this.btnslash.UseVisualStyleBackColor = true;
            this.btnslash.Click += new System.EventHandler(this.btnslash_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 36);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 45);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 36);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 87);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 36);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(165, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 36);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(165, 45);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 36);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(165, 87);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 36);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btneql
            // 
            this.btneql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneql.Location = new System.Drawing.Point(165, 129);
            this.btneql.Name = "btneql";
            this.btneql.Size = new System.Drawing.Size(75, 36);
            this.btneql.TabIndex = 12;
            this.btneql.Text = "=";
            this.btneql.UseVisualStyleBackColor = true;
            this.btneql.Click += new System.EventHandler(this.btneql_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(3, 129);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 36);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(84, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 36);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(84, 45);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 36);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(84, 87);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 36);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btndot
            // 
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(84, 129);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(75, 36);
            this.btndot.TabIndex = 11;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btnce
            // 
            this.btnce.Location = new System.Drawing.Point(349, 53);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(75, 23);
            this.btnce.TabIndex = 0;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.visor);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox visor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnslash;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btneql;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnce;
    }
}

