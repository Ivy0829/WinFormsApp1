using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.DirectoryServices.AccountManagement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 0;
        string domain = "";
        string userName = "";
        string password = "";
        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

        public void Init()
        {
            domain = Properties.Settings.Default.ADPath;
            userName = Properties.Settings.Default.ADAccount;
            password = Properties.Settings.Default.ADPassword;
            
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FileList_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileary = (String[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < fileary.Length; i++)
            {
                FileList.Items.Add(fileary[i]);
            }
        }

        private void FileList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void BtnAllSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FileList.Items.Count; i++)
            {
                FileList.SetSelected(i, true);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            for (int i = this.FileList.Items.Count - 1; i >= 0; i--)
            {
                this.FileList.Items.Remove(this.FileList.SelectedItem);
            }
        }

        private void TSSetSaveFilePath_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }


        private void TSSetAccountManage_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ClientSize = new System.Drawing.Size(this.Width, this.Height);
            form3.Location=(new System.Drawing.Point(this.Location.X, this.Location.Y));
            form3.Show();
            //form3.Location = new System.Drawing.Point(FMain.size)
            //form3.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using PrincipalContext context = new PrincipalContext(ContextType.Domain, domain, userName, password);

            bool exist = context.ValidateCredentials(userName, password);

            string[] str;
            string[] filename;
            int counter = 0;
            if (exist)
            {
                foreach (var file in FileList.Items)
                {
                    try
                    {
                        if (File.Exists(file.ToString()))
                        {
                            str = file.ToString().Split('\\');
                            filename = str[str.Length - 1].Split('.');
                            String copyfilePath = Properties.Settings.Default.SavePath;
                            Directory.CreateDirectory(Path.GetDirectoryName(copyfilePath));
                            FileStream fs = File.OpenRead(file.ToString());
                            FileStream fsout = File.OpenWrite(copyfilePath + "\\" + filename[0] + DateTime.Now.ToString("yyyyMMddHHmmss") + "." + filename[1]);
                            BufferedStream bs = new BufferedStream(fs);
                            BufferedStream bsout = new BufferedStream(fsout);
                            byte[] ReadByte = new byte[bs.BufferSize];
                            int count = bs.Read(ReadByte, 0, bs.BufferSize);
                            while (count > 0)
                            {
                                bsout.Write(ReadByte, 0, bs.BufferSize);
                                count = bs.Read(ReadByte, 0, bs.BufferSize);
                            }
                            fs.Close();
                            bs.Close();
                            fsout.Close();
                            bsout.Close();
                            fs.Flush();
                            bs.Flush();
                            fsout.Flush();
                            bsout.Flush();
                            counter++;
                        }
                    }
                    catch (IOException ioex)
                    {
                        MessageBox.Show("請確認資料夾是否存在");
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("檔案複製成功，一共複製" + counter + "筆檔案");
            }
        }

        private void 設定帳號密碼ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}




