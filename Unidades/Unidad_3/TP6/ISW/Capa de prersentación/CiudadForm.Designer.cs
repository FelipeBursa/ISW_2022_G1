
namespace ISW
{
    partial class CiudadForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeliveryEatLabel = new System.Windows.Forms.Label();
            this.DescripcionProductoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionProductoLabel = new System.Windows.Forms.Label();
            this.FotoLabel = new System.Windows.Forms.Label();
            this.CiudadesComboBox = new System.Windows.Forms.ComboBox();
            this.SeleccionarCiudadLabel = new System.Windows.Forms.Label();
            this.CiudadGroupBox = new System.Windows.Forms.GroupBox();
            this.ObligatorioCiudadLabel = new System.Windows.Forms.Label();
            this.ContinuarCiudadButtton = new System.Windows.Forms.Button();
            this.ImagenGroupBox = new System.Windows.Forms.GroupBox();
            this.TamañoLabel = new System.Windows.Forms.Label();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.CargarImagenButton = new System.Windows.Forms.Button();
            this.ObligatorioDescripcionLabel = new System.Windows.Forms.Label();
            this.DescripcionGroupBox = new System.Windows.Forms.GroupBox();
            this.CiudadGroupBox.SuspendLayout();
            this.ImagenGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.DescripcionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeliveryEatLabel
            // 
            this.DeliveryEatLabel.AutoSize = true;
            this.DeliveryEatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(113)))), ((int)(((byte)(82)))));
            this.DeliveryEatLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryEatLabel.Location = new System.Drawing.Point(12, 9);
            this.DeliveryEatLabel.Name = "DeliveryEatLabel";
            this.DeliveryEatLabel.Size = new System.Drawing.Size(338, 86);
            this.DeliveryEatLabel.TabIndex = 0;
            this.DeliveryEatLabel.Text = "DeliverEat!";
            // 
            // DescripcionProductoTextBox
            // 
            this.DescripcionProductoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescripcionProductoTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProductoTextBox.Location = new System.Drawing.Point(13, 59);
            this.DescripcionProductoTextBox.MaximumSize = new System.Drawing.Size(400, 400);
            this.DescripcionProductoTextBox.MaxLength = 50;
            this.DescripcionProductoTextBox.Multiline = true;
            this.DescripcionProductoTextBox.Name = "DescripcionProductoTextBox";
            this.DescripcionProductoTextBox.Size = new System.Drawing.Size(400, 93);
            this.DescripcionProductoTextBox.TabIndex = 1;
            this.DescripcionProductoTextBox.TextChanged += new System.EventHandler(this.DescripcionProductoTextBox_TextChanged);
            // 
            // DescripcionProductoLabel
            // 
            this.DescripcionProductoLabel.AutoSize = true;
            this.DescripcionProductoLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProductoLabel.Location = new System.Drawing.Point(6, 16);
            this.DescripcionProductoLabel.Name = "DescripcionProductoLabel";
            this.DescripcionProductoLabel.Size = new System.Drawing.Size(350, 40);
            this.DescripcionProductoLabel.TabIndex = 2;
            this.DescripcionProductoLabel.Text = "Describa el/los producto/s:";
            // 
            // FotoLabel
            // 
            this.FotoLabel.AutoSize = true;
            this.FotoLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotoLabel.Location = new System.Drawing.Point(15, 16);
            this.FotoLabel.Name = "FotoLabel";
            this.FotoLabel.Size = new System.Drawing.Size(180, 40);
            this.FotoLabel.TabIndex = 3;
            this.FotoLabel.Text = "Agregar Foto";
            // 
            // CiudadesComboBox
            // 
            this.CiudadesComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadesComboBox.FormattingEnabled = true;
            this.CiudadesComboBox.Location = new System.Drawing.Point(7, 48);
            this.CiudadesComboBox.Name = "CiudadesComboBox";
            this.CiudadesComboBox.Size = new System.Drawing.Size(406, 33);
            this.CiudadesComboBox.TabIndex = 4;
            this.CiudadesComboBox.TextChanged += new System.EventHandler(this.CiudadesComboBox_TextChanged);
            // 
            // SeleccionarCiudadLabel
            // 
            this.SeleccionarCiudadLabel.AutoSize = true;
            this.SeleccionarCiudadLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarCiudadLabel.Location = new System.Drawing.Point(10, 110);
            this.SeleccionarCiudadLabel.Name = "SeleccionarCiudadLabel";
            this.SeleccionarCiudadLabel.Size = new System.Drawing.Size(380, 40);
            this.SeleccionarCiudadLabel.TabIndex = 5;
            this.SeleccionarCiudadLabel.Text = "Selecionar ciudad de Destino";
            // 
            // CiudadGroupBox
            // 
            this.CiudadGroupBox.Controls.Add(this.ObligatorioCiudadLabel);
            this.CiudadGroupBox.Controls.Add(this.CiudadesComboBox);
            this.CiudadGroupBox.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadGroupBox.Location = new System.Drawing.Point(12, 123);
            this.CiudadGroupBox.Name = "CiudadGroupBox";
            this.CiudadGroupBox.Size = new System.Drawing.Size(450, 103);
            this.CiudadGroupBox.TabIndex = 24;
            this.CiudadGroupBox.TabStop = false;
            // 
            // ObligatorioCiudadLabel
            // 
            this.ObligatorioCiudadLabel.AutoSize = true;
            this.ObligatorioCiudadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioCiudadLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ObligatorioCiudadLabel.Location = new System.Drawing.Point(11, 132);
            this.ObligatorioCiudadLabel.Name = "ObligatorioCiudadLabel";
            this.ObligatorioCiudadLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioCiudadLabel.TabIndex = 29;
            this.ObligatorioCiudadLabel.Text = "*Campo obligatorio";
            // 
            // ContinuarCiudadButtton
            // 
            this.ContinuarCiudadButtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(113)))), ((int)(((byte)(82)))));
            this.ContinuarCiudadButtton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuarCiudadButtton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(212)))), ((int)(((byte)(113)))));
            this.ContinuarCiudadButtton.Location = new System.Drawing.Point(330, 609);
            this.ContinuarCiudadButtton.Name = "ContinuarCiudadButtton";
            this.ContinuarCiudadButtton.Size = new System.Drawing.Size(160, 51);
            this.ContinuarCiudadButtton.TabIndex = 6;
            this.ContinuarCiudadButtton.Text = "Continuar";
            this.ContinuarCiudadButtton.UseVisualStyleBackColor = false;
            this.ContinuarCiudadButtton.Click += new System.EventHandler(this.ContinuarCiudadButtton_Click);
            // 
            // ImagenGroupBox
            // 
            this.ImagenGroupBox.Controls.Add(this.TamañoLabel);
            this.ImagenGroupBox.Controls.Add(this.ImagenPictureBox);
            this.ImagenGroupBox.Controls.Add(this.CargarImagenButton);
            this.ImagenGroupBox.Controls.Add(this.FotoLabel);
            this.ImagenGroupBox.Location = new System.Drawing.Point(12, 419);
            this.ImagenGroupBox.Name = "ImagenGroupBox";
            this.ImagenGroupBox.Size = new System.Drawing.Size(312, 241);
            this.ImagenGroupBox.TabIndex = 25;
            this.ImagenGroupBox.TabStop = false;
            // 
            // TamañoLabel
            // 
            this.TamañoLabel.AutoSize = true;
            this.TamañoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamañoLabel.Location = new System.Drawing.Point(19, 102);
            this.TamañoLabel.Name = "TamañoLabel";
            this.TamañoLabel.Size = new System.Drawing.Size(0, 21);
            this.TamañoLabel.TabIndex = 30;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Location = new System.Drawing.Point(25, 102);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(249, 115);
            this.ImagenPictureBox.TabIndex = 29;
            this.ImagenPictureBox.TabStop = false;
            // 
            // CargarImagenButton
            // 
            this.CargarImagenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(113)))), ((int)(((byte)(82)))));
            this.CargarImagenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarImagenButton.Location = new System.Drawing.Point(25, 59);
            this.CargarImagenButton.Name = "CargarImagenButton";
            this.CargarImagenButton.Size = new System.Drawing.Size(184, 35);
            this.CargarImagenButton.TabIndex = 4;
            this.CargarImagenButton.Text = "Seleccionar Imagen ";
            this.CargarImagenButton.UseVisualStyleBackColor = false;
            this.CargarImagenButton.Click += new System.EventHandler(this.CargarImagenBoton_Click);
            // 
            // ObligatorioDescripcionLabel
            // 
            this.ObligatorioDescripcionLabel.AutoSize = true;
            this.ObligatorioDescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioDescripcionLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ObligatorioDescripcionLabel.Location = new System.Drawing.Point(9, 155);
            this.ObligatorioDescripcionLabel.Name = "ObligatorioDescripcionLabel";
            this.ObligatorioDescripcionLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioDescripcionLabel.TabIndex = 28;
            this.ObligatorioDescripcionLabel.Text = "*Campo obligatorio";
            // 
            // DescripcionGroupBox
            // 
            this.DescripcionGroupBox.Controls.Add(this.DescripcionProductoLabel);
            this.DescripcionGroupBox.Controls.Add(this.DescripcionProductoTextBox);
            this.DescripcionGroupBox.Controls.Add(this.ObligatorioDescripcionLabel);
            this.DescripcionGroupBox.Location = new System.Drawing.Point(12, 228);
            this.DescripcionGroupBox.Name = "DescripcionGroupBox";
            this.DescripcionGroupBox.Size = new System.Drawing.Size(450, 185);
            this.DescripcionGroupBox.TabIndex = 29;
            this.DescripcionGroupBox.TabStop = false;
            // 
            // CiudadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(525, 675);
            this.Controls.Add(this.DescripcionGroupBox);
            this.Controls.Add(this.ContinuarCiudadButtton);
            this.Controls.Add(this.SeleccionarCiudadLabel);
            this.Controls.Add(this.ImagenGroupBox);
            this.Controls.Add(this.CiudadGroupBox);
            this.Controls.Add(this.DeliveryEatLabel);
            this.Name = "CiudadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliverEat";
            this.Load += new System.EventHandler(this.InterfazPedidoDeLoQueSea_Load);
            this.CiudadGroupBox.ResumeLayout(false);
            this.CiudadGroupBox.PerformLayout();
            this.ImagenGroupBox.ResumeLayout(false);
            this.ImagenGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.DescripcionGroupBox.ResumeLayout(false);
            this.DescripcionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeliveryEatLabel;
        private System.Windows.Forms.TextBox DescripcionProductoTextBox;
        private System.Windows.Forms.Label DescripcionProductoLabel;
        private System.Windows.Forms.Label FotoLabel;
        private System.Windows.Forms.ComboBox CiudadesComboBox;
        private System.Windows.Forms.Label SeleccionarCiudadLabel;
        private System.Windows.Forms.GroupBox CiudadGroupBox;
        private System.Windows.Forms.GroupBox ImagenGroupBox;
        private System.Windows.Forms.Button ContinuarCiudadButtton;
        private System.Windows.Forms.Label ObligatorioDescripcionLabel;
        private System.Windows.Forms.Label ObligatorioCiudadLabel;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.Button CargarImagenButton;
        private System.Windows.Forms.Label TamañoLabel;
        private System.Windows.Forms.GroupBox DescripcionGroupBox;
    }
}

