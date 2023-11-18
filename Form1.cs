using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Arrays a = new Arrays(Convert.ToInt32(textBox1.Text));
            FileWrite f1 = new FileWrite();
            FileRead f2 = new FileRead();
            FileWrite f3 = new FileWrite();
            ShowArray show = new ShowArray();

            string patch = @"1.txt";
            string patch2 = @"2.txt";

            f2.read(patch, a);
            f1.write(patch2, a);
            f3.write2(patch2, a.CalculateAverageB());

            label1.Text = show.writeArray(a.a);
            label2.Text = a.CalculateAverageB().ToString();

        }
    }
}
