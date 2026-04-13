namespace WindowsFormsApp1.Presentación.Reportes
{
    partial class Prestamos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClientePrestamo_Txt = new System.Windows.Forms.TextBox();
            this.TasaInterés_txt = new System.Windows.Forms.TextBox();
            this.PlazoPrestamo_txt = new System.Windows.Forms.TextBox();
            this.MontoPrestamo_txt = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.CalcularPrestamo_btn = new System.Windows.Forms.Button();
            this.LimpiarPrestamo_btn = new System.Windows.Forms.Button();
            this.EliminarPrestamo_btn = new System.Windows.Forms.Button();
            this.EditarPrestamo_btn = new System.Windows.Forms.Button();
            this.GuardarPrestamo_btn = new System.Windows.Forms.Button();
            this.dataGridViewPrestamo = new System.Windows.Forms.DataGridView();
            this.InterésGenerado_lbl = new System.Windows.Forms.Label();
            this.MontoAPagar_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CapitalDisponibleParaPrestamo_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitar Prestamo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerFechaInicio);
            this.panel1.Controls.Add(this.MontoPrestamo_txt);
            this.panel1.Controls.Add(this.PlazoPrestamo_txt);
            this.panel1.Controls.Add(this.TasaInterés_txt);
            this.panel1.Controls.Add(this.ClientePrestamo_Txt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CalcularPrestamo_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(141, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 633);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monto Total A Pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Interes Generado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tasa De Interés (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Plazo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Monto Del Préstamo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha De Inicio";
            // 
            // ClientePrestamo_Txt
            // 
            this.ClientePrestamo_Txt.Location = new System.Drawing.Point(352, 34);
            this.ClientePrestamo_Txt.Name = "ClientePrestamo_Txt";
            this.ClientePrestamo_Txt.Size = new System.Drawing.Size(159, 22);
            this.ClientePrestamo_Txt.TabIndex = 7;
            // 
            // TasaInterés_txt
            // 
            this.TasaInterés_txt.Location = new System.Drawing.Point(352, 353);
            this.TasaInterés_txt.Name = "TasaInterés_txt";
            this.TasaInterés_txt.Size = new System.Drawing.Size(159, 22);
            this.TasaInterés_txt.TabIndex = 13;
            // 
            // PlazoPrestamo_txt
            // 
            this.PlazoPrestamo_txt.Location = new System.Drawing.Point(352, 244);
            this.PlazoPrestamo_txt.Name = "PlazoPrestamo_txt";
            this.PlazoPrestamo_txt.Size = new System.Drawing.Size(159, 22);
            this.PlazoPrestamo_txt.TabIndex = 14;
            // 
            // MontoPrestamo_txt
            // 
            this.MontoPrestamo_txt.Location = new System.Drawing.Point(352, 145);
            this.MontoPrestamo_txt.Name = "MontoPrestamo_txt";
            this.MontoPrestamo_txt.Size = new System.Drawing.Size(159, 22);
            this.MontoPrestamo_txt.TabIndex = 15;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(325, 483);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaInicio.TabIndex = 16;
            // 
            // CalcularPrestamo_btn
            // 
            this.CalcularPrestamo_btn.Location = new System.Drawing.Point(184, 561);
            this.CalcularPrestamo_btn.Name = "CalcularPrestamo_btn";
            this.CalcularPrestamo_btn.Size = new System.Drawing.Size(138, 52);
            this.CalcularPrestamo_btn.TabIndex = 2;
            this.CalcularPrestamo_btn.Text = "Calcular";
            this.CalcularPrestamo_btn.UseVisualStyleBackColor = true;
            // 
            // LimpiarPrestamo_btn
            // 
            this.LimpiarPrestamo_btn.Location = new System.Drawing.Point(936, 812);
            this.LimpiarPrestamo_btn.Name = "LimpiarPrestamo_btn";
            this.LimpiarPrestamo_btn.Size = new System.Drawing.Size(138, 52);
            this.LimpiarPrestamo_btn.TabIndex = 3;
            this.LimpiarPrestamo_btn.Text = "Limpiar";
            this.LimpiarPrestamo_btn.UseVisualStyleBackColor = true;
            // 
            // EliminarPrestamo_btn
            // 
            this.EliminarPrestamo_btn.Location = new System.Drawing.Point(647, 812);
            this.EliminarPrestamo_btn.Name = "EliminarPrestamo_btn";
            this.EliminarPrestamo_btn.Size = new System.Drawing.Size(138, 52);
            this.EliminarPrestamo_btn.TabIndex = 4;
            this.EliminarPrestamo_btn.Text = "Eliminar";
            this.EliminarPrestamo_btn.UseVisualStyleBackColor = true;
            // 
            // EditarPrestamo_btn
            // 
            this.EditarPrestamo_btn.Location = new System.Drawing.Point(355, 812);
            this.EditarPrestamo_btn.Name = "EditarPrestamo_btn";
            this.EditarPrestamo_btn.Size = new System.Drawing.Size(138, 52);
            this.EditarPrestamo_btn.TabIndex = 5;
            this.EditarPrestamo_btn.Text = "Editar";
            this.EditarPrestamo_btn.UseVisualStyleBackColor = true;
            // 
            // GuardarPrestamo_btn
            // 
            this.GuardarPrestamo_btn.Location = new System.Drawing.Point(108, 812);
            this.GuardarPrestamo_btn.Name = "GuardarPrestamo_btn";
            this.GuardarPrestamo_btn.Size = new System.Drawing.Size(138, 52);
            this.GuardarPrestamo_btn.TabIndex = 6;
            this.GuardarPrestamo_btn.Text = "Guardar";
            this.GuardarPrestamo_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPrestamo
            // 
            this.dataGridViewPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamo.Location = new System.Drawing.Point(1, 904);
            this.dataGridViewPrestamo.Name = "dataGridViewPrestamo";
            this.dataGridViewPrestamo.RowHeadersWidth = 51;
            this.dataGridViewPrestamo.RowTemplate.Height = 24;
            this.dataGridViewPrestamo.Size = new System.Drawing.Size(1311, 150);
            this.dataGridViewPrestamo.TabIndex = 7;
            // 
            // InterésGenerado_lbl
            // 
            this.InterésGenerado_lbl.AutoSize = true;
            this.InterésGenerado_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterésGenerado_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InterésGenerado_lbl.Location = new System.Drawing.Point(1163, 279);
            this.InterésGenerado_lbl.Name = "InterésGenerado_lbl";
            this.InterésGenerado_lbl.Size = new System.Drawing.Size(22, 24);
            this.InterésGenerado_lbl.TabIndex = 8;
            this.InterésGenerado_lbl.Text = "0";
            // 
            // MontoAPagar_lbl
            // 
            this.MontoAPagar_lbl.AutoSize = true;
            this.MontoAPagar_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoAPagar_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MontoAPagar_lbl.Location = new System.Drawing.Point(1163, 400);
            this.MontoAPagar_lbl.Name = "MontoAPagar_lbl";
            this.MontoAPagar_lbl.Size = new System.Drawing.Size(22, 24);
            this.MontoAPagar_lbl.TabIndex = 9;
            this.MontoAPagar_lbl.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(742, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(380, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Capital Disponible para Prestamo:";
            // 
            // CapitalDisponibleParaPrestamo_lbl
            // 
            this.CapitalDisponibleParaPrestamo_lbl.AutoSize = true;
            this.CapitalDisponibleParaPrestamo_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapitalDisponibleParaPrestamo_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CapitalDisponibleParaPrestamo_lbl.Location = new System.Drawing.Point(1128, 112);
            this.CapitalDisponibleParaPrestamo_lbl.Name = "CapitalDisponibleParaPrestamo_lbl";
            this.CapitalDisponibleParaPrestamo_lbl.Size = new System.Drawing.Size(22, 24);
            this.CapitalDisponibleParaPrestamo_lbl.TabIndex = 11;
            this.CapitalDisponibleParaPrestamo_lbl.Text = "0";
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 1055);
            this.Controls.Add(this.CapitalDisponibleParaPrestamo_lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MontoAPagar_lbl);
            this.Controls.Add(this.InterésGenerado_lbl);
            this.Controls.Add(this.dataGridViewPrestamo);
            this.Controls.Add(this.GuardarPrestamo_btn);
            this.Controls.Add(this.EditarPrestamo_btn);
            this.Controls.Add(this.EliminarPrestamo_btn);
            this.Controls.Add(this.LimpiarPrestamo_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Prestamos";
            this.Text = "PrestamosForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.TextBox MontoPrestamo_txt;
        private System.Windows.Forms.TextBox PlazoPrestamo_txt;
        private System.Windows.Forms.TextBox TasaInterés_txt;
        private System.Windows.Forms.TextBox ClientePrestamo_Txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CalcularPrestamo_btn;
        private System.Windows.Forms.Button LimpiarPrestamo_btn;
        private System.Windows.Forms.Button EliminarPrestamo_btn;
        private System.Windows.Forms.Button EditarPrestamo_btn;
        private System.Windows.Forms.Button GuardarPrestamo_btn;
        private System.Windows.Forms.DataGridView dataGridViewPrestamo;
        private System.Windows.Forms.Label InterésGenerado_lbl;
        private System.Windows.Forms.Label MontoAPagar_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CapitalDisponibleParaPrestamo_lbl;
    }
}