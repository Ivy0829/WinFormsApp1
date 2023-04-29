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
    public partial class Form4 : Form
    {
        int count = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Size = new Size(100, 30);
            label.Location = new Point(0, 30 * count + 5);
            label.Name = "Label" + Convert.ToString(count);
            label.Text = "點擊修改內容"+count.ToString();
            label.Click += new System.EventHandler(this.beep);
            this.Controls.Add(label);

            TextBox txtBox = new TextBox();
            txtBox.Size = new Size(200, 50);
            txtBox.Location = new Point(105, 30*count+5);
            txtBox.Name = "TXT" + Convert.ToString(count);
            this.Controls.Add(txtBox);
            count++;
        }
        private void beep(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            if(input.ShowDialog() == DialogResult.OK)
            {
                (sender as Label).Text = input.TextBoxMsg;
            }
            //input.ShowDialog();
            //MessageBox.Show(sender.ToString() + e.ToString());
        }
    }
}
