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
        public float precio;

        private float distancia;

        public FormaPagoForm()
        {
            ///Inicializa variables
            InitializeComponent();
            CargarCombo();
            GenerarDistancia();
            CalcularCostoEnvio();
            MontoTextBox.Enabled                = false;
            EfectivoGroupBox.Visible            = false;
            TarjetaVisaGroupBox.Visible         = false;
            FechaRecibidaGroupBox.Visible       = false;
            MontoValidacionLabel.Visible        = false;
            CodigoLabel.Visible                 = false;
            InmediatoRadioButton.Checked        = true;
            HoraMasketTextBox.Text              = DateTime.Now.ToString("hh:mm");
        }

        public void CargarCombo()
        {
            ///Carga el combo con las formas de pago
            FormaPagoComboBox.Items.Add("Seleccione una forma de pago...");
            FormaPagoComboBox.Items.Add("Efectivo");
            FormaPagoComboBox.Items.Add("Tarjeta VISA");
            FormaPagoComboBox.SelectedIndex = 0;
        }

        private void FormaPagoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Método que muestra u oculta los group box
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

        public void ValidarCampos()
        {
            ///Valida campos obligatorios
            if (FormaPagoComboBox.SelectedIndex == -1 || FormaPagoComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Se seleccionar un método de pago",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (FormaPagoComboBox.SelectedIndex == 1)
                {
                    if ((MontoPagaClienteTextBox.Text.Equals("")) 
                        || (float.Parse(MontoPagaClienteTextBox.Text.ToString()) < 0) 
                        || ((float.Parse(MontoPagaClienteTextBox.Text.ToString())) < precio))
                    {
                        MessageBox.Show("Ingresar un monto válido",
                                        "Error", MessageBoxButtons.OK, 
                                        MessageBoxIcon.Warning);
                    }

                    else
                    {
                        ValidarFechas();
                    }
                }

                if (FormaPagoComboBox.SelectedIndex == 2)
                {
                    if ((NombreTitularTarjetaTextBox.Text.Equals("")) 
                        || (NumeroTarjetaTextBox.Text.Equals(""))
                        || (CodigoSeguridadTextBox.Text.Equals("")))
                    {
                        MessageBox.Show("Se deben completar todos los campos",
                                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        if ((MensajeTarjetaLabel.Visible == true) || (CodigoSeguridadTextBox.Text.Length < 3))
                        {
                            MessageBox.Show("La tarjeta no es valida",
                                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            DateTime fechaVencimiento = FechaVencimientoDateTimePicker.Value;

                            if (fechaVencimiento < DateTime.Today)
                            {
                                MessageBox.Show("La tarjeta ingresada se encuentra vencida",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            else
                            {
                                ValidarFechas();
                            }
                        }
                    }
                }
            }
        }

        private void ValidarFechas()
        {
            ///Valida que se ingresen fechas válida 
            DateTime fechaSeleccionadaEntrega = FechaRecibidaDateTimePicker.Value;
            DateTime fechaHasta               = DateTime.Today.AddDays( + 8);

            if ((fechaSeleccionadaEntrega > fechaHasta) || (fechaSeleccionadaEntrega < DateTime.Today))
            {
                MessageBox.Show("Se debe ingresar una fecha dentro de los proximos 7 días",
                                "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                bool ResultadoHora = ValidarHora();
                
                if(ResultadoHora == false)
                {
                    MessageBox.Show("Se debe ingresar una hora válida",
                                    "Fecha Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    MessageBox.Show("Su pedido ha sido realizado con éxito, el delivery llegará a la brevedad",
                                    "Pedido Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ConfirmarPedidoButton_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void VolverDireccionDestinoButton_Click(object sender, EventArgs e)
        {
            ///Para volver a una ventana anterior
            DirecciónDestinoForm ventana = new DirecciónDestinoForm();
            ventana.Show();
            this.Hide();
        }

        private void GenerarDistancia()
        {
            ///Genera una distancia para luego calcular el costo de envío
            Random GeneradorRandom = new Random();
            distancia              = GeneradorRandom.Next(1, 52);  
        }

        private void CalcularCostoEnvio()
        {
            ///Calcula el costo del envío según la distancia
            precio            = distancia * 100;
            MontoTextBox.Text = precio.ToString()+",00 $";
        }

        private void InmediatoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FechaRecibidaDateTimePicker.Enabled = false;
            HoraMasketTextBox.Enabled           = false;

        }

        private void ProgramadoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FechaRecibidaDateTimePicker.Enabled = true;
            HoraMasketTextBox.Enabled           = true;
        }

        private void ValidarTarjeta()
        {
            ///Valida que se ingrese una tarjeta VISA de 16 dígitos
            if (NumeroTarjetaTextBox.Text != "")
            {
                if ((NumeroTarjetaTextBox.Text[0] != '4') || (NumeroTarjetaTextBox.Text.Length < 16))
                {
                    MensajeTarjetaLabel.Visible = true;
                }

                else
                {
                    MensajeTarjetaLabel.Visible = false;
                }
            }
        }

        private void MontoPagaClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            ///Valida que el cliente ingrese un monto válido
            MontoValidacionLabel.Visible = false;

            if (MontoPagaClienteTextBox.Text != "")
            {
                if (float.Parse(MontoPagaClienteTextBox.Text) < precio)
                {
                    MontoValidacionLabel.Visible = true;
                    MontoValidacionLabel.Text    = "El monto ingresado tiene que ser mayor o igual al precio de envio";
                }              
            }        
        }

        private void MontoPagaClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///Validación dinamica donde solo se pueden ingresar números en el monto
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled                    = false;
                MontoValidacionLabel.Visible = false;
            }

            else
            {
                MontoValidacionLabel.Text = "Solo se pueden ingresar caracteres numéricos";
                e.Handled                 = true;
            }
        }

        private void CodigoSeguridadTextBox_TextChanged(object sender, EventArgs e)
        {
            ///Validación dinamica en el código de seguridad
            CodigoLabel.Visible = false;

            if (CodigoSeguridadTextBox.Text != "")
            {
                if (CodigoSeguridadTextBox.Text.Length < 3)
                {
                    CodigoLabel.Visible = true;
                    CodigoLabel.Text    = "* Faltan campos del codigo de seguridad"; 
                }
            }
        }

        private void CodigoSeguridadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///Validación dinamica para que solo se ingresen números en el codigo de seguridad
            CodigoLabel.Visible = false;

            if ((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }

            else
            {
                CodigoLabel.Visible = true;
                CodigoLabel.Text    = " * Solo se pueden ingresar caracteres numéricos";
                e.Handled           = true;
            }
        }

        private void FechaVencimientoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ///Muestra label si la fecha ingresada es anterior a la actual
            DateTime fechaSeleccionada = FechaVencimientoDateTimePicker.Value;

            if (fechaSeleccionada < DateTime.Today)
            {
                FechaTarjetaLabel.Visible = true;
            }

            else
            {
                FechaTarjetaLabel.Visible = false;
            }
        }

        private void FechaRecibidaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ///Valida fechas de entrega del pedido
            DateTime fechaSeleccionadaEntrega = FechaRecibidaDateTimePicker.Value;
            DateTime fechaHasta               = DateTime.Today.AddDays(+8);

            if ((fechaSeleccionadaEntrega > fechaHasta) || (fechaSeleccionadaEntrega < DateTime.Today))
            {
                FechaLabel.Visible = true;
            }

            else
            {
                FechaLabel.Visible = false;
            }
        }

        private void NumeroTarjetaTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidarTarjeta();
        }

        private void NumeroTarjetaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }


        private Boolean ValidarHora()
        {
            ///Valida la hora de la fecha de entrega programada
            if (int.Parse(HoraMasketTextBox.Text[0].ToString()) < 3)
            {
                if (int.Parse(HoraMasketTextBox.Text[1].ToString()) <= 9)
                {
                    if (int.Parse(HoraMasketTextBox.Text[3].ToString()) <= 5)
                    {
                        if (int.Parse(HoraMasketTextBox.Text[4].ToString()) <= 9 )
                        {
                            return true;
                        }

                        else
                        {
                            return false;
                        }
                    }

                    else
                    {
                        return false;
                    }
                }

                else
                {
                    return false;

                }
            }

            else
            {
                return false;
            }
        }

    }
}
