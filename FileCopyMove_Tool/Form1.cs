using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileCopyMove_Tool
{
    public partial class Form1 : Form
    {
        String StartPath = null;
        String TargetPath = null;
        String Ext = null;
        bool isCopy = true;
        int CopyCount = 0;

        HashSet<string> SerchFile = new HashSet<string>();
        HashSet<string> SerchFolder = new HashSet<string>();
        HashSet<string> SerchExt = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private bool FindSerchFile(string str)
        {
            return SerchFile.Contains(str);
        }

        private bool FindSerchFolder(string str)
        {
            return SerchFolder.Contains(str);
        }

        private bool FindSerchExt(string str)
        {
            return SerchExt.Contains(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                StartPath = folderBrowserDialog1.SelectedPath;
                textBox1.Text = StartPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                TargetPath = folderBrowserDialog2.SelectedPath;
                textBox2.Text = TargetPath;
                TargetPath += '\\';
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                isCopy ^= true;
                radioButton2.Checked = false;
            }

            else if(radioButton2.Checked == true)
            {
                isCopy ^= true;
                radioButton1.Checked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 15;
            String InputExt = textBox3.Text;
            String Sibal = ".";

            if (InputExt.Contains('.') == false)
                InputExt = Sibal + InputExt;

            Ext = InputExt;
        }

        private void _KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox3.Focused == false)
                return;

            switch(e.KeyCode)
            {
                case Keys.Enter:
                {
                    if (FindSerchExt(Ext) == true)
                    {
                        DialogResult mg = MessageBox.Show("중복된 확장자가 존재합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Text = "";
                        return;
                    }

                    SerchExt.Add(Ext);
                    listBox2.Items.Add(Ext);
                    textBox3.Text = "";
                }
 
                break;
            }
            
        }

        private void _ListKeyDown(object sender, KeyEventArgs e)
        {
            if (listBox2.Focused == false)
                return;
            
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        if (listBox2.SelectedItems.Count < 0)
                            return;

                        int Idx = listBox2.SelectedIndex;

                        SerchExt.Remove(listBox2.SelectedItem.ToString());
                        listBox2.Items.RemoveAt(Idx);
                        listBox2.Update();
                    }
                    break;
            }
            
        }

        void DirCheck (string Dir)
        {
            string[] Directories = System.IO.Directory.GetDirectories(Dir);
            string[] Files = System.IO.Directory.GetFiles(Dir);

            foreach (var FileName in Files)
            {
                string FileN = System.IO.Path.GetFileName(FileName);
                string FileExt = System.IO.Path.GetExtension(FileN);

                if (FindSerchFile(FileN) == true)
                    continue;

                if (FindSerchExt(FileExt) == true)
                    continue;

                System.IO.FileInfo fileInfo = new System.IO.FileInfo(FileName);
                fileInfo.IsReadOnly = false;

                if (isCopy == true)
                {
                    fileInfo.CopyTo(TargetPath + FileN, true);
                    FileN += " 복사 완료";
                }
                else
                {
                   fileInfo.MoveTo(TargetPath + FileN);
                   FileN += " 이동 완료";
                }

                listBox1.Items.Insert(0, FileN);
            }

            listBox1.TopIndex = listBox1.Items.Count - 1;

            foreach (var DirPath in Directories)
            {
                string Temp = DirPath;
                Temp = Temp.Remove(0, Temp.LastIndexOf('\\') + 1);

                if (FindSerchFolder(Temp) == true)
                    continue;

                DirCheck(DirPath);
            }

           listBox1.Items.Insert(0, "--------------------------------------");

           if(CopyCount == 0)
            {
                listBox1.Items.Insert(listBox1.Items.Count, "--------------------------------------");
                CopyCount++;
            }

           DialogResult mg = MessageBox.Show("작업 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //실행코드!
            if (StartPath == null)
            {
                DialogResult mg = MessageBox.Show("시작경로를 넣어주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TargetPath == null)
            {
                DialogResult mg = MessageBox.Show("타겟 경로를 넣어주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DirCheck(StartPath);

        }

        private void _OutFolder(object sender, KeyEventArgs e)
        {
            if (textBox4.Focused == false)
                return;

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        if (FindSerchFolder(textBox4.Text) == true)
                        {
                            DialogResult mg = MessageBox.Show("중복된 폴더명이 존재합니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox4.Text = "";
                            return;
                        }

                        listBox3.Items.Add(textBox4.Text);
                        SerchFolder.Add(textBox4.Text);
                        textBox4.Text = "";
                    }
                    break;
            }
        }

        private void _OutFile(object sender, KeyEventArgs e)
        {
            if (textBox5.Focused == false)
                return;

           switch (e.KeyCode)
           {
                case Keys.Enter:
                    {
                        if (FindSerchFile(textBox4.Text) == true)
                        {
                            DialogResult mg = MessageBox.Show("중복된 이름이 존재합니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox5.Text = "";
                            return;
                        }

                        listBox4.Items.Add(textBox5.Text);
                        SerchFile.Add(textBox5.Text);
                        textBox5.Text = "";
                        break;
                    }
           }
        }

        private void _OutFolderList(object sender, KeyEventArgs e)
        {
            if (listBox3.Focused == false)
                return;

            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        if (listBox3.SelectedItems.Count < 0)
                            return;

                        int Idx = listBox3.SelectedIndex;

                        SerchFolder.Remove(listBox3.SelectedItem.ToString());
                        listBox3.Items.RemoveAt(Idx);
                        listBox3.Update();
                    }
                    break;
            }
        }

        private void _OutFileName(object sender, KeyEventArgs e)
        {
            if (listBox4.Focused == false)
                return;

            switch (e.KeyCode)
            {
                case Keys.Delete:
                    {
                        if (listBox4.SelectedItems.Count < 0)
                            return;

                        int Idx = listBox4.SelectedIndex;

                        SerchFile.Remove(listBox4.SelectedItem.ToString());
                        listBox4.Items.RemoveAt(Idx);
                        listBox4.Update();
                    }
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CopyCount = 0;
        }

    }
}
