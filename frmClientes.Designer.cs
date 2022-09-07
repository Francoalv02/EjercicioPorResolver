namespace PryAlvarezER
{
    partial class frmClientes
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNroCliente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(156, 148);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 30);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCliente.Location = new System.Drawing.Point(12, 26);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(144, 20);
            this.lblNroCliente.TabIndex = 1;
            this.lblNroCliente.Text = "Numero del cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(166, 79);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(221, 26);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre  del cliente:";
            // 
            // nudNroCliente
            // 
            this.nudNroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNroCliente.Location = new System.Drawing.Point(166, 24);
            this.nudNroCliente.Name = "nudNroCliente";
            this.nudNroCliente.Size = new System.Drawing.Size(221, 26);
            this.nudNroCliente.TabIndex = 12;
            this.nudNroCliente.ValueChanged += new System.EventHandler(this.nudCliente_ValueChanged);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 221);
            this.Controls.Add(this.nudNroCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNroCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNroCliente;
    }
}