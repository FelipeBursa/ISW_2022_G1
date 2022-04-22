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
    public partial class InterfazPedidoDeLoQueSea : Form
    {
     
        public InterfazPedidoDeLoQueSea()
        {
            InitializeComponent();
            
            
        }

      

        private void CargarDatos()
        {
            //cargo ciudades 
            ciudadesComboBox.Items.Add(("Cordoba"));
            ciudadesComboBox.Items.Add(("Villa Maria"));
            ciudadesComboBox.Items.Add(("Alta Gracia"));
            ciudadesComboBox.Items.Add(("Jesus Maria"));
            ciudadesComboBox.Items.Add(("Rio Cuarto"));

        }
        private void InterfazPedidoDeLoQueSea_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ciudadGroupBox.Visible = false;
            direccionRetiroGroupBox.Visible = false;
            direccionEnviooGroupBox.Visible = false;
            productoGroupBox.Visible = false;
        }

        private void PedidoDeLoQueSeaBotonClick(object sender, EventArgs e)
        {
            ciudadGroupBox.Visible = true;
        }

        private void ciudadesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            direccionRetiroGroupBox.Visible = true;
            direccionEnviooGroupBox.Visible = true;
            productoGroupBox.Visible = true;
        }
    }
}
