using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
            scroll();
        }

        private void scroll()
        {          
            panel1.AutoScroll = true;
        }
       
        private void textBox1_TextChanged_(object sender, EventArgs e)
        {
            SetTextBoxClientSize(sender as TextBox);
        }
        private void SetTextBoxClientSize(TextBox textBox)
        {
            const int MARGIN_X = 0;
            const int MARGIN_Y = 1;

            Size size = TextRenderer.MeasureText(textBox.Text, textBox.Font);
            textBox.ClientSize = new Size(size.Width + MARGIN_X, size.Height + MARGIN_Y);
            textBox.Multiline = true;
;        }
        private void button1_Click(object sender, EventArgs e)
        {          
            add();
        }

        private void add()
        {
            Panel panel = new Panel();

            TextBox textBox = new TextBox();
            SetTextBoxClientSize(textBox);
            textBox.ScrollBars = ScrollBars.None;
            textBox.TextChanged += textBox1_TextChanged_;

            textBox.Text = textBox1.Text;
            textBox.Location = new Point(10, 10);

            panel.Controls.Add(textBox);


            panel.Dock = DockStyle.Bottom;
            panel.Enabled = false;
            panel1.Controls.Add(panel);

        }

    }
}
