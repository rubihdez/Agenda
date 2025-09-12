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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGVAgenda = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stS = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAgenda)).BeginInit();
            this.stS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVAgenda
            // 
            this.dGVAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVAgenda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Columna4,
            this.Columna5,
            this.Columna6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVAgenda.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVAgenda.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGVAgenda.Location = new System.Drawing.Point(0, 11);
            this.dGVAgenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVAgenda.Name = "dGVAgenda";
            this.dGVAgenda.RowHeadersWidth = 51;
            this.dGVAgenda.RowTemplate.Height = 24;
            this.dGVAgenda.Size = new System.Drawing.Size(846, 385);
            this.dGVAgenda.TabIndex = 0;
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "NOMBRE:";
            this.Columna1.MinimumWidth = 6;
            this.Columna1.Name = "Columna1";
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "APELLIDO PATERNO:";
            this.Columna2.MinimumWidth = 6;
            this.Columna2.Name = "Columna2";
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "APELLIDO MATERNO:";
            this.Columna3.MinimumWidth = 6;
            this.Columna3.Name = "Columna3";
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "DIRECCION";
            this.Columna4.MinimumWidth = 6;
            this.Columna4.Name = "Columna4";
            // 
            // Columna5
            // 
            this.Columna5.HeaderText = "TELEFONO";
            this.Columna5.MinimumWidth = 6;
            this.Columna5.Name = "Columna5";
            // 
            // Columna6
            // 
            this.Columna6.HeaderText = "CORREO";
            this.Columna6.MinimumWidth = 6;
            this.Columna6.Name = "Columna6";
            // 
            // stS
            // 
            this.stS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRegistros,
            this.toolStripStatusLabelFecha});
            this.stS.Location = new System.Drawing.Point(0, 422);
            this.stS.Name = "stS";
            this.stS.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.stS.Size = new System.Drawing.Size(846, 26);
            this.stS.TabIndex = 1;
            this.stS.Text = "stS";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(846, 448);
            this.Controls.Add(this.stS);
            this.Controls.Add(this.dGVAgenda);
            this.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAgenda";
            this.Text = "AGENDA";
            ((System.ComponentModel.ISupportInitialize)(this.dGVAgenda)).EndInit();
            this.stS.ResumeLayout(false);
            this.stS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVAgenda;
        private System.Windows.Forms.StatusStrip stS;
        private System.Windows.Forms.Timer timer;
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

