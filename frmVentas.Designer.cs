namespace PryAlvarezER
{
    partial class frmVentas
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
            this.nudFacturaNro = new System.Windows.Forms.NumericUpDown();
            this.lblFacturaNro = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.cbClienteID = new System.Windows.Forms.ComboBox();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.cbVendedorID = new System.Windows.Forms.ComboBox();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.cbFactura = new System.Windows.Forms.ComboBox();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFacturaNro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFacturaNro
            // 
            this.nudFacturaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFacturaNro.Location = new System.Drawing.Point(191, 173);
            this.nudFacturaNro.Name = "nudFacturaNro";
            this.nudFacturaNro.Size = new System.Drawing.Size(160, 26);
            this.nudFacturaNro.TabIndex = 13;
            // 
            // lblFacturaNro
            // 
            this.lblFacturaNro.AutoSize = true;
            this.lblFacturaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaNro.Location = new System.Drawing.Point(20, 175);
            this.lblFacturaNro.Name = "lblFacturaNro";
            this.lblFacturaNro.Size = new System.Drawing.Size(93, 20);
            this.lblFacturaNro.TabIndex = 12;
            this.lblFacturaNro.Text = "Factura Nro";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(19, 33);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(79, 20);
            this.lblClienteID.TabIndex = 15;
            this.lblClienteID.Text = "Cliente ID";
            // 
            // cbClienteID
            // 
            this.cbClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClienteID.FormattingEnabled = true;
            this.cbClienteID.Location = new System.Drawing.Point(190, 25);
            this.cbClienteID.Name = "cbClienteID";
            this.cbClienteID.Size = new System.Drawing.Size(161, 28);
            this.cbClienteID.TabIndex = 14;
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorID.Location = new System.Drawing.Point(19, 75);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(100, 20);
            this.lblVendedorID.TabIndex = 17;
            this.lblVendedorID.Text = "Vendedor ID";
            // 
            // cbVendedorID
            // 
            this.cbVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendedorID.FormattingEnabled = true;
            this.cbVendedorID.Location = new System.Drawing.Point(190, 67);
            this.cbVendedorID.Name = "cbVendedorID";
            this.cbVendedorID.Size = new System.Drawing.Size(161, 28);
            this.cbVendedorID.TabIndex = 16;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(19, 125);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(98, 20);
            this.lblTipoFactura.TabIndex = 19;
            this.lblTipoFactura.Text = "Tipo Factura";
            // 
            // cbFactura
            // 
            this.cbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactura.FormattingEnabled = true;
            this.cbFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbFactura.Location = new System.Drawing.Point(190, 117);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(161, 28);
            this.cbFactura.TabIndex = 18;
            // 
            // nudMonto
            // 
            this.nudMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonto.Location = new System.Drawing.Point(191, 226);
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(160, 26);
            this.nudMonto.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Monto";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(258, 303);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(93, 30);
            this.btn.TabIndex = 22;
            this.btn.Text = "Aceptar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 345);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.cbFactura);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.cbVendedorID);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.cbClienteID);
            this.Controls.Add(this.nudFacturaNro);
            this.Controls.Add(this.lblFacturaNro);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFacturaNro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFacturaNro;
        private System.Windows.Forms.Label lblFacturaNro;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.ComboBox cbClienteID;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.ComboBox cbVendedorID;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.ComboBox cbFactura;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn;
    }
}