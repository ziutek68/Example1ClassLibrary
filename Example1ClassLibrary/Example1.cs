using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Example1ClassLibrary
{
    [ComVisible(true)]
    public class ExampleShow
    {
        public int Execute(string fdatas, string fpars, ref string fouts)
        {
            int res = -1;
            try
            {
                var myForm = new MainForm();
                myForm.fdatasRtf.Text = fdatas;
                myForm.fparsRtf.Text = fpars;
                myForm.Show();
                fouts = "Caption=wywo³ano okno zwyk³e";
                res = 0;
            }
            catch (System.Exception ex)
            {
                fouts = "ErrorMessage=" + ex.Message;
            }
            return res;
        }
    }

    [ComVisible(true)]
    public class ExampleShowModal
    {
        public int Execute(string fdatas, string fpars, ref string fouts)
        {
            int res = -1;
            try
            {
                var myForm = new MainForm();
                myForm.fdatasRtf.Text = fdatas;
                myForm.fparsRtf.Text = fpars;
                myForm.ShowDialog();
                fouts = myForm.fparsRtf.Text;
                res = 0;
            }
            catch (System.Exception ex)
            {
                fouts = "ErrorMessage=" + ex.Message;
            }
            return res;
        }
    }

    [ComVisible(true)]
    public class ExampleFunction
    {
        private string inputParams;
        private string GetTextParameter(string parName)
        {
            foreach (string line in inputParams.Split(new char[] { '\n', '\r'}))
                if (line.IndexOf(parName + "=", StringComparison.OrdinalIgnoreCase) == 0)
                    return line.Substring(parName.Length + 1);
            return "";
        }
        private int GetIntParameter(string parName, int defVal)
        {
            var cRes = GetTextParameter(parName);
            return int.TryParse(cRes, out int nRes) ? nRes : defVal;
        }
        public int Execute(string fdatas, string fpars, ref string fouts)
        {
            int res = -1;
            try
            {
                inputParams = fpars;
                Thread.Sleep(GetIntParameter("Timeout", 0));
                var rand = new System.Random();
                var wyn = rand.NextDouble() * GetIntParameter("MaxValue", 1000);
                fouts = "Result=" + wyn;
                res = 1;
            }
            catch (System.Exception ex)
            {
                fouts = "ErrorMessage=" + ex.Message;
            }
            return res;
        }
    }
}