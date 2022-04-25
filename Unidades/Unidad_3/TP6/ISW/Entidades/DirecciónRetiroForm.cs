﻿using System;
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
        bool Validacion;
        public DirecciónRetiroForm()
        {
            InitializeComponent();
            DirecciónRetiroGroupBox.Enabled = false;
            Validacion = false;                     
        }
        
        //Hace visible la imagen y oculta el gruop box
        private void MapaInteractivoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalleTextBox.Text = "";
            NumCalleTextBox.Text = "";
            ReferenciaTextBox.Text = "";
            DirecciónRetiroGroupBox.Enabled = false;
            MapaInteractivoButton.Enabled = true;
        }

        //Hace visible el group box y oculta la imagen
        private void LlenarCamposRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DirecciónRetiroGroupBox.Enabled = true;
            MapaInteractivoButton.Enabled = false;
            
        }
        
        private void ValidarCampos()
        {
            if ((ReferenciaTextBox.Text.Length > 100) || (CalleTextBox.Text.Equals("")) || (NumCalleTextBox.Text.Equals("")))
            {
                MessageBox.Show("Por favor complete todos los campos y asegurese de que la referencia no supere los 100 caracteres", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (CalleTextBox.Text.Equals(""))
                {
                    CalleTextBox.Focus();
                }
                if (NumCalleTextBox.Text.Equals(""))
                {
                    NumCalleTextBox.Focus();
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
            CalleTextBox.Text = "Macaon";
            NumCalleTextBox.Text = "4124";
            ReferenciaTextBox.Text = "Casa Blanca con ventanas grandes";
        }

        private void NumCalleTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        }

    }

    
}
