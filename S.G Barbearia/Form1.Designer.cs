
namespace S.G_Barbearia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new Guna.UI.WinForms.GunaPanel();
            this.pg_paginas = new Bunifu.UI.WinForms.BunifuPages();
            this.pg_cortes = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pg_melhores = new System.Windows.Forms.TabPage();
            this.pg_barbeiros = new System.Windows.Forms.TabPage();
            this.sideBarAnimation = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.corte1 = new S.G_Barbearia.corte();
            this.corte111 = new S.G_Barbearia.corte11();
            this.corte121 = new S.G_Barbearia.corte12();
            this.corte11 = new S.G_Barbearia.corte1();
            this.corte21 = new S.G_Barbearia.corte2();
            this.corte31 = new S.G_Barbearia.corte3();
            this.corte41 = new S.G_Barbearia.corte4();
            this.corte51 = new S.G_Barbearia.corte5();
            this.corte61 = new S.G_Barbearia.corte6();
            this.corte71 = new S.G_Barbearia.corte7();
            this.corte81 = new S.G_Barbearia.corte8();
            this.corte91 = new S.G_Barbearia.corte9();
            this.cote101 = new S.G_Barbearia.cote10();
            this.pg_paginas.SuspendLayout();
            this.pg_cortes.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(202)))));
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(218, 720);
            this.sidebar.MinimumSize = new System.Drawing.Size(74, 720);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(218, 720);
            this.sidebar.TabIndex = 0;
            // 
            // pg_paginas
            // 
            this.pg_paginas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pg_paginas.AllowTransitions = true;
            this.pg_paginas.Controls.Add(this.pg_cortes);
            this.pg_paginas.Controls.Add(this.pg_melhores);
            this.pg_paginas.Controls.Add(this.pg_barbeiros);
            this.pg_paginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg_paginas.Location = new System.Drawing.Point(218, 0);
            this.pg_paginas.Multiline = true;
            this.pg_paginas.Name = "pg_paginas";
            this.pg_paginas.Page = this.pg_cortes;
            this.pg_paginas.PageIndex = 0;
            this.pg_paginas.PageName = "pg_cortes";
            this.pg_paginas.PageTitle = "Cortes";
            this.pg_paginas.SelectedIndex = 0;
            this.pg_paginas.Size = new System.Drawing.Size(1112, 720);
            this.pg_paginas.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pg_paginas.Transition = animation1;
            this.pg_paginas.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pg_cortes
            // 
            this.pg_cortes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pg_cortes.Controls.Add(this.flowLayoutPanel1);
            this.pg_cortes.Controls.Add(this.panel1);
            this.pg_cortes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pg_cortes.ForeColor = System.Drawing.Color.White;
            this.pg_cortes.Location = new System.Drawing.Point(4, 4);
            this.pg_cortes.Name = "pg_cortes";
            this.pg_cortes.Padding = new System.Windows.Forms.Padding(3);
            this.pg_cortes.Size = new System.Drawing.Size(1104, 684);
            this.pg_cortes.TabIndex = 0;
            this.pg_cortes.Text = "Cortes";
            this.pg_cortes.Click += new System.EventHandler(this.pg_cortes_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.corte1);
            this.flowLayoutPanel1.Controls.Add(this.corte111);
            this.flowLayoutPanel1.Controls.Add(this.corte121);
            this.flowLayoutPanel1.Controls.Add(this.corte11);
            this.flowLayoutPanel1.Controls.Add(this.corte21);
            this.flowLayoutPanel1.Controls.Add(this.corte31);
            this.flowLayoutPanel1.Controls.Add(this.corte41);
            this.flowLayoutPanel1.Controls.Add(this.corte51);
            this.flowLayoutPanel1.Controls.Add(this.corte61);
            this.flowLayoutPanel1.Controls.Add(this.corte71);
            this.flowLayoutPanel1.Controls.Add(this.corte81);
            this.flowLayoutPanel1.Controls.Add(this.corte91);
            this.flowLayoutPanel1.Controls.Add(this.cote101);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1098, 639);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(494, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cortes disponíveis";
            // 
            // pg_melhores
            // 
            this.pg_melhores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pg_melhores.ForeColor = System.Drawing.Color.White;
            this.pg_melhores.Location = new System.Drawing.Point(4, 4);
            this.pg_melhores.Name = "pg_melhores";
            this.pg_melhores.Padding = new System.Windows.Forms.Padding(3);
            this.pg_melhores.Size = new System.Drawing.Size(1104, 684);
            this.pg_melhores.TabIndex = 1;
            this.pg_melhores.Text = "Melhores";
            // 
            // pg_barbeiros
            // 
            this.pg_barbeiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pg_barbeiros.Location = new System.Drawing.Point(4, 4);
            this.pg_barbeiros.Name = "pg_barbeiros";
            this.pg_barbeiros.Size = new System.Drawing.Size(1104, 684);
            this.pg_barbeiros.TabIndex = 2;
            this.pg_barbeiros.Text = "Barbeiros";
            // 
            // sideBarAnimation
            // 
            this.sideBarAnimation.Interval = 20;
            this.sideBarAnimation.Tick += new System.EventHandler(this.sideBarAnimation_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // corte1
            // 
            this.corte1.AllowAnimations = false;
            this.corte1.AllowBorderColorChanges = false;
            this.corte1.AllowMouseEffects = false;
            this.corte1.AnimationSpeed = 200;
            this.corte1.BackColor = System.Drawing.Color.Transparent;
            this.corte1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte1.BorderRadius = 2;
            this.corte1.BorderThickness = 2;
            this.corte1.ColorContrastOnClick = 30;
            this.corte1.ColorContrastOnHover = 30;
            this.corte1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte1.Image = null;
            this.corte1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte1.Location = new System.Drawing.Point(3, 3);
            this.corte1.Name = "corte1";
            this.corte1.ShowBorders = true;
            this.corte1.Size = new System.Drawing.Size(355, 287);
            this.corte1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte1.TabIndex = 0;
            // 
            // corte111
            // 
            this.corte111.AllowAnimations = false;
            this.corte111.AllowBorderColorChanges = false;
            this.corte111.AllowMouseEffects = false;
            this.corte111.AnimationSpeed = 200;
            this.corte111.BackColor = System.Drawing.Color.Transparent;
            this.corte111.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte111.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte111.BorderRadius = 2;
            this.corte111.BorderThickness = 2;
            this.corte111.ColorContrastOnClick = 30;
            this.corte111.ColorContrastOnHover = 30;
            this.corte111.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte111.Image = null;
            this.corte111.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte111.Location = new System.Drawing.Point(364, 3);
            this.corte111.Name = "corte111";
            this.corte111.ShowBorders = true;
            this.corte111.Size = new System.Drawing.Size(355, 287);
            this.corte111.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte111.TabIndex = 1;
            // 
            // corte121
            // 
            this.corte121.AllowAnimations = false;
            this.corte121.AllowBorderColorChanges = false;
            this.corte121.AllowMouseEffects = false;
            this.corte121.AnimationSpeed = 200;
            this.corte121.BackColor = System.Drawing.Color.Transparent;
            this.corte121.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte121.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte121.BorderRadius = 2;
            this.corte121.BorderThickness = 2;
            this.corte121.ColorContrastOnClick = 30;
            this.corte121.ColorContrastOnHover = 30;
            this.corte121.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte121.Image = null;
            this.corte121.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte121.Location = new System.Drawing.Point(3, 296);
            this.corte121.Name = "corte121";
            this.corte121.ShowBorders = true;
            this.corte121.Size = new System.Drawing.Size(355, 287);
            this.corte121.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte121.TabIndex = 2;
            // 
            // corte11
            // 
            this.corte11.AllowAnimations = false;
            this.corte11.AllowBorderColorChanges = false;
            this.corte11.AllowMouseEffects = false;
            this.corte11.AnimationSpeed = 200;
            this.corte11.BackColor = System.Drawing.Color.Transparent;
            this.corte11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte11.BorderRadius = 2;
            this.corte11.BorderThickness = 2;
            this.corte11.ColorContrastOnClick = 30;
            this.corte11.ColorContrastOnHover = 30;
            this.corte11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte11.Image = null;
            this.corte11.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte11.Location = new System.Drawing.Point(364, 296);
            this.corte11.Name = "corte11";
            this.corte11.ShowBorders = true;
            this.corte11.Size = new System.Drawing.Size(355, 287);
            this.corte11.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte11.TabIndex = 3;
            // 
            // corte21
            // 
            this.corte21.AllowAnimations = false;
            this.corte21.AllowBorderColorChanges = false;
            this.corte21.AllowMouseEffects = false;
            this.corte21.AnimationSpeed = 200;
            this.corte21.BackColor = System.Drawing.Color.Transparent;
            this.corte21.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte21.BorderRadius = 2;
            this.corte21.BorderThickness = 2;
            this.corte21.ColorContrastOnClick = 30;
            this.corte21.ColorContrastOnHover = 30;
            this.corte21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte21.Image = null;
            this.corte21.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte21.Location = new System.Drawing.Point(3, 589);
            this.corte21.Name = "corte21";
            this.corte21.ShowBorders = true;
            this.corte21.Size = new System.Drawing.Size(355, 287);
            this.corte21.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte21.TabIndex = 4;
            // 
            // corte31
            // 
            this.corte31.AllowAnimations = false;
            this.corte31.AllowBorderColorChanges = false;
            this.corte31.AllowMouseEffects = false;
            this.corte31.AnimationSpeed = 200;
            this.corte31.BackColor = System.Drawing.Color.Transparent;
            this.corte31.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte31.BorderRadius = 2;
            this.corte31.BorderThickness = 2;
            this.corte31.ColorContrastOnClick = 30;
            this.corte31.ColorContrastOnHover = 30;
            this.corte31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte31.Image = null;
            this.corte31.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte31.Location = new System.Drawing.Point(364, 589);
            this.corte31.Name = "corte31";
            this.corte31.ShowBorders = true;
            this.corte31.Size = new System.Drawing.Size(355, 287);
            this.corte31.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte31.TabIndex = 5;
            // 
            // corte41
            // 
            this.corte41.AllowAnimations = false;
            this.corte41.AllowBorderColorChanges = false;
            this.corte41.AllowMouseEffects = false;
            this.corte41.AnimationSpeed = 200;
            this.corte41.BackColor = System.Drawing.Color.Transparent;
            this.corte41.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte41.BorderRadius = 2;
            this.corte41.BorderThickness = 2;
            this.corte41.ColorContrastOnClick = 30;
            this.corte41.ColorContrastOnHover = 30;
            this.corte41.Cursor = System.Windows.Forms.Cursors.Default;
            this.corte41.Image = null;
            this.corte41.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte41.Location = new System.Drawing.Point(3, 882);
            this.corte41.Name = "corte41";
            this.corte41.ShowBorders = true;
            this.corte41.Size = new System.Drawing.Size(355, 287);
            this.corte41.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte41.TabIndex = 6;
            // 
            // corte51
            // 
            this.corte51.AllowAnimations = false;
            this.corte51.AllowBorderColorChanges = false;
            this.corte51.AllowMouseEffects = false;
            this.corte51.AnimationSpeed = 200;
            this.corte51.BackColor = System.Drawing.Color.Transparent;
            this.corte51.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte51.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte51.BorderRadius = 2;
            this.corte51.BorderThickness = 2;
            this.corte51.ColorContrastOnClick = 30;
            this.corte51.ColorContrastOnHover = 30;
            this.corte51.Cursor = System.Windows.Forms.Cursors.Default;
            this.corte51.Image = null;
            this.corte51.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte51.Location = new System.Drawing.Point(364, 882);
            this.corte51.Name = "corte51";
            this.corte51.ShowBorders = true;
            this.corte51.Size = new System.Drawing.Size(355, 287);
            this.corte51.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte51.TabIndex = 7;
            // 
            // corte61
            // 
            this.corte61.AllowAnimations = false;
            this.corte61.AllowBorderColorChanges = false;
            this.corte61.AllowMouseEffects = false;
            this.corte61.AnimationSpeed = 200;
            this.corte61.BackColor = System.Drawing.Color.Transparent;
            this.corte61.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte61.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte61.BorderRadius = 2;
            this.corte61.BorderThickness = 2;
            this.corte61.ColorContrastOnClick = 30;
            this.corte61.ColorContrastOnHover = 30;
            this.corte61.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte61.Image = null;
            this.corte61.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte61.Location = new System.Drawing.Point(3, 1175);
            this.corte61.Name = "corte61";
            this.corte61.ShowBorders = true;
            this.corte61.Size = new System.Drawing.Size(355, 287);
            this.corte61.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte61.TabIndex = 8;
            // 
            // corte71
            // 
            this.corte71.AllowAnimations = false;
            this.corte71.AllowBorderColorChanges = false;
            this.corte71.AllowMouseEffects = false;
            this.corte71.AnimationSpeed = 200;
            this.corte71.BackColor = System.Drawing.Color.Transparent;
            this.corte71.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte71.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte71.BorderRadius = 2;
            this.corte71.BorderThickness = 2;
            this.corte71.ColorContrastOnClick = 30;
            this.corte71.ColorContrastOnHover = 30;
            this.corte71.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte71.Image = null;
            this.corte71.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte71.Location = new System.Drawing.Point(364, 1175);
            this.corte71.Name = "corte71";
            this.corte71.ShowBorders = true;
            this.corte71.Size = new System.Drawing.Size(355, 287);
            this.corte71.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte71.TabIndex = 9;
            // 
            // corte81
            // 
            this.corte81.AllowAnimations = false;
            this.corte81.AllowBorderColorChanges = false;
            this.corte81.AllowMouseEffects = false;
            this.corte81.AnimationSpeed = 200;
            this.corte81.BackColor = System.Drawing.Color.Transparent;
            this.corte81.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte81.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte81.BorderRadius = 2;
            this.corte81.BorderThickness = 2;
            this.corte81.ColorContrastOnClick = 30;
            this.corte81.ColorContrastOnHover = 30;
            this.corte81.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte81.Image = null;
            this.corte81.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte81.Location = new System.Drawing.Point(3, 1468);
            this.corte81.Name = "corte81";
            this.corte81.ShowBorders = true;
            this.corte81.Size = new System.Drawing.Size(355, 287);
            this.corte81.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte81.TabIndex = 10;
            // 
            // corte91
            // 
            this.corte91.AllowAnimations = false;
            this.corte91.AllowBorderColorChanges = false;
            this.corte91.AllowMouseEffects = false;
            this.corte91.AnimationSpeed = 200;
            this.corte91.BackColor = System.Drawing.Color.Transparent;
            this.corte91.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.corte91.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.corte91.BorderRadius = 2;
            this.corte91.BorderThickness = 2;
            this.corte91.ColorContrastOnClick = 30;
            this.corte91.ColorContrastOnHover = 30;
            this.corte91.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corte91.Image = null;
            this.corte91.ImageMargin = new System.Windows.Forms.Padding(0);
            this.corte91.Location = new System.Drawing.Point(364, 1468);
            this.corte91.Name = "corte91";
            this.corte91.ShowBorders = true;
            this.corte91.Size = new System.Drawing.Size(355, 287);
            this.corte91.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.corte91.TabIndex = 11;
            // 
            // cote101
            // 
            this.cote101.AllowAnimations = false;
            this.cote101.AllowBorderColorChanges = false;
            this.cote101.AllowMouseEffects = false;
            this.cote101.AnimationSpeed = 200;
            this.cote101.BackColor = System.Drawing.Color.Transparent;
            this.cote101.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cote101.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.cote101.BorderRadius = 2;
            this.cote101.BorderThickness = 2;
            this.cote101.ColorContrastOnClick = 30;
            this.cote101.ColorContrastOnHover = 30;
            this.cote101.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cote101.Image = null;
            this.cote101.ImageMargin = new System.Windows.Forms.Padding(0);
            this.cote101.Location = new System.Drawing.Point(3, 1761);
            this.cote101.Name = "cote101";
            this.cote101.ShowBorders = true;
            this.cote101.Size = new System.Drawing.Size(355, 287);
            this.cote101.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.cote101.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 720);
            this.Controls.Add(this.pg_paginas);
            this.Controls.Add(this.sidebar);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.pg_paginas.ResumeLayout(false);
            this.pg_cortes.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel sidebar;
        private Bunifu.UI.WinForms.BunifuPages pg_paginas;
        private System.Windows.Forms.TabPage pg_cortes;
        private System.Windows.Forms.TabPage pg_melhores;
        private System.Windows.Forms.Timer sideBarAnimation;
        private System.Windows.Forms.TabPage pg_barbeiros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private corte corte1;
        private corte11 corte111;
        private corte12 corte121;
        private corte1 corte11;
        private corte2 corte21;
        private corte3 corte31;
        private corte4 corte41;
        private corte5 corte51;
        private corte6 corte61;
        private corte7 corte71;
        private corte8 corte81;
        private corte9 corte91;
        private cote10 cote101;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

