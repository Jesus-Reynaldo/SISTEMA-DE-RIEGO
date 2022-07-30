namespace UI
{
    partial class MenuPrincipal
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelSecuencia = new System.Windows.Forms.Panel();
            this.panel_hidra = new System.Windows.Forms.Panel();
            this.Cir_hidra = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.Btn_hidra = new System.Windows.Forms.Button();
            this.panel_proy = new System.Windows.Forms.Panel();
            this.Cir_proy = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.Btn_proy = new System.Windows.Forms.Button();
            this.Sepa_agro = new Bunifu.Framework.UI.BunifuSeparator();
            this.Sepa_proy = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_agro = new System.Windows.Forms.Panel();
            this.Cir_agro = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.Btn_Agro = new System.Windows.Forms.Button();
            this.panel_cul = new System.Windows.Forms.Panel();
            this.Cir_Cul = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.Btn_cul = new System.Windows.Forms.Button();
            this.Sepa_cul = new Bunifu.Framework.UI.BunifuSeparator();
            this.Logo = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnCopiaSeguridad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCerrarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnHidraulico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAgronomico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnProyecto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCultivo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.LblProyecto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTransion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoTransion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.panelSecuencia.SuspendLayout();
            this.panel_hidra.SuspendLayout();
            this.panel_proy.SuspendLayout();
            this.panel_agro.SuspendLayout();
            this.panel_cul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.LogoTransion.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1200, 800);
            this.panelContenedor.TabIndex = 1;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panelFormularios.Controls.Add(this.panelSecuencia);
            this.panelFormularios.Controls.Add(this.Logo);
            this.LogoTransion.SetDecoration(this.panelFormularios, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panelFormularios, BunifuAnimatorNS.DecorationType.None);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(230, 50);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(970, 750);
            this.panelFormularios.TabIndex = 2;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // panelSecuencia
            // 
            this.panelSecuencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelSecuencia.Controls.Add(this.panel_hidra);
            this.panelSecuencia.Controls.Add(this.panel_proy);
            this.panelSecuencia.Controls.Add(this.Sepa_agro);
            this.panelSecuencia.Controls.Add(this.Sepa_proy);
            this.panelSecuencia.Controls.Add(this.panel_agro);
            this.panelSecuencia.Controls.Add(this.panel_cul);
            this.panelSecuencia.Controls.Add(this.Sepa_cul);
            this.LogoTransion.SetDecoration(this.panelSecuencia, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panelSecuencia, BunifuAnimatorNS.DecorationType.None);
            this.panelSecuencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSecuencia.Location = new System.Drawing.Point(0, 0);
            this.panelSecuencia.Name = "panelSecuencia";
            this.panelSecuencia.Size = new System.Drawing.Size(970, 30);
            this.panelSecuencia.TabIndex = 1;
            // 
            // panel_hidra
            // 
            this.panel_hidra.Controls.Add(this.Cir_hidra);
            this.panel_hidra.Controls.Add(this.Btn_hidra);
            this.panel_hidra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.panel_hidra, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panel_hidra, BunifuAnimatorNS.DecorationType.None);
            this.panel_hidra.Location = new System.Drawing.Point(669, 0);
            this.panel_hidra.Name = "panel_hidra";
            this.panel_hidra.Size = new System.Drawing.Size(150, 30);
            this.panel_hidra.TabIndex = 52;
            // 
            // Cir_hidra
            // 
            this.Cir_hidra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Cir_hidra.Checked = true;
            this.LogoTransion.SetDecoration(this.Cir_hidra, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.Cir_hidra, BunifuAnimatorNS.DecorationType.None);
            this.Cir_hidra.Location = new System.Drawing.Point(127, 5);
            this.Cir_hidra.Name = "Cir_hidra";
            this.Cir_hidra.OutlineColor = System.Drawing.Color.Gray;
            this.Cir_hidra.RadioColor = System.Drawing.Color.Silver;
            this.Cir_hidra.Size = new System.Drawing.Size(20, 20);
            this.Cir_hidra.TabIndex = 1;
            this.Cir_hidra.Text = null;
            // 
            // Btn_hidra
            // 
            this.Btn_hidra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Btn_hidra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransion.SetDecoration(this.Btn_hidra, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.Btn_hidra, BunifuAnimatorNS.DecorationType.None);
            this.Btn_hidra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_hidra.FlatAppearance.BorderSize = 0;
            this.Btn_hidra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_hidra.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hidra.ForeColor = System.Drawing.Color.Silver;
            this.Btn_hidra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_hidra.Location = new System.Drawing.Point(0, 0);
            this.Btn_hidra.Name = "Btn_hidra";
            this.Btn_hidra.Size = new System.Drawing.Size(150, 30);
            this.Btn_hidra.TabIndex = 2;
            this.Btn_hidra.Text = "Diseño Hidráulica";
            this.Btn_hidra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_hidra.UseVisualStyleBackColor = false;
            this.Btn_hidra.Click += new System.EventHandler(this.Btn_hidra_Click);
            // 
            // panel_proy
            // 
            this.panel_proy.Controls.Add(this.Cir_proy);
            this.panel_proy.Controls.Add(this.Btn_proy);
            this.panel_proy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.panel_proy, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panel_proy, BunifuAnimatorNS.DecorationType.None);
            this.panel_proy.Location = new System.Drawing.Point(154, 0);
            this.panel_proy.Name = "panel_proy";
            this.panel_proy.Size = new System.Drawing.Size(100, 30);
            this.panel_proy.TabIndex = 46;
            // 
            // Cir_proy
            // 
            this.Cir_proy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Cir_proy.Checked = true;
            this.LogoTransion.SetDecoration(this.Cir_proy, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.Cir_proy, BunifuAnimatorNS.DecorationType.None);
            this.Cir_proy.Location = new System.Drawing.Point(77, 5);
            this.Cir_proy.Name = "Cir_proy";
            this.Cir_proy.OutlineColor = System.Drawing.Color.Gray;
            this.Cir_proy.RadioColor = System.Drawing.Color.Silver;
            this.Cir_proy.Size = new System.Drawing.Size(20, 20);
            this.Cir_proy.TabIndex = 1;
            this.Cir_proy.Text = null;
            // 
            // Btn_proy
            // 
            this.Btn_proy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Btn_proy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransion.SetDecoration(this.Btn_proy, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.Btn_proy, BunifuAnimatorNS.DecorationType.None);
            this.Btn_proy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_proy.FlatAppearance.BorderSize = 0;
            this.Btn_proy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_proy.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_proy.ForeColor = System.Drawing.Color.Silver;
            this.Btn_proy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_proy.Location = new System.Drawing.Point(0, 0);
            this.Btn_proy.Name = "Btn_proy";
            this.Btn_proy.Size = new System.Drawing.Size(100, 30);
            this.Btn_proy.TabIndex = 2;
            this.Btn_proy.Text = "Proyecto";
            this.Btn_proy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_proy.UseVisualStyleBackColor = false;
            this.Btn_proy.Click += new System.EventHandler(this.Btn_proy_Click);
            // 
            // Sepa_agro
            // 
            this.Sepa_agro.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransion.SetDecoration(this.Sepa_agro, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.Sepa_agro, BunifuAnimatorNS.DecorationType.None);
            this.Sepa_agro.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Sepa_agro.LineThickness = 1;
            this.Sepa_agro.Location = new System.Drawing.Point(617, 5);
            this.Sepa_agro.Name = "Sepa_agro";
            this.Sepa_agro.Size = new System.Drawing.Size(50, 20);
            this.Sepa_agro.TabIndex = 51;
            this.Sepa_agro.Transparency = 255;
            this.Sepa_agro.Vertical = false;
            // 
            // Sepa_proy
            // 
            this.Sepa_proy.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransion.SetDecoration(this.Sepa_proy, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.Sepa_proy, BunifuAnimatorNS.DecorationType.None);
            this.Sepa_proy.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Sepa_proy.LineThickness = 1;
            this.Sepa_proy.Location = new System.Drawing.Point(257, 5);
            this.Sepa_proy.Name = "Sepa_proy";
            this.Sepa_proy.Size = new System.Drawing.Size(50, 20);
            this.Sepa_proy.TabIndex = 47;
            this.Sepa_proy.Transparency = 255;
            this.Sepa_proy.Vertical = false;
            // 
            // panel_agro
            // 
            this.panel_agro.Controls.Add(this.Cir_agro);
            this.panel_agro.Controls.Add(this.Btn_Agro);
            this.panel_agro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.panel_agro, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panel_agro, BunifuAnimatorNS.DecorationType.None);
            this.panel_agro.Location = new System.Drawing.Point(464, 0);
            this.panel_agro.Name = "panel_agro";
            this.panel_agro.Size = new System.Drawing.Size(150, 30);
            this.panel_agro.TabIndex = 50;
            // 
            // Cir_agro
            // 
            this.Cir_agro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Cir_agro.Checked = true;
            this.LogoTransion.SetDecoration(this.Cir_agro, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.Cir_agro, BunifuAnimatorNS.DecorationType.None);
            this.Cir_agro.Location = new System.Drawing.Point(127, 5);
            this.Cir_agro.Name = "Cir_agro";
            this.Cir_agro.OutlineColor = System.Drawing.Color.Gray;
            this.Cir_agro.RadioColor = System.Drawing.Color.Silver;
            this.Cir_agro.Size = new System.Drawing.Size(20, 20);
            this.Cir_agro.TabIndex = 1;
            this.Cir_agro.Text = null;
            // 
            // Btn_Agro
            // 
            this.Btn_Agro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Btn_Agro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransion.SetDecoration(this.Btn_Agro, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.Btn_Agro, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Agro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_Agro.FlatAppearance.BorderSize = 0;
            this.Btn_Agro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agro.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agro.ForeColor = System.Drawing.Color.Silver;
            this.Btn_Agro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agro.Location = new System.Drawing.Point(0, 0);
            this.Btn_Agro.Name = "Btn_Agro";
            this.Btn_Agro.Size = new System.Drawing.Size(150, 30);
            this.Btn_Agro.TabIndex = 2;
            this.Btn_Agro.Text = "Diseño Agronómico";
            this.Btn_Agro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agro.UseVisualStyleBackColor = false;
            this.Btn_Agro.Click += new System.EventHandler(this.Btn_Agro_Click);
            // 
            // panel_cul
            // 
            this.panel_cul.Controls.Add(this.Cir_Cul);
            this.panel_cul.Controls.Add(this.Btn_cul);
            this.panel_cul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.panel_cul, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panel_cul, BunifuAnimatorNS.DecorationType.None);
            this.panel_cul.Location = new System.Drawing.Point(309, 0);
            this.panel_cul.Name = "panel_cul";
            this.panel_cul.Size = new System.Drawing.Size(100, 30);
            this.panel_cul.TabIndex = 48;
            // 
            // Cir_Cul
            // 
            this.Cir_Cul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Cir_Cul.Checked = true;
            this.LogoTransion.SetDecoration(this.Cir_Cul, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.Cir_Cul, BunifuAnimatorNS.DecorationType.None);
            this.Cir_Cul.Location = new System.Drawing.Point(77, 5);
            this.Cir_Cul.Name = "Cir_Cul";
            this.Cir_Cul.OutlineColor = System.Drawing.Color.Gray;
            this.Cir_Cul.RadioColor = System.Drawing.Color.Silver;
            this.Cir_Cul.Size = new System.Drawing.Size(20, 20);
            this.Cir_Cul.TabIndex = 1;
            this.Cir_Cul.Text = null;
            // 
            // Btn_cul
            // 
            this.Btn_cul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Btn_cul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransion.SetDecoration(this.Btn_cul, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.Btn_cul, BunifuAnimatorNS.DecorationType.None);
            this.Btn_cul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.Btn_cul.FlatAppearance.BorderSize = 0;
            this.Btn_cul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cul.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cul.ForeColor = System.Drawing.Color.Silver;
            this.Btn_cul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cul.Location = new System.Drawing.Point(0, 0);
            this.Btn_cul.Name = "Btn_cul";
            this.Btn_cul.Size = new System.Drawing.Size(100, 30);
            this.Btn_cul.TabIndex = 2;
            this.Btn_cul.Text = "Cultivo";
            this.Btn_cul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cul.UseVisualStyleBackColor = false;
            this.Btn_cul.Click += new System.EventHandler(this.Btn_cul_Click);
            // 
            // Sepa_cul
            // 
            this.Sepa_cul.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransion.SetDecoration(this.Sepa_cul, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.Sepa_cul, BunifuAnimatorNS.DecorationType.None);
            this.Sepa_cul.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Sepa_cul.LineThickness = 1;
            this.Sepa_cul.Location = new System.Drawing.Point(412, 5);
            this.Sepa_cul.Name = "Sepa_cul";
            this.Sepa_cul.Size = new System.Drawing.Size(50, 20);
            this.Sepa_cul.TabIndex = 49;
            this.Sepa_cul.Transparency = 255;
            this.Sepa_cul.Vertical = false;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransion.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageActive = null;
            this.Logo.Location = new System.Drawing.Point(100, 225);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(770, 300);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Zoom = 10;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.panelMenu.Controls.Add(this.bunifuSeparator1);
            this.panelMenu.Controls.Add(this.BtnCopiaSeguridad);
            this.panelMenu.Controls.Add(this.BtnCerrarSesion);
            this.panelMenu.Controls.Add(this.BtnHidraulico);
            this.panelMenu.Controls.Add(this.BtnAgronomico);
            this.panelMenu.Controls.Add(this.BtnProyecto);
            this.panelMenu.Controls.Add(this.BtnCultivo);
            this.panelMenu.Controls.Add(this.BtnHome);
            this.LogoTransion.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 750);
            this.panelMenu.TabIndex = 1;
            // 
            // BtnCopiaSeguridad
            // 
            this.BtnCopiaSeguridad.Activecolor = System.Drawing.Color.Transparent;
            this.BtnCopiaSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnCopiaSeguridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCopiaSeguridad.BorderRadius = 0;
            this.BtnCopiaSeguridad.ButtonText = "COPIA DE SEGURIDAD";
            this.BtnCopiaSeguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.BtnCopiaSeguridad, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.BtnCopiaSeguridad, BunifuAnimatorNS.DecorationType.None);
            this.BtnCopiaSeguridad.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.BtnCopiaSeguridad.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCopiaSeguridad.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCopiaSeguridad.Iconimage")));
            this.BtnCopiaSeguridad.Iconimage_right = null;
            this.BtnCopiaSeguridad.Iconimage_right_Selected = null;
            this.BtnCopiaSeguridad.Iconimage_Selected = null;
            this.BtnCopiaSeguridad.IconMarginLeft = 0;
            this.BtnCopiaSeguridad.IconMarginRight = 0;
            this.BtnCopiaSeguridad.IconRightVisible = true;
            this.BtnCopiaSeguridad.IconRightZoom = 0D;
            this.BtnCopiaSeguridad.IconVisible = true;
            this.BtnCopiaSeguridad.IconZoom = 90D;
            this.BtnCopiaSeguridad.IsTab = false;
            this.BtnCopiaSeguridad.Location = new System.Drawing.Point(0, 262);
            this.BtnCopiaSeguridad.Name = "BtnCopiaSeguridad";
            this.BtnCopiaSeguridad.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnCopiaSeguridad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnCopiaSeguridad.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCopiaSeguridad.selected = false;
            this.BtnCopiaSeguridad.Size = new System.Drawing.Size(230, 80);
            this.BtnCopiaSeguridad.TabIndex = 9;
            this.BtnCopiaSeguridad.Text = "COPIA DE SEGURIDAD";
            this.BtnCopiaSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCopiaSeguridad.Textcolor = System.Drawing.Color.White;
            this.BtnCopiaSeguridad.TextFont = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopiaSeguridad.Click += new System.EventHandler(this.BtnCopiaSeguridad_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Activecolor = System.Drawing.Color.Transparent;
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrarSesion.BorderRadius = 0;
            this.BtnCerrarSesion.ButtonText = "Cerrar Sesíon";
            this.BtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.BtnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.BtnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.BtnCerrarSesion.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCerrarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCerrarSesion.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCerrarSesion.Iconimage")));
            this.BtnCerrarSesion.Iconimage_right = null;
            this.BtnCerrarSesion.Iconimage_right_Selected = null;
            this.BtnCerrarSesion.Iconimage_Selected = null;
            this.BtnCerrarSesion.IconMarginLeft = 0;
            this.BtnCerrarSesion.IconMarginRight = 0;
            this.BtnCerrarSesion.IconRightVisible = true;
            this.BtnCerrarSesion.IconRightZoom = 0D;
            this.BtnCerrarSesion.IconVisible = true;
            this.BtnCerrarSesion.IconZoom = 90D;
            this.BtnCerrarSesion.IsTab = false;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 0);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnCerrarSesion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnCerrarSesion.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.BtnCerrarSesion.selected = false;
            this.BtnCerrarSesion.Size = new System.Drawing.Size(230, 80);
            this.BtnCerrarSesion.TabIndex = 8;
            this.BtnCerrarSesion.Text = "Cerrar Sesíon";
            this.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrarSesion.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.BtnCerrarSesion.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Visible = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click_1);
            // 
            // BtnHidraulico
            // 
            this.BtnHidraulico.Activecolor = System.Drawing.Color.Transparent;
            this.BtnHidraulico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnHidraulico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHidraulico.BorderRadius = 0;
            this.BtnHidraulico.ButtonText = "Hidráulico";
            this.BtnHidraulico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.BtnHidraulico, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.BtnHidraulico, BunifuAnimatorNS.DecorationType.None);
            this.BtnHidraulico.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.BtnHidraulico.Enabled = false;
            this.BtnHidraulico.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnHidraulico.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnHidraulico.Iconimage")));
            this.BtnHidraulico.Iconimage_right = null;
            this.BtnHidraulico.Iconimage_right_Selected = null;
            this.BtnHidraulico.Iconimage_Selected = null;
            this.BtnHidraulico.IconMarginLeft = 0;
            this.BtnHidraulico.IconMarginRight = 0;
            this.BtnHidraulico.IconRightVisible = true;
            this.BtnHidraulico.IconRightZoom = 0D;
            this.BtnHidraulico.IconVisible = true;
            this.BtnHidraulico.IconZoom = 90D;
            this.BtnHidraulico.IsTab = false;
            this.BtnHidraulico.Location = new System.Drawing.Point(0, 577);
            this.BtnHidraulico.Name = "BtnHidraulico";
            this.BtnHidraulico.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnHidraulico.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnHidraulico.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnHidraulico.selected = false;
            this.BtnHidraulico.Size = new System.Drawing.Size(230, 80);
            this.BtnHidraulico.TabIndex = 7;
            this.BtnHidraulico.Text = "Hidráulico";
            this.BtnHidraulico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHidraulico.Textcolor = System.Drawing.Color.White;
            this.BtnHidraulico.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHidraulico.Click += new System.EventHandler(this.BtnHidraulico_Click);
            // 
            // BtnAgronomico
            // 
            this.BtnAgronomico.Activecolor = System.Drawing.Color.Transparent;
            this.BtnAgronomico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnAgronomico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgronomico.BorderRadius = 0;
            this.BtnAgronomico.ButtonText = "Agronómico";
            this.BtnAgronomico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.BtnAgronomico, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.BtnAgronomico, BunifuAnimatorNS.DecorationType.None);
            this.BtnAgronomico.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.BtnAgronomico.Enabled = false;
            this.BtnAgronomico.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAgronomico.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnAgronomico.Iconimage")));
            this.BtnAgronomico.Iconimage_right = null;
            this.BtnAgronomico.Iconimage_right_Selected = null;
            this.BtnAgronomico.Iconimage_Selected = null;
            this.BtnAgronomico.IconMarginLeft = 0;
            this.BtnAgronomico.IconMarginRight = 0;
            this.BtnAgronomico.IconRightVisible = true;
            this.BtnAgronomico.IconRightZoom = 0D;
            this.BtnAgronomico.IconVisible = true;
            this.BtnAgronomico.IconZoom = 90D;
            this.BtnAgronomico.IsTab = false;
            this.BtnAgronomico.Location = new System.Drawing.Point(0, 496);
            this.BtnAgronomico.Name = "BtnAgronomico";
            this.BtnAgronomico.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnAgronomico.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnAgronomico.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnAgronomico.selected = false;
            this.BtnAgronomico.Size = new System.Drawing.Size(230, 80);
            this.BtnAgronomico.TabIndex = 6;
            this.BtnAgronomico.Text = "Agronómico";
            this.BtnAgronomico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgronomico.Textcolor = System.Drawing.Color.White;
            this.BtnAgronomico.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgronomico.Click += new System.EventHandler(this.BtnAgronomico_Click);
            // 
            // BtnProyecto
            // 
            this.BtnProyecto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.BtnProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProyecto.BorderRadius = 0;
            this.BtnProyecto.ButtonText = "Proyecto";
            this.BtnProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.BtnProyecto, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.BtnProyecto, BunifuAnimatorNS.DecorationType.None);
            this.BtnProyecto.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.BtnProyecto.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnProyecto.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnProyecto.Iconimage")));
            this.BtnProyecto.Iconimage_right = null;
            this.BtnProyecto.Iconimage_right_Selected = null;
            this.BtnProyecto.Iconimage_Selected = null;
            this.BtnProyecto.IconMarginLeft = 0;
            this.BtnProyecto.IconMarginRight = 0;
            this.BtnProyecto.IconRightVisible = true;
            this.BtnProyecto.IconRightZoom = 0D;
            this.BtnProyecto.IconVisible = true;
            this.BtnProyecto.IconZoom = 90D;
            this.BtnProyecto.IsTab = false;
            this.BtnProyecto.Location = new System.Drawing.Point(0, 176);
            this.BtnProyecto.Name = "BtnProyecto";
            this.BtnProyecto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnProyecto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnProyecto.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnProyecto.selected = false;
            this.BtnProyecto.Size = new System.Drawing.Size(230, 80);
            this.BtnProyecto.TabIndex = 4;
            this.BtnProyecto.Text = "Proyecto";
            this.BtnProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProyecto.Textcolor = System.Drawing.Color.White;
            this.BtnProyecto.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProyecto.Click += new System.EventHandler(this.BtnProyecto_Click);
            // 
            // BtnCultivo
            // 
            this.BtnCultivo.Activecolor = System.Drawing.Color.Transparent;
            this.BtnCultivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnCultivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCultivo.BorderRadius = 0;
            this.BtnCultivo.ButtonText = "Cultivo";
            this.BtnCultivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.BtnCultivo, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.BtnCultivo, BunifuAnimatorNS.DecorationType.None);
            this.BtnCultivo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(170)))));
            this.BtnCultivo.Enabled = false;
            this.BtnCultivo.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCultivo.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCultivo.Iconimage")));
            this.BtnCultivo.Iconimage_right = null;
            this.BtnCultivo.Iconimage_right_Selected = null;
            this.BtnCultivo.Iconimage_Selected = null;
            this.BtnCultivo.IconMarginLeft = 0;
            this.BtnCultivo.IconMarginRight = 0;
            this.BtnCultivo.IconRightVisible = true;
            this.BtnCultivo.IconRightZoom = 0D;
            this.BtnCultivo.IconVisible = true;
            this.BtnCultivo.IconZoom = 90D;
            this.BtnCultivo.IsTab = false;
            this.BtnCultivo.Location = new System.Drawing.Point(0, 415);
            this.BtnCultivo.Name = "BtnCultivo";
            this.BtnCultivo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnCultivo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnCultivo.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCultivo.selected = false;
            this.BtnCultivo.Size = new System.Drawing.Size(230, 80);
            this.BtnCultivo.TabIndex = 3;
            this.BtnCultivo.Text = "Cultivo";
            this.BtnCultivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCultivo.Textcolor = System.Drawing.Color.White;
            this.BtnCultivo.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCultivo.Click += new System.EventHandler(this.BtnCultivo_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Activecolor = System.Drawing.Color.Transparent;
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHome.BorderRadius = 0;
            this.BtnHome.ButtonText = "Inicio";
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.BtnHome, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.BtnHome, BunifuAnimatorNS.DecorationType.None);
            this.BtnHome.DisabledColor = System.Drawing.Color.Gray;
            this.BtnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnHome.Iconimage")));
            this.BtnHome.Iconimage_right = null;
            this.BtnHome.Iconimage_right_Selected = null;
            this.BtnHome.Iconimage_Selected = null;
            this.BtnHome.IconMarginLeft = 0;
            this.BtnHome.IconMarginRight = 0;
            this.BtnHome.IconRightVisible = true;
            this.BtnHome.IconRightZoom = 0D;
            this.BtnHome.IconVisible = true;
            this.BtnHome.IconZoom = 90D;
            this.BtnHome.IsTab = false;
            this.BtnHome.Location = new System.Drawing.Point(0, 95);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.BtnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.BtnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnHome.selected = false;
            this.BtnHome.Size = new System.Drawing.Size(230, 80);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.Text = "Inicio";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHome.Textcolor = System.Drawing.Color.White;
            this.BtnHome.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.panelBarraTitulo.Controls.Add(this.LblProyecto);
            this.panelBarraTitulo.Controls.Add(this.pictureBox1);
            this.panelBarraTitulo.Controls.Add(this.BtnMenu);
            this.panelBarraTitulo.Controls.Add(this.BtnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.BtnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.BtnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.BtnCerrar);
            this.panelBarraTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.panelBarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.panelBarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1200, 50);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // LblProyecto
            // 
            this.LblProyecto.AutoSize = true;
            this.panelTransion.SetDecoration(this.LblProyecto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.LblProyecto, BunifuAnimatorNS.DecorationType.None);
            this.LblProyecto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProyecto.ForeColor = System.Drawing.Color.White;
            this.LblProyecto.Location = new System.Drawing.Point(475, 17);
            this.LblProyecto.Name = "LblProyecto";
            this.LblProyecto.Size = new System.Drawing.Size(366, 21);
            this.LblProyecto.TabIndex = 6;
            this.LblProyecto.Text = "Proyecto: Sistema de Riego - Sucre (12/03/021)";
            this.LblProyecto.Visible = false;
            // 
            // pictureBox1
            // 
            this.panelTransion.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransion.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageActive = null;
            this.BtnMenu.Location = new System.Drawing.Point(35, 14);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(24, 24);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 4;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Zoom = 10;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransion.SetDecoration(this.BtnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.BtnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(1150, 12);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(16, 16);
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransion.SetDecoration(this.BtnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.BtnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(1128, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransion.SetDecoration(this.BtnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.BtnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(1150, 12);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.BtnMaximizar.TabIndex = 1;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransion.SetDecoration(this.BtnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this.BtnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1172, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(16, 16);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTransion
            // 
            this.panelTransion.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.panelTransion.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.panelTransion.DefaultAnimation = animation4;
            // 
            // LogoTransion
            // 
            this.LogoTransion.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoTransion.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoTransion.DefaultAnimation = animation3;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.LogoTransion.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransion.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 368);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(205, 20);
            this.bunifuSeparator1.TabIndex = 48;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelContenedor);
            this.panelTransion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelSecuencia.ResumeLayout(false);
            this.panel_hidra.ResumeLayout(false);
            this.panel_proy.ResumeLayout(false);
            this.panel_agro.ResumeLayout(false);
            this.panel_cul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton BtnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition panelTransion;
        private BunifuAnimatorNS.BunifuTransition LogoTransion;
        private System.Windows.Forms.Panel panelFormularios;
        private Bunifu.Framework.UI.BunifuImageButton Logo;
        private Bunifu.Framework.UI.BunifuFlatButton BtnHome;
        public System.Windows.Forms.Label LblProyecto;
        public Bunifu.Framework.UI.BunifuFlatButton BtnProyecto;
        public Bunifu.Framework.UI.BunifuFlatButton BtnCultivo;
        public Bunifu.Framework.UI.BunifuFlatButton BtnAgronomico;
        public Bunifu.Framework.UI.BunifuFlatButton BtnHidraulico;
        public Bunifu.Framework.UI.BunifuFlatButton BtnCerrarSesion;
        public Bunifu.Framework.UI.BunifuFlatButton BtnCopiaSeguridad;
        private System.Windows.Forms.Panel panelSecuencia;
        public System.Windows.Forms.Panel panel_hidra;
        public Bunifu.UI.WinForms.BunifuRadioButton Cir_hidra;
        public System.Windows.Forms.Panel panel_proy;
        public Bunifu.UI.WinForms.BunifuRadioButton Cir_proy;
        public Bunifu.Framework.UI.BunifuSeparator Sepa_agro;
        public Bunifu.Framework.UI.BunifuSeparator Sepa_proy;
        public System.Windows.Forms.Panel panel_agro;
        public Bunifu.UI.WinForms.BunifuRadioButton Cir_agro;
        public System.Windows.Forms.Panel panel_cul;
        public Bunifu.UI.WinForms.BunifuRadioButton Cir_Cul;
        public Bunifu.Framework.UI.BunifuSeparator Sepa_cul;
        public System.Windows.Forms.Button Btn_hidra;
        public System.Windows.Forms.Button Btn_proy;
        public System.Windows.Forms.Button Btn_Agro;
        public System.Windows.Forms.Button Btn_cul;
        public Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}

