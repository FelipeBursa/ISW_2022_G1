
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
            this.DeliveryEatLbl = new System.Windows.Forms.Label();
            this.DescripcionProductoTextBox = new System.Windows.Forms.TextBox();
            this.DescrProductoLbl = new System.Windows.Forms.Label();
            this.FotoLabel = new System.Windows.Forms.Label();
            this.CiudadesComboBox = new System.Windows.Forms.ComboBox();
            this.SeleccionarCiudadLbl = new System.Windows.Forms.Label();
            this.CiudadGrb = new System.Windows.Forms.GroupBox();
            this.ObligatorioCiudadLabel = new System.Windows.Forms.Label();
            this.ContinuarCiudadButtton = new System.Windows.Forms.Button();
            this.ProductoGrb = new System.Windows.Forms.GroupBox();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.cargarImagenBoton = new System.Windows.Forms.Button();
            this.ObligatorioDescripcionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CiudadGrb.SuspendLayout();
            this.ProductoGrb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeliveryEatLbl
            // 
            this.DeliveryEatLbl.AutoSize = true;
            this.DeliveryEatLbl.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryEatLbl.Location = new System.Drawing.Point(12, 9);
            this.DeliveryEatLbl.Name = "DeliveryEatLbl";
            this.DeliveryEatLbl.Size = new System.Drawing.Size(338, 86);
            this.DeliveryEatLbl.TabIndex = 0;
            this.DeliveryEatLbl.Text = "DeliverEat!";
            // 
            // DescripcionProductoTextBox
            // 
            this.DescripcionProductoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescripcionProductoTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProductoTextBox.Location = new System.Drawing.Point(27, 142);
            this.DescripcionProductoTextBox.MaximumSize = new System.Drawing.Size(300, 200);
            this.DescripcionProductoTextBox.Multiline = true;
            this.DescripcionProductoTextBox.Name = "DescripcionProductoTextBox";
            this.DescripcionProductoTextBox.Size = new System.Drawing.Size(300, 100);
            this.DescripcionProductoTextBox.TabIndex = 1;
            // 
            // DescrProductoLbl
            // 
            this.DescrProductoLbl.AutoSize = true;
            this.DescrProductoLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescrProductoLbl.Location = new System.Drawing.Point(20, 99);
            this.DescrProductoLbl.Name = "DescrProductoLbl";
            this.DescrProductoLbl.Size = new System.Drawing.Size(350, 40);
            this.DescrProductoLbl.TabIndex = 2;
            this.DescrProductoLbl.Text = "Describa el/los producto/s:";
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
            this.CiudadesComboBox.Location = new System.Drawing.Point(15, 77);
            this.CiudadesComboBox.Name = "CiudadesComboBox";
            this.CiudadesComboBox.Size = new System.Drawing.Size(349, 33);
            this.CiudadesComboBox.TabIndex = 4;
            // 
            // SeleccionarCiudadLbl
            // 
            this.SeleccionarCiudadLbl.AutoSize = true;
            this.SeleccionarCiudadLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarCiudadLbl.Location = new System.Drawing.Point(22, 21);
            this.SeleccionarCiudadLbl.Name = "SeleccionarCiudadLbl";
            this.SeleccionarCiudadLbl.Size = new System.Drawing.Size(380, 40);
            this.SeleccionarCiudadLbl.TabIndex = 5;
            this.SeleccionarCiudadLbl.Text = "Selecionar ciudad de Destino";
            // 
            // CiudadGrb
            // 
            this.CiudadGrb.Controls.Add(this.ObligatorioCiudadLabel);
            this.CiudadGrb.Controls.Add(this.SeleccionarCiudadLbl);
            this.CiudadGrb.Controls.Add(this.CiudadesComboBox);
            this.CiudadGrb.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadGrb.Location = new System.Drawing.Point(12, 276);
            this.CiudadGrb.Name = "CiudadGrb";
            this.CiudadGrb.Size = new System.Drawing.Size(481, 149);
            this.CiudadGrb.TabIndex = 24;
            this.CiudadGrb.TabStop = false;
            // 
            // ObligatorioCiudadLabel
            // 
            this.ObligatorioCiudadLabel.AutoSize = true;
            this.ObligatorioCiudadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioCiudadLabel.Location = new System.Drawing.Point(11, 113);
            this.ObligatorioCiudadLabel.Name = "ObligatorioCiudadLabel";
            this.ObligatorioCiudadLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioCiudadLabel.TabIndex = 29;
            this.ObligatorioCiudadLabel.Text = "*Campo obligatorio";
            // 
            // ContinuarCiudadButtton
            // 
            this.ContinuarCiudadButtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContinuarCiudadButtton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuarCiudadButtton.Location = new System.Drawing.Point(537, 401);
            this.ContinuarCiudadButtton.Name = "ContinuarCiudadButtton";
            this.ContinuarCiudadButtton.Size = new System.Drawing.Size(160, 51);
            this.ContinuarCiudadButtton.TabIndex = 6;
            this.ContinuarCiudadButtton.Text = "Continuar";
            this.ContinuarCiudadButtton.UseVisualStyleBackColor = false;
            this.ContinuarCiudadButtton.Click += new System.EventHandler(this.ContinuarCiudadButtton_Click);
            // 
            // ProductoGrb
            // 
            this.ProductoGrb.Controls.Add(this.label1);
            this.ProductoGrb.Controls.Add(this.imagenPictureBox);
            this.ProductoGrb.Controls.Add(this.cargarImagenBoton);
            this.ProductoGrb.Controls.Add(this.FotoLabel);
            this.ProductoGrb.Location = new System.Drawing.Point(450, 52);
            this.ProductoGrb.Name = "ProductoGrb";
            this.ProductoGrb.Size = new System.Drawing.Size(291, 221);
            this.ProductoGrb.TabIndex = 25;
            this.ProductoGrb.TabStop = false;
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.Location = new System.Drawing.Point(22, 100);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(249, 115);
            this.imagenPictureBox.TabIndex = 29;
            this.imagenPictureBox.TabStop = false;
            // 
            // cargarImagenBoton
            // 
            this.cargarImagenBoton.Location = new System.Drawing.Point(75, 59);
            this.cargarImagenBoton.Name = "cargarImagenBoton";
            this.cargarImagenBoton.Size = new System.Drawing.Size(140, 23);
            this.cargarImagenBoton.TabIndex = 4;
            this.cargarImagenBoton.Text = "Seleccionar Imagen ";
            this.cargarImagenBoton.UseVisualStyleBackColor = true;
            this.cargarImagenBoton.Click += new System.EventHandler(this.cargarImagenBoton_Click);
            // 
            // ObligatorioDescripcionLabel
            // 
            this.ObligatorioDescripcionLabel.AutoSize = true;
            this.ObligatorioDescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioDescripcionLabel.Location = new System.Drawing.Point(23, 252);
            this.ObligatorioDescripcionLabel.Name = "ObligatorioDescripcionLabel";
            this.ObligatorioDescripcionLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioDescripcionLabel.TabIndex = 28;
            this.ObligatorioDescripcionLabel.Text = "*Campo obligatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // CiudadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(753, 471);
            this.Controls.Add(this.ContinuarCiudadButtton);
            this.Controls.Add(this.DescripcionProductoTextBox);
            this.Controls.Add(this.ObligatorioDescripcionLabel);
            this.Controls.Add(this.DescrProductoLbl);
            this.Controls.Add(this.ProductoGrb);
            this.Controls.Add(this.CiudadGrb);
            this.Controls.Add(this.DeliveryEatLbl);
            this.Name = "CiudadForm";
            this.Text = "DeliverEat";
            this.Load += new System.EventHandler(this.InterfazPedidoDeLoQueSea_Load);
            this.CiudadGrb.ResumeLayout(false);
            this.CiudadGrb.PerformLayout();
            this.ProductoGrb.ResumeLayout(false);
            this.ProductoGrb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeliveryEatLbl;
        private System.Windows.Forms.TextBox DescripcionProductoTextBox;
        private System.Windows.Forms.Label DescrProductoLbl;
        private System.Windows.Forms.Label FotoLabel;
        private System.Windows.Forms.ComboBox CiudadesComboBox;
        private System.Windows.Forms.Label SeleccionarCiudadLbl;
        private System.Windows.Forms.GroupBox CiudadGrb;
        private System.Windows.Forms.GroupBox ProductoGrb;
        private System.Windows.Forms.Button ContinuarCiudadButtton;
        private System.Windows.Forms.Label ObligatorioDescripcionLabel;
        private System.Windows.Forms.Label ObligatorioCiudadLabel;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.Button cargarImagenBoton;
        private System.Windows.Forms.Label label1;
    }
}

