namespace UI
{
    partial class ProyectoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtLugar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panel_registrar = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_proyecto = new System.Windows.Forms.Panel();
            this.DgwProyecto = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Efx_panel_registrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_panel_proyecto = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_DgwProyecto = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnNuevo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnAbrir = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnEliminar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnEditar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_registrar.SuspendLayout();
            this.panel_proyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLugar
            // 
            this.TxtLugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.TxtLugar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLugar.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.TxtLugar.ForeColor = System.Drawing.Color.Gray;
            this.TxtLugar.HintForeColor = System.Drawing.Color.Gray;
            this.TxtLugar.HintText = "Lugar";
            this.TxtLugar.isPassword = false;
            this.TxtLugar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtLugar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.TxtLugar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtLugar.LineThickness = 2;
            this.TxtLugar.Location = new System.Drawing.Point(176, 100);
            this.TxtLugar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLugar.Name = "TxtLugar";
            this.TxtLugar.Size = new System.Drawing.Size(502, 30);
            this.TxtLugar.TabIndex = 3;
            this.TxtLugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.TxtNombre.ForeColor = System.Drawing.Color.Gray;
            this.TxtNombre.HintForeColor = System.Drawing.Color.Gray;
            this.TxtNombre.HintText = "Nombre Proyecto";
            this.TxtNombre.isPassword = false;
            this.TxtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtNombre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.TxtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtNombre.LineThickness = 2;
            this.TxtNombre.Location = new System.Drawing.Point(176, 60);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(502, 30);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(707, 60);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Padding = new System.Windows.Forms.Padding(10);
            this.BtnNuevo.Size = new System.Drawing.Size(168, 68);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "REGISTRAR";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            this.BtnNuevo.MouseEnter += new System.EventHandler(this.BtnNuevo_MouseEnter);
            this.BtnNuevo.MouseLeave += new System.EventHandler(this.BtnNuevo_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lugar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Proyecto:";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrir.FlatAppearance.BorderSize = 0;
            this.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrir.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.ForeColor = System.Drawing.Color.White;
            this.BtnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrir.Image")));
            this.BtnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrir.Location = new System.Drawing.Point(702, 422);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Padding = new System.Windows.Forms.Padding(10);
            this.BtnAbrir.Size = new System.Drawing.Size(168, 68);
            this.BtnAbrir.TabIndex = 5;
            this.BtnAbrir.Text = "INGRESAR";
            this.BtnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            this.BtnAbrir.MouseEnter += new System.EventHandler(this.BtnAbrir_MouseEnter);
            this.BtnAbrir.MouseLeave += new System.EventHandler(this.BtnAbrir_MouseLeave);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(20, 422);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(68, 68);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(98, 422);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(68, 68);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // panel_registrar
            // 
            this.panel_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel_registrar.Controls.Add(this.bunifuCustomLabel2);
            this.panel_registrar.Controls.Add(this.bunifuSeparator2);
            this.panel_registrar.Controls.Add(this.TxtLugar);
            this.panel_registrar.Controls.Add(this.TxtNombre);
            this.panel_registrar.Controls.Add(this.label1);
            this.panel_registrar.Controls.Add(this.BtnNuevo);
            this.panel_registrar.Controls.Add(this.label2);
            this.panel_registrar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_registrar.ForeColor = System.Drawing.Color.White;
            this.panel_registrar.Location = new System.Drawing.Point(40, 15);
            this.panel_registrar.Name = "panel_registrar";
            this.panel_registrar.Size = new System.Drawing.Size(890, 160);
            this.panel_registrar.TabIndex = 8;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(398, 15);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(64, 15);
            this.bunifuCustomLabel2.TabIndex = 49;
            this.bunifuCustomLabel2.Text = "Registrar ";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(15, 35);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(860, 10);
            this.bunifuSeparator2.TabIndex = 48;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panel_proyecto
            // 
            this.panel_proyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel_proyecto.Controls.Add(this.DgwProyecto);
            this.panel_proyecto.Controls.Add(this.bunifuCustomLabel1);
            this.panel_proyecto.Controls.Add(this.bunifuSeparator1);
            this.panel_proyecto.Controls.Add(this.BtnAbrir);
            this.panel_proyecto.Controls.Add(this.BtnEliminar);
            this.panel_proyecto.Controls.Add(this.BtnEditar);
            this.panel_proyecto.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_proyecto.ForeColor = System.Drawing.Color.White;
            this.panel_proyecto.Location = new System.Drawing.Point(40, 195);
            this.panel_proyecto.Name = "panel_proyecto";
            this.panel_proyecto.Size = new System.Drawing.Size(890, 510);
            this.panel_proyecto.TabIndex = 9;
            // 
            // DgwProyecto
            // 
            this.DgwProyecto.AllowUserToAddRows = false;
            this.DgwProyecto.AllowUserToDeleteRows = false;
            this.DgwProyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwProyecto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgwProyecto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.DgwProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwProyecto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgwProyecto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwProyecto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgwProyecto.ColumnHeadersHeight = 50;
            this.DgwProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgwProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwProyecto.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgwProyecto.EnableHeadersVisualStyles = false;
            this.DgwProyecto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(82)))));
            this.DgwProyecto.Location = new System.Drawing.Point(20, 70);
            this.DgwProyecto.MultiSelect = false;
            this.DgwProyecto.Name = "DgwProyecto";
            this.DgwProyecto.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwProyecto.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgwProyecto.RowHeadersVisible = false;
            this.DgwProyecto.RowHeadersWidth = 50;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DgwProyecto.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgwProyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwProyecto.Size = new System.Drawing.Size(850, 332);
            this.DgwProyecto.TabIndex = 52;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(67, 15);
            this.bunifuCustomLabel1.TabIndex = 51;
            this.bunifuCustomLabel1.Text = "Proyectos";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 40);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(708, 10);
            this.bunifuSeparator1.TabIndex = 50;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Efx_panel_registrar
            // 
            this.Efx_panel_registrar.ElipseRadius = 30;
            this.Efx_panel_registrar.TargetControl = this.panel_registrar;
            // 
            // Efx_panel_proyecto
            // 
            this.Efx_panel_proyecto.ElipseRadius = 30;
            this.Efx_panel_proyecto.TargetControl = this.panel_proyecto;
            // 
            // Efx_DgwProyecto
            // 
            this.Efx_DgwProyecto.ElipseRadius = 20;
            this.Efx_DgwProyecto.TargetControl = this.DgwProyecto;
            // 
            // Efx_BtnNuevo
            // 
            this.Efx_BtnNuevo.ElipseRadius = 15;
            this.Efx_BtnNuevo.TargetControl = this.BtnNuevo;
            // 
            // Efx_BtnAbrir
            // 
            this.Efx_BtnAbrir.ElipseRadius = 15;
            this.Efx_BtnAbrir.TargetControl = this.BtnAbrir;
            // 
            // Efx_BtnEliminar
            // 
            this.Efx_BtnEliminar.ElipseRadius = 15;
            this.Efx_BtnEliminar.TargetControl = this.BtnEliminar;
            // 
            // Efx_BtnEditar
            // 
            this.Efx_BtnEditar.ElipseRadius = 15;
            this.Efx_BtnEditar.TargetControl = this.BtnEditar;
            // 
            // ProyectoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(970, 750);
            this.Controls.Add(this.panel_proyecto);
            this.Controls.Add(this.panel_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProyectoUI";
            this.Text = "ProyectoUI";
            this.Load += new System.EventHandler(this.ProyectoUI_Load);
            this.panel_registrar.ResumeLayout(false);
            this.panel_registrar.PerformLayout();
            this.panel_proyecto.ResumeLayout(false);
            this.panel_proyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNuevo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtLugar;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panel_registrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel_proyecto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public Bunifu.Framework.UI.BunifuElipse Efx_panel_registrar;
        public Bunifu.Framework.UI.BunifuElipse Efx_panel_proyecto;
        public Bunifu.Framework.UI.BunifuElipse Efx_DgwProyecto;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnNuevo;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnAbrir;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnEliminar;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnEditar;
        public System.Windows.Forms.DataGridView DgwProyecto;
    }
}