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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void DeLoQueSeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///Continua a la siguiente ventana del pedido
            CiudadForm ventana = new CiudadForm();
            ventana.Show();
            this.Hide();
        }
    }
}
