namespace LoginProgram
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_passwd = new System.Windows.Forms.Label();
            this.lb_Id = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbox_lId = new System.Windows.Forms.TextBox();
            this.tbox_lPasswd = new System.Windows.Forms.TextBox();
            this.btn_Join = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_passwd);
            this.groupBox1.Controls.Add(this.lb_Id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lb_passwd
            // 
            this.lb_passwd.AutoSize = true;
            this.lb_passwd.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_passwd.Location = new System.Drawing.Point(91, 161);
            this.lb_passwd.Name = "lb_passwd";
            this.lb_passwd.Size = new System.Drawing.Size(103, 20);
            this.lb_passwd.TabIndex = 2;
            this.lb_passwd.Text = "패스워드 :";
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_Id.Location = new System.Drawing.Point(104, 62);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(90, 20);
            this.lb_Id.TabIndex = 1;
            this.lb_Id.Text = "아이디 : ";
            // 
            // tbox_lId
            // 
            this.tbox_lId.Font = new System.Drawing.Font("굴림", 15F);
            this.tbox_lId.Location = new System.Drawing.Point(206, 50);
            this.tbox_lId.Multiline = true;
            this.tbox_lId.Name = "tbox_lId";
            this.tbox_lId.Size = new System.Drawing.Size(232, 41);
            this.tbox_lId.TabIndex = 1;
            // 
            // tbox_lPasswd
            // 
            this.tbox_lPasswd.Font = new System.Drawing.Font("굴림", 15F);
            this.tbox_lPasswd.Location = new System.Drawing.Point(206, 150);
            this.tbox_lPasswd.Multiline = true;
            this.tbox_lPasswd.Name = "tbox_lPasswd";
            this.tbox_lPasswd.PasswordChar = '*';
            this.tbox_lPasswd.Size = new System.Drawing.Size(232, 41);
            this.tbox_lPasswd.TabIndex = 2;
            // 
            // btn_Join
            // 
            this.btn_Join.BackColor = System.Drawing.Color.White;
            this.btn_Join.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_Join.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Join.Location = new System.Drawing.Point(206, 279);
            this.btn_Join.Name = "btn_Join";
            this.btn_Join.Size = new System.Drawing.Size(109, 49);
            this.btn_Join.TabIndex = 3;
            this.btn_Join.Text = "회원가입";
            this.btn_Join.UseVisualStyleBackColor = false;
            this.btn_Join.Click += new System.EventHandler(this.btn_Join_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Login.Location = new System.Drawing.Point(329, 279);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(109, 49);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginProgram.Properties.Resources.symbol_check_icon;
            this.pictureBox1.Location = new System.Drawing.Point(206, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 44);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "로그인";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Join);
            this.Controls.Add(this.tbox_lPasswd);
            this.Controls.Add(this.tbox_lId);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Login";
            this.Text = "로그인창";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_passwd;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbox_lId;
        private System.Windows.Forms.TextBox tbox_lPasswd;
        private System.Windows.Forms.Button btn_Join;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

