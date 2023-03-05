using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X;
            double y;
            X = Convert.ToInt32(textBox1.Text);
            y = Math.Sin(x) - Math.Cos(x);
            if (x > 7) y = Math.Sin(x);
            else if ((x > 2) && (x <= 6)) y = Math.Cos(x);

             textBox2.Text = Convert.ToString(y);
            if (y < 0) textBox2.ForeColor = Color.Blue;
            else textBox2.ForeColor = Color.Blue;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
          
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Input x", "Data Input", "0");

        }

      }  
}
        
   

