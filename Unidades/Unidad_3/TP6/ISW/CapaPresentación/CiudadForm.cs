using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISW.Entidades;

namespace ISW
{
    public partial class CiudadForm : Form
    {
        private bool ValidacionCiudad;

        private bool ValidacionDescripcion;

        public CiudadForm()
        {
            InitializeComponent();
            TamañoLabel.Visible         = false;
            DescripcionGroupBox.Visible = false;
            ImagenGroupBox.Visible      = false;
        }

        private void CargarDatos()
        //carga ciudades al combo 
        {
            CiudadesComboBox.Items.Add(("Seleccione una ciudad"));
            CiudadesComboBox.Items.Add(("Córdoba"));
            CiudadesComboBox.Items.Add(("Villa Carlos Paz"));
            CiudadesComboBox.Items.Add(("Villa Allende"));
            CiudadesComboBox.SelectedIndex = 0;         
        }

        private void ValidarCiudadCombo()
        //se valida que se haya seleccionado una ciudad valida
        {
            if ((CiudadesComboBox.SelectedIndex == -1) || (CiudadesComboBox.SelectedIndex == 0))
            {
                MessageBox.Show("Se debe seleccionar una ciudad", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //No se cumple con la validación
                ValidacionCiudad = false;
            }

            else
            {
                //Se cumple con la validación
                ValidacionCiudad = true;
            }
        }

        public void ValidarCampoDescripción()
        {
            if (DescripcionProductoTextBox.Text.Equals(""))
            {
                MessageBox.Show("La descripción es obligatoria y debe ser menor a 50 caracteres",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //No se cumple con la validación
                ValidacionDescripcion = false;
                DescripcionProductoTextBox.Focus();
            }

            else
            {
                //Se cumple con la validación
                ValidacionDescripcion = true;
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
           
            if (ValidacionCiudad == true && ValidacionDescripcion == true)
            {
                DirecciónRetiroForm ventana = new DirecciónRetiroForm();
                ventana.Show();
                this.Hide();
            }  
        }

        private void CargarImagenBoton_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "Image files (*.jpg) | *.jpg;";

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(abrirImagen.FileName);
                TamañoLabel.Text = "Tamaño de imagen : " +
                    (info.Length * 0.000001).ToString() + " MB";

                if (info.Length * 0.000001 > 5) //Validación para mostrar imagen
                {
                    MessageBox.Show("La Imagen seleccionada supera el limite de tamaño de 5MB",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    ImagenPictureBox.ImageLocation = abrirImagen.FileName;
                    ImagenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    TamañoLabel.Visible = true;
                }
            }
        }

        private void CiudadesComboBox_TextChanged(object sender, EventArgs e)
        {
            if ((CiudadesComboBox.SelectedIndex == -1) || (CiudadesComboBox.SelectedIndex == 0))
            {
                DescripcionGroupBox.Visible = false;
                ImagenGroupBox.Visible = false;
            }

            else
            {
                //Se cumple con la validación
                ValidacionCiudad = true;
                DescripcionGroupBox.Visible =true ;
                ImagenGroupBox.Visible = true;
            }
        }

        private void DescripcionProductoTextBox_TextChanged(object sender, EventArgs e)
        {
            if(DescripcionProductoTextBox.Text.Length > 0)
            {
                ObligatorioDescripcionLabel.Visible = false;
            }

            else
            {
                ObligatorioDescripcionLabel.Visible = true;
            }
        }
    }
}
