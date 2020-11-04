namespace LoginProgram
{
    partial class ServerChatting
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
            this.tbox_server = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_server
            // 
            this.tbox_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_server.Enabled = false;
            this.tbox_server.Location = new System.Drawing.Point(0, 0);
            this.tbox_server.Multiline = true;
            this.tbox_server.Name = "tbox_server";
            this.tbox_server.Size = new System.Drawing.Size(630, 390);
            this.tbox_server.TabIndex = 0;
            this.tbox_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerChatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 390);
            this.Controls.Add(this.tbox_server);
            this.Name = "ServerChatting";
            this.Text = "server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerChat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_server;
    }
}