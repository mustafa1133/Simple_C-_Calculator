namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.num1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.opDivide = new System.Windows.Forms.Button();
            this.opAllClear = new System.Windows.Forms.Button();
            this.opClear = new System.Windows.Forms.Button();
            this.opMultiply = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.opMinus = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.opEquals = new System.Windows.Forms.Button();
            this.opPlus = new System.Windows.Forms.Button();
            this.opPoint = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textbox_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(13, 96);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(40, 40);
            this.num1.TabIndex = 0;
            this.num1.Text = "7";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "8";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(105, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "9";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // opDivide
            // 
            this.opDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opDivide.Location = new System.Drawing.Point(151, 96);
            this.opDivide.Name = "opDivide";
            this.opDivide.Size = new System.Drawing.Size(40, 40);
            this.opDivide.TabIndex = 3;
            this.opDivide.Text = "/";
            this.opDivide.UseVisualStyleBackColor = true;
            this.opDivide.Click += new System.EventHandler(this.operator_click);
            // 
            // opAllClear
            // 
            this.opAllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opAllClear.Location = new System.Drawing.Point(197, 96);
            this.opAllClear.Name = "opAllClear";
            this.opAllClear.Size = new System.Drawing.Size(50, 40);
            this.opAllClear.TabIndex = 4;
            this.opAllClear.Text = "CE";
            this.opAllClear.UseVisualStyleBackColor = true;
            this.opAllClear.Click += new System.EventHandler(this.opAllClear_Click);
            // 
            // opClear
            // 
            this.opClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opClear.Location = new System.Drawing.Point(197, 142);
            this.opClear.Name = "opClear";
            this.opClear.Size = new System.Drawing.Size(50, 40);
            this.opClear.TabIndex = 9;
            this.opClear.Text = "C";
            this.opClear.UseVisualStyleBackColor = true;
            this.opClear.Click += new System.EventHandler(this.opClear_Click);
            // 
            // opMultiply
            // 
            this.opMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opMultiply.Location = new System.Drawing.Point(151, 142);
            this.opMultiply.Name = "opMultiply";
            this.opMultiply.Size = new System.Drawing.Size(40, 40);
            this.opMultiply.TabIndex = 8;
            this.opMultiply.Text = "*";
            this.opMultiply.UseVisualStyleBackColor = true;
            this.opMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(105, 142);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 7;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(59, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 6;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(13, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 5;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // opMinus
            // 
            this.opMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opMinus.Location = new System.Drawing.Point(151, 188);
            this.opMinus.Name = "opMinus";
            this.opMinus.Size = new System.Drawing.Size(40, 40);
            this.opMinus.TabIndex = 13;
            this.opMinus.Text = "-";
            this.opMinus.UseVisualStyleBackColor = true;
            this.opMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(105, 188);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 12;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(59, 188);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 11;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(13, 188);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 40);
            this.button14.TabIndex = 10;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_click);
            // 
            // opEquals
            // 
            this.opEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opEquals.Location = new System.Drawing.Point(197, 188);
            this.opEquals.Name = "opEquals";
            this.opEquals.Size = new System.Drawing.Size(50, 86);
            this.opEquals.TabIndex = 19;
            this.opEquals.Text = "=";
            this.opEquals.UseVisualStyleBackColor = true;
            this.opEquals.Click += new System.EventHandler(this.opEquals_Click);
            // 
            // opPlus
            // 
            this.opPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opPlus.Location = new System.Drawing.Point(151, 234);
            this.opPlus.Name = "opPlus";
            this.opPlus.Size = new System.Drawing.Size(40, 40);
            this.opPlus.TabIndex = 18;
            this.opPlus.Text = "+";
            this.opPlus.UseVisualStyleBackColor = true;
            this.opPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // opPoint
            // 
            this.opPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opPoint.Location = new System.Drawing.Point(105, 234);
            this.opPoint.Name = "opPoint";
            this.opPoint.Size = new System.Drawing.Size(40, 40);
            this.opPoint.TabIndex = 17;
            this.opPoint.Text = ".";
            this.opPoint.UseVisualStyleBackColor = true;
            this.opPoint.Click += new System.EventHandler(this.button_click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(13, 234);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(86, 40);
            this.num0.TabIndex = 15;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.button_click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(13, 70);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(234, 29);
            this.textBox.TabIndex = 20;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textbox_Result
            // 
            this.textbox_Result.AutoSize = true;
            this.textbox_Result.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Result.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textbox_Result.Location = new System.Drawing.Point(12, 43);
            this.textbox_Result.Name = "textbox_Result";
            this.textbox_Result.Size = new System.Drawing.Size(0, 24);
            this.textbox_Result.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 313);
            this.Controls.Add(this.textbox_Result);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.opEquals);
            this.Controls.Add(this.opPlus);
            this.Controls.Add(this.opPoint);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.opMinus);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.opClear);
            this.Controls.Add(this.opMultiply);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.opAllClear);
            this.Controls.Add(this.opDivide);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button opDivide;
        private System.Windows.Forms.Button opAllClear;
        private System.Windows.Forms.Button opClear;
        private System.Windows.Forms.Button opMultiply;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button opMinus;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button opEquals;
        private System.Windows.Forms.Button opPlus;
        private System.Windows.Forms.Button opPoint;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label textbox_Result;
    }
}

