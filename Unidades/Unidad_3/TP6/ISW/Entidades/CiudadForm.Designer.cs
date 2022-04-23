
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
            this.DescrProductoTxt = new System.Windows.Forms.TextBox();
            this.DescrProductoLbl = new System.Windows.Forms.Label();
            this.FotoLbl = new System.Windows.Forms.Label();
            this.CiudadesCmb = new System.Windows.Forms.ComboBox();
            this.SeleccionarCiudadLbl = new System.Windows.Forms.Label();
            this.CiudadGrb = new System.Windows.Forms.GroupBox();
            this.ContinuarCiudadButtton = new System.Windows.Forms.Button();
            this.ProductoGrb = new System.Windows.Forms.GroupBox();
            this.ObligatorioDescripcionLabel = new System.Windows.Forms.Label();
            this.ObligatorioCiudadLabel = new System.Windows.Forms.Label();
            this.CiudadGrb.SuspendLayout();
            this.ProductoGrb.SuspendLayout();
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
            // DescrProductoTxt
            // 
            this.DescrProductoTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescrProductoTxt.Location = new System.Drawing.Point(24, 161);
            this.DescrProductoTxt.MaximumSize = new System.Drawing.Size(300, 200);
            this.DescrProductoTxt.Name = "DescrProductoTxt";
            this.DescrProductoTxt.Size = new System.Drawing.Size(300, 33);
            this.DescrProductoTxt.TabIndex = 1;
            // 
            // DescrProductoLbl
            // 
            this.DescrProductoLbl.AutoSize = true;
            this.DescrProductoLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescrProductoLbl.Location = new System.Drawing.Point(20, 118);
            this.DescrProductoLbl.Name = "DescrProductoLbl";
            this.DescrProductoLbl.Size = new System.Drawing.Size(350, 40);
            this.DescrProductoLbl.TabIndex = 2;
            this.DescrProductoLbl.Text = "Describa el/los producto/s:";
            // 
            // FotoLbl
            // 
            this.FotoLbl.AutoSize = true;
            this.FotoLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotoLbl.Location = new System.Drawing.Point(15, 16);
            this.FotoLbl.Name = "FotoLbl";
            this.FotoLbl.Size = new System.Drawing.Size(180, 40);
            this.FotoLbl.TabIndex = 3;
            this.FotoLbl.Text = "Agregar Foto";
            // 
            // CiudadesCmb
            // 
            this.CiudadesCmb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadesCmb.FormattingEnabled = true;
            this.CiudadesCmb.Location = new System.Drawing.Point(7, 70);
            this.CiudadesCmb.Name = "CiudadesCmb";
            this.CiudadesCmb.Size = new System.Drawing.Size(349, 33);
            this.CiudadesCmb.TabIndex = 4;
            // 
            // SeleccionarCiudadLbl
            // 
            this.SeleccionarCiudadLbl.AutoSize = true;
            this.SeleccionarCiudadLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarCiudadLbl.Location = new System.Drawing.Point(16, 27);
            this.SeleccionarCiudadLbl.Name = "SeleccionarCiudadLbl";
            this.SeleccionarCiudadLbl.Size = new System.Drawing.Size(380, 40);
            this.SeleccionarCiudadLbl.TabIndex = 5;
            this.SeleccionarCiudadLbl.Text = "Selecionar ciudad de Destino";
            // 
            // CiudadGrb
            // 
            this.CiudadGrb.Controls.Add(this.SeleccionarCiudadLbl);
            this.CiudadGrb.Controls.Add(this.CiudadesCmb);
            this.CiudadGrb.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadGrb.Location = new System.Drawing.Point(14, 243);
            this.CiudadGrb.Name = "CiudadGrb";
            this.CiudadGrb.Size = new System.Drawing.Size(479, 125);
            this.CiudadGrb.TabIndex = 24;
            this.CiudadGrb.TabStop = false;
            // 
            // ContinuarCiudadButtton
            // 
            this.ContinuarCiudadButtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContinuarCiudadButtton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuarCiudadButtton.Location = new System.Drawing.Point(536, 408);
            this.ContinuarCiudadButtton.Name = "ContinuarCiudadButtton";
            this.ContinuarCiudadButtton.Size = new System.Drawing.Size(160, 51);
            this.ContinuarCiudadButtton.TabIndex = 6;
            this.ContinuarCiudadButtton.Text = "Continuar";
            this.ContinuarCiudadButtton.UseVisualStyleBackColor = false;
            this.ContinuarCiudadButtton.Click += new System.EventHandler(this.ContinuarCiudadButtton_Click);
            // 
            // ProductoGrb
            // 
            this.ProductoGrb.Controls.Add(this.FotoLbl);
            this.ProductoGrb.Location = new System.Drawing.Point(443, 99);
            this.ProductoGrb.Name = "ProductoGrb";
            this.ProductoGrb.Size = new System.Drawing.Size(270, 91);
            this.ProductoGrb.TabIndex = 25;
            this.ProductoGrb.TabStop = false;
            // 
            // ObligatorioDescripcionLabel
            // 
            this.ObligatorioDescripcionLabel.AutoSize = true;
            this.ObligatorioDescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioDescripcionLabel.Location = new System.Drawing.Point(23, 197);
            this.ObligatorioDescripcionLabel.Name = "ObligatorioDescripcionLabel";
            this.ObligatorioDescripcionLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioDescripcionLabel.TabIndex = 28;
            this.ObligatorioDescripcionLabel.Text = "*Campo obligatorio";
            // 
            // ObligatorioCiudadLabel
            // 
            this.ObligatorioCiudadLabel.AutoSize = true;
            this.ObligatorioCiudadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioCiudadLabel.Location = new System.Drawing.Point(23, 371);
            this.ObligatorioCiudadLabel.Name = "ObligatorioCiudadLabel";
            this.ObligatorioCiudadLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioCiudadLabel.TabIndex = 29;
            this.ObligatorioCiudadLabel.Text = "*Campo obligatorio";
            // 
            // CiudadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(753, 471);
            this.Controls.Add(this.ObligatorioCiudadLabel);
            this.Controls.Add(this.ObligatorioDescripcionLabel);
            this.Controls.Add(this.ContinuarCiudadButtton);
            this.Controls.Add(this.DescrProductoTxt);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeliveryEatLbl;
        private System.Windows.Forms.TextBox DescrProductoTxt;
        private System.Windows.Forms.Label DescrProductoLbl;
        private System.Windows.Forms.Label FotoLbl;
        private System.Windows.Forms.ComboBox CiudadesCmb;
        private System.Windows.Forms.Label SeleccionarCiudadLbl;
        private System.Windows.Forms.GroupBox CiudadGrb;
        private System.Windows.Forms.GroupBox ProductoGrb;
        private System.Windows.Forms.Button ContinuarCiudadButtton;
        private System.Windows.Forms.Label ObligatorioDescripcionLabel;
        private System.Windows.Forms.Label ObligatorioCiudadLabel;
    }
}

