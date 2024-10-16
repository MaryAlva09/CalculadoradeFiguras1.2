using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoradeFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCuadrado_Click(object sender, EventArgs e)
        {
            double lado;
            if (double.TryParse(txtLadoCuadrado.Text, out lado))
            {
                double perimetro = 4 * lado;
                double area = lado * lado;

                txtPerimetroCuadrado.Text = perimetro.ToString();
                txtAreaCuadrado.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, introduce un valor numérico válido para el lado del cuadrado.");
            }
        }

        private void btnCalcularRectangulo_Click(object sender, EventArgs e)
        {
            double baseRectangulo, alturaRectangulo;
            if (double.TryParse(txtBaseRectangulo.Text, out baseRectangulo) && double.TryParse(txtAlturaRectangulo.Text, out alturaRectangulo))
            {
                double perimetro = 2 * (baseRectangulo + alturaRectangulo);
                double area = baseRectangulo * alturaRectangulo;

                txtPerimetroRectangulo.Text = perimetro.ToString();
                txtAreaRectangulo.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos para la base y la altura del rectángulo.");
            }
        }

        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            double baseTriangulo, alturaTriangulo;
            if (double.TryParse(txtBaseTriangulo.Text, out baseTriangulo) && double.TryParse(txtAlturaTriangulo.Text, out alturaTriangulo))
            {
                double perimetro = 3 * baseTriangulo;
                double area = (baseTriangulo * alturaTriangulo) / 2;

                txtPerimetroTriangulo.Text = perimetro.ToString();
                txtAreaTriangulo.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos para la base y la altura del triángulo.");
            }
        }

        private void btnCalcularCirculo_Click(object sender, EventArgs e)
        {
            double radio;
            if (double.TryParse(txtRadioCirculo.Text, out radio))
            {
                double perimetro = 2 * Math.PI * radio;
                double area = Math.PI * radio * radio;

                txtPerimetroCirculo.Text = perimetro.ToString("F2");
                txtAreaCirculo.Text = area.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, introduce un valor numérico válido para el radio del círculo.");
            }
        }

        private void btnCalcularPentagono_Click(object sender, EventArgs e)
        {
            double lado;
            if (double.TryParse(txtLadoPentagono.Text, out lado))
            {
                // Fórmula del perímetro: 5 * lado
                double perimetro = 5 * lado;

                // Fórmula aproximada del área: (5/4) * lado^2 * (1 / Math.Tan(π/5))
                double area = (5 * lado * lado) / (4 * Math.Tan(Math.PI / 5));

                txtPerimetroPentagono.Text = perimetro.ToString("F2");
                txtAreaPentagono.Text = area.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, introduce un valor numérico válido para el lado del pentágono.");
            }
        }

    }
}
