namespace project16
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.cal = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(138, 113);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Number1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(138, 212);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(74, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nuumber2";
            this.lbl2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(358, 113);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(358, 207);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 3;
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(406, 505);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 4;
            this.cal.Text = "Calculate";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.Cal_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(249, 366);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(78, 17);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Summation";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(434, 366);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(80, 17);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Subtraction";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(573, 365);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(89, 17);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "Multiplication";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(789, 365);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(57, 17);
            this.lbl6.TabIndex = 8;
            this.lbl6.Text = "Division";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 560);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
    }
}

