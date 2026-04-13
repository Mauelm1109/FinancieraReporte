namespace WindowsFormsApp1.Presentación.Reportes
{
    partial class Amortización
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
            this.PlazoMesesAmortización_lbl = new System.Windows.Forms.Label();
            this.TasaInteresAmortizacion_lbl = new System.Windows.Forms.Label();
            this.MontoPrestamoAmortizacion_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreClienteAmortización_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPrestamosClientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GenerarAmortizacion_btn = new System.Windows.Forms.Button();
            this.dataGridViewAmortización = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortización)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amortización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlazoMesesAmortización_lbl);
            this.panel1.Controls.Add(this.TasaInteresAmortizacion_lbl);
            this.panel1.Controls.Add(this.MontoPrestamoAmortizacion_lbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(264, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 385);
            this.panel1.TabIndex = 1;
            // 
            // PlazoMesesAmortización_lbl
            // 
            this.PlazoMesesAmortización_lbl.AutoSize = true;
            this.PlazoMesesAmortización_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlazoMesesAmortización_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PlazoMesesAmortización_lbl.Location = new System.Drawing.Point(318, 302);
            this.PlazoMesesAmortización_lbl.Name = "PlazoMesesAmortización_lbl";
            this.PlazoMesesAmortización_lbl.Size = new System.Drawing.Size(22, 24);
            this.PlazoMesesAmortización_lbl.TabIndex = 14;
            this.PlazoMesesAmortización_lbl.Text = "0";
            // 
            // TasaInteresAmortizacion_lbl
            // 
            this.TasaInteresAmortizacion_lbl.AutoSize = true;
            this.TasaInteresAmortizacion_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasaInteresAmortizacion_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TasaInteresAmortizacion_lbl.Location = new System.Drawing.Point(318, 177);
            this.TasaInteresAmortizacion_lbl.Name = "TasaInteresAmortizacion_lbl";
            this.TasaInteresAmortizacion_lbl.Size = new System.Drawing.Size(22, 24);
            this.TasaInteresAmortizacion_lbl.TabIndex = 13;
            this.TasaInteresAmortizacion_lbl.Text = "0";
            // 
            // MontoPrestamoAmortizacion_lbl
            // 
            this.MontoPrestamoAmortizacion_lbl.AutoSize = true;
            this.MontoPrestamoAmortizacion_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoPrestamoAmortizacion_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MontoPrestamoAmortizacion_lbl.Location = new System.Drawing.Point(318, 48);
            this.MontoPrestamoAmortizacion_lbl.Name = "MontoPrestamoAmortizacion_lbl";
            this.MontoPrestamoAmortizacion_lbl.Size = new System.Drawing.Size(22, 24);
            this.MontoPrestamoAmortizacion_lbl.TabIndex = 12;
            this.MontoPrestamoAmortizacion_lbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Monto Del Prestamo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tasa De Interés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Plazo a Meses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Del Cliente";
            // 
            // NombreClienteAmortización_txt
            // 
            this.NombreClienteAmortización_txt.Location = new System.Drawing.Point(252, 144);
            this.NombreClienteAmortización_txt.Name = "NombreClienteAmortización_txt";
            this.NombreClienteAmortización_txt.Size = new System.Drawing.Size(167, 22);
            this.NombreClienteAmortización_txt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Datos Del Prestamo";
            // 
            // comboBoxPrestamosClientes
            // 
            this.comboBoxPrestamosClientes.FormattingEnabled = true;
            this.comboBoxPrestamosClientes.Location = new System.Drawing.Point(869, 140);
            this.comboBoxPrestamosClientes.Name = "comboBoxPrestamosClientes";
            this.comboBoxPrestamosClientes.Size = new System.Drawing.Size(244, 24);
            this.comboBoxPrestamosClientes.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Préstamos del cliente";
            // 
            // GenerarAmortizacion_btn
            // 
            this.GenerarAmortizacion_btn.Location = new System.Drawing.Point(409, 662);
            this.GenerarAmortizacion_btn.Name = "GenerarAmortizacion_btn";
            this.GenerarAmortizacion_btn.Size = new System.Drawing.Size(159, 43);
            this.GenerarAmortizacion_btn.TabIndex = 8;
            this.GenerarAmortizacion_btn.Text = "Generar Amortización";
            this.GenerarAmortizacion_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAmortización
            // 
            this.dataGridViewAmortización.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAmortización.Location = new System.Drawing.Point(0, 757);
            this.dataGridViewAmortización.Name = "dataGridViewAmortización";
            this.dataGridViewAmortización.RowHeadersWidth = 51;
            this.dataGridViewAmortización.RowTemplate.Height = 24;
            this.dataGridViewAmortización.Size = new System.Drawing.Size(1189, 300);
            this.dataGridViewAmortización.TabIndex = 9;
            // 
            // Amortización
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 1055);
            this.Controls.Add(this.dataGridViewAmortización);
            this.Controls.Add(this.GenerarAmortizacion_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxPrestamosClientes);
            this.Controls.Add(this.NombreClienteAmortización_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Amortización";
            this.Text = "AmortizaciónForm";
            this.Load += new System.EventHandler(this.Amortización_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortización)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreClienteAmortización_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPrestamosClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GenerarAmortizacion_btn;
        private System.Windows.Forms.DataGridView dataGridViewAmortización;
        private System.Windows.Forms.Label PlazoMesesAmortización_lbl;
        private System.Windows.Forms.Label TasaInteresAmortizacion_lbl;
        private System.Windows.Forms.Label MontoPrestamoAmortizacion_lbl;
    }
}