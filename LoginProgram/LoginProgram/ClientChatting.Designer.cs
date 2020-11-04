namespace LoginProgram
{
    partial class ClientChatting
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
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_port = new System.Windows.Forms.TextBox();
            this.tbox_client = new System.Windows.Forms.TextBox();
            this.tbox_send = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.tbox_ip3 = new System.Windows.Forms.TextBox();
            this.tbox_ip2 = new System.Windows.Forms.TextBox();
            this.tbox_ip1 = new System.Windows.Forms.TextBox();
            this.tbox_ip4 = new System.Windows.Forms.TextBox();
            this.btn_member = new System.Windows.Forms.Button();
            this.lbox_member = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(221, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ip Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(607, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port  :";
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(96, 32);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(100, 21);
            this.tbox_name.TabIndex = 3;
            // 
            // tbox_port
            // 
            this.tbox_port.Location = new System.Drawing.Point(669, 31);
            this.tbox_port.Name = "tbox_port";
            this.tbox_port.Size = new System.Drawing.Size(100, 21);
            this.tbox_port.TabIndex = 4;
            this.tbox_port.Text = "9999";
            // 
            // tbox_client
            // 
            this.tbox_client.Enabled = false;
            this.tbox_client.Font = new System.Drawing.Font("굴림", 12F);
            this.tbox_client.Location = new System.Drawing.Point(16, 98);
            this.tbox_client.Multiline = true;
            this.tbox_client.Name = "tbox_client";
            this.tbox_client.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_client.Size = new System.Drawing.Size(589, 274);
            this.tbox_client.TabIndex = 10;
            // 
            // tbox_send
            // 
            this.tbox_send.Font = new System.Drawing.Font("굴림", 12F);
            this.tbox_send.Location = new System.Drawing.Point(16, 404);
            this.tbox_send.Name = "tbox_send";
            this.tbox_send.Size = new System.Drawing.Size(589, 26);
            this.tbox_send.TabIndex = 11;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.DarkRed;
            this.btn_connect.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_connect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_connect.Location = new System.Drawing.Point(611, 55);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(158, 34);
            this.btn_connect.TabIndex = 13;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Olive;
            this.btn_send.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_send.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_send.Location = new System.Drawing.Point(611, 397);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(158, 34);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tbox_ip3
            // 
            this.tbox_ip3.Location = new System.Drawing.Point(455, 31);
            this.tbox_ip3.Name = "tbox_ip3";
            this.tbox_ip3.Size = new System.Drawing.Size(52, 21);
            this.tbox_ip3.TabIndex = 6;
            this.tbox_ip3.Text = "0";
            // 
            // tbox_ip2
            // 
            this.tbox_ip2.Location = new System.Drawing.Point(397, 31);
            this.tbox_ip2.Name = "tbox_ip2";
            this.tbox_ip2.Size = new System.Drawing.Size(52, 21);
            this.tbox_ip2.TabIndex = 7;
            this.tbox_ip2.Text = "0";
            // 
            // tbox_ip1
            // 
            this.tbox_ip1.Location = new System.Drawing.Point(339, 31);
            this.tbox_ip1.Name = "tbox_ip1";
            this.tbox_ip1.Size = new System.Drawing.Size(52, 21);
            this.tbox_ip1.TabIndex = 8;
            this.tbox_ip1.Text = "127";
            // 
            // tbox_ip4
            // 
            this.tbox_ip4.Location = new System.Drawing.Point(513, 31);
            this.tbox_ip4.Name = "tbox_ip4";
            this.tbox_ip4.Size = new System.Drawing.Size(52, 21);
            this.tbox_ip4.TabIndex = 9;
            this.tbox_ip4.Text = "1";
            // 
            // btn_member
            // 
            this.btn_member.BackColor = System.Drawing.Color.Olive;
            this.btn_member.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_member.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_member.Location = new System.Drawing.Point(611, 338);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(158, 34);
            this.btn_member.TabIndex = 16;
            this.btn_member.Text = "귓속말";
            this.btn_member.UseVisualStyleBackColor = false;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // lbox_member
            // 
            this.lbox_member.FormattingEnabled = true;
            this.lbox_member.ItemHeight = 12;
            this.lbox_member.Location = new System.Drawing.Point(611, 98);
            this.lbox_member.Name = "lbox_member";
            this.lbox_member.Size = new System.Drawing.Size(158, 232);
            this.lbox_member.TabIndex = 17;
            // 
            // ClientChatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 440);
            this.Controls.Add(this.lbox_member);
            this.Controls.Add(this.btn_member);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tbox_send);
            this.Controls.Add(this.tbox_client);
            this.Controls.Add(this.tbox_ip4);
            this.Controls.Add(this.tbox_ip1);
            this.Controls.Add(this.tbox_ip2);
            this.Controls.Add(this.tbox_ip3);
            this.Controls.Add(this.tbox_port);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientChatting";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientChat_FormClosing);
            this.Load += new System.EventHandler(this.ClientChatting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_port;
        private System.Windows.Forms.TextBox tbox_client;
        private System.Windows.Forms.TextBox tbox_send;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tbox_ip3;
        private System.Windows.Forms.TextBox tbox_ip2;
        private System.Windows.Forms.TextBox tbox_ip1;
        private System.Windows.Forms.TextBox tbox_ip4;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.ListBox lbox_member;
    }
}