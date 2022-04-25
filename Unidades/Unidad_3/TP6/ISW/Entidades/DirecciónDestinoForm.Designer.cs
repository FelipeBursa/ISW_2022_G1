
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObligatorioDestinoNumeroLabel = new System.Windows.Forms.Label();
            this.ObligatorioCalleDestinoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReferenciaDestinoLabel = new System.Windows.Forms.Label();
            this.NumeroDestinoTextBox = new System.Windows.Forms.TextBox();
            this.NumeroDestinoLabel = new System.Windows.Forms.Label();
            this.CalleDestinoTextBox = new System.Windows.Forms.TextBox();
            this.CalleDestinoLabel = new System.Windows.Forms.Label();
            this.ReferenciaDestinoTextBox = new System.Windows.Forms.TextBox();
            this.ContinuarDirecciónDestinoButton = new System.Windows.Forms.Button();
            this.VolverDireccionDestinoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ObligatorioDestinoNumeroLabel);
            this.groupBox1.Controls.Add(this.ObligatorioCalleDestinoLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReferenciaDestinoLabel);
            this.groupBox1.Controls.Add(this.NumeroDestinoTextBox);
            this.groupBox1.Controls.Add(this.NumeroDestinoLabel);
            this.groupBox1.Controls.Add(this.CalleDestinoTextBox);
            this.groupBox1.Controls.Add(this.CalleDestinoLabel);
            this.groupBox1.Controls.Add(this.ReferenciaDestinoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 313);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // ObligatorioDestinoNumeroLabel
            // 
            this.ObligatorioDestinoNumeroLabel.AutoSize = true;
            this.ObligatorioDestinoNumeroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioDestinoNumeroLabel.Location = new System.Drawing.Point(48, 192);
            this.ObligatorioDestinoNumeroLabel.Name = "ObligatorioDestinoNumeroLabel";
            this.ObligatorioDestinoNumeroLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioDestinoNumeroLabel.TabIndex = 25;
            this.ObligatorioDestinoNumeroLabel.Text = "*Campo obligatorio";
            // 
            // ObligatorioCalleDestinoLabel
            // 
            this.ObligatorioCalleDestinoLabel.AutoSize = true;
            this.ObligatorioCalleDestinoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObligatorioCalleDestinoLabel.Location = new System.Drawing.Point(48, 117);
            this.ObligatorioCalleDestinoLabel.Name = "ObligatorioCalleDestinoLabel";
            this.ObligatorioCalleDestinoLabel.Size = new System.Drawing.Size(147, 21);
            this.ObligatorioCalleDestinoLabel.TabIndex = 24;
            this.ObligatorioCalleDestinoLabel.Text = "*Campo obligatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ingrese dirección de destino";
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
            this.NumeroDestinoTextBox.Location = new System.Drawing.Point(124, 158);
            this.NumeroDestinoTextBox.Name = "NumeroDestinoTextBox";
            this.NumeroDestinoTextBox.Size = new System.Drawing.Size(212, 26);
            this.NumeroDestinoTextBox.TabIndex = 17;
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
            this.CalleDestinoTextBox.Location = new System.Drawing.Point(96, 88);
            this.CalleDestinoTextBox.Name = "CalleDestinoTextBox";
            this.CalleDestinoTextBox.Size = new System.Drawing.Size(240, 26);
            this.CalleDestinoTextBox.TabIndex = 16;
            // 
            // CalleDestinoLabel
            // 
            this.CalleDestinoLabel.AutoSize = true;
            this.CalleDestinoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalleDestinoLabel.Location = new System.Drawing.Point(43, 88);
            this.CalleDestinoLabel.Name = "CalleDestinoLabel";
            this.CalleDestinoLabel.Size = new System.Drawing.Size(58, 25);
            this.CalleDestinoLabel.TabIndex = 19;
            this.CalleDestinoLabel.Text = "Calle:";
            // 
            // ReferenciaDestinoTextBox
            // 
            this.ReferenciaDestinoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenciaDestinoTextBox.Location = new System.Drawing.Point(155, 233);
            this.ReferenciaDestinoTextBox.Multiline = true;
            this.ReferenciaDestinoTextBox.Name = "ReferenciaDestinoTextBox";
            this.ReferenciaDestinoTextBox.Size = new System.Drawing.Size(253, 67);
            this.ReferenciaDestinoTextBox.TabIndex = 18;
            // 
            // ContinuarDirecciónDestinoButton
            // 
            this.ContinuarDirecciónDestinoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContinuarDirecciónDestinoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinuarDirecciónDestinoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ContinuarDirecciónDestinoButton.Location = new System.Drawing.Point(241, 340);
            this.ContinuarDirecciónDestinoButton.Name = "ContinuarDirecciónDestinoButton";
            this.ContinuarDirecciónDestinoButton.Size = new System.Drawing.Size(192, 49);
            this.ContinuarDirecciónDestinoButton.TabIndex = 30;
            this.ContinuarDirecciónDestinoButton.Text = "Continuar";
            this.ContinuarDirecciónDestinoButton.UseVisualStyleBackColor = false;
            this.ContinuarDirecciónDestinoButton.Click += new System.EventHandler(this.ContinuarDirecciónDestinoButton_Click);
            // 
            // VolverDireccionDestinoButton
            // 
            this.VolverDireccionDestinoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VolverDireccionDestinoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverDireccionDestinoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VolverDireccionDestinoButton.Location = new System.Drawing.Point(26, 340);
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
            this.ClientSize = new System.Drawing.Size(483, 401);
            this.Controls.Add(this.VolverDireccionDestinoButton);
            this.Controls.Add(this.ContinuarDirecciónDestinoButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "DirecciónDestinoForm";
            this.Text = "Dirección de destino del pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
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