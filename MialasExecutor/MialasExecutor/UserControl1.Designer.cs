namespace MialasExecutor
{
    partial class UserControl1
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(376, 25);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CaretBlinking = false;
            this.fastColoredTextBox1.CaretColor = System.Drawing.Color.SlateGray;
            this.fastColoredTextBox1.ChangedLineColor = System.Drawing.Color.Empty;
            this.fastColoredTextBox1.CharHeight = 25;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.CurrentLineColor = System.Drawing.Color.Empty;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DelayedEventsInterval = 300;
            this.fastColoredTextBox1.DelayedTextChangedInterval = 300;
            this.fastColoredTextBox1.DescriptionFile = "";
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.Red;
            this.fastColoredTextBox1.FindEndOfFoldingBlockStrategy = FastColoredTextBoxNS.FindEndOfFoldingBlockStrategy.Strategy2;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Cascadia Code", 9.75F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.LeftPadding = 5;
            this.fastColoredTextBox1.LineInterval = 10;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.DimGray;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(29, 67);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.PreferredLineWidth = 5;
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.SelectionHighlightingForLineBreaksEnabled = false;
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.Empty;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(593, 263);
            this.fastColoredTextBox1.SourceTextBox = this.fastColoredTextBox1;
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Text = "How to zoom a button while in mouse over in";
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.fastColoredTextBox1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(199)))));
            this.guna2Button1.Location = new System.Drawing.Point(29, 346);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Size = new System.Drawing.Size(100, 35);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Clear";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 8;
            this.guna2Elipse2.TargetControl = this.guna2Button1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 8;
            this.guna2Elipse3.TargetControl = this.guna2Button3;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button3.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(199)))));
            this.guna2Button3.Location = new System.Drawing.Point(398, 346);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Size = new System.Drawing.Size(100, 35);
            this.guna2Button3.TabIndex = 3;
            this.guna2Button3.Text = "Attach";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.guna2Button4;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button4.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(199)))));
            this.guna2Button4.Location = new System.Drawing.Point(521, 346);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Size = new System.Drawing.Size(100, 35);
            this.guna2Button4.TabIndex = 4;
            this.guna2Button4.Text = "Execute";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.guna2Button1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::MialasExecutor.Properties.Resources.logo1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(309, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button2.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(199)))));
            this.guna2Button2.Location = new System.Drawing.Point(275, 346);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Size = new System.Drawing.Size(100, 35);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Text = "Save";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(41)))));
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button5.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(199)))));
            this.guna2Button5.Location = new System.Drawing.Point(152, 346);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Size = new System.Drawing.Size(100, 35);
            this.guna2Button5.TabIndex = 7;
            this.guna2Button5.Text = "Open";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.guna2Button2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.TargetControl = this.guna2Button5;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(199)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(605, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(199)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(560, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 9;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MialasExecutor.Properties.Resources.Background__2_;
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(650, 400);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Leave += new System.EventHandler(this.UserControl1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}
