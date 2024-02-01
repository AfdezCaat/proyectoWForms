using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoWForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "El nombre se ha cambiado";
            label1.Text = "La etiqueta se ha cambiado";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            var palabra = textBox3.Text.Split(' ');
            label3.Text = palabra[0]; 
          
            

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
