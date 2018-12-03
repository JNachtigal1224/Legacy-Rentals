namespace WindowsFormsApp1
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        //Program.manageButton = this;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.signButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.signButton);
            this.panel1.Controls.Add(this.manageButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2143, 128);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(999, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hello, Guest";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createButton.Location = new System.Drawing.Point(1923, 12);
            this.createButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(199, 100);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "CREATE ACCOUNT";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // signButton
            // 
            this.signButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.signButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F);
            this.signButton.ForeColor = System.Drawing.Color.White;
            this.signButton.Location = new System.Drawing.Point(1720, 12);
            this.signButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(199, 100);
            this.signButton.TabIndex = 4;
            this.signButton.Text = "SIGN IN";
            this.signButton.UseVisualStyleBackColor = false;
            this.signButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // manageButton
            // 
            this.manageButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageButton.Location = new System.Drawing.Point(294, 8);
            this.manageButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(248, 104);
            this.manageButton.TabIndex = 2;
            this.manageButton.Text = "Manage";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(32, 8);
            this.homeButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(245, 104);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Location = new System.Drawing.Point(838, 156);
            this.searchButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(491, 93);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legacy Rentals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label5;

    }
}