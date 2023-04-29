
namespace WinFormsApp1
{
    partial class Form3
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
            this.LBSetSavePath = new System.Windows.Forms.Label();
            this.TBADPath = new System.Windows.Forms.TextBox();
            this.BtnBrowser = new System.Windows.Forms.Button();
            this.FBSetSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LBAccount = new System.Windows.Forms.Label();
            this.TBAccount = new System.Windows.Forms.TextBox();
            this.LBPassword = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BtnSeePwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBSetSavePath
            // 
            this.LBSetSavePath.AutoSize = true;
            this.LBSetSavePath.Location = new System.Drawing.Point(31, 70);
            this.LBSetSavePath.Name = "LBSetSavePath";
            this.LBSetSavePath.Size = new System.Drawing.Size(82, 15);
            this.LBSetSavePath.TabIndex = 0;
            this.LBSetSavePath.Text = "驗證主機路徑:";
            // 
            // TBADPath
            // 
            this.TBADPath.Location = new System.Drawing.Point(119, 67);
            this.TBADPath.Name = "TBADPath";
            this.TBADPath.Size = new System.Drawing.Size(257, 23);
            this.TBADPath.TabIndex = 1;
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(401, 64);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(147, 31);
            this.BtnBrowser.TabIndex = 2;
            this.BtnBrowser.Text = "瀏覽";
            this.BtnBrowser.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(401, 101);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(147, 31);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "確定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(401, 138);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(147, 31);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LBAccount
            // 
            this.LBAccount.AutoSize = true;
            this.LBAccount.Location = new System.Drawing.Point(55, 117);
            this.LBAccount.Name = "LBAccount";
            this.LBAccount.Size = new System.Drawing.Size(34, 15);
            this.LBAccount.TabIndex = 5;
            this.LBAccount.Text = "帳號:";
            // 
            // TBAccount
            // 
            this.TBAccount.Location = new System.Drawing.Point(119, 114);
            this.TBAccount.Name = "TBAccount";
            this.TBAccount.Size = new System.Drawing.Size(257, 23);
            this.TBAccount.TabIndex = 6;
            // 
            // LBPassword
            // 
            this.LBPassword.AutoSize = true;
            this.LBPassword.Location = new System.Drawing.Point(55, 171);
            this.LBPassword.Name = "LBPassword";
            this.LBPassword.Size = new System.Drawing.Size(34, 15);
            this.LBPassword.TabIndex = 7;
            this.LBPassword.Text = "密碼:";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(119, 168);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(257, 23);
            this.TBPassword.TabIndex = 8;
            // 
            // BtnSeePwd
            // 
            this.BtnSeePwd.Location = new System.Drawing.Point(338, 168);
            this.BtnSeePwd.Name = "BtnSeePwd";
            this.BtnSeePwd.Size = new System.Drawing.Size(38, 23);
            this.BtnSeePwd.TabIndex = 9;
            this.BtnSeePwd.UseVisualStyleBackColor = true;
            this.BtnSeePwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnSeePwd_KeyDown);
            this.BtnSeePwd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnSeePwd_KeyUp);
            this.BtnSeePwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSeePwd_MouseDown);
            this.BtnSeePwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSeePwd_MouseUp);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSeePwd);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LBPassword);
            this.Controls.Add(this.TBAccount);
            this.Controls.Add(this.LBAccount);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnBrowser);
            this.Controls.Add(this.TBADPath);
            this.Controls.Add(this.LBSetSavePath);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBSetSavePath;
        private System.Windows.Forms.TextBox TBADPath;
        private System.Windows.Forms.Button BtnBrowser;
        private System.Windows.Forms.FolderBrowserDialog FBSetSavePath;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LBAccount;
        private System.Windows.Forms.TextBox TBAccount;
        private System.Windows.Forms.Label LBPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BtnSeePwd;
    }
}