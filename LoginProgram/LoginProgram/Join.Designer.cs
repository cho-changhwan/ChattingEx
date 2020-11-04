namespace LoginProgram
{
    partial class Join
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
            this.btn_Join = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tbox_Id = new System.Windows.Forms.TextBox();
            this.lb_Id = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_Passwd = new System.Windows.Forms.Label();
            this.tbox_Phone = new System.Windows.Forms.TextBox();
            this.tbox_Passwd = new System.Windows.Forms.TextBox();
            this.cbox_Passwd = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Join
            // 
            this.btn_Join.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Join.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_Join.Location = new System.Drawing.Point(49, 353);
            this.btn_Join.Name = "btn_Join";
            this.btn_Join.Size = new System.Drawing.Size(103, 41);
            this.btn_Join.TabIndex = 0;
            this.btn_Join.Text = "가입완료";
            this.btn_Join.UseVisualStyleBackColor = true;
            this.btn_Join.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Back.Font = new System.Drawing.Font("굴림", 15F);
            this.btn_Back.Location = new System.Drawing.Point(212, 353);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(103, 41);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "이전단계";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tbox_Id
            // 
            this.tbox_Id.Font = new System.Drawing.Font("굴림", 15F);
            this.tbox_Id.Location = new System.Drawing.Point(177, 73);
            this.tbox_Id.Name = "tbox_Id";
            this.tbox_Id.Size = new System.Drawing.Size(138, 30);
            this.tbox_Id.TabIndex = 200;
            this.tbox_Id.Text = "id";
            this.tbox_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Id.Enter += new System.EventHandler(this.tbox_Id_Enter);
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_Id.Location = new System.Drawing.Point(69, 83);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(83, 20);
            this.lb_Id.TabIndex = 3;
            this.lb_Id.Text = "아이디 :";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_Phone.Location = new System.Drawing.Point(29, 256);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(123, 20);
            this.lb_Phone.TabIndex = 4;
            this.lb_Phone.Text = "핸드폰번호 :";
            // 
            // lb_Passwd
            // 
            this.lb_Passwd.AutoSize = true;
            this.lb_Passwd.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_Passwd.Location = new System.Drawing.Point(49, 165);
            this.lb_Passwd.Name = "lb_Passwd";
            this.lb_Passwd.Size = new System.Drawing.Size(103, 20);
            this.lb_Passwd.TabIndex = 5;
            this.lb_Passwd.Text = "비밀번호 :";
            // 
            // tbox_Phone
            // 
            this.tbox_Phone.Font = new System.Drawing.Font("굴림", 15F);
            this.tbox_Phone.Location = new System.Drawing.Point(177, 253);
            this.tbox_Phone.Name = "tbox_Phone";
            this.tbox_Phone.Size = new System.Drawing.Size(138, 30);
            this.tbox_Phone.TabIndex = 6;
            this.tbox_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Phone.Enter += new System.EventHandler(this.tbox_Phone_Enter);
            // 
            // tbox_Passwd
            // 
            this.tbox_Passwd.Font = new System.Drawing.Font("굴림", 15F);
            this.tbox_Passwd.Location = new System.Drawing.Point(177, 162);
            this.tbox_Passwd.Name = "tbox_Passwd";
            this.tbox_Passwd.PasswordChar = '*';
            this.tbox_Passwd.Size = new System.Drawing.Size(138, 30);
            this.tbox_Passwd.TabIndex = 7;
            this.tbox_Passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbox_Passwd
            // 
            this.cbox_Passwd.AutoSize = true;
            this.cbox_Passwd.Location = new System.Drawing.Point(177, 198);
            this.cbox_Passwd.Name = "cbox_Passwd";
            this.cbox_Passwd.Size = new System.Drawing.Size(108, 16);
            this.cbox_Passwd.TabIndex = 8;
            this.cbox_Passwd.Text = "비밀번호보이기";
            this.cbox_Passwd.UseVisualStyleBackColor = true;
            this.cbox_Passwd.CheckedChanged += new System.EventHandler(this.cbox_Passwd_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 67);
            this.panel1.TabIndex = 201;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(124, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbox_Passwd);
            this.Controls.Add(this.tbox_Passwd);
            this.Controls.Add(this.tbox_Phone);
            this.Controls.Add(this.lb_Passwd);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.tbox_Id);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Join);
            this.Name = "Join";
            this.Text = "Join";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Join_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Join;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tbox_Id;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_Passwd;
        private System.Windows.Forms.TextBox tbox_Phone;
        private System.Windows.Forms.TextBox tbox_Passwd;
        private System.Windows.Forms.CheckBox cbox_Passwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}