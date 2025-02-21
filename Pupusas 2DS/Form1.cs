using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pupusas_2DS
{
    public partial class Form1 : Form
    {
        private decimal total;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            // Inicializar opciones en los ComboBoxes
            comboBoxPupusas.Items.AddRange(new string[] { "Pupusa de Queso - $1.50", "Pupusa de Frijol - $1.50", "Pupusa Revuelta - $2.00" });
            comboBoxBebidas.Items.AddRange(new string[] { "Refresco - $1.00", "Agua - $0.50", "Cerveza - $2.50" });
        }

        public void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxPupusas.SelectedItem != null)
            {
                string selectedPupusa = comboBoxPupusas.SelectedItem.ToString();
                decimal pricePupusa = GetPrice(selectedPupusa);
                total += pricePupusa;
            }

            if (comboBoxBebidas.SelectedItem != null)
            {
                string selectedBeverage = comboBoxBebidas.SelectedItem.ToString();
                decimal priceBeverage = GetPrice(selectedBeverage);
                total += priceBeverage;
            }

            textBoxTotal.Text = $"${total:F2}"; // Mostrar total formateado
        }

        public void buttonCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El total de tu compra es: ${total:F2}", "Total");
        }

        public decimal GetPrice(string item)
        {
            if (item.Contains("Pupusa"))
            {
                return item.Contains("Revuelta") ? 2.00m : 1.50m;
            }
            else if (item.Contains("Refresco"))
            {
                return 1.00m;
            }
            else if (item.Contains("Agua"))
            {
                return 0.50m;
            }
            else if (item.Contains("Cerveza"))
            {
                return 2.50m;
            }
            return 0;
        }

        public void buttonAgregar_Click_1(object sender, EventArgs e)
        {
             
            {
                if (comboBoxPupusas.SelectedItem != null)
                {
                    string selectedPupusa = comboBoxPupusas.SelectedItem.ToString();
                    decimal pricePupusa = GetPrice(selectedPupusa);
                    total += pricePupusa;
                }

                if (comboBoxBebidas.SelectedItem != null)
                {
                    string selectedBeverage = comboBoxBebidas.SelectedItem.ToString();
                    decimal priceBeverage = GetPrice(selectedBeverage);
                    total += priceBeverage;
                }

                textBoxTotal.Text = $"${total:F2}";
            }

        }
    }
}
        
    

