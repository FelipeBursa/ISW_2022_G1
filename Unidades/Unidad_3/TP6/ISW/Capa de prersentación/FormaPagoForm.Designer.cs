
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
            this.FormaPagoLabel = new System.Windows.Forms.Label();
            this.FormaPagoComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmarPedidoButton = new System.Windows.Forms.Button();
            this.EfectivoGroupBox = new System.Windows.Forms.GroupBox();
            this.signoPesosLabel = new System.Windows.Forms.Label();
            this.MontoValidacionLabel = new System.Windows.Forms.Label();
            this.TarjetaGroupBox = new System.Windows.Forms.GroupBox();
            this.MontoPagaClienteTextBox = new System.Windows.Forms.TextBox();
            this.MontoPagaClienteLabel = new System.Windows.Forms.Label();
            this.TarjetaVisaGroupBox = new System.Windows.Forms.GroupBox();
            this.MensajeTarjetaLabel = new System.Windows.Forms.Label();
            this.FechaTarjetaLabel = new System.Windows.Forms.Label();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.AdvertenciaTarjetaLabel = new System.Windows.Forms.Label();
            this.CodigoSeguridadTextBox = new System.Windows.Forms.TextBox();
            this.FechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CodigoSeguridadLabel = new System.Windows.Forms.Label();
            this.NumeroTarjetaTextBox = new System.Windows.Forms.TextBox();
            this.FechaVencimientoLabel = new System.Windows.Forms.Label();
            this.NumeroTarjetaLabel = new System.Windows.Forms.Label();
            this.NombreTitularTarjetaTextBox = new System.Windows.Forms.TextBox();
            this.NombreTitutarTarjetaLabel = new System.Windows.Forms.Label();
            this.VolverDireccionDestinoButton = new System.Windows.Forms.Button();
            this.FechaRecibidaLabel = new System.Windows.Forms.Label();
            this.ProgramadoRadioButton = new System.Windows.Forms.RadioButton();
            this.FechaRecibidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InmediatoRadioButton = new System.Windows.Forms.RadioButton();
            this.FechaRecibidaGroupBox = new System.Windows.Forms.GroupBox();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.EfectivoGroupBox.SuspendLayout();
            this.TarjetaVisaGroupBox.SuspendLayout();
            this.FechaRecibidaGroupBox.SuspendLayout();
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
            this.MontoLabel.Location = new System.Drawing.Point(12, 40);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(181, 32);
            this.MontoLabel.TabIndex = 31;
            this.MontoLabel.Text = "Monto de envio:";
            // 
            // FormaPagoLabel
            // 
            this.FormaPagoLabel.AutoSize = true;
            this.FormaPagoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaPagoLabel.Location = new System.Drawing.Point(12, 98);
            this.FormaPagoLabel.Name = "FormaPagoLabel";
            this.FormaPagoLabel.Size = new System.Drawing.Size(199, 32);
            this.FormaPagoLabel.TabIndex = 28;
            this.FormaPagoLabel.Text = "Métodos de pago:";
            // 
            // FormaPagoComboBox
            // 
            this.FormaPagoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormaPagoComboBox.FormattingEnabled = true;
            this.FormaPagoComboBox.Location = new System.Drawing.Point(217, 101);
            this.FormaPagoComboBox.Name = "FormaPagoComboBox";
            this.FormaPagoComboBox.Size = new System.Drawing.Size(260, 29);
            this.FormaPagoComboBox.TabIndex = 30;
            this.FormaPagoComboBox.SelectedIndexChanged += new System.EventHandler(this.FormaPagoComboBox_SelectedIndexChanged);
            // 
            // ConfirmarPedidoButton
            // 
            this.ConfirmarPedidoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(113)))), ((int)(((byte)(82)))));
            this.ConfirmarPedidoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarPedidoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(212)))), ((int)(((byte)(113)))));
            this.ConfirmarPedidoButton.Location = new System.Drawing.Point(259, 563);
            this.ConfirmarPedidoButton.Name = "ConfirmarPedidoButton";
            this.ConfirmarPedidoButton.Size = new System.Drawing.Size(243, 49);
            this.ConfirmarPedidoButton.TabIndex = 32;
            this.ConfirmarPedidoButton.Text = "Confirmar Pedido";
            this.ConfirmarPedidoButton.UseVisualStyleBackColor = false;
            this.ConfirmarPedidoButton.Click += new System.EventHandler(this.ConfirmarPedidoButton_Click);
            // 
            // EfectivoGroupBox
            // 
            this.EfectivoGroupBox.Controls.Add(this.signoPesosLabel);
            this.EfectivoGroupBox.Controls.Add(this.MontoValidacionLabel);
            this.EfectivoGroupBox.Controls.Add(this.TarjetaGroupBox);
            this.EfectivoGroupBox.Controls.Add(this.MontoPagaClienteTextBox);
            this.EfectivoGroupBox.Controls.Add(this.MontoPagaClienteLabel);
            this.EfectivoGroupBox.Location = new System.Drawing.Point(18, 136);
            this.EfectivoGroupBox.Name = "EfectivoGroupBox";
            this.EfectivoGroupBox.Size = new System.Drawing.Size(593, 80);
            this.EfectivoGroupBox.TabIndex = 33;
            this.EfectivoGroupBox.TabStop = false;
            // 
            // signoPesosLabel
            // 
            this.signoPesosLabel.AutoSize = true;
            this.signoPesosLabel.BackColor = System.Drawing.Color.Transparent;
            this.signoPesosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoPesosLabel.Location = new System.Drawing.Point(555, 29);
            this.signoPesosLabel.Name = "signoPesosLabel";
            this.signoPesosLabel.Size = new System.Drawing.Size(18, 20);
            this.signoPesosLabel.TabIndex = 36;
            this.signoPesosLabel.Text = "$";
            // 
            // MontoValidacionLabel
            // 
            this.MontoValidacionLabel.AutoSize = true;
            this.MontoValidacionLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.MontoValidacionLabel.Location = new System.Drawing.Point(268, 60);
            this.MontoValidacionLabel.Name = "MontoValidacionLabel";
            this.MontoValidacionLabel.Size = new System.Drawing.Size(35, 13);
            this.MontoValidacionLabel.TabIndex = 35;
            this.MontoValidacionLabel.Text = "label1";
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
            this.MontoPagaClienteTextBox.MaxLength = 5;
            this.MontoPagaClienteTextBox.Name = "MontoPagaClienteTextBox";
            this.MontoPagaClienteTextBox.Size = new System.Drawing.Size(226, 29);
            this.MontoPagaClienteTextBox.TabIndex = 30;
            this.MontoPagaClienteTextBox.TextChanged += new System.EventHandler(this.MontoPagaClienteTextBox_TextChanged);
            this.MontoPagaClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MontoPagaClienteTextBox_KeyPress);
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
            this.TarjetaVisaGroupBox.Controls.Add(this.MensajeTarjetaLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.FechaTarjetaLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.CodigoLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.AdvertenciaTarjetaLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.CodigoSeguridadTextBox);
            this.TarjetaVisaGroupBox.Controls.Add(this.FechaVencimientoDateTimePicker);
            this.TarjetaVisaGroupBox.Controls.Add(this.CodigoSeguridadLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.NumeroTarjetaTextBox);
            this.TarjetaVisaGroupBox.Controls.Add(this.FechaVencimientoLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.NumeroTarjetaLabel);
            this.TarjetaVisaGroupBox.Controls.Add(this.NombreTitularTarjetaTextBox);
            this.TarjetaVisaGroupBox.Controls.Add(this.NombreTitutarTarjetaLabel);
            this.TarjetaVisaGroupBox.Location = new System.Drawing.Point(18, 133);
            this.TarjetaVisaGroupBox.Name = "TarjetaVisaGroupBox";
            this.TarjetaVisaGroupBox.Size = new System.Drawing.Size(593, 227);
            this.TarjetaVisaGroupBox.TabIndex = 34;
            this.TarjetaVisaGroupBox.TabStop = false;
            // 
            // MensajeTarjetaLabel
            // 
            this.MensajeTarjetaLabel.AutoSize = true;
            this.MensajeTarjetaLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.MensajeTarjetaLabel.Location = new System.Drawing.Point(206, 106);
            this.MensajeTarjetaLabel.Name = "MensajeTarjetaLabel";
            this.MensajeTarjetaLabel.Size = new System.Drawing.Size(204, 13);
            this.MensajeTarjetaLabel.TabIndex = 13;
            this.MensajeTarjetaLabel.Text = "*Ingrese un número de tarjeta VISA válido";
            this.MensajeTarjetaLabel.Visible = false;
            // 
            // FechaTarjetaLabel
            // 
            this.FechaTarjetaLabel.AutoSize = true;
            this.FechaTarjetaLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.FechaTarjetaLabel.Location = new System.Drawing.Point(206, 162);
            this.FechaTarjetaLabel.Name = "FechaTarjetaLabel";
            this.FechaTarjetaLabel.Size = new System.Drawing.Size(128, 13);
            this.FechaTarjetaLabel.TabIndex = 12;
            this.FechaTarjetaLabel.Text = "*Ingrese una fecha válida";
            this.FechaTarjetaLabel.Visible = false;
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CodigoLabel.Location = new System.Drawing.Point(209, 209);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(35, 13);
            this.CodigoLabel.TabIndex = 11;
            this.CodigoLabel.Text = "label1";
            // 
            // AdvertenciaTarjetaLabel
            // 
            this.AdvertenciaTarjetaLabel.AutoSize = true;
            this.AdvertenciaTarjetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvertenciaTarjetaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdvertenciaTarjetaLabel.Location = new System.Drawing.Point(206, 104);
            this.AdvertenciaTarjetaLabel.Name = "AdvertenciaTarjetaLabel";
            this.AdvertenciaTarjetaLabel.Size = new System.Drawing.Size(0, 16);
            this.AdvertenciaTarjetaLabel.TabIndex = 10;
            // 
            // CodigoSeguridadTextBox
            // 
            this.CodigoSeguridadTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoSeguridadTextBox.Location = new System.Drawing.Point(205, 178);
            this.CodigoSeguridadTextBox.MaxLength = 3;
            this.CodigoSeguridadTextBox.Name = "CodigoSeguridadTextBox";
            this.CodigoSeguridadTextBox.Size = new System.Drawing.Size(326, 29);
            this.CodigoSeguridadTextBox.TabIndex = 9;
            this.CodigoSeguridadTextBox.TextChanged += new System.EventHandler(this.CodigoSeguridadTextBox_TextChanged);
            this.CodigoSeguridadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoSeguridadTextBox_KeyPress);
            // 
            // FechaVencimientoDateTimePicker
            // 
            this.FechaVencimientoDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVencimientoDateTimePicker.Location = new System.Drawing.Point(206, 127);
            this.FechaVencimientoDateTimePicker.Name = "FechaVencimientoDateTimePicker";
            this.FechaVencimientoDateTimePicker.Size = new System.Drawing.Size(326, 29);
            this.FechaVencimientoDateTimePicker.TabIndex = 8;
            this.FechaVencimientoDateTimePicker.ValueChanged += new System.EventHandler(this.FechaVencimientoDateTimePicker_ValueChanged);
            // 
            // CodigoSeguridadLabel
            // 
            this.CodigoSeguridadLabel.AutoSize = true;
            this.CodigoSeguridadLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoSeguridadLabel.Location = new System.Drawing.Point(9, 178);
            this.CodigoSeguridadLabel.Name = "CodigoSeguridadLabel";
            this.CodigoSeguridadLabel.Size = new System.Drawing.Size(192, 25);
            this.CodigoSeguridadLabel.TabIndex = 7;
            this.CodigoSeguridadLabel.Text = "Código de seguridad:";
            // 
            // NumeroTarjetaTextBox
            // 
            this.NumeroTarjetaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTarjetaTextBox.Location = new System.Drawing.Point(205, 73);
            this.NumeroTarjetaTextBox.MaxLength = 16;
            this.NumeroTarjetaTextBox.Name = "NumeroTarjetaTextBox";
            this.NumeroTarjetaTextBox.Size = new System.Drawing.Size(326, 29);
            this.NumeroTarjetaTextBox.TabIndex = 4;
            this.NumeroTarjetaTextBox.TextChanged += new System.EventHandler(this.NumeroTarjetaTextBox_TextChanged);
            this.NumeroTarjetaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroTarjetaTextBox_KeyPress);
            // 
            // FechaVencimientoLabel
            // 
            this.FechaVencimientoLabel.AutoSize = true;
            this.FechaVencimientoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaVencimientoLabel.Location = new System.Drawing.Point(9, 130);
            this.FechaVencimientoLabel.Name = "FechaVencimientoLabel";
            this.FechaVencimientoLabel.Size = new System.Drawing.Size(195, 25);
            this.FechaVencimientoLabel.TabIndex = 3;
            this.FechaVencimientoLabel.Text = "Fecha de vencimiento";
            // 
            // NumeroTarjetaLabel
            // 
            this.NumeroTarjetaLabel.AutoSize = true;
            this.NumeroTarjetaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTarjetaLabel.Location = new System.Drawing.Point(6, 73);
            this.NumeroTarjetaLabel.Name = "NumeroTarjetaLabel";
            this.NumeroTarjetaLabel.Size = new System.Drawing.Size(190, 25);
            this.NumeroTarjetaLabel.TabIndex = 2;
            this.NumeroTarjetaLabel.Text = "Número de la tarjeta:";
            // 
            // NombreTitularTarjetaTextBox
            // 
            this.NombreTitularTarjetaTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTitularTarjetaTextBox.Location = new System.Drawing.Point(269, 25);
            this.NombreTitularTarjetaTextBox.Name = "NombreTitularTarjetaTextBox";
            this.NombreTitularTarjetaTextBox.Size = new System.Drawing.Size(259, 29);
            this.NombreTitularTarjetaTextBox.TabIndex = 1;
            // 
            // NombreTitutarTarjetaLabel
            // 
            this.NombreTitutarTarjetaLabel.AutoSize = true;
            this.NombreTitutarTarjetaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTitutarTarjetaLabel.Location = new System.Drawing.Point(6, 25);
            this.NombreTitutarTarjetaLabel.Name = "NombreTitutarTarjetaLabel";
            this.NombreTitutarTarjetaLabel.Size = new System.Drawing.Size(265, 25);
            this.NombreTitutarTarjetaLabel.TabIndex = 0;
            this.NombreTitutarTarjetaLabel.Text = "Nombre y Apellido del titular: ";
            // 
            // VolverDireccionDestinoButton
            // 
            this.VolverDireccionDestinoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(113)))), ((int)(((byte)(82)))));
            this.VolverDireccionDestinoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverDireccionDestinoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.VolverDireccionDestinoButton.Location = new System.Drawing.Point(57, 563);
            this.VolverDireccionDestinoButton.Name = "VolverDireccionDestinoButton";
            this.VolverDireccionDestinoButton.Size = new System.Drawing.Size(197, 49);
            this.VolverDireccionDestinoButton.TabIndex = 37;
            this.VolverDireccionDestinoButton.Text = "Volver";
            this.VolverDireccionDestinoButton.UseVisualStyleBackColor = false;
            this.VolverDireccionDestinoButton.Click += new System.EventHandler(this.VolverDireccionDestinoButton_Click);
            // 
            // FechaRecibidaLabel
            // 
            this.FechaRecibidaLabel.AutoSize = true;
            this.FechaRecibidaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRecibidaLabel.Location = new System.Drawing.Point(5, 16);
            this.FechaRecibidaLabel.Name = "FechaRecibidaLabel";
            this.FechaRecibidaLabel.Size = new System.Drawing.Size(355, 32);
            this.FechaRecibidaLabel.TabIndex = 41;
            this.FechaRecibidaLabel.Text = "¿Cúando desea recibir el pedido?";
            // 
            // ProgramadoRadioButton
            // 
            this.ProgramadoRadioButton.AutoSize = true;
            this.ProgramadoRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramadoRadioButton.Location = new System.Drawing.Point(19, 85);
            this.ProgramadoRadioButton.Name = "ProgramadoRadioButton";
            this.ProgramadoRadioButton.Size = new System.Drawing.Size(204, 29);
            this.ProgramadoRadioButton.TabIndex = 44;
            this.ProgramadoRadioButton.TabStop = true;
            this.ProgramadoRadioButton.Text = "Entrega programada";
            this.ProgramadoRadioButton.UseVisualStyleBackColor = true;
            this.ProgramadoRadioButton.CheckedChanged += new System.EventHandler(this.ProgramadoRadioButton_CheckedChanged);
            // 
            // FechaRecibidaDateTimePicker
            // 
            this.FechaRecibidaDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight;
            this.FechaRecibidaDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRecibidaDateTimePicker.Location = new System.Drawing.Point(14, 131);
            this.FechaRecibidaDateTimePicker.Name = "FechaRecibidaDateTimePicker";
            this.FechaRecibidaDateTimePicker.Size = new System.Drawing.Size(289, 29);
            this.FechaRecibidaDateTimePicker.TabIndex = 42;
            this.FechaRecibidaDateTimePicker.ValueChanged += new System.EventHandler(this.FechaRecibidaDateTimePicker_ValueChanged);
            // 
            // InmediatoRadioButton
            // 
            this.InmediatoRadioButton.AutoSize = true;
            this.InmediatoRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InmediatoRadioButton.Location = new System.Drawing.Point(19, 50);
            this.InmediatoRadioButton.Name = "InmediatoRadioButton";
            this.InmediatoRadioButton.Size = new System.Drawing.Size(232, 29);
            this.InmediatoRadioButton.TabIndex = 43;
            this.InmediatoRadioButton.TabStop = true;
            this.InmediatoRadioButton.Text = "Entrega lo antes posible";
            this.InmediatoRadioButton.UseVisualStyleBackColor = true;
            this.InmediatoRadioButton.CheckedChanged += new System.EventHandler(this.InmediatoRadioButton_CheckedChanged);
            // 
            // FechaRecibidaGroupBox
            // 
            this.FechaRecibidaGroupBox.Controls.Add(this.FechaLabel);
            this.FechaRecibidaGroupBox.Controls.Add(this.FechaRecibidaLabel);
            this.FechaRecibidaGroupBox.Controls.Add(this.ProgramadoRadioButton);
            this.FechaRecibidaGroupBox.Controls.Add(this.FechaRecibidaDateTimePicker);
            this.FechaRecibidaGroupBox.Controls.Add(this.InmediatoRadioButton);
            this.FechaRecibidaGroupBox.Location = new System.Drawing.Point(18, 369);
            this.FechaRecibidaGroupBox.Name = "FechaRecibidaGroupBox";
            this.FechaRecibidaGroupBox.Size = new System.Drawing.Size(593, 188);
            this.FechaRecibidaGroupBox.TabIndex = 46;
            this.FechaRecibidaGroupBox.TabStop = false;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.FechaLabel.Location = new System.Drawing.Point(11, 163);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(375, 13);
            this.FechaLabel.TabIndex = 14;
            this.FechaLabel.Text = "*El pedido puede ser programado para un envío dentro de los próximos 7 días";
            this.FechaLabel.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(486, 67);
            this.maskedTextBox1.Mask = ",99$";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBox1.TabIndex = 47;
            // 
            // FormaPagoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(641, 624);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.FechaRecibidaGroupBox);
            this.Controls.Add(this.VolverDireccionDestinoButton);
            this.Controls.Add(this.TarjetaVisaGroupBox);
            this.Controls.Add(this.EfectivoGroupBox);
            this.Controls.Add(this.ConfirmarPedidoButton);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.FormaPagoLabel);
            this.Controls.Add(this.FormaPagoComboBox);
            this.Name = "FormaPagoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas de pago";
            this.EfectivoGroupBox.ResumeLayout(false);
            this.EfectivoGroupBox.PerformLayout();
            this.TarjetaVisaGroupBox.ResumeLayout(false);
            this.TarjetaVisaGroupBox.PerformLayout();
            this.FechaRecibidaGroupBox.ResumeLayout(false);
            this.FechaRecibidaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.Label FormaPagoLabel;
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
        private System.Windows.Forms.Button VolverDireccionDestinoButton;
        private System.Windows.Forms.Label FechaRecibidaLabel;
        private System.Windows.Forms.RadioButton ProgramadoRadioButton;
        private System.Windows.Forms.DateTimePicker FechaRecibidaDateTimePicker;
        private System.Windows.Forms.RadioButton InmediatoRadioButton;
        private System.Windows.Forms.GroupBox FechaRecibidaGroupBox;
        private System.Windows.Forms.Label AdvertenciaTarjetaLabel;
        private System.Windows.Forms.Label MontoValidacionLabel;
        private System.Windows.Forms.Label signoPesosLabel;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.Label FechaTarjetaLabel;
        private System.Windows.Forms.Label MensajeTarjetaLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}