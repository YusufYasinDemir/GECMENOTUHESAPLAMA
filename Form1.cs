using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U200920021_GECMENOTUHESAPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int ort = Convert.ToInt32(textBox1.Text);
            if (ort < 0 || ort > 100)
            {
                MessageBox.Show("0- 100 arasında bir sayı giriniz");

            }
            else
            if (ort >=50)
            {
                MessageBox.Show("Dersi geçtiniz");
            }
            else
            {
               
            }
               
                
                
        }
    }
}
