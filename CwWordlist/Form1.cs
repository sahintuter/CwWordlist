using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CwWordlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string degerler = "";
        static string user = Environment.UserName.ToString();

       StreamWriter writer = new StreamWriter(path: $"C:\\Users\\sahin\\Desktop\\pass.txt");

        public void btnOlustur_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            parolalar.ResetText();
            for (int i = 1; i <= parolaSayisi.Value; i++)
            {
              
                for (int j = 1; j <= karakterSayisi.Value; j++)
                {
                    int index = random.Next(33,127);
                    degerler += Convert.ToChar(index).ToString();
                }

                parolalar.Text += degerler + Environment.NewLine;
            }
        }

        private void btnTXT_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < karakterSayisi.Value; i++)
            {
                writer.WriteLine(degerler);
            }
            
        }
    }
}
