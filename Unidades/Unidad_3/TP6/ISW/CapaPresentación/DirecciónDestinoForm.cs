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
    public partial class DirecciónDestinoForm : Form
    {
        bool ValidacionDestino;

        public DirecciónDestinoForm()
        {
            ///Inicializamos componenetes
            InitializeComponent();
            ValidacionDestino = false;
        }

        private void VolverDireccionDestinoButton_Click(object sender, EventArgs e)
        {
            ///Para volver a la ventana anterior
            DirecciónRetiroForm ventana = new DirecciónRetiroForm();
            ventana.Show();
            this.Hide();
        }

        private void ValidarCampos()
        {
            ///valida que todos los campos obligatorios sean completados
            if ((CalleDestinoTextBox.Text.Equals("")) || (NumeroDestinoTextBox.Text.Equals("")) ||
                (ReferenciaDestinoTextBox.Text.Length > 100))
            {
                MessageBox.Show("Se deben completar todos los campos obligatorios.", 
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (CalleDestinoTextBox.Text.Equals(""))
                {
                    CalleDestinoTextBox.Focus();
                }

                if (NumeroDestinoTextBox.Text.Equals(""))
                {
                    NumeroDestinoTextBox.Focus();
                }
            }

            else
            {
                ValidacionDestino = true;
            }
        }

        private void ContinuarDirecciónDestinoButton_Click(object sender, EventArgs e)
        {           
            ValidarCampos();

            ///Validación para cuando se apriete el botón "Continuar"
            if (ValidacionDestino == true)
            {
                FormaPagoForm ventana = new FormaPagoForm();
                ventana.Show();
                this.Hide();
            }         
        }

        private void NumeroDestinoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///Validación dinamica del número de destino
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }

            else
            {
                ObligatorioDestinoNumeroLabel.Text = "Solo se pueden ingresar caracteres numéricos";
                e.Handled                          = true;
            }
        }

        private void NumeroDestinoTextBox_TextChanged(object sender, EventArgs e)
        {
            ///Validación que muestra mensaje de obligatoriedad
            if (NumeroDestinoTextBox.Text.Length == 0)
            {
                ObligatorioDestinoNumeroLabel.Text    = "*Campo obligatorio ";
                ObligatorioDestinoNumeroLabel.Visible = true;
            }

            else
            {
                ObligatorioDestinoNumeroLabel.Visible = false;
            }
        }

        private void CalleDestinoTextBox_TextChanged(object sender, EventArgs e)
        {
            ///Validación que muestra mensaje de obligatoriedad
            if (CalleDestinoTextBox.Text.Length == 0)
            {
                ObligatorioCalleDestinoLabel.Text    = "*Campo obligatorio ";
                ObligatorioCalleDestinoLabel.Visible = true;
            }

            else
            {
                ObligatorioCalleDestinoLabel.Visible = false;
            }
        }
    }
}
