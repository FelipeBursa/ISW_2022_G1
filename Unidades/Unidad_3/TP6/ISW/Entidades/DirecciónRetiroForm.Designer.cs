
namespace ISW.Entidades
{
    partial class DirecciónRetiroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirecciónRetiroForm));
            this.DirecciónRetiroGroupBox = new System.Windows.Forms.GroupBox();
            this.ObligatorioNumRetiroLabel = new System.Windows.Forms.Label();
            this.ObligatorioCalleRetiroLabel = new System.Windows.Forms.Label();
            this.CalleLbl = new System.Windows.Forms.Label();
            this.DirecDestinolbl = new System.Windows.Forms.Label();
            this.NumCalleTextBox = new System.Windows.Forms.TextBox();
            this.CalleTextBox = new System.Windows.Forms.TextBox();
            this.ReferenciaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumCalleLbl = new System.Windows.Forms.Label();
            this.ReferenciaLbl = new System.Windows.Forms.Label();
            this.OpcionDireccionLabel = new System.Windows.Forms.Label();
            this.MapaInteractivoRadioButton = new System.Windows.Forms.RadioButton();
            this.LlenarCamposRadioButton = new System.Windows.Forms.RadioButton();
            this.ContinuarDirecciónRetiroButton = new System.Windows.Forms.Button();
            this.VolverDirecciónRetiroButton = new System.Windows.Forms.Button();
            this.MapaInteractivoButton = new System.Windows.Forms.Button();
            this.DirecciónRetiroGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DirecciónRetiroGroupBox
            // 
            this.DirecciónRetiroGroupBox.Controls.Add(this.ObligatorioNumRetiroLabel);
            this.DirecciónRetiroGroupBox.Controls.Add(this.ObligatorioCalleRetiroLabel);
            this.DirecciónRetiroGroupBox.Controls.Add(this.CalleLbl);
            this.DirecciónRetiroGroupBox.Controls.Add(this.DirecDestinolbl);
            this.DirecciónRetiroGroupBox.Controls.Add(this.NumCalleTextBox);
            this.DirecciónRetiroGroupBox.Controls.Add(this.CalleTextBox);
            this.DirecciónRetiroGroupBox.Controls.Add(this.ReferenciaTextBox);
            this.DirecciónRetiroGroupBox.Controls.Add(this.label4);
            this.DirecciónRetiroGroupBox.Controls.Add(this.NumCalleLbl);
            this.DirecciónRetiroGroupBox.Controls.Add(this.ReferenciaLbl);
            this.DirecciónRetiroGroupBox.Location = new System.Drawing.Point(18, 137);
            this.DirecciónRetiroGroupBox.Name = "DirecciónRetiroGroupBox";
            this.DirecciónRetiroGroupBox.Size = new System.Drawing.Size(419, 317);
            this.DirecciónRetiroGroupBox.TabIndex = 24;
            this.DirecciónRetiroGroupBox.TabStop = false;
            // 
            // ObligatorioNumRetiroLabel
            // 
            this.ObligatorioNumRetiroLabel.AutoSize = true;
            this.ObligatorioNumRetiroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioNumRetiroLabel.Location = new System.Drawing.Point(6, 197);
            this.ObligatorioNumRetiroLabel.Name = "ObligatorioNumRetiroLabel";
            this.ObligatorioNumRetiroLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioNumRetiroLabel.TabIndex = 24;
            this.ObligatorioNumRetiroLabel.Text = "*Campo obligatorio";
            // 
            // ObligatorioCalleRetiroLabel
            // 
            this.ObligatorioCalleRetiroLabel.AutoSize = true;
            this.ObligatorioCalleRetiroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioCalleRetiroLabel.Location = new System.Drawing.Point(7, 126);
            this.ObligatorioCalleRetiroLabel.Name = "ObligatorioCalleRetiroLabel";
            this.ObligatorioCalleRetiroLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioCalleRetiroLabel.TabIndex = 23;
            this.ObligatorioCalleRetiroLabel.Text = "*Campo obligatorio";
            // 
            // CalleLbl
            // 
            this.CalleLbl.AutoSize = true;
            this.CalleLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalleLbl.Location = new System.Drawing.Point(10, 88);
            this.CalleLbl.Name = "CalleLbl";
            this.CalleLbl.Size = new System.Drawing.Size(63, 30);
            this.CalleLbl.TabIndex = 22;
            this.CalleLbl.Text = "Calle:";
            // 
            // DirecDestinolbl
            // 
            this.DirecDestinolbl.AutoSize = true;
            this.DirecDestinolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecDestinolbl.Location = new System.Drawing.Point(9, 16);
            this.DirecDestinolbl.Name = "DirecDestinolbl";
            this.DirecDestinolbl.Size = new System.Drawing.Size(353, 33);
            this.DirecDestinolbl.TabIndex = 16;
            this.DirecDestinolbl.Text = "Ingrese dirección de retiro";
            // 
            // NumCalleTextBox
            // 
            this.NumCalleTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCalleTextBox.Location = new System.Drawing.Point(101, 159);
            this.NumCalleTextBox.Name = "NumCalleTextBox";
            this.NumCalleTextBox.Size = new System.Drawing.Size(200, 35);
            this.NumCalleTextBox.TabIndex = 7;
            this.NumCalleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumCalleTextBox_KeyPress);
            // 
            // CalleTextBox
            // 
            this.CalleTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalleTextBox.Location = new System.Drawing.Point(74, 88);
            this.CalleTextBox.Name = "CalleTextBox";
            this.CalleTextBox.Size = new System.Drawing.Size(227, 35);
            this.CalleTextBox.TabIndex = 6;
            // 
            // ReferenciaTextBox
            // 
            this.ReferenciaTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenciaTextBox.Location = new System.Drawing.Point(121, 236);
            this.ReferenciaTextBox.Multiline = true;
            this.ReferenciaTextBox.Name = "ReferenciaTextBox";
            this.ReferenciaTextBox.Size = new System.Drawing.Size(289, 57);
            this.ReferenciaTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 9;
            // 
            // NumCalleLbl
            // 
            this.NumCalleLbl.AutoSize = true;
            this.NumCalleLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCalleLbl.Location = new System.Drawing.Point(6, 159);
            this.NumCalleLbl.Name = "NumCalleLbl";
            this.NumCalleLbl.Size = new System.Drawing.Size(94, 30);
            this.NumCalleLbl.TabIndex = 10;
            this.NumCalleLbl.Text = "Número:";
            // 
            // ReferenciaLbl
            // 
            this.ReferenciaLbl.AutoSize = true;
            this.ReferenciaLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenciaLbl.Location = new System.Drawing.Point(10, 236);
            this.ReferenciaLbl.Name = "ReferenciaLbl";
            this.ReferenciaLbl.Size = new System.Drawing.Size(115, 30);
            this.ReferenciaLbl.TabIndex = 11;
            this.ReferenciaLbl.Text = "Referencia:";
            // 
            // OpcionDireccionLabel
            // 
            this.OpcionDireccionLabel.AutoSize = true;
            this.OpcionDireccionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionDireccionLabel.Location = new System.Drawing.Point(12, 27);
            this.OpcionDireccionLabel.Name = "OpcionDireccionLabel";
            this.OpcionDireccionLabel.Size = new System.Drawing.Size(379, 32);
            this.OpcionDireccionLabel.TabIndex = 25;
            this.OpcionDireccionLabel.Text = "¿Como desea ingresar la dirección?";
            // 
            // MapaInteractivoRadioButton
            // 
            this.MapaInteractivoRadioButton.AutoSize = true;
            this.MapaInteractivoRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapaInteractivoRadioButton.Location = new System.Drawing.Point(51, 60);
            this.MapaInteractivoRadioButton.Name = "MapaInteractivoRadioButton";
            this.MapaInteractivoRadioButton.Size = new System.Drawing.Size(408, 29);
            this.MapaInteractivoRadioButton.TabIndex = 26;
            this.MapaInteractivoRadioButton.TabStop = true;
            this.MapaInteractivoRadioButton.Text = "Seleccionar un punto en un mapa interactivo";
            this.MapaInteractivoRadioButton.UseVisualStyleBackColor = true;
            this.MapaInteractivoRadioButton.CheckedChanged += new System.EventHandler(this.MapaInteractivoRadioButton_CheckedChanged);
            // 
            // LlenarCamposRadioButton
            // 
            this.LlenarCamposRadioButton.AutoSize = true;
            this.LlenarCamposRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlenarCamposRadioButton.Location = new System.Drawing.Point(51, 92);
            this.LlenarCamposRadioButton.Name = "LlenarCamposRadioButton";
            this.LlenarCamposRadioButton.Size = new System.Drawing.Size(201, 29);
            this.LlenarCamposRadioButton.TabIndex = 27;
            this.LlenarCamposRadioButton.TabStop = true;
            this.LlenarCamposRadioButton.Text = "Escribir mi dirección";
            this.LlenarCamposRadioButton.UseVisualStyleBackColor = true;
            this.LlenarCamposRadioButton.CheckedChanged += new System.EventHandler(this.LlenarCamposRadioButton_CheckedChanged);
            // 
            // ContinuarDirecciónRetiroButton
            // 
            this.ContinuarDirecciónRetiroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContinuarDirecciónRetiroButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuarDirecciónRetiroButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ContinuarDirecciónRetiroButton.Location = new System.Drawing.Point(691, 430);
            this.ContinuarDirecciónRetiroButton.Name = "ContinuarDirecciónRetiroButton";
            this.ContinuarDirecciónRetiroButton.Size = new System.Drawing.Size(190, 49);
            this.ContinuarDirecciónRetiroButton.TabIndex = 29;
            this.ContinuarDirecciónRetiroButton.Text = "Continuar";
            this.ContinuarDirecciónRetiroButton.UseVisualStyleBackColor = false;
            this.ContinuarDirecciónRetiroButton.Click += new System.EventHandler(this.ContinuarDirecciónButton_Click);
            // 
            // VolverDirecciónRetiroButton
            // 
            this.VolverDirecciónRetiroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VolverDirecciónRetiroButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverDirecciónRetiroButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VolverDirecciónRetiroButton.Location = new System.Drawing.Point(491, 430);
            this.VolverDirecciónRetiroButton.Name = "VolverDirecciónRetiroButton";
            this.VolverDirecciónRetiroButton.Size = new System.Drawing.Size(194, 49);
            this.VolverDirecciónRetiroButton.TabIndex = 30;
            this.VolverDirecciónRetiroButton.Text = "Volver";
            this.VolverDirecciónRetiroButton.UseVisualStyleBackColor = false;
            this.VolverDirecciónRetiroButton.Click += new System.EventHandler(this.VolverDirecciónRetiroButton_Click);
            // 
            // MapaInteractivoButton
            // 
            this.MapaInteractivoButton.Image = ((System.Drawing.Image)(resources.GetObject("MapaInteractivoButton.Image")));
            this.MapaInteractivoButton.Location = new System.Drawing.Point(482, 27);
            this.MapaInteractivoButton.Margin = new System.Windows.Forms.Padding(0);
            this.MapaInteractivoButton.Name = "MapaInteractivoButton";
            this.MapaInteractivoButton.Size = new System.Drawing.Size(390, 363);
            this.MapaInteractivoButton.TabIndex = 31;
            this.MapaInteractivoButton.UseVisualStyleBackColor = true;
            this.MapaInteractivoButton.Click += new System.EventHandler(this.MapaButton_Click);
            // 
            // DirecciónRetiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(908, 491);
            this.Controls.Add(this.MapaInteractivoButton);
            this.Controls.Add(this.VolverDirecciónRetiroButton);
            this.Controls.Add(this.ContinuarDirecciónRetiroButton);
            this.Controls.Add(this.LlenarCamposRadioButton);
            this.Controls.Add(this.MapaInteractivoRadioButton);
            this.Controls.Add(this.OpcionDireccionLabel);
            this.Controls.Add(this.DirecciónRetiroGroupBox);
            this.Name = "DirecciónRetiroForm";
            this.Text = "Dirección de retiro del producto";
            this.DirecciónRetiroGroupBox.ResumeLayout(false);
            this.DirecciónRetiroGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DirecciónRetiroGroupBox;
        private System.Windows.Forms.Label CalleLbl;
        private System.Windows.Forms.Label DirecDestinolbl;
        private System.Windows.Forms.TextBox NumCalleTextBox;
        private System.Windows.Forms.TextBox CalleTextBox;
        private System.Windows.Forms.TextBox ReferenciaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NumCalleLbl;
        private System.Windows.Forms.Label ReferenciaLbl;
        private System.Windows.Forms.Label OpcionDireccionLabel;
        private System.Windows.Forms.RadioButton MapaInteractivoRadioButton;
        private System.Windows.Forms.RadioButton LlenarCamposRadioButton;
        private System.Windows.Forms.Button ContinuarDirecciónRetiroButton;
        private System.Windows.Forms.Label ObligatorioNumRetiroLabel;
        private System.Windows.Forms.Label ObligatorioCalleRetiroLabel;
        private System.Windows.Forms.Button VolverDirecciónRetiroButton;
        private System.Windows.Forms.Button MapaInteractivoButton;
    }
}