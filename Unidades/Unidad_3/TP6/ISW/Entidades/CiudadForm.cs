using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISW.Entidades;

namespace ISW
{
    public partial class CiudadForm : Form
    {
     
        public CiudadForm()
        {
            InitializeComponent();
            
            
        }

        private void CargarDatos()
        //carga ciudades al combo 
        {

            CiudadesCmb.Items.Add(("Seleccione una ciudad..."));
            CiudadesCmb.Items.Add(("Cordoba"));
            CiudadesCmb.Items.Add(("Villa Carlos Paz"));
            CiudadesCmb.Items.Add(("Villa Allende"));
            CiudadesCmb.SelectedIndex = 0;
          
        }

        private void ValidarCiudadCombo()
        // se valida que se haya seleccionado una ciudad valida
        {
            if ((CiudadesCmb.SelectedIndex == -1) || (CiudadesCmb.SelectedIndex == 0))
            {
                MessageBox.Show("Se debe seleccionar una ciudad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Continua hacia la siguiente ventana para seguir completando datos
                DirecciónRetiroForm ventana = new DirecciónRetiroForm();
                ventana.Show();
                this.Hide();
            }
        }

        public void ValidarCampoDescripción()
        {
            if (DescrProductoTxt.Text.Equals(""))
            {
                MessageBox.Show("Se debe ingresar una descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void InterfazPedidoDeLoQueSea_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void ContinuarCiudadButtton_Click(object sender, EventArgs e)
        {
            ValidarCampoDescripción();
            ValidarCiudadCombo();
        }

    }
}
