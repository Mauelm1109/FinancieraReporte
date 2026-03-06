namespace WindowsFormsApp1.Presentación.Reportes
{
    partial class Reportes
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
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.PrestamosBtn = new System.Windows.Forms.Button();
            this.PagosBtn = new System.Windows.Forms.Button();
            this.ReportesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesBtn.Location = new System.Drawing.Point(462, 170);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Size = new System.Drawing.Size(303, 106);
            this.ClientesBtn.TabIndex = 3;
            this.ClientesBtn.Text = "Clientes";
            this.ClientesBtn.UseVisualStyleBackColor = true;
            // 
            // PrestamosBtn
            // 
            this.PrestamosBtn.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PrestamosBtn.Location = new System.Drawing.Point(99, 170);
            this.PrestamosBtn.Name = "PrestamosBtn";
            this.PrestamosBtn.Size = new System.Drawing.Size(247, 106);
            this.PrestamosBtn.TabIndex = 4;
            this.PrestamosBtn.Text = "Prestamos";
            this.PrestamosBtn.UseVisualStyleBackColor = true;
            this.PrestamosBtn.Click += new System.EventHandler(this.PrestamosBtn_Click);
            // 
            // PagosBtn
            // 
            this.PagosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PagosBtn.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PagosBtn.Location = new System.Drawing.Point(99, 319);
            this.PagosBtn.Name = "PagosBtn";
            this.PagosBtn.Size = new System.Drawing.Size(247, 98);
            this.PagosBtn.TabIndex = 5;
            this.PagosBtn.Text = "Pagos";
            this.PagosBtn.UseVisualStyleBackColor = true;
            // 
            // ReportesBtn
            // 
            this.ReportesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportesBtn.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ReportesBtn.Location = new System.Drawing.Point(462, 308);
            this.ReportesBtn.Name = "ReportesBtn";
            this.ReportesBtn.Size = new System.Drawing.Size(303, 109);
            this.ReportesBtn.TabIndex = 6;
            this.ReportesBtn.Text = "Reportes";
            this.ReportesBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 71);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menú Principal";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sala_vip_banco_intern_curitiba5_1529x860;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportesBtn);
            this.Controls.Add(this.PagosBtn);
            this.Controls.Add(this.PrestamosBtn);
            this.Controls.Add(this.ClientesBtn);
            this.Name = "Reportes";
            this.Opacity = 0.8D;
            this.Text = "ReportesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Button PrestamosBtn;
        private System.Windows.Forms.Button PagosBtn;
        private System.Windows.Forms.Button ReportesBtn;
        private System.Windows.Forms.Label label1;
    }
}