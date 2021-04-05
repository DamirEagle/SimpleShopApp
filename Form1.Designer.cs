
namespace TestTaskFromNikita
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonShopping = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelMode = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.buttonShopping);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 588);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buttonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(0, 140);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.buttonProfile.Size = new System.Drawing.Size(251, 60);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "PROFILE";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonShopping
            // 
            this.buttonShopping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShopping.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShopping.FlatAppearance.BorderSize = 0;
            this.buttonShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buttonShopping.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonShopping.Image = ((System.Drawing.Image)(resources.GetObject("buttonShopping.Image")));
            this.buttonShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShopping.Location = new System.Drawing.Point(0, 80);
            this.buttonShopping.Name = "buttonShopping";
            this.buttonShopping.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.buttonShopping.Size = new System.Drawing.Size(251, 60);
            this.buttonShopping.TabIndex = 3;
            this.buttonShopping.Text = "SHOPPING";
            this.buttonShopping.UseVisualStyleBackColor = true;
            this.buttonShopping.Click += new System.EventHandler(this.buttonShopping_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkCyan;
            this.panelTitleBar.Controls.Add(this.labelMode);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(251, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1097, 80);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // labelMode
            // 
            this.labelMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMode.AutoSize = true;
            this.labelMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMode.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.Location = new System.Drawing.Point(515, 23);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(79, 31);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "Home";
            this.labelMode.Click += new System.EventHandler(this.labelMode_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContainer.BackgroundImage")));
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(251, 80);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1097, 508);
            this.panelContainer.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 588);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1316, 615);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonShopping;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panelContainer;
    }
}

