namespace Backend_Practice
{
    partial class ManagementFrom
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
            this.gobackBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roleGB = new System.Windows.Forms.GroupBox();
            this.BackEndOption = new System.Windows.Forms.RadioButton();
            this.FrontEndOption = new System.Windows.Forms.RadioButton();
            this.FullstackOption = new System.Windows.Forms.RadioButton();
            this.statusGB = new System.Windows.Forms.GroupBox();
            this.AdminStatusOption = new System.Windows.Forms.RadioButton();
            this.MemberStatusOption = new System.Windows.Forms.RadioButton();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.confirmPasswordInput = new System.Windows.Forms.TextBox();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.firstnameInput = new System.Windows.Forms.TextBox();
            this.stateInput = new System.Windows.Forms.TextBox();
            this.avatarURLInput = new System.Windows.Forms.TextBox();
            this.userEmailInput = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.userSearchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findUserBtn = new System.Windows.Forms.Button();
            this.roleGB.SuspendLayout();
            this.statusGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // gobackBtn
            // 
            this.gobackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gobackBtn.Location = new System.Drawing.Point(12, 12);
            this.gobackBtn.Name = "gobackBtn";
            this.gobackBtn.Size = new System.Drawing.Size(107, 33);
            this.gobackBtn.TabIndex = 24;
            this.gobackBtn.Text = "Go Back";
            this.gobackBtn.UseVisualStyleBackColor = true;
            this.gobackBtn.Click += new System.EventHandler(this.gobackBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Location = new System.Drawing.Point(763, 582);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(328, 33);
            this.updateBtn.TabIndex = 46;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(746, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(741, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(741, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Avatar URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(955, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(741, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(741, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(953, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(741, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "First Name";
            // 
            // roleGB
            // 
            this.roleGB.Controls.Add(this.BackEndOption);
            this.roleGB.Controls.Add(this.FrontEndOption);
            this.roleGB.Controls.Add(this.FullstackOption);
            this.roleGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleGB.ForeColor = System.Drawing.Color.White;
            this.roleGB.Location = new System.Drawing.Point(763, 427);
            this.roleGB.Name = "roleGB";
            this.roleGB.Size = new System.Drawing.Size(147, 126);
            this.roleGB.TabIndex = 35;
            this.roleGB.TabStop = false;
            this.roleGB.Text = "Role";
            // 
            // BackEndOption
            // 
            this.BackEndOption.AutoSize = true;
            this.BackEndOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackEndOption.Location = new System.Drawing.Point(6, 85);
            this.BackEndOption.Name = "BackEndOption";
            this.BackEndOption.Size = new System.Drawing.Size(105, 24);
            this.BackEndOption.TabIndex = 11;
            this.BackEndOption.Text = "Back-End";
            this.BackEndOption.UseVisualStyleBackColor = true;
            // 
            // FrontEndOption
            // 
            this.FrontEndOption.AutoSize = true;
            this.FrontEndOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FrontEndOption.Location = new System.Drawing.Point(6, 55);
            this.FrontEndOption.Name = "FrontEndOption";
            this.FrontEndOption.Size = new System.Drawing.Size(108, 24);
            this.FrontEndOption.TabIndex = 10;
            this.FrontEndOption.Text = "Front-End";
            this.FrontEndOption.UseVisualStyleBackColor = true;
            // 
            // FullstackOption
            // 
            this.FullstackOption.AutoSize = true;
            this.FullstackOption.Checked = true;
            this.FullstackOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullstackOption.Location = new System.Drawing.Point(6, 25);
            this.FullstackOption.Name = "FullstackOption";
            this.FullstackOption.Size = new System.Drawing.Size(99, 24);
            this.FullstackOption.TabIndex = 9;
            this.FullstackOption.TabStop = true;
            this.FullstackOption.Text = "Fullstack";
            this.FullstackOption.UseVisualStyleBackColor = true;
            // 
            // statusGB
            // 
            this.statusGB.Controls.Add(this.AdminStatusOption);
            this.statusGB.Controls.Add(this.MemberStatusOption);
            this.statusGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusGB.ForeColor = System.Drawing.Color.White;
            this.statusGB.Location = new System.Drawing.Point(944, 427);
            this.statusGB.Name = "statusGB";
            this.statusGB.Size = new System.Drawing.Size(147, 126);
            this.statusGB.TabIndex = 34;
            this.statusGB.TabStop = false;
            this.statusGB.Text = "Status";
            // 
            // AdminStatusOption
            // 
            this.AdminStatusOption.AutoSize = true;
            this.AdminStatusOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminStatusOption.Location = new System.Drawing.Point(6, 55);
            this.AdminStatusOption.Name = "AdminStatusOption";
            this.AdminStatusOption.Size = new System.Drawing.Size(77, 24);
            this.AdminStatusOption.TabIndex = 10;
            this.AdminStatusOption.Text = "Admin";
            this.AdminStatusOption.UseVisualStyleBackColor = true;
            // 
            // MemberStatusOption
            // 
            this.MemberStatusOption.AutoSize = true;
            this.MemberStatusOption.Checked = true;
            this.MemberStatusOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemberStatusOption.Location = new System.Drawing.Point(6, 25);
            this.MemberStatusOption.Name = "MemberStatusOption";
            this.MemberStatusOption.Size = new System.Drawing.Size(91, 24);
            this.MemberStatusOption.TabIndex = 9;
            this.MemberStatusOption.TabStop = true;
            this.MemberStatusOption.Text = "Member";
            this.MemberStatusOption.UseVisualStyleBackColor = true;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(745, 317);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(396, 26);
            this.passwordInput.TabIndex = 33;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(953, 194);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(188, 26);
            this.addressInput.TabIndex = 32;
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Location = new System.Drawing.Point(745, 381);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.Size = new System.Drawing.Size(396, 26);
            this.confirmPasswordInput.TabIndex = 31;
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(953, 134);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(188, 26);
            this.lastnameInput.TabIndex = 30;
            // 
            // firstnameInput
            // 
            this.firstnameInput.Location = new System.Drawing.Point(745, 134);
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new System.Drawing.Size(174, 26);
            this.firstnameInput.TabIndex = 29;
            // 
            // stateInput
            // 
            this.stateInput.Location = new System.Drawing.Point(745, 194);
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(174, 26);
            this.stateInput.TabIndex = 28;
            // 
            // avatarURLInput
            // 
            this.avatarURLInput.Location = new System.Drawing.Point(745, 253);
            this.avatarURLInput.Name = "avatarURLInput";
            this.avatarURLInput.Size = new System.Drawing.Size(396, 26);
            this.avatarURLInput.TabIndex = 27;
            // 
            // userEmailInput
            // 
            this.userEmailInput.Location = new System.Drawing.Point(745, 73);
            this.userEmailInput.Name = "userEmailInput";
            this.userEmailInput.Size = new System.Drawing.Size(396, 26);
            this.userEmailInput.TabIndex = 26;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Location = new System.Drawing.Point(763, 631);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(328, 33);
            this.deleteBtn.TabIndex = 47;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // userSearchInput
            // 
            this.userSearchInput.Location = new System.Drawing.Point(160, 355);
            this.userSearchInput.Name = "userSearchInput";
            this.userSearchInput.Size = new System.Drawing.Size(216, 26);
            this.userSearchInput.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Please enter a username";
            // 
            // findUserBtn
            // 
            this.findUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findUserBtn.Location = new System.Drawing.Point(382, 355);
            this.findUserBtn.Name = "findUserBtn";
            this.findUserBtn.Size = new System.Drawing.Size(78, 26);
            this.findUserBtn.TabIndex = 50;
            this.findUserBtn.Text = "Find";
            this.findUserBtn.UseVisualStyleBackColor = true;
            this.findUserBtn.Click += new System.EventHandler(this.findUserBtn_Click);
            // 
            // ManagementFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.findUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userSearchInput);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roleGB);
            this.Controls.Add(this.statusGB);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.lastnameInput);
            this.Controls.Add(this.firstnameInput);
            this.Controls.Add(this.stateInput);
            this.Controls.Add(this.avatarURLInput);
            this.Controls.Add(this.userEmailInput);
            this.Controls.Add(this.gobackBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagementFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementFrom";
            this.Load += new System.EventHandler(this.ManagementFrom_Load);
            this.roleGB.ResumeLayout(false);
            this.roleGB.PerformLayout();
            this.statusGB.ResumeLayout(false);
            this.statusGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gobackBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox roleGB;
        private System.Windows.Forms.RadioButton BackEndOption;
        private System.Windows.Forms.RadioButton FrontEndOption;
        private System.Windows.Forms.RadioButton FullstackOption;
        private System.Windows.Forms.GroupBox statusGB;
        private System.Windows.Forms.RadioButton AdminStatusOption;
        private System.Windows.Forms.RadioButton MemberStatusOption;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox confirmPasswordInput;
        private System.Windows.Forms.TextBox lastnameInput;
        private System.Windows.Forms.TextBox firstnameInput;
        private System.Windows.Forms.TextBox stateInput;
        private System.Windows.Forms.TextBox avatarURLInput;
        private System.Windows.Forms.TextBox userEmailInput;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox userSearchInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findUserBtn;
    }
}