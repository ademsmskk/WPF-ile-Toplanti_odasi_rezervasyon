
namespace toplantı_odası_rezervazsyon
{
    partial class frmOdaSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdaSec));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(775, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.AllowAnimations = true;
            this.button1.AllowMouseEffects = true;
            this.button1.AllowToggling = false;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AnimationSpeed = 200;
            this.button1.AutoGenerateColors = false;
            this.button1.AutoRoundBorders = false;
            this.button1.AutoSizeLeftIcon = true;
            this.button1.AutoSizeRightIcon = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackColor1 = System.Drawing.Color.Wheat;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.ButtonText = "Seçilen Odayı Rezerve Et";
            this.button1.ButtonTextMarginLeft = 0;
            this.button1.ColorContrastOnClick = 45;
            this.button1.ColorContrastOnHover = 45;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.button1.CustomizableEdges = borderEdges2;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button1.IconMarginLeft = 11;
            this.button1.IconPadding = 10;
            this.button1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button1.IconSize = 25;
            this.button1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.IdleBorderRadius = 1;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleFillColor = System.Drawing.Color.Wheat;
            this.button1.IdleIconLeftImage = null;
            this.button1.IdleIconRightImage = null;
            this.button1.IndicateFocus = false;
            this.button1.Location = new System.Drawing.Point(201, 363);
            this.button1.Name = "button1";
            this.button1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button1.OnDisabledState.BorderRadius = 1;
            this.button1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.OnDisabledState.BorderThickness = 1;
            this.button1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button1.OnDisabledState.IconLeftImage = null;
            this.button1.OnDisabledState.IconRightImage = null;
            this.button1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.onHoverState.BorderRadius = 1;
            this.button1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.onHoverState.BorderThickness = 1;
            this.button1.onHoverState.FillColor = System.Drawing.Color.NavajoWhite;
            this.button1.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.button1.onHoverState.IconLeftImage = null;
            this.button1.onHoverState.IconRightImage = null;
            this.button1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.OnIdleState.BorderRadius = 1;
            this.button1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.OnIdleState.BorderThickness = 1;
            this.button1.OnIdleState.FillColor = System.Drawing.Color.Wheat;
            this.button1.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.button1.OnIdleState.IconLeftImage = null;
            this.button1.OnIdleState.IconRightImage = null;
            this.button1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button1.OnPressedState.BorderRadius = 1;
            this.button1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button1.OnPressedState.BorderThickness = 1;
            this.button1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button1.OnPressedState.IconLeftImage = null;
            this.button1.OnPressedState.IconRightImage = null;
            this.button1.Size = new System.Drawing.Size(407, 39);
            this.button1.TabIndex = 8;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.TextMarginLeft = 0;
            this.button1.TextPadding = new System.Windows.Forms.Padding(0);
            this.button1.UseDefaultRadiusAndThickness = true;
            this.button1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ODA ÖZELLİKLERİ";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::toplantı_odası_rezervazsyon.Properties.Resources.backpng3;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(709, 363);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(90, 90);
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frmOdaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::toplantı_odası_rezervazsyon.Properties.Resources.color;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOdaSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOdaSec";
            this.Load += new System.EventHandler(this.frmOdaSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
    }
}