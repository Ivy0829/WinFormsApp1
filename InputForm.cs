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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        public string TextBoxMsg
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxMsg = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
