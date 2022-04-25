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
        private float precio;

        private float distancia;

        public FormaPagoForm()
        {
            InitializeComponent();
            CargarCombo();
            GenerarDistancia();
            CalcularCostoEnvio();
            MontoTextBox.Enabled                = false;
            EfectivoGroupBox.Visible            = false;
            TarjetaVisaGroupBox.Visible         = false;
            FechaRecibidaGroupBox.Visible       = false;
            precio                              = 0;
            distancia                           = 0;
            InmediatoRadioButton.Checked        = true;
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
            if (FormaPagoComboBox.SelectedIndex == -1 || FormaPagoComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Se seleccionar un método de pago",
                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (FormaPagoComboBox.SelectedIndex == 1)
                {
                    if ((MontoPagaClienteTextBox.Text.Equals("")) || (float.Parse(MontoPagaClienteTextBox.Text.ToString()) < 0))
                    {
                        MessageBox.Show("Ingresar un monto válido",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        ValidarFechas();
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
                    else
                    {
                        //ValidarTarjeta();
                        DateTime fechaVencimiento = FechaVencimientoDateTimePicker.Value;

                        if (fechaVencimiento < DateTime.Today)
                        {
                            MessageBox.Show("La tarjeta ingresada se encuentra vencida",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Su pedido ha sido realizado con éxito, el delivery llegará a la brevedad",
                              "Pedido Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        }
                    }
                }
            }
        }

        private void FormaPagoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FechaRecibidaGroupBox.Visible = true;

            if (FormaPagoComboBox.SelectedIndex == 1)
            {
                EfectivoGroupBox.Visible    = true;
                TarjetaVisaGroupBox.Visible = false;
            }

            if (FormaPagoComboBox.SelectedIndex == 2)
            {
                EfectivoGroupBox.Visible    = false;
                TarjetaVisaGroupBox.Visible = true;
            }
        }

        private void ValidarFechas()
        {
            
            DateTime fechaSeleccionadaEntrega = FechaRecibidaDateTimePicker.Value;
            DateTime fechaHasta = DateTime.Today.AddDays( + 7);
            if ((fechaSeleccionadaEntrega > fechaHasta) || (fechaSeleccionadaEntrega < DateTime.Today))
            {
                MessageBox.Show("Se debe ingresar una fecha dentro de los proximos 7 días",
                    "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Su pedido ha sido realizado con éxito, el delivery llegará a la brevedad",
                       "Pedido Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void ConfirmarPedidoButton_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void VolverDireccionDestinoButton_Click(object sender, EventArgs e)
        {
            DirecciónDestinoForm ventana = new DirecciónDestinoForm();
            ventana.Show();
            this.Hide();
        }

        private void GenerarDistancia()
        {
            Random GeneradorRandom = new Random();
            distancia = GeneradorRandom.Next(1, 52);  
            
        }

        private void CalcularCostoEnvio()
        {
            precio = distancia * 100;
            MontoTextBox.Text = precio.ToString();
        }

        private void InmediatoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FechaRecibidaDateTimePicker.Enabled = false;
        }

        private void ProgramadoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FechaRecibidaDateTimePicker.Enabled = true;
        }

        private void ValidarTarjeta()
        {
            AdvertenciaTarjetaLabel.Visible = false;

            //if ((NumeroTarjetaTextBox.Text.Length < 16)||
            if (NumeroTarjetaTextBox.Text[0] != '4')
            {
                AdvertenciaTarjetaLabel.Visible = true;
                AdvertenciaTarjetaLabel.Text = "* Ingresar una tarjeta VISA válida.";
            }
            else
            {
                AdvertenciaTarjetaLabel.Visible = false;
            }
        }

        private void NumeroTarjetaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se pueden ingresar caracteres numéricos", "Advertencia",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            ValidarTarjeta();
        }
    }
}
