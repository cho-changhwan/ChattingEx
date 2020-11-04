namespace LoginProgram
{
    partial class MainChat
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
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_memback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.severToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.Color.Tomato;
            this.btn_client.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_client.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_client.Location = new System.Drawing.Point(459, 24);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(90, 497);
            this.btn_client.TabIndex = 6;
            this.btn_client.Text = "Client";
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_server
            // 
            this.btn_server.BackColor = System.Drawing.Color.Tomato;
            this.btn_server.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_server.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_server.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_server.Location = new System.Drawing.Point(0, 24);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(90, 497);
            this.btn_server.TabIndex = 5;
            this.btn_server.Text = "Server";
            this.btn_server.UseVisualStyleBackColor = false;
            this.btn_server.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_memback
            // 
            this.btn_memback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_memback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_memback.Font = new System.Drawing.Font("굴림", 20F);
            this.btn_memback.ForeColor = System.Drawing.Color.Transparent;
            this.btn_memback.Location = new System.Drawing.Point(90, 24);
            this.btn_memback.Name = "btn_memback";
            this.btn_memback.Size = new System.Drawing.Size(369, 60);
            this.btn_memback.TabIndex = 8;
            this.btn_memback.Text = "이전으로";
            this.btn_memback.UseVisualStyleBackColor = false;
            this.btn_memback.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LoginProgram.Properties.Resources._500_F_218216962_k9yStsnt5Z0PVZA8at1IHeXLlSE9cc8C;
            this.pictureBox1.Location = new System.Drawing.Point(90, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.severToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // severToolStripMenuItem
            // 
            this.severToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.severToolStripMenuItem.Name = "severToolStripMenuItem";
            this.severToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.severToolStripMenuItem.Text = "대화모드";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // MainChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 521);
            this.Controls.Add(this.btn_memback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_client);
            this.Controls.Add(this.btn_server);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainChat";
            this.Text = "MainChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainChat_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_memback;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem severToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
    }
}