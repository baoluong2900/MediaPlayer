
using System;

namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBrowse = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPlayList = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.HSVolume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnSpeaker = new System.Windows.Forms.PictureBox();
            this.btnMute = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblNameSong = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuButton2);
            this.bunifuPanel1.Controls.Add(this.bunifuButton1);
            this.bunifuPanel1.Controls.Add(this.btnBrowse);
            this.bunifuPanel1.Controls.Add(this.btnPlaying);
            this.bunifuPanel1.Controls.Add(this.btnPlayList);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(256, 675);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Settings";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges1;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(0, 553);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 1;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.BorderRadius = 1;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.OnIdleState.BorderRadius = 1;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.Magenta;
            this.bunifuButton2.OnPressedState.BorderRadius = 1;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.Magenta;
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(253, 58);
            this.bunifuButton2.TabIndex = 13;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Help";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(0, 617);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Magenta;
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.Magenta;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(253, 58);
            this.bunifuButton1.TabIndex = 12;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AllowAnimations = true;
            this.btnBrowse.AllowMouseEffects = true;
            this.btnBrowse.AllowToggling = false;
            this.btnBrowse.AnimationSpeed = 200;
            this.btnBrowse.AutoGenerateColors = false;
            this.btnBrowse.AutoRoundBorders = false;
            this.btnBrowse.AutoSizeLeftIcon = true;
            this.btnBrowse.AutoSizeRightIcon = true;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackColor1 = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.ButtonText = "Browse";
            this.btnBrowse.ButtonTextMarginLeft = 0;
            this.btnBrowse.ColorContrastOnClick = 45;
            this.btnBrowse.ColorContrastOnHover = 45;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnBrowse.CustomizableEdges = borderEdges3;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowse.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBrowse.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBrowse.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBrowse.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.DimGray;
            this.btnBrowse.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBrowse.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBrowse.IconMarginLeft = 11;
            this.btnBrowse.IconPadding = 10;
            this.btnBrowse.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBrowse.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBrowse.IconSize = 25;
            this.btnBrowse.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnBrowse.IdleBorderRadius = 1;
            this.btnBrowse.IdleBorderThickness = 1;
            this.btnBrowse.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnBrowse.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.IdleIconLeftImage")));
            this.btnBrowse.IdleIconRightImage = null;
            this.btnBrowse.IndicateFocus = false;
            this.btnBrowse.Location = new System.Drawing.Point(0, 358);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBrowse.OnDisabledState.BorderRadius = 1;
            this.btnBrowse.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnDisabledState.BorderThickness = 1;
            this.btnBrowse.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBrowse.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBrowse.OnDisabledState.IconLeftImage = null;
            this.btnBrowse.OnDisabledState.IconRightImage = null;
            this.btnBrowse.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBrowse.onHoverState.BorderRadius = 1;
            this.btnBrowse.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.onHoverState.BorderThickness = 1;
            this.btnBrowse.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBrowse.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.onHoverState.IconLeftImage = null;
            this.btnBrowse.onHoverState.IconRightImage = null;
            this.btnBrowse.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBrowse.OnIdleState.BorderRadius = 1;
            this.btnBrowse.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnIdleState.BorderThickness = 1;
            this.btnBrowse.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnBrowse.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnBrowse.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.OnIdleState.IconLeftImage")));
            this.btnBrowse.OnIdleState.IconRightImage = null;
            this.btnBrowse.OnPressedState.BorderColor = System.Drawing.Color.Magenta;
            this.btnBrowse.OnPressedState.BorderRadius = 1;
            this.btnBrowse.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnBrowse.OnPressedState.BorderThickness = 1;
            this.btnBrowse.OnPressedState.FillColor = System.Drawing.Color.Magenta;
            this.btnBrowse.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.OnPressedState.IconLeftImage = null;
            this.btnBrowse.OnPressedState.IconRightImage = null;
            this.btnBrowse.Size = new System.Drawing.Size(253, 58);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowse.TextMarginLeft = 0;
            this.btnBrowse.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBrowse.UseDefaultRadiusAndThickness = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnPlaying
            // 
            this.btnPlaying.AllowAnimations = true;
            this.btnPlaying.AllowMouseEffects = true;
            this.btnPlaying.AllowToggling = false;
            this.btnPlaying.AnimationSpeed = 200;
            this.btnPlaying.AutoGenerateColors = false;
            this.btnPlaying.AutoRoundBorders = false;
            this.btnPlaying.AutoSizeLeftIcon = true;
            this.btnPlaying.AutoSizeRightIcon = true;
            this.btnPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaying.BackColor1 = System.Drawing.Color.Transparent;
            this.btnPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaying.BackgroundImage")));
            this.btnPlaying.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.ButtonText = "Now Playing";
            this.btnPlaying.ButtonTextMarginLeft = 0;
            this.btnPlaying.ColorContrastOnClick = 45;
            this.btnPlaying.ColorContrastOnHover = 45;
            this.btnPlaying.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnPlaying.CustomizableEdges = borderEdges4;
            this.btnPlaying.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaying.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaying.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaying.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaying.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlaying.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaying.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlaying.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaying.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaying.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlaying.IconMarginLeft = 11;
            this.btnPlaying.IconPadding = 10;
            this.btnPlaying.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaying.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlaying.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlaying.IconSize = 25;
            this.btnPlaying.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPlaying.IdleBorderRadius = 1;
            this.btnPlaying.IdleBorderThickness = 1;
            this.btnPlaying.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPlaying.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPlaying.IdleIconLeftImage")));
            this.btnPlaying.IdleIconRightImage = null;
            this.btnPlaying.IndicateFocus = false;
            this.btnPlaying.Location = new System.Drawing.Point(0, 195);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaying.OnDisabledState.BorderRadius = 1;
            this.btnPlaying.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnDisabledState.BorderThickness = 1;
            this.btnPlaying.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaying.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaying.OnDisabledState.IconLeftImage = null;
            this.btnPlaying.OnDisabledState.IconRightImage = null;
            this.btnPlaying.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlaying.onHoverState.BorderRadius = 1;
            this.btnPlaying.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.onHoverState.BorderThickness = 1;
            this.btnPlaying.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPlaying.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPlaying.onHoverState.IconLeftImage = null;
            this.btnPlaying.onHoverState.IconRightImage = null;
            this.btnPlaying.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaying.OnIdleState.BorderRadius = 1;
            this.btnPlaying.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnIdleState.BorderThickness = 1;
            this.btnPlaying.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaying.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlaying.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPlaying.OnIdleState.IconLeftImage")));
            this.btnPlaying.OnIdleState.IconRightImage = null;
            this.btnPlaying.OnPressedState.BorderColor = System.Drawing.Color.Magenta;
            this.btnPlaying.OnPressedState.BorderRadius = 1;
            this.btnPlaying.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaying.OnPressedState.BorderThickness = 1;
            this.btnPlaying.OnPressedState.FillColor = System.Drawing.Color.Magenta;
            this.btnPlaying.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPlaying.OnPressedState.IconLeftImage = null;
            this.btnPlaying.OnPressedState.IconRightImage = null;
            this.btnPlaying.Size = new System.Drawing.Size(253, 58);
            this.btnPlaying.TabIndex = 3;
            this.btnPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaying.TextMarginLeft = 0;
            this.btnPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPlaying.UseDefaultRadiusAndThickness = true;
            this.btnPlaying.Click += new System.EventHandler(this.btnPlaying_Click);
            // 
            // btnPlayList
            // 
            this.btnPlayList.AllowAnimations = true;
            this.btnPlayList.AllowMouseEffects = true;
            this.btnPlayList.AllowToggling = false;
            this.btnPlayList.AnimationSpeed = 200;
            this.btnPlayList.AutoGenerateColors = false;
            this.btnPlayList.AutoRoundBorders = false;
            this.btnPlayList.AutoSizeLeftIcon = true;
            this.btnPlayList.AutoSizeRightIcon = true;
            this.btnPlayList.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayList.BackColor1 = System.Drawing.Color.Transparent;
            this.btnPlayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayList.BackgroundImage")));
            this.btnPlayList.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlayList.ButtonText = "Play List";
            this.btnPlayList.ButtonTextMarginLeft = 0;
            this.btnPlayList.ColorContrastOnClick = 45;
            this.btnPlayList.ColorContrastOnHover = 45;
            this.btnPlayList.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnPlayList.CustomizableEdges = borderEdges5;
            this.btnPlayList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlayList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlayList.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlayList.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlayList.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlayList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayList.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlayList.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayList.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayList.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlayList.IconMarginLeft = 11;
            this.btnPlayList.IconPadding = 10;
            this.btnPlayList.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayList.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayList.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlayList.IconSize = 25;
            this.btnPlayList.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPlayList.IdleBorderRadius = 1;
            this.btnPlayList.IdleBorderThickness = 1;
            this.btnPlayList.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPlayList.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPlayList.IdleIconLeftImage")));
            this.btnPlayList.IdleIconRightImage = null;
            this.btnPlayList.IndicateFocus = false;
            this.btnPlayList.Location = new System.Drawing.Point(-3, 273);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlayList.OnDisabledState.BorderRadius = 1;
            this.btnPlayList.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlayList.OnDisabledState.BorderThickness = 1;
            this.btnPlayList.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlayList.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlayList.OnDisabledState.IconLeftImage = null;
            this.btnPlayList.OnDisabledState.IconRightImage = null;
            this.btnPlayList.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlayList.onHoverState.BorderRadius = 1;
            this.btnPlayList.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlayList.onHoverState.BorderThickness = 1;
            this.btnPlayList.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPlayList.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPlayList.onHoverState.IconLeftImage = null;
            this.btnPlayList.onHoverState.IconRightImage = null;
            this.btnPlayList.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlayList.OnIdleState.BorderRadius = 1;
            this.btnPlayList.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlayList.OnIdleState.BorderThickness = 1;
            this.btnPlayList.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlayList.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlayList.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPlayList.OnIdleState.IconLeftImage")));
            this.btnPlayList.OnIdleState.IconRightImage = null;
            this.btnPlayList.OnPressedState.BorderColor = System.Drawing.Color.Magenta;
            this.btnPlayList.OnPressedState.BorderRadius = 1;
            this.btnPlayList.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlayList.OnPressedState.BorderThickness = 1;
            this.btnPlayList.OnPressedState.FillColor = System.Drawing.Color.Magenta;
            this.btnPlayList.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPlayList.OnPressedState.IconLeftImage = null;
            this.btnPlayList.OnPressedState.IconRightImage = null;
            this.btnPlayList.Size = new System.Drawing.Size(253, 58);
            this.btnPlayList.TabIndex = 10;
            this.btnPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayList.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlayList.TextMarginLeft = 0;
            this.btnPlayList.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPlayList.UseDefaultRadiusAndThickness = true;
            this.btnPlayList.Click += new System.EventHandler(this.btnPlayList_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(74, 114);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(92, 25);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Bảo Lương";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 41;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(83, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(83, 83);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Purple;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.pictureBox3);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel2.Controls.Add(this.HSVolume);
            this.bunifuPanel2.Controls.Add(this.btnSpeaker);
            this.bunifuPanel2.Controls.Add(this.btnMute);
            this.bunifuPanel2.Controls.Add(this.Play);
            this.bunifuPanel2.Controls.Add(this.Pause);
            this.bunifuPanel2.Controls.Add(this.pictureBox2);
            this.bunifuPanel2.Controls.Add(this.pictureBox1);
            this.bunifuPanel2.Controls.Add(this.bunifuHSlider1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel2.Location = new System.Drawing.Point(256, 603);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(910, 72);
            this.bunifuPanel2.TabIndex = 1;
            this.bunifuPanel2.Click += new System.EventHandler(this.bunifuPanel2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(99, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel2.Location = new System.Drawing.Point(639, 33);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(31, 21);
            this.bunifuLabel2.TabIndex = 10;
            this.bunifuLabel2.Text = "0.00";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // HSVolume
            // 
            this.HSVolume.AllowCursorChanges = true;
            this.HSVolume.AllowHomeEndKeysDetection = false;
            this.HSVolume.AllowIncrementalClickMoves = true;
            this.HSVolume.AllowMouseDownEffects = false;
            this.HSVolume.AllowMouseHoverEffects = false;
            this.HSVolume.AllowScrollingAnimations = true;
            this.HSVolume.AllowScrollKeysDetection = true;
            this.HSVolume.AllowScrollOptionsMenu = true;
            this.HSVolume.AllowShrinkingOnFocusLost = false;
            this.HSVolume.BackColor = System.Drawing.Color.Transparent;
            this.HSVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HSVolume.BackgroundImage")));
            this.HSVolume.BindingContainer = null;
            this.HSVolume.BorderRadius = 2;
            this.HSVolume.BorderThickness = 1;
            this.HSVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HSVolume.DrawThickBorder = false;
            this.HSVolume.DurationBeforeShrink = 2000;
            this.HSVolume.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HSVolume.LargeChange = 10;
            this.HSVolume.Location = new System.Drawing.Point(724, 29);
            this.HSVolume.Maximum = 100;
            this.HSVolume.Minimum = 0;
            this.HSVolume.MinimumSize = new System.Drawing.Size(0, 31);
            this.HSVolume.MinimumThumbLength = 18;
            this.HSVolume.Name = "HSVolume";
            this.HSVolume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.HSVolume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.HSVolume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.HSVolume.ScrollBarBorderColor = System.Drawing.Color.White;
            this.HSVolume.ScrollBarColor = System.Drawing.Color.White;
            this.HSVolume.ShrinkSizeLimit = 3;
            this.HSVolume.Size = new System.Drawing.Size(126, 31);
            this.HSVolume.SliderColor = System.Drawing.Color.White;
            this.HSVolume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.HSVolume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.HSVolume.SmallChange = 1;
            this.HSVolume.TabIndex = 9;
            this.HSVolume.ThumbColor = System.Drawing.Color.Magenta;
            this.HSVolume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.HSVolume.ThumbLength = 18;
            this.HSVolume.ThumbMargin = 1;
            this.HSVolume.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.HSVolume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.HSVolume.Value = 50;
            this.HSVolume.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider2_Scroll);
            // 
            // btnSpeaker
            // 
            this.btnSpeaker.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeaker.Image")));
            this.btnSpeaker.Location = new System.Drawing.Point(868, 29);
            this.btnSpeaker.Name = "btnSpeaker";
            this.btnSpeaker.Size = new System.Drawing.Size(30, 30);
            this.btnSpeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSpeaker.TabIndex = 8;
            this.btnSpeaker.TabStop = false;
            this.btnSpeaker.Click += new System.EventHandler(this.btnSpeaker_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.Location = new System.Drawing.Point(688, 30);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(30, 30);
            this.btnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMute.TabIndex = 7;
            this.btnMute.TabStop = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.Location = new System.Drawing.Point(51, 30);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(30, 30);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Play.TabIndex = 6;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.Location = new System.Drawing.Point(51, 30);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(30, 30);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pause.TabIndex = 5;
            this.Pause.TabStop = false;
            this.Pause.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(135, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.LargeChange = 10;
            this.bunifuHSlider1.Location = new System.Drawing.Point(171, 29);
            this.bunifuHSlider1.Maximum = 100;
            this.bunifuHSlider1.Minimum = 0;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.White;
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.White;
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(450, 31);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.White;
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 0;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.Magenta;
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 44;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 50;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.lblNameSong);
            this.bunifuPanel3.Controls.Add(this.pictureBox7);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel3.Location = new System.Drawing.Point(256, 0);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(910, 55);
            this.bunifuPanel3.TabIndex = 2;
            // 
            // lblNameSong
            // 
            this.lblNameSong.AllowParentOverrides = false;
            this.lblNameSong.AutoEllipsis = false;
            this.lblNameSong.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNameSong.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNameSong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSong.ForeColor = System.Drawing.Color.DimGray;
            this.lblNameSong.Location = new System.Drawing.Point(19, 17);
            this.lblNameSong.Name = "lblNameSong";
            this.lblNameSong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameSong.Size = new System.Drawing.Size(155, 25);
            this.lblNameSong.TabIndex = 4;
            this.lblNameSong.Text = "Song Name - Title";
            this.lblNameSong.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNameSong.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(868, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click_1);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(256, 55);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(910, 548);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(256, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(910, 548);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1166, 675);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlaying;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuHSlider HSVolume;
        private System.Windows.Forms.PictureBox btnSpeaker;
        private System.Windows.Forms.PictureBox btnMute;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnBrowse;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlayList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblNameSong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

