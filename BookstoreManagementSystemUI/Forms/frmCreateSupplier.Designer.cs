namespace BookstoreManagementSystemUI.Forms
{
	partial class frmCreateSupplier
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
            tableLayoutPanel1 = new TableLayoutPanel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox3 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            materialMaskedTextBox4 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(materialButton1, 2, 4);
            tableLayoutPanel1.Controls.Add(materialMaskedTextBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(materialMaskedTextBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(materialMaskedTextBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(materialMaskedTextBox4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 74);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(572, 303);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Fill;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(381, 232);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(177, 55);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "Create Supplier";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            tableLayoutPanel1.SetColumnSpan(materialMaskedTextBox1, 3);
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Dock = DockStyle.Fill;
            materialMaskedTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "Name";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(13, 13);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(546, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 1;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialMaskedTextBox2
            // 
            materialMaskedTextBox2.AllowPromptAsInput = true;
            materialMaskedTextBox2.AnimateReadOnly = false;
            materialMaskedTextBox2.AsciiOnly = false;
            materialMaskedTextBox2.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox2.BeepOnError = false;
            tableLayoutPanel1.SetColumnSpan(materialMaskedTextBox2, 3);
            materialMaskedTextBox2.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.Depth = 0;
            materialMaskedTextBox2.Dock = DockStyle.Fill;
            materialMaskedTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox2.HidePromptOnLeave = false;
            materialMaskedTextBox2.HideSelection = true;
            materialMaskedTextBox2.Hint = "Email";
            materialMaskedTextBox2.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox2.LeadingIcon = null;
            materialMaskedTextBox2.Location = new Point(13, 67);
            materialMaskedTextBox2.Mask = "";
            materialMaskedTextBox2.MaxLength = 32767;
            materialMaskedTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            materialMaskedTextBox2.PasswordChar = '\0';
            materialMaskedTextBox2.PrefixSuffixText = null;
            materialMaskedTextBox2.PromptChar = '_';
            materialMaskedTextBox2.ReadOnly = false;
            materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            materialMaskedTextBox2.ResetOnPrompt = true;
            materialMaskedTextBox2.ResetOnSpace = true;
            materialMaskedTextBox2.RightToLeft = RightToLeft.No;
            materialMaskedTextBox2.SelectedText = "";
            materialMaskedTextBox2.SelectionLength = 0;
            materialMaskedTextBox2.SelectionStart = 0;
            materialMaskedTextBox2.ShortcutsEnabled = true;
            materialMaskedTextBox2.Size = new Size(546, 48);
            materialMaskedTextBox2.SkipLiterals = true;
            materialMaskedTextBox2.TabIndex = 2;
            materialMaskedTextBox2.TabStop = false;
            materialMaskedTextBox2.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox2.TrailingIcon = null;
            materialMaskedTextBox2.UseSystemPasswordChar = false;
            materialMaskedTextBox2.ValidatingType = null;
            // 
            // materialMaskedTextBox3
            // 
            materialMaskedTextBox3.AllowPromptAsInput = true;
            materialMaskedTextBox3.AnimateReadOnly = false;
            materialMaskedTextBox3.AsciiOnly = false;
            materialMaskedTextBox3.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox3.BeepOnError = false;
            tableLayoutPanel1.SetColumnSpan(materialMaskedTextBox3, 3);
            materialMaskedTextBox3.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox3.Depth = 0;
            materialMaskedTextBox3.Dock = DockStyle.Fill;
            materialMaskedTextBox3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox3.HidePromptOnLeave = false;
            materialMaskedTextBox3.HideSelection = true;
            materialMaskedTextBox3.Hint = "Phone Number";
            materialMaskedTextBox3.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox3.LeadingIcon = null;
            materialMaskedTextBox3.Location = new Point(13, 121);
            materialMaskedTextBox3.Mask = "";
            materialMaskedTextBox3.MaxLength = 32767;
            materialMaskedTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox3.Name = "materialMaskedTextBox3";
            materialMaskedTextBox3.PasswordChar = '\0';
            materialMaskedTextBox3.PrefixSuffixText = null;
            materialMaskedTextBox3.PromptChar = '_';
            materialMaskedTextBox3.ReadOnly = false;
            materialMaskedTextBox3.RejectInputOnFirstFailure = false;
            materialMaskedTextBox3.ResetOnPrompt = true;
            materialMaskedTextBox3.ResetOnSpace = true;
            materialMaskedTextBox3.RightToLeft = RightToLeft.No;
            materialMaskedTextBox3.SelectedText = "";
            materialMaskedTextBox3.SelectionLength = 0;
            materialMaskedTextBox3.SelectionStart = 0;
            materialMaskedTextBox3.ShortcutsEnabled = true;
            materialMaskedTextBox3.Size = new Size(546, 48);
            materialMaskedTextBox3.SkipLiterals = true;
            materialMaskedTextBox3.TabIndex = 3;
            materialMaskedTextBox3.TabStop = false;
            materialMaskedTextBox3.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox3.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox3.TrailingIcon = null;
            materialMaskedTextBox3.UseSystemPasswordChar = false;
            materialMaskedTextBox3.ValidatingType = null;
            // 
            // materialMaskedTextBox4
            // 
            materialMaskedTextBox4.AllowPromptAsInput = true;
            materialMaskedTextBox4.AnimateReadOnly = false;
            materialMaskedTextBox4.AsciiOnly = false;
            materialMaskedTextBox4.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox4.BeepOnError = false;
            tableLayoutPanel1.SetColumnSpan(materialMaskedTextBox4, 3);
            materialMaskedTextBox4.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox4.Depth = 0;
            materialMaskedTextBox4.Dock = DockStyle.Fill;
            materialMaskedTextBox4.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox4.HidePromptOnLeave = false;
            materialMaskedTextBox4.HideSelection = true;
            materialMaskedTextBox4.Hint = "Address";
            materialMaskedTextBox4.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox4.LeadingIcon = null;
            materialMaskedTextBox4.Location = new Point(13, 175);
            materialMaskedTextBox4.Mask = "";
            materialMaskedTextBox4.MaxLength = 32767;
            materialMaskedTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox4.Name = "materialMaskedTextBox4";
            materialMaskedTextBox4.PasswordChar = '\0';
            materialMaskedTextBox4.PrefixSuffixText = null;
            materialMaskedTextBox4.PromptChar = '_';
            materialMaskedTextBox4.ReadOnly = false;
            materialMaskedTextBox4.RejectInputOnFirstFailure = false;
            materialMaskedTextBox4.ResetOnPrompt = true;
            materialMaskedTextBox4.ResetOnSpace = true;
            materialMaskedTextBox4.RightToLeft = RightToLeft.No;
            materialMaskedTextBox4.SelectedText = "";
            materialMaskedTextBox4.SelectionLength = 0;
            materialMaskedTextBox4.SelectionStart = 0;
            materialMaskedTextBox4.ShortcutsEnabled = true;
            materialMaskedTextBox4.Size = new Size(546, 48);
            materialMaskedTextBox4.SkipLiterals = true;
            materialMaskedTextBox4.TabIndex = 4;
            materialMaskedTextBox4.TabStop = false;
            materialMaskedTextBox4.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox4.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox4.TrailingIcon = null;
            materialMaskedTextBox4.UseSystemPasswordChar = false;
            materialMaskedTextBox4.ValidatingType = null;
            // 
            // frmCreateSupplier
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 380);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(580, 380);
            MinimumSize = new Size(580, 380);
            Name = "frmCreateSupplier";
            Padding = new Padding(4, 74, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Supplier";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
		private MaterialSkin.Controls.MaterialButton materialButton1;
		private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
		private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
		private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox3;
		private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox4;
	}
}