using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            tbSavePath.Text = Properties.Settings.Default.SavePath;
        }

        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            tbSavePath.Text = path.SelectedPath;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SavePath = tbSavePath.Text;
            Properties.Settings.Default.Save();
            //寫入設定檔的部分
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
