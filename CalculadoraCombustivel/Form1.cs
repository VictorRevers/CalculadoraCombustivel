using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCombustivel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tempo_gasto = float.Parse(textBox1.Text);
            float velocidade_media = float.Parse(textBox2.Text);

            float distancia = tempo_gasto * velocidade_media;
            float litros_usados = distancia / 12;

            richTextBox1.Text = "Tempo gasto(h): " + tempo_gasto +
                                "\nVelocidade media(km/h): " + velocidade_media +
                                "\nDistancia percorrida(km): " + distancia +
                                "\nListros Usados(L/km): " + litros_usados;
        }
    }
}
