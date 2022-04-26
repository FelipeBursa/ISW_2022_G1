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
        private bool Validacion;
        private string CalleRandom;
        private int NumeroCalleRandom;

        public DirecciónRetiroForm()
        {
            InitializeComponent();
            DirecciónRetiroGroupBox.Enabled = false;
            Validacion                      = false;                     
        }
        
        //Hace visible la imagen y oculta el gruop box
        private void MapaInteractivoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalleTextBox.Text               = "";
            NumeroCalleTextBox.Text         = "";
            ReferenciaTextBox.Text          = "";
            DirecciónRetiroGroupBox.Enabled = false;
            MapaInteractivoButton.Enabled   = true;
        }

        //Hace visible el group box y oculta la imagen
        private void LlenarCamposRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DirecciónRetiroGroupBox.Enabled = true;
            MapaInteractivoButton.Enabled   = false;  
        }
        
        private void ValidarCampos()
        {
            if ((ReferenciaTextBox.Text.Length > 100) || (CalleTextBox.Text.Equals("")) || 
                (NumeroCalleTextBox.Text.Equals("")))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (CalleTextBox.Text.Equals(""))
                {
                    CalleTextBox.Focus();
                }
                if (NumeroCalleTextBox.Text.Equals(""))
                {
                    NumeroCalleTextBox.Focus();
                }
            }
            else
            {              
                Validacion = true;
            }
        }

        private void ContinuarDirecciónButton_Click(object sender, EventArgs e)
        {
            ValidarCampos();

            if (Validacion == true)
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

        private void MapaButton_Click(object sender, EventArgs e)
        {
            GenerarUbicacion();
        }

        private void GenerarUbicacion ()
        {
            List<String> Calles = new List<String>();
            Calles.Add("Macaon");
            Calles.Add("9 de Julio");
            Calles.Add("San Carlos");
            Calles.Add("Javier Lopez");
            Calles.Add("Elias Yofre");
            Calles.Add("Rondeau");
            Calles.Add("Chacabuco");
            Calles.Add("Lima");
            Calles.Add("Tucuman");

            Random GeneradorRandom = new Random();
            CalleTextBox.Text = Calles [GeneradorRandom.Next(0,8)];

            Random GeneradorRandom2 = new Random();
            NumeroCalleTextBox.Text = (GeneradorRandom2.Next(100, 8000)).ToString();

        }

        private void NumeroCalleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                ObligatorioNumeroRetiroLabel.Text = "Solo se pueden ingresar caracteres numéricos";
                e.Handled = true;
            }
        }

        private void CalleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CalleTextBox.Text.Length == 0)
            {
                ObligatorioCalleRetiroLabel.Text = "*Campo obligatorio ";
                ObligatorioCalleRetiroLabel.Visible = true;
            }
            else
            {
                ObligatorioCalleRetiroLabel.Visible = false;
            }
        }

        private void NumeroCalleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NumeroCalleTextBox.Text.Length == 0)
            {
                ObligatorioNumeroRetiroLabel.Text = "*Campo obligatorio ";
                ObligatorioNumeroRetiroLabel.Visible = true;
            }
            else
            {
                ObligatorioNumeroRetiroLabel.Visible = false;
            }

        }
    }   
}
