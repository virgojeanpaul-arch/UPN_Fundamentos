using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_PlantillaTurnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[] LeerSueldos(TextBox[] cajas)
        {
            double[] sueldos = new double[cajas.Length];

            for (int i = 0; i < cajas.Length; i++)
            {
                sueldos[i] = double.Parse(cajas[i].Text);
            }

            return sueldos;
        }
        private double CalcularTotal(double[] datos)
        {
            double total = 0;

            for (int i = 0; i < datos.Length; i++)
            {
                total = total + datos[i];
            }
            return total;
        }
        private void OrdenarBurbuja(double[] datos)
        {
            for (int i = 0; i < datos.Length - 1; i++)
            {
                for (int j = 0; j < datos.Length - 1 - i; j++)
                {
                    if (datos[j] > datos[j + 1])
                    {
                        double auxiliar = datos[j];
                        datos[j] = datos[j + 1];
                        datos[j + 1] = auxiliar;
                    }
                }
            }
        }
        private void MostrarArreglo(string nombreTurno, double[] datos)
        {
            string linea = nombreTurno + ": ";

            for (int i = 0; i < datos.Length; i++)
            {
                linea += $"S/ {datos[i]:F2} ";
            }
            lstResultados.Items.Add(linea);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lstResultados.Items.Clear();

                double[] manana = LeerSueldos(new TextBox[] { txbM1, txbM2, txbM3 });
                double[] tarde = LeerSueldos(new TextBox[] { txbT1, txbT2 });
                double[] noche = LeerSueldos(new TextBox[] { txbN1, txbN2 });

                double totalManana = CalcularTotal(manana);
                double totalTarde = CalcularTotal(tarde);
                double totalNoche = CalcularTotal(noche);

                lstResultados.Items.Add("=== TOTALES POR TURNO ===");
                lstResultados.Items.Add($"Mañana: S/{totalManana:F2}");
                lstResultados.Items.Add($"Tarde: S/{totalTarde:F2}");
                lstResultados.Items.Add($"Noche: S/{totalNoche:F2}");

                string turnoMayor = "Mañana";
                double mayorGasto = totalManana;

                if (totalTarde > mayorGasto)
                {
                    mayorGasto = totalTarde;
                    turnoMayor = "Tarde";
                }

                if (totalNoche > mayorGasto)
                {
                    mayorGasto = totalNoche;
                    turnoMayor = "Noche";
                }

                lblTurnoMayor.Text = $"Turno con mayor gasto: {turnoMayor} (S/{mayorGasto:F2})";

                OrdenarBurbuja(manana);
                OrdenarBurbuja(tarde);
                OrdenarBurbuja(noche);

                lstResultados.Items.Add("");
                lstResultados.Items.Add("=== SUELDOS ORDENADOS DE MENOR A MAYOR ===");

                MostrarArreglo("Mañana", manana);
                MostrarArreglo("Tarde", tarde);
                MostrarArreglo("Noche", noche);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números válidos en los sueldos.",
                    "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpia_Click(object sender, EventArgs e)
        {
            txbM1.Clear();
            txbM2.Clear();
            txbM3.Clear();

            txbT1.Clear();
            txbT2.Clear();

            txbN1.Clear();
            txbN2.Clear();

            lstResultados.Items.Clear();
            lblTurnoMayor.Text = "Turno con mayor gasto: -";

            txbM1.Focus();
        }
        private void btnDatosPrueba_Click(object sender, EventArgs e)
        {
            CargarDatosDePrueba();
        }
        private void CargarDatosDePrueba()
        {
            txbM1.Text = "1500";
            txbM2.Text = "1200";
            txbM3.Text = "1800";

            txbT1.Text = "1100";
            txbT2.Text = "1400";

            txbN1.Text = "1000";
            txbN2.Text = "950";

            lstResultados.Items.Clear();
            lblTurnoMayor.Text = "Turno con mayor gasto: -";
        }
    }
}
