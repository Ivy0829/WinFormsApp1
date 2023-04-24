
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FileList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAllSelect = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eEEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSetSaveFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.設定帳號密碼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FileList
            // 
            this.FileList.AllowDrop = true;
            this.FileList.FormattingEnabled = true;
            this.FileList.ItemHeight = 15;
            this.FileList.Location = new System.Drawing.Point(24, 69);
            this.FileList.Name = "FileList";
            this.FileList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FileList.Size = new System.Drawing.Size(540, 304);
            this.FileList.TabIndex = 2;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.FileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileList_DragDrop);
            this.FileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileList_DragEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "上傳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAllSelect
            // 
            this.BtnAllSelect.Location = new System.Drawing.Point(596, 77);
            this.BtnAllSelect.Name = "BtnAllSelect";
            this.BtnAllSelect.Size = new System.Drawing.Size(115, 81);
            this.BtnAllSelect.TabIndex = 4;
            this.BtnAllSelect.Text = "全選";
            this.BtnAllSelect.UseVisualStyleBackColor = true;
            this.BtnAllSelect.Click += new System.EventHandler(this.BtnAllSelect_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(596, 186);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(115, 81);
            this.BtnDel.TabIndex = 5;
            this.BtnDel.Text = "刪除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eEEToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eEEToolStripMenuItem
            // 
            this.eEEToolStripMenuItem.Name = "eEEToolStripMenuItem";
            this.eEEToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.eEEToolStripMenuItem.Text = "檔案";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSetSaveFilePath,
            this.設定帳號密碼ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // TSSetSaveFilePath
            // 
            this.TSSetSaveFilePath.Name = "TSSetSaveFilePath";
            this.TSSetSaveFilePath.Size = new System.Drawing.Size(180, 22);
            this.TSSetSaveFilePath.Text = "設定儲放路徑";
            this.TSSetSaveFilePath.Click += new System.EventHandler(this.TSSetSaveFilePath_Click);
            // 
            // 設定帳號密碼ToolStripMenuItem
            // 
            this.設定帳號密碼ToolStripMenuItem.Name = "設定帳號密碼ToolStripMenuItem";
            this.設定帳號密碼ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.設定帳號密碼ToolStripMenuItem.Text = "設定帳號密碼";
            this.設定帳號密碼ToolStripMenuItem.Click += new System.EventHandler(this.TSSetAccountManage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 619);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAllSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CopyFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAllSelect;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eEEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSSetSaveFilePath;
        private System.Windows.Forms.ToolStripMenuItem 設定帳號密碼ToolStripMenuItem;
        
    }
}

