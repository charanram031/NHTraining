using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinWeb1.ServiceReference1;

namespace WinWeb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input=Convert.ToInt32(textBox1.Text);
            WebService1SoapClient obj1=new WebService1SoapClient();
            textBox2.Text=obj1.Factorial(input).ToString();

        }
    }
}
