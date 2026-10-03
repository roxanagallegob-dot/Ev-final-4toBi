using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_final_4toBi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(TextVar1.Text);
            Byte Num2 = Byte.Parse(TextVar2.Text);
            int Producto = Num1 * Num2;
            MessageBox.Show("El R// es " + Producto);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int Potencia = 1;
            int J = 0;
            while (J != Num2)
            {
                Potencia = Potencia * Num1;
                J++;
            }
            MessageBox.Show("el R// es" + Potencia);
}

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(TextVar1.Text);
            Byte Num2 = Byte.Parse(TextVar2.Text);
            int Suma = Num1 + Num2;
            MessageBox.Show("El R// es " + Suma);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextVar1.Text);
            float Num2 = float.Parse(TextVar2.Text);
            if (Num2 > 0)
            {
                float Division = Num1 / Num2;
                MessageBox.Show("El R// es " + Division);
            }
            else
            {
                MessageBox.Show("No se puede dividir entre 0");
            }
        }
    }
}

