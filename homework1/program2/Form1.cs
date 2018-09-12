using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

public class WinInOut:Form
{
    TextBox txt1 = new TextBox();
    TextBox txt2 = new TextBox();
    Button btn = new Button();
    Label lbl = new Label();

    public void init()
    {
        this.Controls.Add(txt1);
        this.Controls.Add(txt2);
        this.Controls.Add(btn);
        this.Controls.Add(lbl);
        txt1.Dock = System.Windows.Forms.DockStyle.Top;
        txt2.Dock = System.Windows.Forms.DockStyle.Top;
        btn.Dock = System.Windows.Forms.DockStyle.Fill;
        lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
        btn.Text = "求乘积";
        lbl.Text = "用于显示结果的标签";
        this.Size = new Size(300, 120);

        btn.Click += new System.EventHandler(this.button1_Click);
    }

    public void button1_Click(object sender, EventArgs e)
    {
        string s1 = txt1.Text, s2 = txt2.Text;
        double a = double.Parse(s1), b = double.Parse(s2);
        double n = a * b;
        lbl.Text = a + "与" + b + "的乘积是：" + n;
    }
    static void Do()
    {
        WinInOut f = new WinInOut();
        f.Text = "WinInOut";
        f.init();
        Application.Run(f);
    }
}
