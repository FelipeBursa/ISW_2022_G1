
namespace ISW.Entidades
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.PrincipalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.HacerPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeLoQueSeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComercioAdheridoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrarComercioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SeguimientoDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenGroupBox = new System.Windows.Forms.GroupBox();
            this.DeliveryEatLabel = new System.Windows.Forms.Label();
            this.PrincipalMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrincipalMenuStrip
            // 
            this.PrincipalMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.PrincipalMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrincipalMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PrincipalMenuStrip.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PrincipalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HacerPedidoToolStripMenuItem,
            this.RegistrarComercioToolStripMenuItem,
            this.DescuentosToolStripMenuItem,
            this.SeguimientoDePedidoToolStripMenuItem,
            this.AyudaToolStripMenuItem});
            this.PrincipalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMenuStrip.Name = "PrincipalMenuStrip";
            this.PrincipalMenuStrip.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.PrincipalMenuStrip.Size = new System.Drawing.Size(239, 349);
            this.PrincipalMenuStrip.TabIndex = 0;
            this.PrincipalMenuStrip.Text = "menuStrip2";
            // 
            // HacerPedidoToolStripMenuItem
            // 
            this.HacerPedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeLoQueSeaToolStripMenuItem,
            this.ComercioAdheridoToolStripMenuItem});
            this.HacerPedidoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HacerPedidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(41)))));
            this.HacerPedidoToolStripMenuItem.Name = "HacerPedidoToolStripMenuItem";
            this.HacerPedidoToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.HacerPedidoToolStripMenuItem.Text = " Realizar Pedido";
            // 
            // DeLoQueSeaToolStripMenuItem
            // 
            this.DeLoQueSeaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.DeLoQueSeaToolStripMenuItem.Name = "DeLoQueSeaToolStripMenuItem";
            this.DeLoQueSeaToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.DeLoQueSeaToolStripMenuItem.Text = "De lo que sea";
            this.DeLoQueSeaToolStripMenuItem.Click += new System.EventHandler(this.DeLoQueSeaToolStripMenuItem_Click);
            // 
            // ComercioAdheridoToolStripMenuItem
            // 
            this.ComercioAdheridoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.ComercioAdheridoToolStripMenuItem.Name = "ComercioAdheridoToolStripMenuItem";
            this.ComercioAdheridoToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.ComercioAdheridoToolStripMenuItem.Text = "Comercio Adherido";
            // 
            // RegistrarComercioToolStripMenuItem
            // 
            this.RegistrarComercioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarComercioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(41)))));
            this.RegistrarComercioToolStripMenuItem.Name = "RegistrarComercioToolStripMenuItem";
            this.RegistrarComercioToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.RegistrarComercioToolStripMenuItem.Text = "Registrar Comercio";
            // 
            // DescuentosToolStripMenuItem
            // 
            this.DescuentosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(41)))));
            this.DescuentosToolStripMenuItem.Name = "DescuentosToolStripMenuItem";
            this.DescuentosToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.DescuentosToolStripMenuItem.Text = "Descuentos";
            // 
            // SeguimientoDePedidoToolStripMenuItem
            // 
            this.SeguimientoDePedidoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguimientoDePedidoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(41)))));
            this.SeguimientoDePedidoToolStripMenuItem.Name = "SeguimientoDePedidoToolStripMenuItem";
            this.SeguimientoDePedidoToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.SeguimientoDePedidoToolStripMenuItem.Text = "Seguimiento de Pedido";
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AyudaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(41)))));
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.AyudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ImagenGroupBox
            // 
            this.ImagenGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagenGroupBox.BackgroundImage")));
            this.ImagenGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagenGroupBox.Location = new System.Drawing.Point(250, 12);
            this.ImagenGroupBox.Name = "ImagenGroupBox";
            this.ImagenGroupBox.Size = new System.Drawing.Size(371, 328);
            this.ImagenGroupBox.TabIndex = 3;
            this.ImagenGroupBox.TabStop = false;
            // 
            // DeliveryEatLabel
            // 
            this.DeliveryEatLabel.AutoSize = true;
            this.DeliveryEatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(113)))), ((int)(((byte)(82)))));
            this.DeliveryEatLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryEatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(41)))));
            this.DeliveryEatLabel.Location = new System.Drawing.Point(12, 260);
            this.DeliveryEatLabel.Name = "DeliveryEatLabel";
            this.DeliveryEatLabel.Size = new System.Drawing.Size(200, 47);
            this.DeliveryEatLabel.TabIndex = 4;
            this.DeliveryEatLabel.Text = "DeliveryEat";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(41)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(633, 349);
            this.Controls.Add(this.DeliveryEatLabel);
            this.Controls.Add(this.ImagenGroupBox);
            this.Controls.Add(this.PrincipalMenuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de opciones";
            this.PrincipalMenuStrip.ResumeLayout(false);
            this.PrincipalMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip PrincipalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HacerPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeLoQueSeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComercioAdheridoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistrarComercioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SeguimientoDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        private System.Windows.Forms.GroupBox ImagenGroupBox;
        private System.Windows.Forms.Label DeliveryEatLabel;
    }
}