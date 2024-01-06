namespace BTL_OOP_N17
{
    partial class DoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMK));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtAccount = new Guna.UI.WinForms.GunaTextBox();
            this.txtOldPass = new Guna.UI.WinForms.GunaTextBox();
            this.txtNewPass = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Close = new Guna.UI.WinForms.GunaButton();
            this.btn_Save = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(121, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(126, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Đổi mật khẩu";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.Location = new System.Drawing.Point(52, 114);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 19);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Mật khẩu cũ:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel4.Location = new System.Drawing.Point(52, 145);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(98, 19);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Mật khẩu mới:";
            // 
            // txtAccount
            // 
            this.txtAccount.BaseColor = System.Drawing.Color.White;
            this.txtAccount.BorderColor = System.Drawing.Color.Silver;
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAccount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAccount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccount.Location = new System.Drawing.Point(165, 76);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.SelectedText = "";
            this.txtAccount.Size = new System.Drawing.Size(141, 26);
            this.txtAccount.TabIndex = 4;
            // 
            // txtOldPass
            // 
            this.txtOldPass.BaseColor = System.Drawing.Color.White;
            this.txtOldPass.BorderColor = System.Drawing.Color.Silver;
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOldPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOldPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOldPass.Location = new System.Drawing.Point(165, 108);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '\0';
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.Size = new System.Drawing.Size(141, 26);
            this.txtOldPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BaseColor = System.Drawing.Color.White;
            this.txtNewPass.BorderColor = System.Drawing.Color.Silver;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNewPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNewPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPass.Location = new System.Drawing.Point(165, 139);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(141, 26);
            this.txtNewPass.TabIndex = 6;
            // 
            // btn_Close
            // 
            this.btn_Close.AnimationHoverSpeed = 0.07F;
            this.btn_Close.AnimationSpeed = 0.03F;
            this.btn_Close.BaseColor = System.Drawing.Color.Gainsboro;
            this.btn_Close.BorderColor = System.Drawing.Color.Black;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Close.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Close.Location = new System.Drawing.Point(59, 203);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_Close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Close.OnHoverImage = null;
            this.btn_Close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Close.Size = new System.Drawing.Size(83, 26);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Thoát";
            this.btn_Close.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AnimationHoverSpeed = 0.07F;
            this.btn_Save.AnimationSpeed = 0.03F;
            this.btn_Save.BaseColor = System.Drawing.Color.LightGray;
            this.btn_Save.BorderColor = System.Drawing.Color.Black;
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Save.Location = new System.Drawing.Point(213, 203);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btn_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Save.OnHoverImage = null;
            this.btn_Save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Save.Size = new System.Drawing.Size(100, 26);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Cập nhật";
            this.btn_Save.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.gunaLabel1);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel4);
            this.gunaLinePanel1.Controls.Add(this.txtNewPass);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel3);
            this.gunaLinePanel1.Controls.Add(this.btn_Save);
            this.gunaLinePanel1.Controls.Add(this.txtAccount);
            this.gunaLinePanel1.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel1.Controls.Add(this.btn_Close);
            this.gunaLinePanel1.Controls.Add(this.txtOldPass);
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(59, 38);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(358, 255);
            this.gunaLinePanel1.TabIndex = 9;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.Location = new System.Drawing.Point(52, 83);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(94, 19);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Tên tài khoản:";
            // 
            // DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 305);
            this.Controls.Add(this.gunaLinePanel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "DoiMK";
            this.Text = "DoiMK";
            this.Load += new System.EventHandler(this.DoiMK_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtAccount;
        private Guna.UI.WinForms.GunaTextBox txtOldPass;
        private Guna.UI.WinForms.GunaTextBox txtNewPass;
        private Guna.UI.WinForms.GunaButton btn_Close;
        private Guna.UI.WinForms.GunaButton btn_Save;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}
