namespace ProyectoGraficacion_ITT
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnVistaEntrada = new System.Windows.Forms.PictureBox();
            this.btnVistaCalafornix = new System.Windows.Forms.PictureBox();
            this.btnVista300 = new System.Windows.Forms.PictureBox();
            this.btnVistaBiblioteca = new System.Windows.Forms.PictureBox();
            this.btnVista600 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.Movimiento = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnVistaEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVistaCalafornix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVista300)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVistaBiblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVista600)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVistaEntrada
            // 
            this.btnVistaEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVistaEntrada.Location = new System.Drawing.Point(320, 437);
            this.btnVistaEntrada.Name = "btnVistaEntrada";
            this.btnVistaEntrada.Size = new System.Drawing.Size(73, 86);
            this.btnVistaEntrada.TabIndex = 0;
            this.btnVistaEntrada.TabStop = false;
            this.btnVistaEntrada.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVistaEntrada_MouseDown);
            // 
            // btnVistaCalafornix
            // 
            this.btnVistaCalafornix.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaCalafornix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVistaCalafornix.Location = new System.Drawing.Point(84, 223);
            this.btnVistaCalafornix.Name = "btnVistaCalafornix";
            this.btnVistaCalafornix.Size = new System.Drawing.Size(136, 77);
            this.btnVistaCalafornix.TabIndex = 1;
            this.btnVistaCalafornix.TabStop = false;
            this.btnVistaCalafornix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVistaCalafornix_MouseDown);
            // 
            // btnVista300
            // 
            this.btnVista300.BackColor = System.Drawing.Color.Transparent;
            this.btnVista300.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVista300.Location = new System.Drawing.Point(64, 338);
            this.btnVista300.Name = "btnVista300";
            this.btnVista300.Size = new System.Drawing.Size(110, 24);
            this.btnVista300.TabIndex = 2;
            this.btnVista300.TabStop = false;
            this.btnVista300.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVista300_MouseDown);
            // 
            // btnVistaBiblioteca
            // 
            this.btnVistaBiblioteca.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVistaBiblioteca.Location = new System.Drawing.Point(205, 159);
            this.btnVistaBiblioteca.Name = "btnVistaBiblioteca";
            this.btnVistaBiblioteca.Size = new System.Drawing.Size(63, 75);
            this.btnVistaBiblioteca.TabIndex = 3;
            this.btnVistaBiblioteca.TabStop = false;
            this.btnVistaBiblioteca.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVistaBiblioteca_MouseDown);
            // 
            // btnVista600
            // 
            this.btnVista600.BackColor = System.Drawing.Color.Transparent;
            this.btnVista600.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVista600.Location = new System.Drawing.Point(359, 25);
            this.btnVista600.Name = "btnVista600";
            this.btnVista600.Size = new System.Drawing.Size(97, 60);
            this.btnVista600.TabIndex = 4;
            this.btnVista600.TabStop = false;
            this.btnVista600.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVista600_MouseDown);
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(397, 622);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 27);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "Controles";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(397, 588);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(76, 27);
            this.btnInfo.TabIndex = 11;
            this.btnInfo.Text = "INFO";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Movimiento
            // 
            this.Movimiento.Interval = 60;
            this.Movimiento.Tick += new System.EventHandler(this.Movimiento_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnVista600);
            this.Controls.Add(this.btnVistaBiblioteca);
            this.Controls.Add(this.btnVista300);
            this.Controls.Add(this.btnVistaCalafornix);
            this.Controls.Add(this.btnVistaEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITT-Graficado";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.btnVistaEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVistaCalafornix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVista300)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVistaBiblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVista600)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnVistaEntrada;
        private System.Windows.Forms.PictureBox btnVistaCalafornix;
        private System.Windows.Forms.PictureBox btnVista300;
        private System.Windows.Forms.PictureBox btnVistaBiblioteca;
        private System.Windows.Forms.PictureBox btnVista600;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Timer Movimiento;
    }
}

