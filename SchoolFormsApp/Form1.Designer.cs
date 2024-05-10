namespace SchoolFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtState = new TextBox();
            txtZip = new TextBox();
            txtPhone = new TextBox();
            txtTwitter = new TextBox();
            btnPushToTest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 80);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "School Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 119);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 155);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 3;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 189);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "State";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 230);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 5;
            label5.Text = "Zip";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 260);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 6;
            label6.Text = "Phone";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 298);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 7;
            label7.Text = "Twitter";
            label7.Click += label7_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(194, 152);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(194, 116);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtState
            // 
            txtState.Location = new Point(194, 186);
            txtState.Name = "txtState";
            txtState.Size = new Size(100, 23);
            txtState.TabIndex = 11;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(194, 222);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(100, 23);
            txtZip.TabIndex = 12;
            txtZip.TextChanged += textBox5_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(194, 260);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 13;
            // 
            // txtTwitter
            // 
            txtTwitter.Location = new Point(194, 290);
            txtTwitter.Name = "txtTwitter";
            txtTwitter.Size = new Size(100, 23);
            txtTwitter.TabIndex = 14;
            // 
            // btnPushToTest
            // 
            btnPushToTest.Location = new Point(194, 376);
            btnPushToTest.Name = "btnPushToTest";
            btnPushToTest.Size = new Size(100, 23);
            btnPushToTest.TabIndex = 15;
            btnPushToTest.Text = "Push To Test";
            btnPushToTest.UseVisualStyleBackColor = true;
            btnPushToTest.Click += btnPushToTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(btnPushToTest);
            Controls.Add(txtTwitter);
            Controls.Add(txtPhone);
            Controls.Add(txtZip);
            Controls.Add(txtState);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtState;
        private TextBox txtZip;
        private TextBox txtPhone;
        private TextBox txtTwitter;
        private Button btnPushToTest;
    }
}
