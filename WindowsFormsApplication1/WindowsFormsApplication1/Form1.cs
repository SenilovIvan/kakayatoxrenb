using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Summ = Convert.ToDouble(textBox1.Text);
                double Raznost = Convert.ToDouble(textBox2.Text);
                double Light = (Summ - Raznost) / 2;
                double Lampa = Light + Raznost;
                textBox3.Text = String.Format("Стоимость светодиода:{0};Стоимость лампы:{1}", Light, Lampa);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
