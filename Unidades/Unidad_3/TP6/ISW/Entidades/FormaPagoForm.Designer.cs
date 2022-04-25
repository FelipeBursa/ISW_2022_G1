
namespace ISW.Entidades
{
    partial class FormaPagoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.FormaPagoLbl = new System.Windows.Forms.Label();
            this.FormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmarPedidoButton = new System.Windows.Forms.Button();
            this.EfectivoGroupBox = new System.Windows.Forms.GroupBox();
            this.TarjetaGroupBox = new System.Windows.Forms.GroupBox();
            this.MontoPagaClienteTextBox = new System.Windows.Forms.TextBox();
            this.MontoPagaClienteLabel = new System.Windows.Forms.Label();
            this.TarjetaVisaGroupBox = new System.Windows.Forms.GroupBox();
            this.CodigoSeguridadTextBox = new System.Windows.Forms.TextBox();
            this.FechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CodigoSeguridadLabel = new System.Windows.Forms.Label();
            this.NumeroTarjetaTextBox = new System.Windows.Forms.TextBox();
            this.FechaVencimientoLabel = new System.Windows.Forms.Label();
            this.NumeroTarjetaLabel = new System.Windows.Forms.Label();
            this.NombreTitularTarjetaTextBox = new System.Windows.Forms.TextBox();
            this.NombreTitutarTarjetaLabel = new System.Windows.Forms.Label();
            this.FechaRecibidaLabel = new System.Windows.Forms.Label();
            this.FechaRecibidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EfectivoGroupBox.SuspendLayout();
            this.TarjetaVisaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoTextBox.Location = new System.Drawing.Point(207, 46);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(100, 29);
            this.MontoTextBox.TabIndex = 29;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoLabel.Location = new System.Drawing.Point(20, 40);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(181, 32);
            this.MontoLabel.TabIndex = 31;
            this.MontoLabel.Text = "Monto de envio:";
            // 
            // FormaPagoLbl
            // 
            this.FormaPagoLbl.AutoSize = true;
            this.FormaPagoLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaPagoLbl.Location = new System.Drawing.Point(12, 98);
            this.FormaPagoLbl.Name = "FormaPagoLbl";
            this.FormaPagoLbl.Size = new System.Drawing.Size(199, 32);
            this.FormaPagoLbl.TabIndex = 28;
            this.FormaPagoLbl.Text = "Métodos de pago:";
            // 
            // FormaPagoComboBox
            // 
            this.FormaPagoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaPagoComboBox.FormattingEnabled = true;
            this.FormaPagoComboBox.Location = new System.Drawing.Point(207, 101);
            this.FormaPagoComboBox.Name = "FormaPagoComboBox";
            this.FormaPagoComboBox.Size = new System.Drawing.Size(240, 29);
            this.FormaPagoComboBox.TabIndex = 30;
            this.FormaPagoComboBox.SelectedIndexChanged += new System.EventHandler(this.FormaPagoComboBox_SelectedIndexChanged);
            // 
            // ConfirmarPedidoButton
            // 
            this.ConfirmarPedidoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ConfirmarPedidoButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarPedidoButton.Location = new System.Drawing.Point(304, 609);
            this.ConfirmarPedidoButton.Name = "ConfirmarPedidoButton";
            this.ConfirmarPedidoButton.Size = new System.Drawing.Size(210, 46);
            this.ConfirmarPedidoButton.TabIndex = 32;
            this.ConfirmarPedidoButton.Text = "Confirmar Pedido";
            this.ConfirmarPedidoButton.UseVisualStyleBackColor = false;
            this.ConfirmarPedidoButton.Click += new System.EventHandler(this.ConfirmarPedidoButton_Click);
            // 
            // EfectivoGroupBox
            // 
            this.EfectivoGroupBox.Controls.Add(this.TarjetaGroupBox);
            this.EfectivoGroupBox.Controls.Add(this.MontoPagaClienteTextBox);
            this.EfectivoGroupBox.Controls.Add(this.MontoPagaClienteLabel);
            this.EfectivoGroupBox.Location = new System.Drawing.Point(22, 158);
            this.EfectivoGroupBox.Name = "EfectivoGroupBox";
            this.EfectivoGroupBox.Size = new System.Drawing.Size(475, 73);
            this.EfectivoGroupBox.TabIndex = 33;
            this.EfectivoGroupBox.TabStop = false;
            // 
            // TarjetaGroupBox
            // 
            this.TarjetaGroupBox.Location = new System.Drawing.Point(277, 130);
            this.TarjetaGroupBox.Name = "TarjetaGroupBox";
            this.TarjetaGroupBox.Size = new System.Drawing.Size(296, 183);
            this.TarjetaGroupBox.TabIndex = 34;
            this.TarjetaGroupBox.TabStop = false;
            // 
            // MontoPagaClienteTextBox
            // 
            this.MontoPagaClienteTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoPagaClienteTextBox.Location = new System.Drawing.Point(359, 25);
            this.MontoPagaClienteTextBox.Name = "MontoPagaClienteTextBox";
            this.MontoPagaClienteTextBox.Size = new System.Drawing.Size(100, 29);
            this.MontoPagaClienteTextBox.TabIndex = 30;
            // 
            // MontoPagaClienteLabel
            // 
            this.MontoPagaClienteLabel.AutoSize = true;
            this.MontoPagaClienteLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoPagaClienteLabel.Location = new System.Drawing.Point(6, 25);
            this.MontoPagaClienteLabel.Name = "MontoPagaClienteLabel";
            this.MontoPagaClienteLabel.Size = new System.Drawing.Size(347, 25);
            this.MontoPagaClienteLabel.TabIndex = 0;
            this.MontoPagaClienteLabel.Text = "Ingrese monto con el que se va a pagar:";
            // 
            // TarjetaVisaGroupBox
            // 
            this.TarjetaVisaGroupBox.Controls.Add(this.CodigoSeguridadTextBox);
            this.TarjetaVisaGroupBox.Controls.Add(this.FechaVencimientoDateTimePicker);
            this.TarjetaVisaGroupBox.Controls.Add(this.CodigoSeguridadLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.NumeroTarjetaTextBox);
            this.TarjetaVisaGroupBox.Controls.Add(this.FechaVencimientoLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.NumeroTarjetaLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.NombreTitularTarjetaTextBox);
            this.TarjetaVisaGroupBox.Controls.Add(this.NombreTitutarTarjetaLabel);
            this.TarjetaVisaGroupBox.Location = new System.Drawing.Point(18, 258);
            this.TarjetaVisaGroupBox.Name = "TarjetaVisaGroupBox";
            this.TarjetaVisaGroupBox.Size = new System.Drawing.Size(496, 207);
            this.TarjetaVisaGroupBox.TabIndex = 34;
            this.TarjetaVisaGroupBox.TabStop = false;
            // 
            // CodigoSeguridadTextBox
            // 
            this.CodigoSeguridadTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoSeguridadTextBox.Location = new System.Drawing.Point(206, 150);
            this.CodigoSeguridadTextBox.Name = "CodigoSeguridadTextBox";
            this.CodigoSeguridadTextBox.Size = new System.Drawing.Size(271, 29);
            this.CodigoSeguridadTextBox.TabIndex = 9;
            // 
            // FechaVencimientoDateTimePicker
            // 
            this.FechaVencimientoDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVencimientoDateTimePicker.Location = new System.Drawing.Point(206, 115);
            this.FechaVencimientoDateTimePicker.Name = "FechaVencimientoDateTimePicker";
            this.FechaVencimientoDateTimePicker.Size = new System.Drawing.Size(273, 29);
            this.FechaVencimientoDateTimePicker.TabIndex = 8;
            // 
            // CodigoSeguridadLabel
            // 
            this.CodigoSeguridadLabel.AutoSize = true;
            this.CodigoSeguridadLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoSeguridadLabel.Location = new System.Drawing.Point(10, 154);
            this.CodigoSeguridadLabel.Name = "CodigoSeguridadLabel";
            this.CodigoSeguridadLabel.Size = new System.Drawing.Size(192, 25);
            this.CodigoSeguridadLabel.TabIndex = 7;
            this.CodigoSeguridadLabel.Text = "Código de seguridad:";
            // 
            // NumeroTarjetaTextBox
            // 
            this.NumeroTarjetaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTarjetaTextBox.Location = new System.Drawing.Point(206, 72);
            this.NumeroTarjetaTextBox.Name = "NumeroTarjetaTextBox";
            this.NumeroTarjetaTextBox.Size = new System.Drawing.Size(273, 29);
            this.NumeroTarjetaTextBox.TabIndex = 4;
            // 
            // FechaVencimientoLabel
            // 
            this.FechaVencimientoLabel.AutoSize = true;
            this.FechaVencimientoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVencimientoLabel.Location = new System.Drawing.Point(10, 115);
            this.FechaVencimientoLabel.Name = "FechaVencimientoLabel";
            this.FechaVencimientoLabel.Size = new System.Drawing.Size(195, 25);
            this.FechaVencimientoLabel.TabIndex = 3;
            this.FechaVencimientoLabel.Text = "Fecha de vencimiento";
            // 
            // NumeroTarjetaLabel
            // 
            this.NumeroTarjetaLabel.AutoSize = true;
            this.NumeroTarjetaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTarjetaLabel.Location = new System.Drawing.Point(10, 72);
            this.NumeroTarjetaLabel.Name = "NumeroTarjetaLabel";
            this.NumeroTarjetaLabel.Size = new System.Drawing.Size(190, 25);
            this.NumeroTarjetaLabel.TabIndex = 2;
            this.NumeroTarjetaLabel.Text = "Número de la tarjeta:";
            // 
            // NombreTitularTarjetaTextBox
            // 
            this.NombreTitularTarjetaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTitularTarjetaTextBox.Location = new System.Drawing.Point(273, 33);
            this.NombreTitularTarjetaTextBox.Name = "NombreTitularTarjetaTextBox";
            this.NombreTitularTarjetaTextBox.Size = new System.Drawing.Size(206, 29);
            this.NombreTitularTarjetaTextBox.TabIndex = 1;
            // 
            // NombreTitutarTarjetaLabel
            // 
            this.NombreTitutarTarjetaLabel.AutoSize = true;
            this.NombreTitutarTarjetaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTitutarTarjetaLabel.Location = new System.Drawing.Point(7, 33);
            this.NombreTitutarTarjetaLabel.Name = "NombreTitutarTarjetaLabel";
            this.NombreTitutarTarjetaLabel.Size = new System.Drawing.Size(265, 25);
            this.NombreTitutarTarjetaLabel.TabIndex = 0;
            this.NombreTitutarTarjetaLabel.Text = "Nombre y Apellido del titular: ";
            // 
            // FechaRecibidaLabel
            // 
            this.FechaRecibidaLabel.AutoSize = true;
            this.FechaRecibidaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRecibidaLabel.Location = new System.Drawing.Point(12, 496);
            this.FechaRecibidaLabel.Name = "FechaRecibidaLabel";
            this.FechaRecibidaLabel.Size = new System.Drawing.Size(355, 32);
            this.FechaRecibidaLabel.TabIndex = 35;
            this.FechaRecibidaLabel.Text = "¿Cúando desea recibir el pedido?";
            // 
            // FechaRecibidaDateTimePicker
            // 
            this.FechaRecibidaDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRecibidaDateTimePicker.Location = new System.Drawing.Point(51, 541);
            this.FechaRecibidaDateTimePicker.Name = "FechaRecibidaDateTimePicker";
            this.FechaRecibidaDateTimePicker.Size = new System.Drawing.Size(273, 29);
            this.FechaRecibidaDateTimePicker.TabIndex = 36;
            // 
            // FormaPagoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(543, 667);
            this.Controls.Add(this.FechaRecibidaDateTimePicker);
            this.Controls.Add(this.FechaRecibidaLabel);
            this.Controls.Add(this.TarjetaVisaGroupBox);
            this.Controls.Add(this.EfectivoGroupBox);
            this.Controls.Add(this.ConfirmarPedidoButton);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.FormaPagoLbl);
            this.Controls.Add(this.FormaPagoComboBox);
            this.Name = "FormaPagoForm";
            this.Text = "Formas de pago";
            this.EfectivoGroupBox.ResumeLayout(false);
            this.EfectivoGroupBox.PerformLayout();
            this.TarjetaVisaGroupBox.ResumeLayout(false);
            this.TarjetaVisaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.Label FormaPagoLbl;
        private System.Windows.Forms.ComboBox FormaPagoComboBox;
        private System.Windows.Forms.Button ConfirmarPedidoButton;
        private System.Windows.Forms.GroupBox EfectivoGroupBox;
        private System.Windows.Forms.GroupBox TarjetaGroupBox;
        private System.Windows.Forms.TextBox MontoPagaClienteTextBox;
        private System.Windows.Forms.Label MontoPagaClienteLabel;
        private System.Windows.Forms.GroupBox TarjetaVisaGroupBox;
        private System.Windows.Forms.TextBox CodigoSeguridadTextBox;
        private System.Windows.Forms.DateTimePicker FechaVencimientoDateTimePicker;
        private System.Windows.Forms.Label CodigoSeguridadLabel;
        private System.Windows.Forms.TextBox NumeroTarjetaTextBox;
        private System.Windows.Forms.Label FechaVencimientoLabel;
        private System.Windows.Forms.Label NumeroTarjetaLabel;
        private System.Windows.Forms.TextBox NombreTitularTarjetaTextBox;
        private System.Windows.Forms.Label NombreTitutarTarjetaLabel;
        private System.Windows.Forms.Label FechaRecibidaLabel;
        private System.Windows.Forms.DateTimePicker FechaRecibidaDateTimePicker;
    }
}