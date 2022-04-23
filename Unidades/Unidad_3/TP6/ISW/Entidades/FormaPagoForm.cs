using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISW.Entidades
{
    public partial class FormaPagoForm : Form
    {
        public FormaPagoForm()
        {
            InitializeComponent();
            CargarCombo();
            MontoTextBox.Enabled = false;
            EfectivoGroupBox.Visible = false;
            TarjetaVisaGroupBox.Visible = false;
        }

        public void CargarCombo()
        {
            FormaPagoComboBox.Items.Add(("Seleccione una forma de pago..."));
            FormaPagoComboBox.Items.Add(("Efectivo"));
            FormaPagoComboBox.Items.Add(("Tarjeta VISA"));
            FormaPagoComboBox.SelectedIndex = 0;
        }

        public void ValidarCampos()
        {
            if (FormaPagoComboBox.SelectedIndex == 1)
            {
                if (MontoPagaClienteTextBox.Text.Equals(""))
                {
                    MessageBox.Show("Se debe ingresar el monto con el que se va a realizar el pago", 
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MontoTextBox.Focus();
                }
            
            }
            if (FormaPagoComboBox.SelectedIndex == 2)
            {
                if ((NombreTitularTarjetaTextBox.Text.Equals("")) || (NumeroTarjetaTextBox.Text.Equals("")) 
                    || (CodigoSeguridadTextBox.Text.Equals("")))
                {
                    MessageBox.Show("Se deben completar todos los campos",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (FormaPagoComboBox.SelectedIndex == -1 || FormaPagoComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Se seleccionar un método de pago",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                MessageBox.Show("Su pedido ha sido realizado con éxito, el delivery llegará a la brevedad", "Pedido Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void FormaPagoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormaPagoComboBox.SelectedIndex == 1)
            {
                EfectivoGroupBox.Visible = true;
                TarjetaVisaGroupBox.Visible = false;
            }

            if (FormaPagoComboBox.SelectedIndex == 2)
            {
                EfectivoGroupBox.Visible = false;
                TarjetaVisaGroupBox.Visible = true;
            }
        }

        private void ConfirmarPedidoButton_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }
}
