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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
            TBADPath.Text = Properties.Settings.Default.ADPath;
            TBAccount.Text = Properties.Settings.Default.ADAccount;
            TBPassword.Text = Properties.Settings.Default.ADPassword;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ADPath = TBADPath.Text;
            Properties.Settings.Default.ADAccount = TBAccount.Text;
            Properties.Settings.Default.ADPassword = TBPassword.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
