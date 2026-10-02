using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtbProducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int producto = num1 * num2;
            MessageBox.Show("el resultado del producto es" + producto);



        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int suma = num1 + Num2;
            MessageBox.Show("el resultado de la suma es" + suma);

        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int producto = num1 * num2;
            MessageBox.Show("el resultado del producto es" + producto);


        }

        private void BtnDivicon_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(TextVar1.Text);
            float num2 = float.Parse(TextVar2.Text);
            if (num2 > 0) ;
            {
                float divicion = num1 / num2;
                MessageBox.Show("el resultado de la dicion es " + divicion);
            }

            {
                MessageBox.Show("la divicion es indefinida");
            }


        }

    }
}

