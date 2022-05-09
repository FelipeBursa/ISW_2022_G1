
namespace ISW.Entidades
{
    partial class DirecciónDestinoForm
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
            this.DireccionDestinoGroupBox = new System.Windows.Forms.GroupBox();
            this.ObligatorioDestinoNumeroLabel = new System.Windows.Forms.Label();
            this.ObligatorioCalleDestinoLabel = new System.Windows.Forms.Label();
            this.IngresoDireccionDestinoLabel = new System.Windows.Forms.Label();
            this.ReferenciaDestinoLabel = new System.Windows.Forms.Label();
            this.NumeroDestinoTextBox = new System.Windows.Forms.TextBox();
            this.NumeroDestinoLabel = new System.Windows.Forms.Label();
            this.CalleDestinoTextBox = new System.Windows.Forms.TextBox();
            this.CalleDestinoLabel = new System.Windows.Forms.Label();
            this.ReferenciaDestinoTextBox = new System.Windows.Forms.TextBox();
            this.ContinuarDirecciónDestinoButton = new System.Windows.Forms.Button();
            this.VolverDireccionDestinoButton = new System.Windows.Forms.Button();
            this.DireccionDestinoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DireccionDestinoGroupBox
            // 
            this.DireccionDestinoGroupBox.Controls.Add(this.ObligatorioDestinoNumeroLabel);
            this.DireccionDestinoGroupBox.Controls.Add(this.ObligatorioCalleDestinoLabel);
            this.DireccionDestinoGroupBox.Controls.Add(this.IngresoDireccionDestinoLabel);
            this.DireccionDestinoGroupBox.Controls.Add(this.ReferenciaDestinoLabel);
            this.DireccionDestinoGroupBox.Controls.Add(this.NumeroDestinoTextBox);
            this.DireccionDestinoGroupBox.Controls.Add(this.NumeroDestinoLabel);
            this.DireccionDestinoGroupBox.Controls.Add(this.CalleDestinoTextBox);
            this.DireccionDestinoGroupBox.Controls.Add(this.CalleDestinoLabel);
            this.DireccionDestinoGroupBox.Controls.Add(this.ReferenciaDestinoTextBox);
            this.DireccionDestinoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DireccionDestinoGroupBox.Name = "DireccionDestinoGroupBox";
            this.DireccionDestinoGroupBox.Size = new System.Drawing.Size(523, 335);
            this.DireccionDestinoGroupBox.TabIndex = 23;
            this.DireccionDestinoGroupBox.TabStop = false;
            // 
            // ObligatorioDestinoNumeroLabel
            // 
            this.ObligatorioDestinoNumeroLabel.AutoSize = true;
            this.ObligatorioDestinoNumeroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioDestinoNumeroLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ObligatorioDestinoNumeroLabel.Location = new System.Drawing.Point(131, 185);
            this.ObligatorioDestinoNumeroLabel.Name = "ObligatorioDestinoNumeroLabel";
            this.ObligatorioDestinoNumeroLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioDestinoNumeroLabel.TabIndex = 25;
            this.ObligatorioDestinoNumeroLabel.Text = "*Campo obligatorio";
            // 
            // ObligatorioCalleDestinoLabel
            // 
            this.ObligatorioCalleDestinoLabel.AutoSize = true;
            this.ObligatorioCalleDestinoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioCalleDestinoLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ObligatorioCalleDestinoLabel.Location = new System.Drawing.Point(131, 118);
            this.ObligatorioCalleDestinoLabel.Name = "ObligatorioCalleDestinoLabel";
            this.ObligatorioCalleDestinoLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioCalleDestinoLabel.TabIndex = 24;
            this.ObligatorioCalleDestinoLabel.Text = "*Campo obligatorio";
            // 
            // IngresoDireccionDestinoLabel
            // 
            this.IngresoDireccionDestinoLabel.AutoSize = true;
            this.IngresoDireccionDestinoLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresoDireccionDestinoLabel.Location = new System.Drawing.Point(6, 16);
            this.IngresoDireccionDestinoLabel.Name = "IngresoDireccionDestinoLabel";
            this.IngresoDireccionDestinoLabel.Size = new System.Drawing.Size(402, 45);
            this.IngresoDireccionDestinoLabel.TabIndex = 15;
            this.IngresoDireccionDestinoLabel.Text = "Ingrese dirección de destino";
            // 
            // ReferenciaDestinoLabel
            // 
            this.ReferenciaDestinoLabel.AutoSize = true;
            this.ReferenciaDestinoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenciaDestinoLabel.Location = new System.Drawing.Point(45, 232);
            this.ReferenciaDestinoLabel.Name = "ReferenciaDestinoLabel";
            this.ReferenciaDestinoLabel.Size = new System.Drawing.Size(104, 25);
            this.ReferenciaDestinoLabel.TabIndex = 21;
            this.ReferenciaDestinoLabel.Text = "Referencia:";
            // 
            // NumeroDestinoTextBox
            // 
            this.NumeroDestinoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDestinoTextBox.Location = new System.Drawing.Point(135, 157);
            this.NumeroDestinoTextBox.Name = "NumeroDestinoTextBox";
            this.NumeroDestinoTextBox.Size = new System.Drawing.Size(293, 26);
            this.NumeroDestinoTextBox.TabIndex = 17;
            this.NumeroDestinoTextBox.TextChanged += new System.EventHandler(this.NumeroDestinoTextBox_TextChanged);
            this.NumeroDestinoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroDestinoTextBox_KeyPress);
            // 
            // NumeroDestinoLabel
            // 
            this.NumeroDestinoLabel.AutoSize = true;
            this.NumeroDestinoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDestinoLabel.Location = new System.Drawing.Point(44, 157);
            this.NumeroDestinoLabel.Name = "NumeroDestinoLabel";
            this.NumeroDestinoLabel.Size = new System.Drawing.Size(85, 25);
            this.NumeroDestinoLabel.TabIndex = 20;
            this.NumeroDestinoLabel.Text = "Numero:";
            // 
            // CalleDestinoTextBox
            // 
            this.CalleDestinoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalleDestinoTextBox.Location = new System.Drawing.Point(135, 89);
            this.CalleDestinoTextBox.Name = "CalleDestinoTextBox";
            this.CalleDestinoTextBox.Size = new System.Drawing.Size(293, 26);
            this.CalleDestinoTextBox.TabIndex = 16;
            this.CalleDestinoTextBox.TextChanged += new System.EventHandler(this.CalleDestinoTextBox_TextChanged);
            // 
            // CalleDestinoLabel
            // 
            this.CalleDestinoLabel.AutoSize = true;
            this.CalleDestinoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalleDestinoLabel.Location = new System.Drawing.Point(45, 88);
            this.CalleDestinoLabel.Name = "CalleDestinoLabel";
            this.CalleDestinoLabel.Size = new System.Drawing.Size(58, 25);
            this.CalleDestinoLabel.TabIndex = 19;
            this.CalleDestinoLabel.Text = "Calle:";
            // 
            // ReferenciaDestinoTextBox
            // 
            this.ReferenciaDestinoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenciaDestinoTextBox.Location = new System.Drawing.Point(155, 232);
            this.ReferenciaDestinoTextBox.MaxLength = 100;
            this.ReferenciaDestinoTextBox.Multiline = true;
            this.ReferenciaDestinoTextBox.Name = "ReferenciaDestinoTextBox";
            this.ReferenciaDestinoTextBox.Size = new System.Drawing.Size(273, 86);
            this.ReferenciaDestinoTextBox.TabIndex = 18;
            // 
            // ContinuarDirecciónDestinoButton
            // 
            this.ContinuarDirecciónDestinoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(113)))), ((int)(((byte)(82)))));
            this.ContinuarDirecciónDestinoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuarDirecciónDestinoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(212)))), ((int)(((byte)(113)))));
            this.ContinuarDirecciónDestinoButton.Location = new System.Drawing.Point(257, 366);
            this.ContinuarDirecciónDestinoButton.Name = "ContinuarDirecciónDestinoButton";
            this.ContinuarDirecciónDestinoButton.Size = new System.Drawing.Size(192, 49);
            this.ContinuarDirecciónDestinoButton.TabIndex = 30;
            this.ContinuarDirecciónDestinoButton.Text = "Continuar";
            this.ContinuarDirecciónDestinoButton.UseVisualStyleBackColor = false;
            this.ContinuarDirecciónDestinoButton.Click += new System.EventHandler(this.ContinuarDirecciónDestinoButton_Click);
            // 
            // VolverDireccionDestinoButton
            // 
            this.VolverDireccionDestinoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(113)))), ((int)(((byte)(82)))));
            this.VolverDireccionDestinoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverDireccionDestinoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.VolverDireccionDestinoButton.Location = new System.Drawing.Point(12, 366);
            this.VolverDireccionDestinoButton.Name = "VolverDireccionDestinoButton";
            this.VolverDireccionDestinoButton.Size = new System.Drawing.Size(197, 49);
            this.VolverDireccionDestinoButton.TabIndex = 31;
            this.VolverDireccionDestinoButton.Text = "Volver";
            this.VolverDireccionDestinoButton.UseVisualStyleBackColor = false;
            this.VolverDireccionDestinoButton.Click += new System.EventHandler(this.VolverDireccionDestinoButton_Click);
            // 
            // DirecciónDestinoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(554, 429);
            this.Controls.Add(this.VolverDireccionDestinoButton);
            this.Controls.Add(this.ContinuarDirecciónDestinoButton);
            this.Controls.Add(this.DireccionDestinoGroupBox);
            this.Name = "DirecciónDestinoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dirección de destino del pedido";
            this.DireccionDestinoGroupBox.ResumeLayout(false);
            this.DireccionDestinoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox DireccionDestinoGroupBox;
        private System.Windows.Forms.Label IngresoDireccionDestinoLabel;
        private System.Windows.Forms.Label ReferenciaDestinoLabel;
        private System.Windows.Forms.TextBox NumeroDestinoTextBox;
        private System.Windows.Forms.Label NumeroDestinoLabel;
        private System.Windows.Forms.TextBox CalleDestinoTextBox;
        private System.Windows.Forms.Label CalleDestinoLabel;
        private System.Windows.Forms.TextBox ReferenciaDestinoTextBox;
        private System.Windows.Forms.Label ObligatorioDestinoNumeroLabel;
        private System.Windows.Forms.Label ObligatorioCalleDestinoLabel;
        private System.Windows.Forms.Button ContinuarDirecciónDestinoButton;
        private System.Windows.Forms.Button VolverDireccionDestinoButton;
    }
}