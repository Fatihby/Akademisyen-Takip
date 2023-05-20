namespace DouYonetim.KullanıcıDenetimi
{
    partial class TariheGoreArama
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariheGoreArama));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bts = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bslngc = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.gosterbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tablo = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(329, 118);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(54, 15);
            this.bunifuLabel2.TabIndex = 31;
            this.bunifuLabel2.Text = "Bitiş Tarihi";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(111, 118);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(82, 15);
            this.bunifuLabel1.TabIndex = 30;
            this.bunifuLabel1.Text = "Başlangıç Tarihi";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "-";
            // 
            // bts
            // 
            this.bts.BackColor = System.Drawing.Color.Transparent;
            this.bts.BorderRadius = 1;
            this.bts.Color = System.Drawing.Color.Silver;
            this.bts.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bts.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bts.DisabledColor = System.Drawing.Color.Gray;
            this.bts.DisplayWeekNumbers = false;
            this.bts.DPHeight = 0;
            this.bts.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bts.FillDatePicker = false;
            this.bts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bts.ForeColor = System.Drawing.Color.Black;
            this.bts.Icon = ((System.Drawing.Image)(resources.GetObject("bts.Icon")));
            this.bts.IconColor = System.Drawing.Color.Gray;
            this.bts.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bts.LeftTextMargin = 5;
            this.bts.Location = new System.Drawing.Point(265, 139);
            this.bts.MinimumSize = new System.Drawing.Size(4, 32);
            this.bts.Name = "bts";
            this.bts.Size = new System.Drawing.Size(182, 32);
            this.bts.TabIndex = 27;
            this.bts.Value = new System.DateTime(2022, 12, 29, 18, 58, 0, 0);
            // 
            // bslngc
            // 
            this.bslngc.BackColor = System.Drawing.Color.Transparent;
            this.bslngc.BorderRadius = 1;
            this.bslngc.Color = System.Drawing.Color.Silver;
            this.bslngc.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bslngc.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bslngc.DisabledColor = System.Drawing.Color.Gray;
            this.bslngc.DisplayWeekNumbers = false;
            this.bslngc.DPHeight = 0;
            this.bslngc.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bslngc.FillDatePicker = false;
            this.bslngc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bslngc.ForeColor = System.Drawing.Color.Black;
            this.bslngc.Icon = ((System.Drawing.Image)(resources.GetObject("bslngc.Icon")));
            this.bslngc.IconColor = System.Drawing.Color.Gray;
            this.bslngc.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bslngc.LeftTextMargin = 5;
            this.bslngc.Location = new System.Drawing.Point(61, 139);
            this.bslngc.MinimumSize = new System.Drawing.Size(4, 32);
            this.bslngc.Name = "bslngc";
            this.bslngc.Size = new System.Drawing.Size(182, 32);
            this.bslngc.TabIndex = 28;
            this.bslngc.Value = new System.DateTime(2022, 12, 29, 18, 58, 0, 0);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 47;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(207, 0);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(95, 95);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 32;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // gosterbtn
            // 
            this.gosterbtn.AllowAnimations = true;
            this.gosterbtn.AllowMouseEffects = true;
            this.gosterbtn.AllowToggling = false;
            this.gosterbtn.AnimationSpeed = 200;
            this.gosterbtn.AutoGenerateColors = false;
            this.gosterbtn.AutoRoundBorders = false;
            this.gosterbtn.AutoSizeLeftIcon = true;
            this.gosterbtn.AutoSizeRightIcon = true;
            this.gosterbtn.BackColor = System.Drawing.Color.Transparent;
            this.gosterbtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.gosterbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gosterbtn.BackgroundImage")));
            this.gosterbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.gosterbtn.ButtonText = "Göster";
            this.gosterbtn.ButtonTextMarginLeft = 0;
            this.gosterbtn.ColorContrastOnClick = 45;
            this.gosterbtn.ColorContrastOnHover = 45;
            this.gosterbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.gosterbtn.CustomizableEdges = borderEdges1;
            this.gosterbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gosterbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.gosterbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gosterbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.gosterbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.gosterbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gosterbtn.ForeColor = System.Drawing.Color.White;
            this.gosterbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gosterbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.gosterbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.gosterbtn.IconMarginLeft = 11;
            this.gosterbtn.IconPadding = 10;
            this.gosterbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gosterbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.gosterbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.gosterbtn.IconSize = 25;
            this.gosterbtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.gosterbtn.IdleBorderRadius = 1;
            this.gosterbtn.IdleBorderThickness = 1;
            this.gosterbtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.gosterbtn.IdleIconLeftImage = null;
            this.gosterbtn.IdleIconRightImage = null;
            this.gosterbtn.IndicateFocus = false;
            this.gosterbtn.Location = new System.Drawing.Point(179, 177);
            this.gosterbtn.Name = "gosterbtn";
            this.gosterbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.gosterbtn.OnDisabledState.BorderRadius = 1;
            this.gosterbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.gosterbtn.OnDisabledState.BorderThickness = 1;
            this.gosterbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gosterbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.gosterbtn.OnDisabledState.IconLeftImage = null;
            this.gosterbtn.OnDisabledState.IconRightImage = null;
            this.gosterbtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.gosterbtn.onHoverState.BorderRadius = 1;
            this.gosterbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.gosterbtn.onHoverState.BorderThickness = 1;
            this.gosterbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.gosterbtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.gosterbtn.onHoverState.IconLeftImage = null;
            this.gosterbtn.onHoverState.IconRightImage = null;
            this.gosterbtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gosterbtn.OnIdleState.BorderRadius = 1;
            this.gosterbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.gosterbtn.OnIdleState.BorderThickness = 1;
            this.gosterbtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.gosterbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.gosterbtn.OnIdleState.IconLeftImage = null;
            this.gosterbtn.OnIdleState.IconRightImage = null;
            this.gosterbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.gosterbtn.OnPressedState.BorderRadius = 1;
            this.gosterbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.gosterbtn.OnPressedState.BorderThickness = 1;
            this.gosterbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.gosterbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.gosterbtn.OnPressedState.IconLeftImage = null;
            this.gosterbtn.OnPressedState.IconRightImage = null;
            this.gosterbtn.Size = new System.Drawing.Size(150, 39);
            this.gosterbtn.TabIndex = 33;
            this.gosterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gosterbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.gosterbtn.TextMarginLeft = 0;
            this.gosterbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.gosterbtn.UseDefaultRadiusAndThickness = true;
            this.gosterbtn.Click += new System.EventHandler(this.gosterbtn_Click);
            // 
            // tablo
            // 
            this.tablo.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tablo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablo.ColumnHeadersHeight = 40;
            this.tablo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tablo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tablo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tablo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tablo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tablo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tablo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tablo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tablo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tablo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablo.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tablo.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tablo.CurrentTheme.Name = null;
            this.tablo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tablo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tablo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tablo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablo.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablo.EnableHeadersVisualStyles = false;
            this.tablo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tablo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tablo.HeaderBgColor = System.Drawing.Color.Empty;
            this.tablo.HeaderForeColor = System.Drawing.Color.White;
            this.tablo.Location = new System.Drawing.Point(2, 222);
            this.tablo.Name = "tablo";
            this.tablo.RowHeadersVisible = false;
            this.tablo.RowTemplate.Height = 40;
            this.tablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablo.Size = new System.Drawing.Size(504, 213);
            this.tablo.TabIndex = 34;
            this.tablo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // TariheGoreArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablo);
            this.Controls.Add(this.gosterbtn);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bts);
            this.Controls.Add(this.bslngc);
            this.Name = "TariheGoreArama";
            this.Size = new System.Drawing.Size(510, 438);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDatePicker bts;
        private Bunifu.UI.WinForms.BunifuDatePicker bslngc;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton gosterbtn;
        private Bunifu.UI.WinForms.BunifuDataGridView tablo;
    }
}
