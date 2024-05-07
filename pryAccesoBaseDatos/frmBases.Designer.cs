namespace pryAccesoBaseDatos
{
    partial class frmBases
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.ofdAbrirArchivos = new System.Windows.Forms.OpenFileDialog();
            this.lblBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(12, 12);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(776, 46);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir base...";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // ofdAbrirArchivos
            // 
            this.ofdAbrirArchivos.FileName = "openFileDialog1";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(12, 78);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(10, 13);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "-";
            // 
            // frmBases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnAbrir);
            this.Name = "frmBases";
            this.Text = "frmBases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArchivos;
        private System.Windows.Forms.Label lblBase;
    }
}