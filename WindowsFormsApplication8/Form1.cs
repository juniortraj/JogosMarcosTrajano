using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Properties.Resources.kart;
                textBox1.Text = (comboBox1.Text + " Mario Kart 8 é um jogo de corrida de karts desenvolvido e publicado pela Nintendo para o Wii U. É o décimo primeiro título da franquia Mario Kart, o oitavo da série principal e foi lançado em 30 de Maio de 2014. Posteriormente, sua versão deluxe foi lançada para Nintendo Swich. ");
            }
                pictureBox1.Image = Properties.Resources.kong;
                textBox1.Text = (comboBox1.Text + " kong ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
