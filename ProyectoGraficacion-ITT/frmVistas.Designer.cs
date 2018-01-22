namespace ProyectoGraficacion_ITT
{
    partial class frmVistas
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
            this.pbxVista = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVista)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxVista
            // 
            this.pbxVista.Location = new System.Drawing.Point(12, 12);
            this.pbxVista.Name = "pbxVista";
            this.pbxVista.Size = new System.Drawing.Size(720, 540);
            this.pbxVista.TabIndex = 0;
            this.pbxVista.TabStop = false;
            this.pbxVista.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxVista_Paint);
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(657, 558);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 27);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Controles";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmVistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 588);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pbxVista);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistas";
            this.Load += new System.EventHandler(this.frmVistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxVista;
        private System.Windows.Forms.Button btnHelp;
    }
}