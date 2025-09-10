namespace Agenda
{
    partial class FrmAgenda
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
            this.components = new System.ComponentModel.Container();
            this.dGVAgenda = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAgenda)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVAgenda
            // 
            this.dGVAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Columna4,
            this.Columna5,
            this.Columna6});
            this.dGVAgenda.Location = new System.Drawing.Point(12, 66);
            this.dGVAgenda.Name = "dGVAgenda";
            this.dGVAgenda.RowHeadersWidth = 51;
            this.dGVAgenda.RowTemplate.Height = 24;
            this.dGVAgenda.Size = new System.Drawing.Size(1006, 229);
            this.dGVAgenda.TabIndex = 0;
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "NOMBRE:";
            this.Columna1.MinimumWidth = 6;
            this.Columna1.Name = "Columna1";
            this.Columna1.Width = 125;
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "APELLIDO PATERNO:";
            this.Columna2.MinimumWidth = 6;
            this.Columna2.Name = "Columna2";
            this.Columna2.Width = 125;
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "APELLIDO MATERNO:";
            this.Columna3.MinimumWidth = 6;
            this.Columna3.Name = "Columna3";
            this.Columna3.Width = 125;
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "DIRECCION";
            this.Columna4.MinimumWidth = 6;
            this.Columna4.Name = "Columna4";
            this.Columna4.Width = 125;
            // 
            // Columna5
            // 
            this.Columna5.HeaderText = "TELEFONO";
            this.Columna5.MinimumWidth = 6;
            this.Columna5.Name = "Columna5";
            this.Columna5.Width = 125;
            // 
            // Columna6
            // 
            this.Columna6.HeaderText = "CORREO";
            this.Columna6.MinimumWidth = 6;
            this.Columna6.Name = "Columna6";
            this.Columna6.Width = 125;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRegistros,
            this.toolStripStatusLabelFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1058, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabelRegistros
            // 
            this.toolStripStatusLabelRegistros.Name = "toolStripStatusLabelRegistros";
            this.toolStripStatusLabelRegistros.Size = new System.Drawing.Size(99, 20);
            this.toolStripStatusLabelRegistros.Text = "REGISTROS: 0";
            // 
            // toolStripStatusLabelFecha
            // 
            this.toolStripStatusLabelFecha.Name = "toolStripStatusLabelFecha";
            this.toolStripStatusLabelFecha.Size = new System.Drawing.Size(211, 20);
            this.toolStripStatusLabelFecha.Text = "Última actualización: --/--/----";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 537);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dGVAgenda);
            this.Name = "FrmAgenda";
            this.Text = "AGENDA";
            ((System.ComponentModel.ISupportInitialize)(this.dGVAgenda)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVAgenda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRegistros;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFecha;
    }
}

