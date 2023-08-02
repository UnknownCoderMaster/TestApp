namespace TestApp
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            myStoreButton = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            logoutButton = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel6 = new Panel();
            button4 = new Button();
            CreateButton = new Button();
            Price = new TextBox();
            ProductName = new TextBox();
            label3 = new Label();
            errorPrice = new Label();
            errorName = new Label();
            label2 = new Label();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(41, 128, 185);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(214, 0);
            sidebar.MinimumSize = new Size(59, 471);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(214, 471);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 28);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.hamburger__1_;
            menuButton.Location = new Point(13, 26);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(26, 25);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 50);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 128, 185);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.home_icon2;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-2, -5);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(222, 59);
            button1.TabIndex = 2;
            button1.Text = "           Add product";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(myStoreButton);
            panel3.Location = new Point(3, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 50);
            panel3.TabIndex = 2;
            // 
            // myStoreButton
            // 
            myStoreButton.BackColor = Color.FromArgb(41, 128, 185);
            myStoreButton.FlatStyle = FlatStyle.Flat;
            myStoreButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            myStoreButton.ForeColor = Color.White;
            myStoreButton.Image = Properties.Resources.white_user_icon1;
            myStoreButton.ImageAlign = ContentAlignment.MiddleLeft;
            myStoreButton.Location = new Point(-3, -6);
            myStoreButton.Name = "myStoreButton";
            myStoreButton.Padding = new Padding(10, 0, 0, 0);
            myStoreButton.Size = new Size(222, 59);
            myStoreButton.TabIndex = 2;
            myStoreButton.Text = "           My Store";
            myStoreButton.TextAlign = ContentAlignment.MiddleLeft;
            myStoreButton.UseVisualStyleBackColor = false;
            myStoreButton.Click += myStoreButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 50);
            panel4.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(41, 128, 185);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.info;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-2, -5);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(222, 59);
            button3.TabIndex = 2;
            button3.Text = "           About";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(logoutButton);
            panel5.Location = new Point(3, 258);
            panel5.Name = "panel5";
            panel5.Size = new Size(211, 50);
            panel5.TabIndex = 3;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(41, 128, 185);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = Properties.Resources.logout;
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(-2, -6);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(10, 0, 0, 0);
            logoutButton.Size = new Size(222, 59);
            logoutButton.TabIndex = 2;
            logoutButton.Text = "           Log out";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(214, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(655, 464);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Controls.Add(CreateButton);
            panel6.Controls.Add(Price);
            panel6.Controls.Add(ProductName);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(errorPrice);
            panel6.Controls.Add(errorName);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(627, 456);
            panel6.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(41, 128, 185);
            button4.Location = new Point(329, 373);
            button4.Name = "button4";
            button4.Size = new Size(119, 39);
            button4.TabIndex = 2;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(41, 128, 185);
            CreateButton.FlatStyle = FlatStyle.Popup;
            CreateButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateButton.ForeColor = Color.White;
            CreateButton.Location = new Point(118, 373);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(119, 39);
            CreateButton.TabIndex = 2;
            CreateButton.Text = "Add";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // Price
            // 
            Price.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Price.ForeColor = Color.FromArgb(41, 128, 185);
            Price.Location = new Point(118, 278);
            Price.Name = "Price";
            Price.Size = new Size(330, 27);
            Price.TabIndex = 1;
            // 
            // ProductName
            // 
            ProductName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductName.ForeColor = Color.FromArgb(41, 128, 185);
            ProductName.Location = new Point(118, 153);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(330, 27);
            ProductName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(41, 128, 185);
            label3.Location = new Point(113, 218);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 0;
            label3.Text = "Price";
            // 
            // errorPrice
            // 
            errorPrice.AutoSize = true;
            errorPrice.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorPrice.ForeColor = Color.Red;
            errorPrice.Location = new Point(118, 308);
            errorPrice.Name = "errorPrice";
            errorPrice.Size = new Size(0, 16);
            errorPrice.TabIndex = 0;
            // 
            // errorName
            // 
            errorName.AutoSize = true;
            errorName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorName.ForeColor = Color.Red;
            errorName.Location = new Point(118, 183);
            errorName.Name = "errorName";
            errorName.Size = new Size(0, 16);
            errorName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(113, 99);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 0;
            label2.Text = "Product Name";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 464);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(sidebar);
            Name = "Home";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private Button myStoreButton;
        private Panel panel5;
        private Button logoutButton;
        private Panel panel4;
        private Button button3;
        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
        private Button button4;
        private Button CreateButton;
        private TextBox Price;
        private TextBox ProductName;
        private Label label3;
        private Label label2;
        private Label errorPrice;
        private Label errorName;
    }
}