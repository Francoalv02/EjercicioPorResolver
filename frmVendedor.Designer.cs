namespace PryAlvarezER
{
    partial class frmVendedor
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
            this.lblNombreClientes = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.nudCliente = new System.Windows.Forms.NumericUpDown();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreClientes
            // 
            this.lblNombreClientes.AutoSize = true;
            this.lblNombreClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClientes.Location = new System.Drawing.Point(18, 75);
            this.lblNombreClientes.Name = "lblNombreClientes";
            this.lblNombreClientes.Size = new System.Drawing.Size(148, 20);
            this.lblNombreClientes.TabIndex = 8;
            this.lblNombreClientes.Text = "Nombre  del cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(172, 75);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(161, 26);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCliente.Location = new System.Drawing.Point(18, 34);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(144, 20);
            this.lblNroCliente.TabIndex = 6;
            this.lblNroCliente.Text = "Numero del cliente:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(137, 266);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 30);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbActivo
            // 
            this.cbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "-1",
            "0"});
            this.cbActivo.Location = new System.Drawing.Point(172, 128);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(161, 28);
            this.cbActivo.TabIndex = 9;
            // 
            // cbComision
            // 
            this.cbComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComision.FormattingEnabled = true;
            this.cbComision.Items.AddRange(new object[] {
            "-1",
            "0"});
            this.cbComision.Location = new System.Drawing.Point(172, 185);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(161, 28);
            this.cbComision.TabIndex = 10;
            // 
            // nudCliente
            // 
            this.nudCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCliente.Location = new System.Drawing.Point(172, 32);
            this.nudCliente.Name = "nudCliente";
            this.nudCliente.Size = new System.Drawing.Size(160, 26);
            this.nudCliente.TabIndex = 11;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(18, 136);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(109, 20);
            this.lblActivo.TabIndex = 12;
            this.lblActivo.Text = "Cliente Activo ";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(18, 193);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(143, 20);
            this.lblComision.TabIndex = 13;
            this.lblComision.Text = "Cobro de Comision";
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 314);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.nudCliente);
            this.Controls.Add(this.cbComision);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.lblNombreClientes);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.nudCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreClientes;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbActivo;
        private System.Windows.Forms.ComboBox cbComision;
        private System.Windows.Forms.NumericUpDown nudCliente;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblComision;
    }
}