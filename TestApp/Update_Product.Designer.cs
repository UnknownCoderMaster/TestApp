namespace TestApp
{
    partial class Update_Product
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
            panel7 = new Panel();
            button2 = new Button();
            updateButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(button2);
            panel7.Controls.Add(updateButton);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(textBox2);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(627, 449);
            panel7.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(41, 128, 185);
            button2.Location = new Point(329, 373);
            button2.Name = "button2";
            button2.Size = new Size(119, 39);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(41, 128, 185);
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(118, 373);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(119, 39);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(41, 128, 185);
            textBox1.Location = new Point(118, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(41, 128, 185);
            textBox2.Location = new Point(118, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 27);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(113, 218);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 0;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(118, 308);
            label5.Name = "label5";
            label5.Size = new Size(0, 16);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(118, 183);
            label6.Name = "label6";
            label6.Size = new Size(0, 16);
            label6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(41, 128, 185);
            label7.Location = new Point(113, 99);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 0;
            label7.Text = "Product Name";
            // 
            // Update_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(panel7);
            MaximumSize = new Size(651, 489);
            MinimumSize = new Size(651, 489);
            Name = "Update_Product";
            Text = "Update Product";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button button2;
        private Button updateButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}