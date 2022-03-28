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

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int hasChosen = 0;
        int canChose = 2;
        bool flagA = false;
        bool flagB = false;
        bool flagC = false;
        bool flagD = false;
        bool flagE = false;
        bool flagF = false;
        String[] c1 = new String[2];
        public Form1()
        {
            InitializeComponent();
            tiip.Text = "";
        }
        public void updateClick(Button a)
        {
            hasChosen++;
            if (hasChosen > canChose)
            {
                tip.Text = "选择的文件个数有误，需选两个！";
            }
            else
            {
                tip.Text = "";

                c1[hasChosen - 1] = a.Text;

                a.Text += "（已选中)";

            }

        }
        public void cancelChose(Button a)
        {
            hasChosen--;
            a.Text = a.Text.Substring(0, 5);

            for (int i = 0; i < 2; i++)
            {
                if (c1[i] == a.Text)
                {
                    c1[i] = null;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            flagA = !flagA;
            if (flagA == true)
            {
                updateClick(txt1);
            }
            else
            {
                cancelChose(txt1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flagB = !flagB;
            if (flagB == true)
            {
                updateClick(txt2);
            }
            else
            {
                cancelChose(txt2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flagC = !flagC;
            if (flagC == true)
            {
                updateClick(txt3);
            }
            else
            {
                cancelChose(txt3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flagD = !flagD;
            if (flagD == true)
            {
                updateClick(txt4);
            }
            else
            {
                cancelChose(txt4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flagE = !flagE;
            if (flagE == true)
            {
                updateClick(txt5);
            }
            else
            {
                cancelChose(txt5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flagF = !flagF;
            if (flagF == true)
            {
                updateClick(txt6);
            }
            else
            {
                cancelChose(txt6);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (hasChosen != 2)
            {
                tiip.Text = "请选择两个文件再点击合成";
            }
            else if (fName.Text == "")
            {
                tiip.Text = "请输入合成后的文件名";
            }
            else
            {
                String path1 = AppDomain.CurrentDomain.BaseDirectory + @"Data\" + c1[0];
                String path2 = AppDomain.CurrentDomain.BaseDirectory + @"Data\" + c1[1];
                String fPath = AppDomain.CurrentDomain.BaseDirectory + @"Data\" + fName.Text + ".txt";

                try
                {
                    FileStream f;
                    if (!File.Exists(fPath))
                    {
                        f = new FileStream(fPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                    }
                    else
                    {
                        f = new FileStream(fPath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
                    }
                    FileStream f1 = new FileStream(path1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    FileStream f2 = new FileStream(path2, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    StreamReader sr1 = new StreamReader(f1, Encoding.UTF8);
                    StreamReader sr2 = new StreamReader(f2, Encoding.UTF8);
                    StreamWriter sw = new StreamWriter(f, Encoding.UTF8);
                    for (string s1 = sr1.ReadLine(); s1 != null; s1 = sr1.ReadLine())
                    {
                        sw.WriteLine(s1);
                    }
                    for (string s2 = sr2.ReadLine(); s2 != null; s2 = sr2.ReadLine())
                    {
                        sw.WriteLine(s2);
                    }

                    sr1.Close();
                    sr2.Close();
                    sw.Close();
                    f.Close();
                    f1.Close();
                    f2.Close();
                    tiip.Text = "成功!";

                }
                catch (DirectoryNotFoundException e1)
                {
                    throw e1;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
