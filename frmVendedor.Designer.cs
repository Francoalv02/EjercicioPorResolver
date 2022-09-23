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
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.Location = new System.Drawing.Point(21, 69);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(168, 20);
            this.lblNombreVendedor.TabIndex = 8;
            this.lblNombreVendedor.Text = "Nombre del Vendedor:";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVendedor.Location = new System.Drawing.Point(192, 69);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(161, 26);
            this.txtNombreVendedor.TabIndex = 7;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(260, 245);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(93, 30);
            this.btn.TabIndex = 5;
            this.btn.Text = "Aceptar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbActivo
            // 
            this.cbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Items.AddRange(new object[] {
            "-1",
            "0"});
            this.cbActivo.Location = new System.Drawing.Point(192, 122);
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
            this.cbComision.Location = new System.Drawing.Point(192, 179);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(161, 28);
            this.cbComision.TabIndex = 10;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(21, 130);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(109, 20);
            this.lblActivo.TabIndex = 12;
            this.lblActivo.Text = "Cliente Activo ";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(21, 187);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(143, 20);
            this.lblComision.TabIndex = 13;
            this.lblComision.Text = "Cobro de Comision";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(2, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(409, 60);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "La ID de cada cliente se genera automaticamente con el nombre que se ingrese a co" +
    "ntinuacion.";
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 287);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.cbComision);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.btn);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ComboBox cbActivo;
        private System.Windows.Forms.ComboBox cbComision;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblID;
    }
}