namespace WindowsFormsApp1.Presentación.Reportes
{
    partial class Pagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClientePagos_txt = new System.Windows.Forms.TextBox();
            this.BuscarClientePagos_btn = new System.Windows.Forms.Button();
            this.comboBoxPrestamoPagos = new System.Windows.Forms.ComboBox();
            this.comboBoxMesPagos = new System.Windows.Forms.ComboBox();
            this.MontoAPagarPagos_txt = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaPagoPagos = new System.Windows.Forms.DateTimePicker();
            this.RegistrarPago_btn = new System.Windows.Forms.Button();
            this.progressBarPago = new System.Windows.Forms.ProgressBar();
            this.dataGridViewPagos = new System.Windows.Forms.DataGridView();
            this.LimpiarPago_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.MontoAnterior_lbl = new System.Windows.Forms.Label();
            this.NuevoSaldo_lbl = new System.Windows.Forms.Label();
            this.InteresDelMes_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha De Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto A Pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mes (cuotas)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Préstamo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LimpiarPago_btn);
            this.panel1.Controls.Add(this.RegistrarPago_btn);
            this.panel1.Controls.Add(this.dateTimePickerFechaPagoPagos);
            this.panel1.Controls.Add(this.MontoAPagarPagos_txt);
            this.panel1.Controls.Add(this.comboBoxMesPagos);
            this.panel1.Controls.Add(this.comboBoxPrestamoPagos);
            this.panel1.Controls.Add(this.BuscarClientePagos_btn);
            this.panel1.Controls.Add(this.ClientePagos_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(67, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 560);
            this.panel1.TabIndex = 7;
            // 
            // ClientePagos_txt
            // 
            this.ClientePagos_txt.Location = new System.Drawing.Point(117, 17);
            this.ClientePagos_txt.Name = "ClientePagos_txt";
            this.ClientePagos_txt.Size = new System.Drawing.Size(142, 22);
            this.ClientePagos_txt.TabIndex = 7;
            // 
            // BuscarClientePagos_btn
            // 
            this.BuscarClientePagos_btn.Location = new System.Drawing.Point(283, 17);
            this.BuscarClientePagos_btn.Name = "BuscarClientePagos_btn";
            this.BuscarClientePagos_btn.Size = new System.Drawing.Size(189, 23);
            this.BuscarClientePagos_btn.TabIndex = 8;
            this.BuscarClientePagos_btn.Text = "Buscar";
            this.BuscarClientePagos_btn.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrestamoPagos
            // 
            this.comboBoxPrestamoPagos.FormattingEnabled = true;
            this.comboBoxPrestamoPagos.Location = new System.Drawing.Point(272, 109);
            this.comboBoxPrestamoPagos.Name = "comboBoxPrestamoPagos";
            this.comboBoxPrestamoPagos.Size = new System.Drawing.Size(200, 24);
            this.comboBoxPrestamoPagos.TabIndex = 9;
            // 
            // comboBoxMesPagos
            // 
            this.comboBoxMesPagos.FormattingEnabled = true;
            this.comboBoxMesPagos.Location = new System.Drawing.Point(272, 202);
            this.comboBoxMesPagos.Name = "comboBoxMesPagos";
            this.comboBoxMesPagos.Size = new System.Drawing.Size(200, 24);
            this.comboBoxMesPagos.TabIndex = 10;
            // 
            // MontoAPagarPagos_txt
            // 
            this.MontoAPagarPagos_txt.Location = new System.Drawing.Point(272, 303);
            this.MontoAPagarPagos_txt.Name = "MontoAPagarPagos_txt";
            this.MontoAPagarPagos_txt.Size = new System.Drawing.Size(200, 22);
            this.MontoAPagarPagos_txt.TabIndex = 11;
            // 
            // dateTimePickerFechaPagoPagos
            // 
            this.dateTimePickerFechaPagoPagos.Location = new System.Drawing.Point(272, 379);
            this.dateTimePickerFechaPagoPagos.Name = "dateTimePickerFechaPagoPagos";
            this.dateTimePickerFechaPagoPagos.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaPagoPagos.TabIndex = 12;
            // 
            // RegistrarPago_btn
            // 
            this.RegistrarPago_btn.Location = new System.Drawing.Point(159, 486);
            this.RegistrarPago_btn.Name = "RegistrarPago_btn";
            this.RegistrarPago_btn.Size = new System.Drawing.Size(125, 52);
            this.RegistrarPago_btn.TabIndex = 13;
            this.RegistrarPago_btn.Text = "Registrar Pago";
            this.RegistrarPago_btn.UseVisualStyleBackColor = true;
            // 
            // progressBarPago
            // 
            this.progressBarPago.Location = new System.Drawing.Point(67, 686);
            this.progressBarPago.Name = "progressBarPago";
            this.progressBarPago.Size = new System.Drawing.Size(496, 28);
            this.progressBarPago.TabIndex = 8;
            // 
            // dataGridViewPagos
            // 
            this.dataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagos.Location = new System.Drawing.Point(1, 799);
            this.dataGridViewPagos.Name = "dataGridViewPagos";
            this.dataGridViewPagos.RowHeadersWidth = 51;
            this.dataGridViewPagos.RowTemplate.Height = 24;
            this.dataGridViewPagos.Size = new System.Drawing.Size(1197, 240);
            this.dataGridViewPagos.TabIndex = 9;
            // 
            // LimpiarPago_btn
            // 
            this.LimpiarPago_btn.Location = new System.Drawing.Point(347, 486);
            this.LimpiarPago_btn.Name = "LimpiarPago_btn";
            this.LimpiarPago_btn.Size = new System.Drawing.Size(125, 52);
            this.LimpiarPago_btn.TabIndex = 14;
            this.LimpiarPago_btn.Text = "Limpiar";
            this.LimpiarPago_btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Monto Anterior:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Interes Del Mes:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InteresDelMes_lbl);
            this.panel2.Controls.Add(this.NuevoSaldo_lbl);
            this.panel2.Controls.Add(this.MontoAnterior_lbl);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(659, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 560);
            this.panel2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nuevo Saldo:";
            // 
            // MontoAnterior_lbl
            // 
            this.MontoAnterior_lbl.AutoSize = true;
            this.MontoAnterior_lbl.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoAnterior_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MontoAnterior_lbl.Location = new System.Drawing.Point(300, 36);
            this.MontoAnterior_lbl.Name = "MontoAnterior_lbl";
            this.MontoAnterior_lbl.Size = new System.Drawing.Size(19, 20);
            this.MontoAnterior_lbl.TabIndex = 18;
            this.MontoAnterior_lbl.Text = "0";
            // 
            // NuevoSaldo_lbl
            // 
            this.NuevoSaldo_lbl.AutoSize = true;
            this.NuevoSaldo_lbl.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoSaldo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NuevoSaldo_lbl.Location = new System.Drawing.Point(300, 261);
            this.NuevoSaldo_lbl.Name = "NuevoSaldo_lbl";
            this.NuevoSaldo_lbl.Size = new System.Drawing.Size(19, 20);
            this.NuevoSaldo_lbl.TabIndex = 19;
            this.NuevoSaldo_lbl.Text = "0";
            // 
            // InteresDelMes_lbl
            // 
            this.InteresDelMes_lbl.AutoSize = true;
            this.InteresDelMes_lbl.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InteresDelMes_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InteresDelMes_lbl.Location = new System.Drawing.Point(300, 141);
            this.InteresDelMes_lbl.Name = "InteresDelMes_lbl";
            this.InteresDelMes_lbl.Size = new System.Drawing.Size(19, 20);
            this.InteresDelMes_lbl.TabIndex = 20;
            this.InteresDelMes_lbl.Text = "0";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1038);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewPagos);
            this.Controls.Add(this.progressBarPago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Pagos";
            this.Text = "PagosForm";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BuscarClientePagos_btn;
        private System.Windows.Forms.TextBox ClientePagos_txt;
        private System.Windows.Forms.Button RegistrarPago_btn;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPagoPagos;
        private System.Windows.Forms.TextBox MontoAPagarPagos_txt;
        private System.Windows.Forms.ComboBox comboBoxMesPagos;
        private System.Windows.Forms.ComboBox comboBoxPrestamoPagos;
        private System.Windows.Forms.ProgressBar progressBarPago;
        private System.Windows.Forms.DataGridView dataGridViewPagos;
        private System.Windows.Forms.Button LimpiarPago_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MontoAnterior_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label InteresDelMes_lbl;
        private System.Windows.Forms.Label NuevoSaldo_lbl;
    }
}