namespace WindowsFormsApp1.Presentación.Reportes
{
    partial class MenúPrincipal
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
            this.CorreoCliente_txt = new System.Windows.Forms.TextBox();
            this.GarantíaCliente_txt = new System.Windows.Forms.TextBox();
            this.SueldoCliente_txt = new System.Windows.Forms.TextBox();
            this.DirecciónCliente_txt = new System.Windows.Forms.TextBox();
            this.NombreCliente_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Guardar_btn = new System.Windows.Forms.Button();
            this.Limpiar_btn = new System.Windows.Forms.Button();
            this.Eliminar_btn = new System.Windows.Forms.Button();
            this.Editar_btn = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(187, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.CorreoCliente_txt);
            this.panel1.Controls.Add(this.GarantíaCliente_txt);
            this.panel1.Controls.Add(this.SueldoCliente_txt);
            this.panel1.Controls.Add(this.DirecciónCliente_txt);
            this.panel1.Controls.Add(this.NombreCliente_txt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(199, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 554);
            this.panel1.TabIndex = 1;
            // 
            // CorreoCliente_txt
            // 
            this.CorreoCliente_txt.Location = new System.Drawing.Point(206, 165);
            this.CorreoCliente_txt.Name = "CorreoCliente_txt";
            this.CorreoCliente_txt.Size = new System.Drawing.Size(267, 22);
            this.CorreoCliente_txt.TabIndex = 10;
            // 
            // GarantíaCliente_txt
            // 
            this.GarantíaCliente_txt.Location = new System.Drawing.Point(206, 390);
            this.GarantíaCliente_txt.Name = "GarantíaCliente_txt";
            this.GarantíaCliente_txt.Size = new System.Drawing.Size(267, 22);
            this.GarantíaCliente_txt.TabIndex = 9;
            // 
            // SueldoCliente_txt
            // 
            this.SueldoCliente_txt.Location = new System.Drawing.Point(206, 499);
            this.SueldoCliente_txt.Name = "SueldoCliente_txt";
            this.SueldoCliente_txt.Size = new System.Drawing.Size(267, 22);
            this.SueldoCliente_txt.TabIndex = 8;
            // 
            // DirecciónCliente_txt
            // 
            this.DirecciónCliente_txt.Location = new System.Drawing.Point(206, 271);
            this.DirecciónCliente_txt.Name = "DirecciónCliente_txt";
            this.DirecciónCliente_txt.Size = new System.Drawing.Size(267, 22);
            this.DirecciónCliente_txt.TabIndex = 7;
            // 
            // NombreCliente_txt
            // 
            this.NombreCliente_txt.Location = new System.Drawing.Point(206, 72);
            this.NombreCliente_txt.Name = "NombreCliente_txt";
            this.NombreCliente_txt.Size = new System.Drawing.Size(267, 22);
            this.NombreCliente_txt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 22.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(25, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 44);
            this.label7.TabIndex = 5;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 22.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(25, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 44);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sueldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 22.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(25, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 44);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 22.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(25, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 44);
            this.label4.TabIndex = 2;
            this.label4.Text = "Garantía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // Guardar_btn
            // 
            this.Guardar_btn.Location = new System.Drawing.Point(199, 723);
            this.Guardar_btn.Name = "Guardar_btn";
            this.Guardar_btn.Size = new System.Drawing.Size(87, 50);
            this.Guardar_btn.TabIndex = 2;
            this.Guardar_btn.Text = "Guardar";
            this.Guardar_btn.UseVisualStyleBackColor = true;
            // 
            // Limpiar_btn
            // 
            this.Limpiar_btn.Location = new System.Drawing.Point(717, 723);
            this.Limpiar_btn.Name = "Limpiar_btn";
            this.Limpiar_btn.Size = new System.Drawing.Size(87, 50);
            this.Limpiar_btn.TabIndex = 3;
            this.Limpiar_btn.Text = "Limpiar";
            this.Limpiar_btn.UseVisualStyleBackColor = true;
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.Location = new System.Drawing.Point(540, 723);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(87, 50);
            this.Eliminar_btn.TabIndex = 4;
            this.Eliminar_btn.Text = "Eliminar";
            this.Eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // Editar_btn
            // 
            this.Editar_btn.Location = new System.Drawing.Point(361, 723);
            this.Editar_btn.Name = "Editar_btn";
            this.Editar_btn.Size = new System.Drawing.Size(87, 50);
            this.Editar_btn.TabIndex = 5;
            this.Editar_btn.Text = "Editar";
            this.Editar_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(1, 846);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(1035, 214);
            this.dataGridViewClientes.TabIndex = 6;
            // 
            // MenúPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._903174444d24a2c5575ac3bd32072d41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 1055);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.Editar_btn);
            this.Controls.Add(this.Eliminar_btn);
            this.Controls.Add(this.Limpiar_btn);
            this.Controls.Add(this.Guardar_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MenúPrincipal";
            this.Text = "ClientesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CorreoCliente_txt;
        private System.Windows.Forms.TextBox GarantíaCliente_txt;
        private System.Windows.Forms.TextBox SueldoCliente_txt;
        private System.Windows.Forms.TextBox DirecciónCliente_txt;
        private System.Windows.Forms.TextBox NombreCliente_txt;
        private System.Windows.Forms.Button Guardar_btn;
        private System.Windows.Forms.Button Limpiar_btn;
        private System.Windows.Forms.Button Eliminar_btn;
        private System.Windows.Forms.Button Editar_btn;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
    }
}