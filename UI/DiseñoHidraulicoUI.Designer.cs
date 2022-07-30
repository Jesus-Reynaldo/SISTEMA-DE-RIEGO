namespace UI
{
    partial class DiseñoHidraulicoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseñoHidraulicoUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblDesnivel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtHg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtHa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CmbTopografia = new System.Windows.Forms.ComboBox();
            this.TxtLT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CmbLo = new System.Windows.Forms.ComboBox();
            this.CmbHs = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTipoTuberia = new System.Windows.Forms.ComboBox();
            this.TxtLL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReportEspecificoHidraulico = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtnReportResumenHidraulico = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panel_Datos_Entrada = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_Resultado = new System.Windows.Forms.Panel();
            this.DgwHidraulico = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_Reporte = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Efx_Panel_Datos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_Panel_Reporte = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_Panel_Resultado = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_Agregar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnEliminar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnReportResumenHidraulico = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnReportEspecificoHidraulico = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_DgwHidraulico = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ToolTopografia = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Datos_Entrada.SuspendLayout();
            this.panel_Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwHidraulico)).BeginInit();
            this.panel_Reporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDesnivel
            // 
            this.LblDesnivel.AutoSize = true;
            this.LblDesnivel.Enabled = false;
            this.LblDesnivel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesnivel.Location = new System.Drawing.Point(44, 212);
            this.LblDesnivel.Name = "LblDesnivel";
            this.LblDesnivel.Size = new System.Drawing.Size(211, 17);
            this.LblDesnivel.TabIndex = 21;
            this.LblDesnivel.Text = "DESNIVEL TOPOGRÁFICO (m) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 34);
            this.label8.TabIndex = 20;
            this.label8.Text = "ALTURA DE PRESIÓN \r\nPORTAASPERSOR (m) :";
            // 
            // TxtHg
            // 
            this.TxtHg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TxtHg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHg.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.TxtHg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtHg.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtHg.HintText = "";
            this.TxtHg.isPassword = false;
            this.TxtHg.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtHg.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtHg.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtHg.LineThickness = 2;
            this.TxtHg.Location = new System.Drawing.Point(306, 206);
            this.TxtHg.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHg.Name = "TxtHg";
            this.TxtHg.Size = new System.Drawing.Size(135, 31);
            this.TxtHg.TabIndex = 19;
            this.TxtHg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtHg.Visible = false;
            this.TxtHg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHg_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(537, 187);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Padding = new System.Windows.Forms.Padding(10);
            this.BtnAgregar.Size = new System.Drawing.Size(168, 50);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            this.BtnAgregar.MouseEnter += new System.EventHandler(this.BtnAgregar_MouseEnter);
            this.BtnAgregar.MouseLeave += new System.EventHandler(this.BtnAgregar_MouseLeave);
            // 
            // TxtHa
            // 
            this.TxtHa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TxtHa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHa.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.TxtHa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtHa.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtHa.HintText = "";
            this.TxtHa.isPassword = false;
            this.TxtHa.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtHa.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtHa.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtHa.LineThickness = 2;
            this.TxtHa.Location = new System.Drawing.Point(709, 57);
            this.TxtHa.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHa.Name = "TxtHa";
            this.TxtHa.Size = new System.Drawing.Size(135, 31);
            this.TxtHa.TabIndex = 18;
            this.TxtHa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtHa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHa_KeyPress);
            // 
            // CmbTopografia
            // 
            this.CmbTopografia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CmbTopografia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTopografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbTopografia.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTopografia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.CmbTopografia.FormattingEnabled = true;
            this.CmbTopografia.ItemHeight = 17;
            this.CmbTopografia.Location = new System.Drawing.Point(306, 95);
            this.CmbTopografia.Margin = new System.Windows.Forms.Padding(0);
            this.CmbTopografia.Name = "CmbTopografia";
            this.CmbTopografia.Size = new System.Drawing.Size(135, 25);
            this.CmbTopografia.TabIndex = 17;
            this.CmbTopografia.SelectedValueChanged += new System.EventHandler(this.CmbTopografia_SelectedValueChanged);
            // 
            // TxtLT
            // 
            this.TxtLT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TxtLT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLT.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.TxtLT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtLT.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtLT.HintText = "";
            this.TxtLT.isPassword = false;
            this.TxtLT.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtLT.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtLT.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtLT.LineThickness = 2;
            this.TxtLT.Location = new System.Drawing.Point(709, 96);
            this.TxtLT.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLT.Name = "TxtLT";
            this.TxtLT.Size = new System.Drawing.Size(135, 31);
            this.TxtLT.TabIndex = 16;
            this.TxtLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLT_KeyPress);
            // 
            // CmbLo
            // 
            this.CmbLo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CmbLo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbLo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbLo.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbLo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.CmbLo.FormattingEnabled = true;
            this.CmbLo.ItemHeight = 17;
            this.CmbLo.Location = new System.Drawing.Point(306, 169);
            this.CmbLo.Margin = new System.Windows.Forms.Padding(0);
            this.CmbLo.Name = "CmbLo";
            this.CmbLo.Size = new System.Drawing.Size(135, 25);
            this.CmbLo.TabIndex = 15;
            // 
            // CmbHs
            // 
            this.CmbHs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CmbHs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbHs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbHs.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbHs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.CmbHs.FormattingEnabled = true;
            this.CmbHs.ItemHeight = 17;
            this.CmbHs.Location = new System.Drawing.Point(306, 132);
            this.CmbHs.Margin = new System.Windows.Forms.Padding(0);
            this.CmbHs.Name = "CmbHs";
            this.CmbHs.Size = new System.Drawing.Size(135, 25);
            this.CmbHs.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "PERDIDA CARGAS ACCESORIAS (%) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "UBICACIÓN PRIMER ASPERSOR (lo):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "TOPOGRAFÍA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "TIPO DE TUBERÍA:";
            // 
            // CmbTipoTuberia
            // 
            this.CmbTipoTuberia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CmbTipoTuberia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTipoTuberia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbTipoTuberia.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoTuberia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.CmbTipoTuberia.FormattingEnabled = true;
            this.CmbTipoTuberia.ItemHeight = 17;
            this.CmbTipoTuberia.Location = new System.Drawing.Point(306, 60);
            this.CmbTipoTuberia.Margin = new System.Windows.Forms.Padding(0);
            this.CmbTipoTuberia.Name = "CmbTipoTuberia";
            this.CmbTipoTuberia.Size = new System.Drawing.Size(135, 25);
            this.CmbTipoTuberia.TabIndex = 8;
            // 
            // TxtLL
            // 
            this.TxtLL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TxtLL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLL.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.TxtLL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtLL.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtLL.HintText = "";
            this.TxtLL.isPassword = false;
            this.TxtLL.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtLL.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtLL.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtLL.LineThickness = 2;
            this.TxtLL.Location = new System.Drawing.Point(709, 135);
            this.TxtLL.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLL.Name = "TxtLL";
            this.TxtLL.Size = new System.Drawing.Size(135, 31);
            this.TxtLL.TabIndex = 3;
            this.TxtLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLL_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "LONGITUD LATERAL (m):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "LONGITUD TERCIARIA (m):";
            // 
            // BtnReportEspecificoHidraulico
            // 
            this.BtnReportEspecificoHidraulico.ActiveImage = null;
            this.BtnReportEspecificoHidraulico.AllowAnimations = true;
            this.BtnReportEspecificoHidraulico.AllowBuffering = false;
            this.BtnReportEspecificoHidraulico.AllowZooming = true;
            this.BtnReportEspecificoHidraulico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BtnReportEspecificoHidraulico.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnReportEspecificoHidraulico.ErrorImage")));
            this.BtnReportEspecificoHidraulico.FadeWhenInactive = false;
            this.BtnReportEspecificoHidraulico.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnReportEspecificoHidraulico.Image = ((System.Drawing.Image)(resources.GetObject("BtnReportEspecificoHidraulico.Image")));
            this.BtnReportEspecificoHidraulico.ImageActive = null;
            this.BtnReportEspecificoHidraulico.ImageLocation = null;
            this.BtnReportEspecificoHidraulico.ImageMargin = 20;
            this.BtnReportEspecificoHidraulico.ImageSize = new System.Drawing.Size(130, 130);
            this.BtnReportEspecificoHidraulico.ImageZoomSize = new System.Drawing.Size(150, 150);
            this.BtnReportEspecificoHidraulico.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnReportEspecificoHidraulico.InitialImage")));
            this.BtnReportEspecificoHidraulico.Location = new System.Drawing.Point(780, 515);
            this.BtnReportEspecificoHidraulico.Name = "BtnReportEspecificoHidraulico";
            this.BtnReportEspecificoHidraulico.Rotation = 0;
            this.BtnReportEspecificoHidraulico.ShowActiveImage = true;
            this.BtnReportEspecificoHidraulico.ShowCursorChanges = true;
            this.BtnReportEspecificoHidraulico.ShowImageBorders = false;
            this.BtnReportEspecificoHidraulico.ShowSizeMarkers = false;
            this.BtnReportEspecificoHidraulico.Size = new System.Drawing.Size(150, 150);
            this.BtnReportEspecificoHidraulico.TabIndex = 5;
            this.BtnReportEspecificoHidraulico.ToolTipText = "Reporte detallado del calculo del lateral";
            this.BtnReportEspecificoHidraulico.WaitOnLoad = false;
            this.BtnReportEspecificoHidraulico.Zoom = 20;
            this.BtnReportEspecificoHidraulico.ZoomSpeed = 10;
            this.BtnReportEspecificoHidraulico.Click += new System.EventHandler(this.BtnReportEspecificoHidraulico_Click);
            // 
            // BtnReportResumenHidraulico
            // 
            this.BtnReportResumenHidraulico.ActiveImage = null;
            this.BtnReportResumenHidraulico.AllowAnimations = true;
            this.BtnReportResumenHidraulico.AllowBuffering = false;
            this.BtnReportResumenHidraulico.AllowZooming = true;
            this.BtnReportResumenHidraulico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BtnReportResumenHidraulico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReportResumenHidraulico.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnReportResumenHidraulico.ErrorImage")));
            this.BtnReportResumenHidraulico.FadeWhenInactive = false;
            this.BtnReportResumenHidraulico.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnReportResumenHidraulico.Image = ((System.Drawing.Image)(resources.GetObject("BtnReportResumenHidraulico.Image")));
            this.BtnReportResumenHidraulico.ImageActive = null;
            this.BtnReportResumenHidraulico.ImageLocation = null;
            this.BtnReportResumenHidraulico.ImageMargin = 20;
            this.BtnReportResumenHidraulico.ImageSize = new System.Drawing.Size(130, 130);
            this.BtnReportResumenHidraulico.ImageZoomSize = new System.Drawing.Size(150, 150);
            this.BtnReportResumenHidraulico.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnReportResumenHidraulico.InitialImage")));
            this.BtnReportResumenHidraulico.Location = new System.Drawing.Point(780, 345);
            this.BtnReportResumenHidraulico.Name = "BtnReportResumenHidraulico";
            this.BtnReportResumenHidraulico.Rotation = 0;
            this.BtnReportResumenHidraulico.ShowActiveImage = true;
            this.BtnReportResumenHidraulico.ShowCursorChanges = true;
            this.BtnReportResumenHidraulico.ShowImageBorders = false;
            this.BtnReportResumenHidraulico.ShowSizeMarkers = false;
            this.BtnReportResumenHidraulico.Size = new System.Drawing.Size(150, 150);
            this.BtnReportResumenHidraulico.TabIndex = 4;
            this.BtnReportResumenHidraulico.ToolTipText = "Reporte resumido del diseño hidráulico";
            this.BtnReportResumenHidraulico.WaitOnLoad = false;
            this.BtnReportResumenHidraulico.Zoom = 20;
            this.BtnReportResumenHidraulico.ZoomSpeed = 10;
            this.BtnReportResumenHidraulico.Click += new System.EventHandler(this.BtnReportResumenHidraulico_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(537, 355);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Padding = new System.Windows.Forms.Padding(10);
            this.BtnEliminar.Size = new System.Drawing.Size(168, 50);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseEnter += new System.EventHandler(this.BtnEliminar_MouseEnter);
            this.BtnEliminar.MouseLeave += new System.EventHandler(this.BtnEliminar_MouseLeave);
            // 
            // panel_Datos_Entrada
            // 
            this.panel_Datos_Entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel_Datos_Entrada.Controls.Add(this.button1);
            this.panel_Datos_Entrada.Controls.Add(this.bunifuCustomLabel2);
            this.panel_Datos_Entrada.Controls.Add(this.bunifuSeparator2);
            this.panel_Datos_Entrada.Controls.Add(this.LblDesnivel);
            this.panel_Datos_Entrada.Controls.Add(this.label3);
            this.panel_Datos_Entrada.Controls.Add(this.label8);
            this.panel_Datos_Entrada.Controls.Add(this.label1);
            this.panel_Datos_Entrada.Controls.Add(this.TxtHg);
            this.panel_Datos_Entrada.Controls.Add(this.label2);
            this.panel_Datos_Entrada.Controls.Add(this.BtnAgregar);
            this.panel_Datos_Entrada.Controls.Add(this.TxtLL);
            this.panel_Datos_Entrada.Controls.Add(this.TxtHa);
            this.panel_Datos_Entrada.Controls.Add(this.CmbTipoTuberia);
            this.panel_Datos_Entrada.Controls.Add(this.CmbTopografia);
            this.panel_Datos_Entrada.Controls.Add(this.label4);
            this.panel_Datos_Entrada.Controls.Add(this.TxtLT);
            this.panel_Datos_Entrada.Controls.Add(this.label5);
            this.panel_Datos_Entrada.Controls.Add(this.CmbLo);
            this.panel_Datos_Entrada.Controls.Add(this.label6);
            this.panel_Datos_Entrada.Controls.Add(this.CmbHs);
            this.panel_Datos_Entrada.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Datos_Entrada.ForeColor = System.Drawing.Color.White;
            this.panel_Datos_Entrada.Location = new System.Drawing.Point(40, 15);
            this.panel_Datos_Entrada.Name = "panel_Datos_Entrada";
            this.panel_Datos_Entrada.Size = new System.Drawing.Size(890, 250);
            this.panel_Datos_Entrada.TabIndex = 7;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(15, 15);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(107, 15);
            this.bunifuCustomLabel2.TabIndex = 49;
            this.bunifuCustomLabel2.Text = "Datos de entrada";
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
            // panel_Resultado
            // 
            this.panel_Resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel_Resultado.Controls.Add(this.DgwHidraulico);
            this.panel_Resultado.Controls.Add(this.bunifuCustomLabel1);
            this.panel_Resultado.Controls.Add(this.BtnEliminar);
            this.panel_Resultado.Controls.Add(this.bunifuSeparator1);
            this.panel_Resultado.Location = new System.Drawing.Point(40, 285);
            this.panel_Resultado.Name = "panel_Resultado";
            this.panel_Resultado.Size = new System.Drawing.Size(720, 420);
            this.panel_Resultado.TabIndex = 8;
            // 
            // DgwHidraulico
            // 
            this.DgwHidraulico.AllowDrop = true;
            this.DgwHidraulico.AllowUserToAddRows = false;
            this.DgwHidraulico.AllowUserToDeleteRows = false;
            this.DgwHidraulico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgwHidraulico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwHidraulico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgwHidraulico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.DgwHidraulico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwHidraulico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DgwHidraulico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Cn", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwHidraulico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgwHidraulico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwHidraulico.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwHidraulico.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgwHidraulico.EnableHeadersVisualStyles = false;
            this.DgwHidraulico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(125)))), ((int)(((byte)(242)))));
            this.DgwHidraulico.Location = new System.Drawing.Point(15, 60);
            this.DgwHidraulico.Name = "DgwHidraulico";
            this.DgwHidraulico.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwHidraulico.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgwHidraulico.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DgwHidraulico.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgwHidraulico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwHidraulico.Size = new System.Drawing.Size(690, 280);
            this.DgwHidraulico.TabIndex = 9;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 15);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "Diseño hidráulico";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 35);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(690, 10);
            this.bunifuSeparator1.TabIndex = 48;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel_Reporte
            // 
            this.panel_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel_Reporte.Controls.Add(this.bunifuCustomLabel4);
            this.panel_Reporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Reporte.Location = new System.Drawing.Point(780, 285);
            this.panel_Reporte.Name = "panel_Reporte";
            this.panel_Reporte.Size = new System.Drawing.Size(150, 40);
            this.panel_Reporte.TabIndex = 50;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(44, 15);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(60, 15);
            this.bunifuCustomLabel4.TabIndex = 48;
            this.bunifuCustomLabel4.Text = "Reportes";
            // 
            // Efx_Panel_Datos
            // 
            this.Efx_Panel_Datos.ElipseRadius = 30;
            this.Efx_Panel_Datos.TargetControl = this.panel_Datos_Entrada;
            // 
            // Efx_Panel_Reporte
            // 
            this.Efx_Panel_Reporte.ElipseRadius = 15;
            this.Efx_Panel_Reporte.TargetControl = this.panel_Reporte;
            // 
            // Efx_Panel_Resultado
            // 
            this.Efx_Panel_Resultado.ElipseRadius = 30;
            this.Efx_Panel_Resultado.TargetControl = this.panel_Resultado;
            // 
            // Efx_Agregar
            // 
            this.Efx_Agregar.ElipseRadius = 15;
            this.Efx_Agregar.TargetControl = this.BtnAgregar;
            // 
            // Efx_BtnEliminar
            // 
            this.Efx_BtnEliminar.ElipseRadius = 15;
            this.Efx_BtnEliminar.TargetControl = this.BtnEliminar;
            // 
            // Efx_BtnReportResumenHidraulico
            // 
            this.Efx_BtnReportResumenHidraulico.ElipseRadius = 30;
            this.Efx_BtnReportResumenHidraulico.TargetControl = this.BtnReportResumenHidraulico;
            // 
            // Efx_BtnReportEspecificoHidraulico
            // 
            this.Efx_BtnReportEspecificoHidraulico.ElipseRadius = 30;
            this.Efx_BtnReportEspecificoHidraulico.TargetControl = this.BtnReportEspecificoHidraulico;
            // 
            // Efx_DgwHidraulico
            // 
            this.Efx_DgwHidraulico.ElipseRadius = 20;
            this.Efx_DgwHidraulico.TargetControl = this.DgwHidraulico;
            // 
            // ToolTopografia
            // 
            this.ToolTopografia.IsBalloon = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(444, 60);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DiseñoHidraulicoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(970, 750);
            this.Controls.Add(this.BtnReportEspecificoHidraulico);
            this.Controls.Add(this.panel_Reporte);
            this.Controls.Add(this.BtnReportResumenHidraulico);
            this.Controls.Add(this.panel_Resultado);
            this.Controls.Add(this.panel_Datos_Entrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiseñoHidraulicoUI";
            this.Text = "DiseñoHidraulico";
            this.Load += new System.EventHandler(this.DiseñoHidraulico_Load);
            this.panel_Datos_Entrada.ResumeLayout(false);
            this.panel_Datos_Entrada.PerformLayout();
            this.panel_Resultado.ResumeLayout(false);
            this.panel_Resultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwHidraulico)).EndInit();
            this.panel_Reporte.ResumeLayout(false);
            this.panel_Reporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtLT;
        private System.Windows.Forms.ComboBox CmbLo;
        private System.Windows.Forms.ComboBox CmbHs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipoTuberia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtLL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtHg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtHa;
        private System.Windows.Forms.ComboBox CmbTopografia;
        private System.Windows.Forms.Label LblDesnivel;
        private Bunifu.UI.WinForms.BunifuImageButton BtnReportResumenHidraulico;
        private Bunifu.UI.WinForms.BunifuImageButton BtnReportEspecificoHidraulico;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panel_Datos_Entrada;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel_Resultado;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridView DgwHidraulico;
        private System.Windows.Forms.Panel panel_Reporte;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public Bunifu.Framework.UI.BunifuElipse Efx_Panel_Datos;
        public Bunifu.Framework.UI.BunifuElipse Efx_Panel_Reporte;
        public Bunifu.Framework.UI.BunifuElipse Efx_Panel_Resultado;
        public Bunifu.Framework.UI.BunifuElipse Efx_Agregar;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnEliminar;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnReportResumenHidraulico;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnReportEspecificoHidraulico;
        public Bunifu.Framework.UI.BunifuElipse Efx_DgwHidraulico;
        private System.Windows.Forms.ToolTip ToolTopografia;
        private System.Windows.Forms.Button button1;
    }
}