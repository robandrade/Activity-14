namespace Activity_14
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
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.brownRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giftCheckBox = new System.Windows.Forms.CheckBox();
            this.shippingCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shirtList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(22, 105);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 2;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(22, 128);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteRadioButton.TabIndex = 3;
            this.whiteRadioButton.TabStop = true;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // brownRadioButton
            // 
            this.brownRadioButton.AutoSize = true;
            this.brownRadioButton.Location = new System.Drawing.Point(22, 151);
            this.brownRadioButton.Name = "brownRadioButton";
            this.brownRadioButton.Size = new System.Drawing.Size(55, 17);
            this.brownRadioButton.TabIndex = 4;
            this.brownRadioButton.TabStop = true;
            this.brownRadioButton.Text = "Brown";
            this.brownRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Extras:";
            // 
            // giftCheckBox
            // 
            this.giftCheckBox.AutoSize = true;
            this.giftCheckBox.Location = new System.Drawing.Point(151, 105);
            this.giftCheckBox.Name = "giftCheckBox";
            this.giftCheckBox.Size = new System.Drawing.Size(85, 17);
            this.giftCheckBox.TabIndex = 7;
            this.giftCheckBox.Text = "Is this a gift?";
            this.giftCheckBox.UseVisualStyleBackColor = true;
            // 
            // shippingCheckBox
            // 
            this.shippingCheckBox.AutoSize = true;
            this.shippingCheckBox.Location = new System.Drawing.Point(151, 128);
            this.shippingCheckBox.Name = "shippingCheckBox";
            this.shippingCheckBox.Size = new System.Drawing.Size(167, 17);
            this.shippingCheckBox.TabIndex = 8;
            this.shippingCheckBox.Text = "Express Shipping? (2-3 Days):";
            this.shippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shirtList
            // 
            this.shirtList.FormattingEnabled = true;
            this.shirtList.Items.AddRange(new object[] {
            "T-Shirt",
            "Long Sleeve Shirt",
            "Polo Shirt",
            "Button Up Shirt"});
            this.shirtList.Location = new System.Drawing.Point(22, 12);
            this.shirtList.Name = "shirtList";
            this.shirtList.Size = new System.Drawing.Size(120, 69);
            this.shirtList.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Information:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shirtList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shippingCheckBox);
            this.Controls.Add(this.giftCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brownRadioButton);
            this.Controls.Add(this.whiteRadioButton);
            this.Controls.Add(this.blackRadioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton brownRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox giftCheckBox;
        private System.Windows.Forms.CheckBox shippingCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox shirtList;
        private System.Windows.Forms.Label label4;
    }
}

