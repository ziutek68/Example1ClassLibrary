using System;
using System.Windows.Forms;
using Example1ClassLibrary;

namespace LaunchExample1CL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myFunc = new ExampleFunction();
            var fdatas = "APLIKACJA=LaunchExample1CL";
            var fpars = paramsMemo.Text;
            string fRes = "";
            myFunc.Execute(fdatas, fpars, ref fRes);
            resultText.Text = fRes;
        }
    }
}
