namespace pryAccesoBaseDatos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnConectar = new System.Windows.Forms.Button();
            this.barraInferior = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLeer = new System.Windows.Forms.Button();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAbrirOtroForm = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCargarChart = new System.Windows.Forms.Button();
            this.barraInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(13, 13);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(173, 37);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar a Base de Datos";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // barraInferior
            // 
            this.barraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.barraInferior.Location = new System.Drawing.Point(0, 630);
            this.barraInferior.Name = "barraInferior";
            this.barraInferior.Size = new System.Drawing.Size(749, 22);
            this.barraInferior.TabIndex = 1;
            this.barraInferior.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(12, 17);
            this.lblEstadoConexion.Text = "-";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(12, 56);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(173, 37);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer información";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Location = new System.Drawing.Point(253, 13);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.Size = new System.Drawing.Size(452, 309);
            this.dgvSocios.TabIndex = 3;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(12, 113);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(16, 13);
            this.lblDatos.TabIndex = 4;
            this.lblDatos.Text = "---";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(13, 157);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(173, 37);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Listar y Registrar información";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 222);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 206);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAbrirOtroForm
            // 
            this.btnAbrirOtroForm.Location = new System.Drawing.Point(12, 300);
            this.btnAbrirOtroForm.Name = "btnAbrirOtroForm";
            this.btnAbrirOtroForm.Size = new System.Drawing.Size(173, 37);
            this.btnAbrirOtroForm.TabIndex = 8;
            this.btnAbrirOtroForm.Text = "Abrir otro form...";
            this.btnAbrirOtroForm.UseVisualStyleBackColor = true;
            this.btnAbrirOtroForm.Click += new System.EventHandler(this.btnAbrirOtroForm_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(253, 384);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(452, 217);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // btnCargarChart
            // 
            this.btnCargarChart.Location = new System.Drawing.Point(13, 384);
            this.btnCargarChart.Name = "btnCargarChart";
            this.btnCargarChart.Size = new System.Drawing.Size(173, 47);
            this.btnCargarChart.TabIndex = 10;
            this.btnCargarChart.Text = "Cargar Chart";
            this.btnCargarChart.UseVisualStyleBackColor = true;
            this.btnCargarChart.Click += new System.EventHandler(this.btnCargarChart_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 652);
            this.Controls.Add(this.btnCargarChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnAbrirOtroForm);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.barraInferior);
            this.Controls.Add(this.btnConectar);
            this.Name = "frmPrincipal";
            this.Text = "Acceso a Bases de Datos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.barraInferior.ResumeLayout(false);
            this.barraInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.StatusStrip barraInferior;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAbrirOtroForm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCargarChart;
    }
}

