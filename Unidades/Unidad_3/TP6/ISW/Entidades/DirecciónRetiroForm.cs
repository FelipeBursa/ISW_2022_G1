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
    public partial class DirecciónRetiroForm : Form
    {
        public DirecciónRetiroForm()
        {
            InitializeComponent();
            DirecciónRetiroGrb.Visible = false;
           
        }

        
        
        //Hace visible la imagen y oculta el gruop box
        private void MapaInteractivoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DirecciónRetiroGrb.Visible = false;
            ImagenDirecciónGroupBox.Visible = true;
        }

        //Hace visible el group box y oculta la imagen
        private void LlenarCamposRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DirecciónRetiroGrb.Visible = true;
            ImagenDirecciónGroupBox.Visible = false;
            
        }

        //valida que todos los campos obligatorios sean completados
        private void ValidarCampos()
        {
            
                MessageBox.Show("Se deben completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(CalleTxt.Text.Equals(""))
                {
                    CalleTxt.Focus();
                }
                if (NumCalletxt.Text.Equals(""))
                {
                    NumCalletxt.Focus();
                }
            
        }


        private void ContinuarDirecciónButton_Click(object sender, EventArgs e)
        {
            if ((LlenarCamposRadioButton.Checked) & (CalleTxt.Text.Equals("") || (NumCalletxt.Text.Equals(""))))
            {
                ValidarCampos();
            }
            else
            {
                DirecciónDestinoForm ventana = new DirecciónDestinoForm();
                ventana.Show();
                this.Hide();
            }
        }

        private void VolverDirecciónRetiroButton_Click(object sender, EventArgs e)
        {
            CiudadForm ventana = new CiudadForm();
            ventana.Show();
            this.Hide();
        }
    }

    
}
