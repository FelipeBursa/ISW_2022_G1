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
        public DirecciónDestinoForm()
        {
            InitializeComponent();
        }

        private void VolverDireccionDestinoButton_Click(object sender, EventArgs e)
        {
            DirecciónRetiroForm ventana = new DirecciónRetiroForm();
            ventana.Show();
            this.Hide();
        }

        //valida que todos los campos obligatorios sean completados
        private void ValidarCampos()
        {

            MessageBox.Show("Se deben completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (CalleDestinoTextBox.Text.Equals(""))
            {
                CalleDestinoTextBox.Focus();
            }
            if (NumeroDestinoTextBox.Text.Equals(""))
            {
                NumeroDestinoTextBox.Focus();
            }

        }

        private void ContinuarDirecciónDestinoButton_Click(object sender, EventArgs e)
        {
            if ((CalleDestinoTextBox.Text.Equals("")) || NumeroDestinoTextBox.Text.Equals(""))
            {
                ValidarCampos();
            }
            else 
            {
                FormaPagoForm ventana = new FormaPagoForm();
                ventana.Show();
                this.Hide();
            }
           
        }

        
    }
}
