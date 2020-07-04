namespace project23
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtUni = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtCPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(77, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frist Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(77, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(77, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(77, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "University";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(77, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(77, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirm Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(423, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(423, 80);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(417, 22);
            this.txtFName.TabIndex = 7;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(423, 131);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(417, 22);
            this.txtLName.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(423, 180);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(417, 22);
            this.txtAge.TabIndex = 9;
            // 
            // txtUni
            // 
            this.txtUni.Location = new System.Drawing.Point(423, 232);
            this.txtUni.Name = "txtUni";
            this.txtUni.Size = new System.Drawing.Size(417, 22);
            this.txtUni.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(423, 281);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(417, 22);
            this.txtPass.TabIndex = 11;
            // 
            // txtCPass
            // 
            this.txtCPass.Location = new System.Drawing.Point(423, 332);
            this.txtCPass.Name = "txtCPass";
            this.txtCPass.Size = new System.Drawing.Size(417, 22);
            this.txtCPass.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 630);
            this.Controls.Add(this.txtCPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUni);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtCPass;
    }
}

