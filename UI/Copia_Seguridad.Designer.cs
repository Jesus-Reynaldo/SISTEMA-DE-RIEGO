namespace UI
{
    partial class Copia_Seguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Copia_Seguridad));
            this.panelGenerar = new System.Windows.Forms.Panel();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.TxtBackup = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblVb = new System.Windows.Forms.Label();
            this.BtnExaminarG = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblmVb = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.LblVn = new System.Windows.Forms.Label();
            this.LblmMes = new System.Windows.Forms.Label();
            this.LblmVn = new System.Windows.Forms.Label();
            this.LblMes = new System.Windows.Forms.Label();
            this.panelRestaurar = new System.Windows.Forms.Panel();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            this.BtnExaminarR = new System.Windows.Forms.Button();
            this.TxtRestaurar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Efx_panelGenerar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_panelRestaurar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnRestaurar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Efx_BtnGenerar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelGenerar.SuspendLayout();
            this.panelRestaurar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGenerar
            // 
            this.panelGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelGenerar.Controls.Add(this.BtnGenerar);
            this.panelGenerar.Controls.Add(this.TxtBackup);
            this.panelGenerar.Controls.Add(this.LblVb);
            this.panelGenerar.Controls.Add(this.BtnExaminarG);
            this.panelGenerar.Controls.Add(this.bunifuCustomLabel1);
            this.panelGenerar.Controls.Add(this.LblmVb);
            this.panelGenerar.Controls.Add(this.bunifuSeparator1);
            this.panelGenerar.Controls.Add(this.LblVn);
            this.panelGenerar.Controls.Add(this.LblmMes);
            this.panelGenerar.Controls.Add(this.LblmVn);
            this.panelGenerar.Controls.Add(this.LblMes);
            this.panelGenerar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGenerar.Location = new System.Drawing.Point(61, 111);
            this.panelGenerar.Name = "panelGenerar";
            this.panelGenerar.Size = new System.Drawing.Size(839, 225);
            this.panelGenerar.TabIndex = 7;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerar.Enabled = false;
            this.BtnGenerar.FlatAppearance.BorderSize = 0;
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.White;
            this.BtnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerar.Image")));
            this.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar.Location = new System.Drawing.Point(71, 123);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Padding = new System.Windows.Forms.Padding(10);
            this.BtnGenerar.Size = new System.Drawing.Size(168, 68);
            this.BtnGenerar.TabIndex = 47;
            this.BtnGenerar.Text = "BACKUP";
            this.BtnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // TxtBackup
            // 
            this.TxtBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TxtBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBackup.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.TxtBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtBackup.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtBackup.HintText = "Ruta";
            this.TxtBackup.isPassword = false;
            this.TxtBackup.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtBackup.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.TxtBackup.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtBackup.LineThickness = 2;
            this.TxtBackup.Location = new System.Drawing.Point(71, 85);
            this.TxtBackup.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBackup.Name = "TxtBackup";
            this.TxtBackup.Size = new System.Drawing.Size(585, 31);
            this.TxtBackup.TabIndex = 9;
            this.TxtBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblVb
            // 
            this.LblVb.AutoSize = true;
            this.LblVb.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVb.ForeColor = System.Drawing.Color.White;
            this.LblVb.Location = new System.Drawing.Point(239, 137);
            this.LblVb.Name = "LblVb";
            this.LblVb.Size = new System.Drawing.Size(0, 19);
            this.LblVb.TabIndex = 5;
            // 
            // BtnExaminarG
            // 
            this.BtnExaminarG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnExaminarG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExaminarG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.BtnExaminarG.FlatAppearance.BorderSize = 0;
            this.BtnExaminarG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminarG.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExaminarG.ForeColor = System.Drawing.Color.White;
            this.BtnExaminarG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExaminarG.Location = new System.Drawing.Point(663, 85);
            this.BtnExaminarG.Name = "BtnExaminarG";
            this.BtnExaminarG.Size = new System.Drawing.Size(105, 31);
            this.BtnExaminarG.TabIndex = 8;
            this.BtnExaminarG.Text = "EXAMINAR";
            this.BtnExaminarG.UseVisualStyleBackColor = false;
            this.BtnExaminarG.Click += new System.EventHandler(this.BtnExaminarG_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 15);
            this.bunifuCustomLabel1.TabIndex = 45;
            this.bunifuCustomLabel1.Text = "Copia de seguridad";
            // 
            // LblmVb
            // 
            this.LblmVb.AutoSize = true;
            this.LblmVb.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblmVb.ForeColor = System.Drawing.Color.White;
            this.LblmVb.Location = new System.Drawing.Point(81, 137);
            this.LblmVb.Name = "LblmVb";
            this.LblmVb.Size = new System.Drawing.Size(0, 19);
            this.LblmVb.TabIndex = 4;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(22, 30);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(436, 27);
            this.bunifuSeparator1.TabIndex = 44;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // LblVn
            // 
            this.LblVn.AutoSize = true;
            this.LblVn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVn.ForeColor = System.Drawing.Color.White;
            this.LblVn.Location = new System.Drawing.Point(239, 97);
            this.LblVn.Name = "LblVn";
            this.LblVn.Size = new System.Drawing.Size(0, 19);
            this.LblVn.TabIndex = 3;
            // 
            // LblmMes
            // 
            this.LblmMes.AutoSize = true;
            this.LblmMes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblmMes.ForeColor = System.Drawing.Color.White;
            this.LblmMes.Location = new System.Drawing.Point(81, 62);
            this.LblmMes.Name = "LblmMes";
            this.LblmMes.Size = new System.Drawing.Size(0, 19);
            this.LblmMes.TabIndex = 0;
            // 
            // LblmVn
            // 
            this.LblmVn.AutoSize = true;
            this.LblmVn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblmVn.ForeColor = System.Drawing.Color.White;
            this.LblmVn.Location = new System.Drawing.Point(81, 97);
            this.LblmVn.Name = "LblmVn";
            this.LblmVn.Size = new System.Drawing.Size(0, 19);
            this.LblmVn.TabIndex = 2;
            // 
            // LblMes
            // 
            this.LblMes.AutoSize = true;
            this.LblMes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMes.ForeColor = System.Drawing.Color.White;
            this.LblMes.Location = new System.Drawing.Point(239, 62);
            this.LblMes.Name = "LblMes";
            this.LblMes.Size = new System.Drawing.Size(0, 19);
            this.LblMes.TabIndex = 1;
            // 
            // panelRestaurar
            // 
            this.panelRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelRestaurar.Controls.Add(this.BtnRestaurar);
            this.panelRestaurar.Controls.Add(this.BtnExaminarR);
            this.panelRestaurar.Controls.Add(this.TxtRestaurar);
            this.panelRestaurar.Controls.Add(this.label1);
            this.panelRestaurar.Controls.Add(this.bunifuCustomLabel2);
            this.panelRestaurar.Controls.Add(this.label2);
            this.panelRestaurar.Controls.Add(this.bunifuSeparator2);
            this.panelRestaurar.Controls.Add(this.label3);
            this.panelRestaurar.Controls.Add(this.label4);
            this.panelRestaurar.Controls.Add(this.label5);
            this.panelRestaurar.Controls.Add(this.label6);
            this.panelRestaurar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRestaurar.Location = new System.Drawing.Point(61, 393);
            this.panelRestaurar.Name = "panelRestaurar";
            this.panelRestaurar.Size = new System.Drawing.Size(839, 225);
            this.panelRestaurar.TabIndex = 8;
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Enabled = false;
            this.BtnRestaurar.FlatAppearance.BorderSize = 0;
            this.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurar.ForeColor = System.Drawing.Color.White;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRestaurar.Location = new System.Drawing.Point(71, 126);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Padding = new System.Windows.Forms.Padding(10);
            this.BtnRestaurar.Size = new System.Drawing.Size(168, 68);
            this.BtnRestaurar.TabIndex = 48;
            this.BtnRestaurar.Text = "RESTAURAR";
            this.BtnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRestaurar.UseVisualStyleBackColor = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnExaminarR
            // 
            this.BtnExaminarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.BtnExaminarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExaminarR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.BtnExaminarR.FlatAppearance.BorderSize = 0;
            this.BtnExaminarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExaminarR.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExaminarR.ForeColor = System.Drawing.Color.White;
            this.BtnExaminarR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExaminarR.Location = new System.Drawing.Point(663, 84);
            this.BtnExaminarR.Name = "BtnExaminarR";
            this.BtnExaminarR.Size = new System.Drawing.Size(105, 31);
            this.BtnExaminarR.TabIndex = 47;
            this.BtnExaminarR.Text = "EXAMINAR";
            this.BtnExaminarR.UseVisualStyleBackColor = false;
            this.BtnExaminarR.Click += new System.EventHandler(this.BtnExaminarR_Click);
            // 
            // TxtRestaurar
            // 
            this.TxtRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.TxtRestaurar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRestaurar.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.TxtRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtRestaurar.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.TxtRestaurar.HintText = "Ruta";
            this.TxtRestaurar.isPassword = false;
            this.TxtRestaurar.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtRestaurar.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.TxtRestaurar.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.TxtRestaurar.LineThickness = 2;
            this.TxtRestaurar.Location = new System.Drawing.Point(71, 84);
            this.TxtRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRestaurar.Name = "TxtRestaurar";
            this.TxtRestaurar.Size = new System.Drawing.Size(585, 31);
            this.TxtRestaurar.TabIndex = 9;
            this.TxtRestaurar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 5;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 11);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 15);
            this.bunifuCustomLabel2.TabIndex = 45;
            this.bunifuCustomLabel2.Text = "Restaurar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 4;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(19, 26);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(374, 23);
            this.bunifuSeparator2.TabIndex = 44;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(225, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(67, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(225, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 1;
            // 
            // Efx_panelGenerar
            // 
            this.Efx_panelGenerar.ElipseRadius = 20;
            this.Efx_panelGenerar.TargetControl = this.panelGenerar;
            // 
            // Efx_panelRestaurar
            // 
            this.Efx_panelRestaurar.ElipseRadius = 20;
            this.Efx_panelRestaurar.TargetControl = this.panelRestaurar;
            // 
            // Efx_BtnRestaurar
            // 
            this.Efx_BtnRestaurar.ElipseRadius = 10;
            this.Efx_BtnRestaurar.TargetControl = this.BtnRestaurar;
            // 
            // Efx_BtnGenerar
            // 
            this.Efx_BtnGenerar.ElipseRadius = 20;
            this.Efx_BtnGenerar.TargetControl = this.BtnGenerar;
            // 
            // Copia_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(970, 750);
            this.Controls.Add(this.panelRestaurar);
            this.Controls.Add(this.panelGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Copia_Seguridad";
            this.Text = "Copia_Seguridad";
            this.panelGenerar.ResumeLayout(false);
            this.panelGenerar.PerformLayout();
            this.panelRestaurar.ResumeLayout(false);
            this.panelRestaurar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGenerar;
        private System.Windows.Forms.Label LblVb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label LblmVb;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label LblVn;
        private System.Windows.Forms.Label LblmMes;
        private System.Windows.Forms.Label LblmVn;
        private System.Windows.Forms.Label LblMes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBackup;
        private System.Windows.Forms.Panel panelRestaurar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtRestaurar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnExaminarG;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Button BtnRestaurar;
        private System.Windows.Forms.Button BtnExaminarR;
        public Bunifu.Framework.UI.BunifuElipse Efx_panelGenerar;
        public Bunifu.Framework.UI.BunifuElipse Efx_panelRestaurar;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnRestaurar;
        public Bunifu.Framework.UI.BunifuElipse Efx_BtnGenerar;
    }
}