namespace LoginProgram
{
    partial class Member
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
            this.lb_mId = new System.Windows.Forms.Label();
            this.lb_mPhone = new System.Windows.Forms.Label();
            this.btn_mDelete = new System.Windows.Forms.Button();
            this.btn_mUpdate = new System.Windows.Forms.Button();
            this.tbox_mId = new System.Windows.Forms.TextBox();
            this.tbox_mPhone = new System.Windows.Forms.TextBox();
            this.btn_chat = new System.Windows.Forms.Button();
            this.btn_mInsert = new System.Windows.Forms.Button();
            this.tbox_mPasswd = new System.Windows.Forms.TextBox();
            this.lb_mPasswd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_all = new System.Windows.Forms.Button();
            this.datag_view1 = new System.Windows.Forms.DataGridView();
            this.btn_allmem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datag_view1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_mId
            // 
            this.lb_mId.AutoSize = true;
            this.lb_mId.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_mId.Location = new System.Drawing.Point(47, 91);
            this.lb_mId.Name = "lb_mId";
            this.lb_mId.Size = new System.Drawing.Size(83, 20);
            this.lb_mId.TabIndex = 0;
            this.lb_mId.Text = "아이디 :";
            // 
            // lb_mPhone
            // 
            this.lb_mPhone.AutoSize = true;
            this.lb_mPhone.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_mPhone.Location = new System.Drawing.Point(47, 231);
            this.lb_mPhone.Name = "lb_mPhone";
            this.lb_mPhone.Size = new System.Drawing.Size(90, 20);
            this.lb_mPhone.TabIndex = 1;
            this.lb_mPhone.Text = "핸드폰 : ";
            // 
            // btn_mDelete
            // 
            this.btn_mDelete.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mDelete.ForeColor = System.Drawing.Color.Brown;
            this.btn_mDelete.Location = new System.Drawing.Point(160, 288);
            this.btn_mDelete.Name = "btn_mDelete";
            this.btn_mDelete.Size = new System.Drawing.Size(126, 59);
            this.btn_mDelete.TabIndex = 3;
            this.btn_mDelete.Text = "회원삭제";
            this.btn_mDelete.UseVisualStyleBackColor = true;
            this.btn_mDelete.Click += new System.EventHandler(this.btn_mDelete_Click);
            // 
            // btn_mUpdate
            // 
            this.btn_mUpdate.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mUpdate.ForeColor = System.Drawing.Color.Brown;
            this.btn_mUpdate.Location = new System.Drawing.Point(302, 288);
            this.btn_mUpdate.Name = "btn_mUpdate";
            this.btn_mUpdate.Size = new System.Drawing.Size(126, 59);
            this.btn_mUpdate.TabIndex = 4;
            this.btn_mUpdate.Text = "회원수정";
            this.btn_mUpdate.UseVisualStyleBackColor = true;
            this.btn_mUpdate.Click += new System.EventHandler(this.btn_mUpdate_Click);
            // 
            // tbox_mId
            // 
            this.tbox_mId.Font = new System.Drawing.Font("굴림", 15F);
            this.tbox_mId.Location = new System.Drawing.Point(182, 81);
            this.tbox_mId.Name = "tbox_mId";
            this.tbox_mId.Size = new System.Drawing.Size(205, 30);
            this.tbox_mId.TabIndex = 5;
            // 
            // tbox_mPhone
            // 
            this.tbox_mPhone.Font = new System.Drawing.Font("굴림", 15F);
            this.tbox_mPhone.Location = new System.Drawing.Point(182, 231);
            this.tbox_mPhone.Name = "tbox_mPhone";
            this.tbox_mPhone.Size = new System.Drawing.Size(205, 30);
            this.tbox_mPhone.TabIndex = 6;
            // 
            // btn_chat
            // 
            this.btn_chat.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_chat.ForeColor = System.Drawing.Color.Brown;
            this.btn_chat.Location = new System.Drawing.Point(302, 353);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(126, 59);
            this.btn_chat.TabIndex = 8;
            this.btn_chat.Text = "채팅";
            this.btn_chat.UseVisualStyleBackColor = true;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            // 
            // btn_mInsert
            // 
            this.btn_mInsert.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mInsert.ForeColor = System.Drawing.Color.Brown;
            this.btn_mInsert.Location = new System.Drawing.Point(15, 288);
            this.btn_mInsert.Name = "btn_mInsert";
            this.btn_mInsert.Size = new System.Drawing.Size(126, 59);
            this.btn_mInsert.TabIndex = 15;
            this.btn_mInsert.Text = "회원추가";
            this.btn_mInsert.UseVisualStyleBackColor = true;
            this.btn_mInsert.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbox_mPasswd
            // 
            this.tbox_mPasswd.Font = new System.Drawing.Font("굴림", 15F);
            this.tbox_mPasswd.Location = new System.Drawing.Point(182, 152);
            this.tbox_mPasswd.Name = "tbox_mPasswd";
            this.tbox_mPasswd.PasswordChar = '*';
            this.tbox_mPasswd.Size = new System.Drawing.Size(205, 30);
            this.tbox_mPasswd.TabIndex = 17;
            // 
            // lb_mPasswd
            // 
            this.lb_mPasswd.AutoSize = true;
            this.lb_mPasswd.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_mPasswd.Location = new System.Drawing.Point(27, 152);
            this.lb_mPasswd.Name = "lb_mPasswd";
            this.lb_mPasswd.Size = new System.Drawing.Size(110, 20);
            this.lb_mPasswd.TabIndex = 16;
            this.lb_mPasswd.Text = "비밀번호 : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 64);
            this.panel1.TabIndex = 20;
            // 
            // btn_all
            // 
            this.btn_all.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_all.ForeColor = System.Drawing.Color.Brown;
            this.btn_all.Location = new System.Drawing.Point(15, 353);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(126, 59);
            this.btn_all.TabIndex = 21;
            this.btn_all.Text = "회원찾기";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // datag_view1
            // 
            this.datag_view1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datag_view1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datag_view1.Location = new System.Drawing.Point(465, 70);
            this.datag_view1.Name = "datag_view1";
            this.datag_view1.RowTemplate.Height = 23;
            this.datag_view1.Size = new System.Drawing.Size(447, 342);
            this.datag_view1.TabIndex = 22;
            this.datag_view1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datag_view1_MouseClick);
            // 
            // btn_allmem
            // 
            this.btn_allmem.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_allmem.ForeColor = System.Drawing.Color.Brown;
            this.btn_allmem.Location = new System.Drawing.Point(160, 353);
            this.btn_allmem.Name = "btn_allmem";
            this.btn_allmem.Size = new System.Drawing.Size(126, 59);
            this.btn_allmem.TabIndex = 23;
            this.btn_allmem.Text = "전체회원";
            this.btn_allmem.UseVisualStyleBackColor = true;
            this.btn_allmem.Click += new System.EventHandler(this.btn_allmem_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 429);
            this.Controls.Add(this.btn_allmem);
            this.Controls.Add(this.datag_view1);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbox_mPasswd);
            this.Controls.Add(this.lb_mPasswd);
            this.Controls.Add(this.btn_mInsert);
            this.Controls.Add(this.btn_chat);
            this.Controls.Add(this.tbox_mPhone);
            this.Controls.Add(this.tbox_mId);
            this.Controls.Add(this.btn_mUpdate);
            this.Controls.Add(this.btn_mDelete);
            this.Controls.Add(this.lb_mPhone);
            this.Controls.Add(this.lb_mId);
            this.Name = "Member";
            this.Text = "Member";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Member_FormClosing);
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datag_view1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_mId;
        private System.Windows.Forms.Label lb_mPhone;
        private System.Windows.Forms.Button btn_mDelete;
        private System.Windows.Forms.Button btn_mUpdate;
        private System.Windows.Forms.TextBox tbox_mId;
        private System.Windows.Forms.TextBox tbox_mPhone;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.Button btn_mInsert;
        private System.Windows.Forms.TextBox tbox_mPasswd;
        private System.Windows.Forms.Label lb_mPasswd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.DataGridView datag_view1;
        private System.Windows.Forms.Button btn_allmem;
    }
}