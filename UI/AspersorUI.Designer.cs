namespace UI
{
    partial class AspersorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AspersorUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Efx_AspersorUI = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.BtnSeleccionar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnBuscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DgwAspersor = new System.Windows.Forms.DataGridView();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panel_Titulo = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.EFx_BtnSeleccionar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_DgwAspersor = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwAspersor)).BeginInit();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Efx_AspersorUI
            // 
            this.Efx_AspersorUI.ElipseRadius = 20;
            this.Efx_AspersorUI.TargetControl = this;
            // 
            // PanelInicio
            // 
            this.PanelInicio.Controls.Add(this.BtnSeleccionar);
            this.PanelInicio.Controls.Add(this.BtnEliminar);
            this.PanelInicio.Controls.Add(this.BtnEditar);
            this.PanelInicio.Controls.Add(this.BtnAgregar);
            this.PanelInicio.Controls.Add(this.bunifuSeparator1);
            this.PanelInicio.Controls.Add(this.BtnBuscar);
            this.PanelInicio.Controls.Add(this.DgwAspersor);
            this.PanelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInicio.Location = new System.Drawing.Point(0, 34);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(575, 588);
            this.PanelInicio.TabIndex = 44;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeleccionar.BorderRadius = 0;
            this.BtnSeleccionar.ButtonText = "SELECCIONAR";
            this.BtnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeleccionar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSeleccionar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSeleccionar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Iconimage")));
            this.BtnSeleccionar.Iconimage_right = null;
            this.BtnSeleccionar.Iconimage_right_Selected = null;
            this.BtnSeleccionar.Iconimage_Selected = null;
            this.BtnSeleccionar.IconMarginLeft = 0;
            this.BtnSeleccionar.IconMarginRight = 0;
            this.BtnSeleccionar.IconRightVisible = true;
            this.BtnSeleccionar.IconRightZoom = 0D;
            this.BtnSeleccionar.IconVisible = true;
            this.BtnSeleccionar.IconZoom = 90D;
            this.BtnSeleccionar.IsTab = false;
            this.BtnSeleccionar.Location = new System.Drawing.Point(392, 501);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnSeleccionar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnSeleccionar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSeleccionar.selected = false;
            this.BtnSeleccionar.Size = new System.Drawing.Size(168, 50);
            this.BtnSeleccionar.TabIndex = 26;
            this.BtnSeleccionar.Text = "SELECCIONAR";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Textcolor = System.Drawing.Color.White;
            this.BtnSeleccionar.TextFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(172, 489);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(65, 65);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(101, 489);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(65, 65);
            this.BtnEditar.TabIndex = 24;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(30, 489);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(65, 65);
            this.BtnAgregar.TabIndex = 23;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(30, 477);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(530, 15);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.BtnBuscar.HintForeColor = System.Drawing.Color.Gray;
            this.BtnBuscar.HintText = "Buscar ";
            this.BtnBuscar.isPassword = false;
            this.BtnBuscar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnBuscar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.BtnBuscar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnBuscar.LineThickness = 3;
            this.BtnBuscar.Location = new System.Drawing.Point(114, 38);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(362, 33);
            this.BtnBuscar.TabIndex = 21;
            this.BtnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DgwAspersor
            // 
            this.DgwAspersor.AllowUserToAddRows = false;
            this.DgwAspersor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgwAspersor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgwAspersor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwAspersor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgwAspersor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.DgwAspersor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwAspersor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgwAspersor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwAspersor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgwAspersor.ColumnHeadersHeight = 50;
            this.DgwAspersor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgwAspersor.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwAspersor.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgwAspersor.EnableHeadersVisualStyles = false;
            this.DgwAspersor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.DgwAspersor.Location = new System.Drawing.Point(30, 92);
            this.DgwAspersor.MultiSelect = false;
            this.DgwAspersor.Name = "DgwAspersor";
            this.DgwAspersor.ReadOnly = true;
            this.DgwAspersor.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DgwAspersor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgwAspersor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwAspersor.Size = new System.Drawing.Size(530, 380);
            this.DgwAspersor.TabIndex = 20;
            // 
            // panelFormularios
            // 
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFormularios.Location = new System.Drawing.Point(575, 34);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(15, 588);
            this.panelFormularios.TabIndex = 43;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.panel_Titulo.Controls.Add(this.BtnCerrar);
            this.panel_Titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(590, 34);
            this.panel_Titulo.TabIndex = 42;
            this.panel_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_MouseMove);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(558, 10);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(16, 16);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // EFx_BtnSeleccionar
            // 
            this.EFx_BtnSeleccionar.ElipseRadius = 15;
            this.EFx_BtnSeleccionar.TargetControl = this.BtnSeleccionar;
            // 
            // Efx_DgwAspersor
            // 
            this.Efx_DgwAspersor.ElipseRadius = 20;
            this.Efx_DgwAspersor.TargetControl = this.DgwAspersor;
            // 
            // AspersorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(590, 622);
            this.Controls.Add(this.PanelInicio);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AspersorUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AspersorUI";
            this.Load += new System.EventHandler(this.AspersorUI_Load);
            this.PanelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgwAspersor)).EndInit();
            this.panel_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Efx_AspersorUI;
        private System.Windows.Forms.Panel PanelInicio;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSeleccionar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BtnBuscar;
        public System.Windows.Forms.DataGridView DgwAspersor;
        public System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panel_Titulo;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private Bunifu.Framework.UI.BunifuElipse EFx_BtnSeleccionar;
        private Bunifu.Framework.UI.BunifuElipse Efx_DgwAspersor;
    }
}