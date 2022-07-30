namespace UI
{
    partial class Datos_ClimaticosUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos_ClimaticosUI));
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.DgwDatos = new System.Windows.Forms.DataGridView();
            this.MESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIPITACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.Efx_Datos_Climaticos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Efx_BtnExcel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnAbrir = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_DgwDatos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgwDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.panel_Titulo.SuspendLayout();
            this.PanelInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrir.FlatAppearance.BorderSize = 0;
            this.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.ForeColor = System.Drawing.Color.White;
            this.BtnAbrir.Location = new System.Drawing.Point(264, 499);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(136, 43);
            this.BtnAbrir.TabIndex = 7;
            this.BtnAbrir.Text = "REGISTRAR";
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // DgwDatos
            // 
            this.DgwDatos.AllowUserToAddRows = false;
            this.DgwDatos.AllowUserToDeleteRows = false;
            this.DgwDatos.AllowUserToResizeRows = false;
            this.DgwDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgwDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.DgwDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgwDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgwDatos.ColumnHeadersHeight = 50;
            this.DgwDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MESS,
            this.PRECIPITACION,
            this.ETo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgwDatos.EnableHeadersVisualStyles = false;
            this.DgwDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.DgwDatos.Location = new System.Drawing.Point(50, 54);
            this.DgwDatos.Name = "DgwDatos";
            this.DgwDatos.RowHeadersVisible = false;
            this.DgwDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwDatos.Size = new System.Drawing.Size(350, 395);
            this.DgwDatos.TabIndex = 1;
            this.DgwDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgwDatos_KeyPress);
            // 
            // MESS
            // 
            this.MESS.HeaderText = "MES";
            this.MESS.Name = "MESS";
            // 
            // PRECIPITACION
            // 
            this.PRECIPITACION.HeaderText = "PRECIPITACION (mm)";
            this.PRECIPITACION.Name = "PRECIPITACION";
            // 
            // ETo
            // 
            this.ETo.HeaderText = "ETo (mm/dia)";
            this.ETo.Name = "ETo";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(422, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(16, 16);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnImportar
            // 
            this.BtnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.BtnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImportar.FlatAppearance.BorderSize = 0;
            this.BtnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportar.ForeColor = System.Drawing.Color.White;
            this.BtnImportar.Image = ((System.Drawing.Image)(resources.GetObject("BtnImportar.Image")));
            this.BtnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImportar.Location = new System.Drawing.Point(54, 499);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(136, 43);
            this.BtnImportar.TabIndex = 9;
            this.BtnImportar.Text = "IMPORTAR";
            this.BtnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImportar.UseVisualStyleBackColor = false;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.panel_Titulo.Controls.Add(this.BtnCerrar);
            this.panel_Titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(450, 34);
            this.panel_Titulo.TabIndex = 43;
            this.panel_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_MouseMove);
            // 
            // Efx_Datos_Climaticos
            // 
            this.Efx_Datos_Climaticos.ElipseRadius = 20;
            this.Efx_Datos_Climaticos.TargetControl = this;
            // 
            // PanelInicio
            // 
            this.PanelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.PanelInicio.Controls.Add(this.label1);
            this.PanelInicio.Controls.Add(this.bunifuSeparator2);
            this.PanelInicio.Controls.Add(this.DgwDatos);
            this.PanelInicio.Controls.Add(this.bunifuSeparator1);
            this.PanelInicio.Controls.Add(this.BtnImportar);
            this.PanelInicio.Controls.Add(this.BtnAbrir);
            this.PanelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInicio.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelInicio.Location = new System.Drawing.Point(0, 34);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(450, 566);
            this.PanelInicio.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Datos Climáticos";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(50, 31);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(350, 15);
            this.bunifuSeparator2.TabIndex = 23;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(50, 469);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(350, 15);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Efx_BtnExcel
            // 
            this.Efx_BtnExcel.ElipseRadius = 15;
            this.Efx_BtnExcel.TargetControl = this.BtnImportar;
            // 
            // Efx_BtnAbrir
            // 
            this.Efx_BtnAbrir.ElipseRadius = 15;
            this.Efx_BtnAbrir.TargetControl = this.BtnAbrir;
            // 
            // Efx_DgwDatos
            // 
            this.Efx_DgwDatos.ElipseRadius = 20;
            this.Efx_DgwDatos.TargetControl = this.DgwDatos;
            // 
            // Datos_ClimaticosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.PanelInicio);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datos_ClimaticosUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos_Climaticos";
            ((System.ComponentModel.ISupportInitialize)(this.DgwDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.panel_Titulo.ResumeLayout(false);
            this.PanelInicio.ResumeLayout(false);
            this.PanelInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.DataGridView DgwDatos;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIPITACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETo;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.Panel panel_Titulo;
        private Bunifu.Framework.UI.BunifuElipse Efx_Datos_Climaticos;
        private System.Windows.Forms.Panel PanelInicio;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuElipse Efx_BtnExcel;
        private Bunifu.Framework.UI.BunifuElipse Efx_BtnAbrir;
        private Bunifu.Framework.UI.BunifuElipse Efx_DgwDatos;
    }
}