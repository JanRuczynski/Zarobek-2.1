using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarobek_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int godziny = int.Parse(textBox1.Text);
            int zamowienia = int.Parse(textBox2.Text);
            double minuty = int.Parse(textBox4.Text);

            double godzinyd = godziny + (minuty / 60);

            double zarobek = godzinyd * 9.9 + zamowienia * 5;
            double zarobekh = zarobek / godzinyd;
            
            if(zarobekh < 19.9)
            {
                zarobekh = 19.9;
            }



            label4.Text = "Dzisiejszy zarobek to " + zarobek;
            label5.Text = "Zarobek na godzinę to " + zarobekh;
        }
    }
}
