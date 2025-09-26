using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaparlour
{
    public partial class Form1 : Form
    {
        //global variables
        double slicePrice = 3.25;
        int numOfSlices = 0;
        double taxRate = 0.13;
        double subtotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numOfSlices = Convert.ToInt16(slicesInput.Text);
            subtotal = numOfSlices * slicePrice;
            subTotalOutput.Text = subtotal.ToString("C");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
