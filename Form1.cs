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
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Net;



namespace 百度离线
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisibleAttribute(true)]


    public partial class Form1 : Form
    {
        public int i = 0;
        public int mouse = 0;
        public int mouse1 = 0;
       
       

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
            timer1.Interval = 4000;
            timer1.Enabled = true;

           
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str_url = Application.StartupPath + "\\self1.html";
            Uri url = new Uri(str_url);
            webBrowser1.Url = url; 
            
            webBrowser1.ObjectForScripting = this;
            webBrowser1.ScriptErrorsSuppressed = true;
            
            




            int x3 = this.ClientSize.Width - button1.Size.Width;
            int y3 = 0;
            Point p3 = new Point(x3, y3);
            button1.Location = p3;
            button1.Text = "←";

            int x4 = 0;
            int y4 = this.ClientSize.Height - button2.Size.Height;
            Point p4 = new Point(x4, y4);
            button2.Location = p4;
            button2.Text = "↑";

            int x5 = treeView1.Location.X;
            int y5 = treeView1.Location.Y + treeView1.Size.Height;
            Point p5 = new Point(x5, y5);
            textBox1.Location = p5;

            listView1.Height = ClientSize.Height * 4 / 21;
            listView1.Width = ClientSize.Width;

            treeView1.Height = ClientSize.Height * 3 / 7;
            treeView1.Width = ClientSize.Width * 1 / 4;

            textBox1.Height = ClientSize.Height * 8 / 21;

            webBrowser1.Height = ClientSize.Height;
            webBrowser1.Width = ClientSize.Width;

            int x7 = this.ClientSize.Width - button1.Size.Width;
            int y7 = 0;
            Point p7 = new Point(x7, y7);
            button1.Location = p7;
            button1.Text = "←";
            treeView1.Visible = false;

            int x8 = 0;
            int y8 = this.ClientSize.Height - button2.Size.Height;
            Point p8 = new Point(x8, y8);
            button2.Location = p8;
            button2.Text = "↑";
            listView1.Visible = false;

            int x9 = treeView1.Location.X;
            int y9 = treeView1.Location.Y + treeView1.Size.Height;
            Point p9 = new Point(x9, y9);
            textBox1.Location = p9;

            int x6 = treeView1.Location.X;
            int y6 = y5 + textBox1.Size.Height ;
            Point p6 = new Point(x6, y6);
            button3.Location = p6;
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void TreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouse = e.Clicks;
        }

        private void TreeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (this.mouse > 1)
                e.Cancel = true;
            else
            {
                e.Cancel = false;
            }
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (this.mouse > 1)
                e.Cancel = true;
            else
            {
                e.Cancel = false;
            }
        }

        private void TreeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "军一")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("军长：一 \r\n\r\n人数：100 \r\n\r\n弹药：130（一般）");
            }

            if (treeView1.SelectedNode.Name == "军二")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("军长：二 \r\n\r\n人数：80 \r\n\r\n弹药：90（充足）");
            }

            if (treeView1.SelectedNode.Name == "旅一")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("旅长：一 \r\n\r\n人数：50 \r\n\r\n弹药：30（不足）");
            }

            if (treeView1.SelectedNode.Name == "旅二")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("旅长：二 \r\n\r\n人数：50 \r\n\r\n弹药：100（充足）");
            }

            if (treeView1.SelectedNode.Name == "旅三")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("旅长：三 \r\n\r\n人数：60 \r\n\r\n弹药：50（一般）");
            }

            if (treeView1.SelectedNode.Name == "团一")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("团长：一 \r\n\r\n人数：35 \r\n\r\n弹药：30（充足）");
            }

            if (treeView1.SelectedNode.Name == "团二")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("团长：二 \r\n\r\n人数455 \r\n\r\n弹药：90（充足）");
            }

            if (treeView1.SelectedNode.Name == "团三")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("团长：三 \r\n\r\n人数：35 \r\n\r\n弹药：20（不足）");
            }

            if (treeView1.SelectedNode.Name == "团四")
            {
                button3.Visible = true;
                textBox1.Visible = true;
                textBox1.Text = ("团长：四 \r\n\r\n人数：30 \r\n\r\n弹药：10（不足）");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "←")
            {
                treeView1.Visible = true;
                button1.Text = "→";
                int x1 = this.ClientSize.Width - textBox1.Size.Width - button1.Size.Width;
                int y1 = 0;
                Point p1 = new Point(x1, y1);
                button1.Location = p1;


            }
            else
            {
                treeView1.Visible = false;
                button1.Text = "←";
                int n1 = this.ClientSize.Width - button1.Size.Width;
                int m1 = 0;
                Point p1_1 = new Point(n1, m1);
                button1.Location = p1_1;
                button3.Visible = false;
                textBox1.Visible = false;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "↑")
            {
                listView1.Visible = true;
                button2.Text = "↓";
                int x2 = 0;
                int y2 = this.ClientSize.Height - listView1.Size.Height - 20;
                Point p2 = new Point(x2, y2);
                button2.Location = p2;
            }
            else
            {
                listView1.Visible = false;
                button2.Text = "↑";
                int n2 = 0;
                int m2 = this.ClientSize.Height - button2.Size.Height;
                Point p2_1 = new Point(n2, m2);
                button2.Location = p2_1;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            listView1.Height = ClientSize.Height * 4 / 21;
            listView1.Width = ClientSize.Width;

            treeView1.Height = ClientSize.Height * 3 / 7;
            treeView1.Width = ClientSize.Width * 1 / 4;

            textBox1.Height = ClientSize.Height * 8 / 21;

            webBrowser1.Height = ClientSize.Height;
            webBrowser1.Width = ClientSize.Width;

            int x3 = this.ClientSize.Width - button1.Size.Width;
            int y3 = 0;
            Point p3 = new Point(x3, y3);
            button1.Location = p3;
            button1.Text = "←";
            treeView1.Visible = false;

            int x4 = 0;
            int y4 = this.ClientSize.Height - button2.Size.Height;
            Point p4 = new Point(x4, y4);
            button2.Location = p4;
            button2.Text = "↑";
            listView1.Visible = false;

            int x5 = treeView1.Location.X;
            int y5 = treeView1.Location.Y + treeView1.Size.Height;
            Point p5 = new Point(x5, y5);
            textBox1.Location = p5;

            int x6 = treeView1.Location.X;
            int y6 = y5 + textBox1.Size.Height - button3.Size.Height;
            Point p6 = new Point(x6, y6);
            button3.Location = p6;
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            

            //webBrowser1.Document.InvokeScript("getpoint");

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            

        }
    }
}
