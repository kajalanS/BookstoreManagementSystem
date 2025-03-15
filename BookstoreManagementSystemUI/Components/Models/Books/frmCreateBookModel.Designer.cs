namespace BookstoreManagementSystemUI.Components.Models.Books
{
    partial class frmCreateBookModel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tableLayoutPanel1 = new TableLayoutPanel();
			txtIsbn = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtTitle = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtAuthor = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtPrice = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtPublisher = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtYear = new MaterialSkin.Controls.MaterialMaskedTextBox();
			btnCreateBook = new MaterialSkin.Controls.MaterialButton();
			txtQuantity = new MaterialSkin.Controls.MaterialMaskedTextBox();
			cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
			pbImage = new PictureBox();
			txtLanguage = new MaterialSkin.Controls.MaterialMaskedTextBox();
			materialCard1 = new MaterialSkin.Controls.MaterialCard();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
			materialCard1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.Controls.Add(txtIsbn, 0, 2);
			tableLayoutPanel1.Controls.Add(txtTitle, 0, 0);
			tableLayoutPanel1.Controls.Add(txtAuthor, 0, 1);
			tableLayoutPanel1.Controls.Add(txtPrice, 0, 3);
			tableLayoutPanel1.Controls.Add(txtPublisher, 0, 6);
			tableLayoutPanel1.Controls.Add(txtYear, 0, 7);
			tableLayoutPanel1.Controls.Add(btnCreateBook, 0, 8);
			tableLayoutPanel1.Controls.Add(txtQuantity, 0, 4);
			tableLayoutPanel1.Controls.Add(cmbCategory, 0, 5);
			tableLayoutPanel1.Controls.Add(pbImage, 2, 1);
			tableLayoutPanel1.Controls.Add(txtLanguage, 2, 7);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(15, 15);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 9;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(639, 480);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// txtIsbn
			// 
			txtIsbn.AllowPromptAsInput = true;
			txtIsbn.AnimateReadOnly = false;
			txtIsbn.AsciiOnly = false;
			txtIsbn.BackgroundImageLayout = ImageLayout.None;
			txtIsbn.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtIsbn, 2);
			txtIsbn.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtIsbn.Depth = 0;
			txtIsbn.Dock = DockStyle.Fill;
			txtIsbn.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtIsbn.HidePromptOnLeave = false;
			txtIsbn.HideSelection = true;
			txtIsbn.Hint = "ISBN";
			txtIsbn.InsertKeyMode = InsertKeyMode.Default;
			txtIsbn.LeadingIcon = null;
			txtIsbn.Location = new Point(3, 109);
			txtIsbn.Mask = "";
			txtIsbn.MaxLength = 32767;
			txtIsbn.MouseState = MaterialSkin.MouseState.OUT;
			txtIsbn.Name = "txtIsbn";
			txtIsbn.PasswordChar = '\0';
			txtIsbn.PrefixSuffixText = null;
			txtIsbn.PromptChar = '_';
			txtIsbn.ReadOnly = false;
			txtIsbn.RejectInputOnFirstFailure = false;
			txtIsbn.ResetOnPrompt = true;
			txtIsbn.ResetOnSpace = true;
			txtIsbn.RightToLeft = RightToLeft.No;
			txtIsbn.SelectedText = "";
			txtIsbn.SelectionLength = 0;
			txtIsbn.SelectionStart = 0;
			txtIsbn.ShortcutsEnabled = true;
			txtIsbn.Size = new Size(312, 48);
			txtIsbn.SkipLiterals = true;
			txtIsbn.TabIndex = 10;
			txtIsbn.TabStop = false;
			txtIsbn.TextAlign = HorizontalAlignment.Left;
			txtIsbn.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtIsbn.TrailingIcon = null;
			txtIsbn.UseSystemPasswordChar = false;
			txtIsbn.ValidatingType = null;
			// 
			// txtTitle
			// 
			txtTitle.AllowPromptAsInput = true;
			txtTitle.AnimateReadOnly = false;
			txtTitle.AsciiOnly = false;
			txtTitle.BackgroundImageLayout = ImageLayout.None;
			txtTitle.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtTitle, 4);
			txtTitle.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtTitle.Depth = 0;
			txtTitle.Dock = DockStyle.Fill;
			txtTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtTitle.HidePromptOnLeave = false;
			txtTitle.HideSelection = true;
			txtTitle.Hint = "Title";
			txtTitle.InsertKeyMode = InsertKeyMode.Default;
			txtTitle.LeadingIcon = null;
			txtTitle.Location = new Point(3, 3);
			txtTitle.Mask = "";
			txtTitle.MaxLength = 32767;
			txtTitle.MouseState = MaterialSkin.MouseState.OUT;
			txtTitle.Name = "txtTitle";
			txtTitle.PasswordChar = '\0';
			txtTitle.PrefixSuffixText = null;
			txtTitle.PromptChar = '_';
			txtTitle.ReadOnly = false;
			txtTitle.RejectInputOnFirstFailure = false;
			txtTitle.ResetOnPrompt = true;
			txtTitle.ResetOnSpace = true;
			txtTitle.RightToLeft = RightToLeft.No;
			txtTitle.SelectedText = "";
			txtTitle.SelectionLength = 0;
			txtTitle.SelectionStart = 0;
			txtTitle.ShortcutsEnabled = true;
			txtTitle.Size = new Size(633, 48);
			txtTitle.SkipLiterals = true;
			txtTitle.TabIndex = 0;
			txtTitle.TabStop = false;
			txtTitle.TextAlign = HorizontalAlignment.Left;
			txtTitle.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtTitle.TrailingIcon = null;
			txtTitle.UseSystemPasswordChar = false;
			txtTitle.ValidatingType = null;
			// 
			// txtAuthor
			// 
			txtAuthor.AllowPromptAsInput = true;
			txtAuthor.AnimateReadOnly = false;
			txtAuthor.AsciiOnly = false;
			txtAuthor.BackgroundImageLayout = ImageLayout.None;
			txtAuthor.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtAuthor, 2);
			txtAuthor.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtAuthor.Depth = 0;
			txtAuthor.Dock = DockStyle.Fill;
			txtAuthor.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtAuthor.HidePromptOnLeave = false;
			txtAuthor.HideSelection = true;
			txtAuthor.Hint = "Author";
			txtAuthor.InsertKeyMode = InsertKeyMode.Default;
			txtAuthor.LeadingIcon = null;
			txtAuthor.Location = new Point(3, 56);
			txtAuthor.Mask = "";
			txtAuthor.MaxLength = 32767;
			txtAuthor.MouseState = MaterialSkin.MouseState.OUT;
			txtAuthor.Name = "txtAuthor";
			txtAuthor.PasswordChar = '\0';
			txtAuthor.PrefixSuffixText = null;
			txtAuthor.PromptChar = '_';
			txtAuthor.ReadOnly = false;
			txtAuthor.RejectInputOnFirstFailure = false;
			txtAuthor.ResetOnPrompt = true;
			txtAuthor.ResetOnSpace = true;
			txtAuthor.RightToLeft = RightToLeft.No;
			txtAuthor.SelectedText = "";
			txtAuthor.SelectionLength = 0;
			txtAuthor.SelectionStart = 0;
			txtAuthor.ShortcutsEnabled = true;
			txtAuthor.Size = new Size(312, 48);
			txtAuthor.SkipLiterals = true;
			txtAuthor.TabIndex = 1;
			txtAuthor.TabStop = false;
			txtAuthor.TextAlign = HorizontalAlignment.Left;
			txtAuthor.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtAuthor.TrailingIcon = null;
			txtAuthor.UseSystemPasswordChar = false;
			txtAuthor.ValidatingType = null;
			// 
			// txtPrice
			// 
			txtPrice.AllowPromptAsInput = true;
			txtPrice.AnimateReadOnly = false;
			txtPrice.AsciiOnly = false;
			txtPrice.BackgroundImageLayout = ImageLayout.None;
			txtPrice.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtPrice, 2);
			txtPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtPrice.Depth = 0;
			txtPrice.Dock = DockStyle.Fill;
			txtPrice.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtPrice.HidePromptOnLeave = false;
			txtPrice.HideSelection = true;
			txtPrice.Hint = "Price";
			txtPrice.InsertKeyMode = InsertKeyMode.Default;
			txtPrice.LeadingIcon = null;
			txtPrice.Location = new Point(3, 162);
			txtPrice.Mask = "";
			txtPrice.MaxLength = 32767;
			txtPrice.MouseState = MaterialSkin.MouseState.OUT;
			txtPrice.Name = "txtPrice";
			txtPrice.PasswordChar = '\0';
			txtPrice.PrefixSuffixText = null;
			txtPrice.PromptChar = '_';
			txtPrice.ReadOnly = false;
			txtPrice.RejectInputOnFirstFailure = false;
			txtPrice.ResetOnPrompt = true;
			txtPrice.ResetOnSpace = true;
			txtPrice.RightToLeft = RightToLeft.No;
			txtPrice.SelectedText = "";
			txtPrice.SelectionLength = 0;
			txtPrice.SelectionStart = 0;
			txtPrice.ShortcutsEnabled = true;
			txtPrice.Size = new Size(312, 48);
			txtPrice.SkipLiterals = true;
			txtPrice.TabIndex = 4;
			txtPrice.TabStop = false;
			txtPrice.TextAlign = HorizontalAlignment.Left;
			txtPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtPrice.TrailingIcon = null;
			txtPrice.UseSystemPasswordChar = false;
			txtPrice.ValidatingType = null;
			// 
			// txtPublisher
			// 
			txtPublisher.AllowPromptAsInput = true;
			txtPublisher.AnimateReadOnly = false;
			txtPublisher.AsciiOnly = false;
			txtPublisher.BackgroundImageLayout = ImageLayout.None;
			txtPublisher.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtPublisher, 4);
			txtPublisher.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtPublisher.Depth = 0;
			txtPublisher.Dock = DockStyle.Fill;
			txtPublisher.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtPublisher.HidePromptOnLeave = false;
			txtPublisher.HideSelection = true;
			txtPublisher.Hint = "Publisher";
			txtPublisher.InsertKeyMode = InsertKeyMode.Default;
			txtPublisher.LeadingIcon = null;
			txtPublisher.Location = new Point(3, 321);
			txtPublisher.Mask = "";
			txtPublisher.MaxLength = 32767;
			txtPublisher.MouseState = MaterialSkin.MouseState.OUT;
			txtPublisher.Name = "txtPublisher";
			txtPublisher.PasswordChar = '\0';
			txtPublisher.PrefixSuffixText = null;
			txtPublisher.PromptChar = '_';
			txtPublisher.ReadOnly = false;
			txtPublisher.RejectInputOnFirstFailure = false;
			txtPublisher.ResetOnPrompt = true;
			txtPublisher.ResetOnSpace = true;
			txtPublisher.RightToLeft = RightToLeft.No;
			txtPublisher.SelectedText = "";
			txtPublisher.SelectionLength = 0;
			txtPublisher.SelectionStart = 0;
			txtPublisher.ShortcutsEnabled = true;
			txtPublisher.Size = new Size(633, 48);
			txtPublisher.SkipLiterals = true;
			txtPublisher.TabIndex = 6;
			txtPublisher.TabStop = false;
			txtPublisher.TextAlign = HorizontalAlignment.Left;
			txtPublisher.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtPublisher.TrailingIcon = null;
			txtPublisher.UseSystemPasswordChar = false;
			txtPublisher.ValidatingType = null;
			// 
			// txtYear
			// 
			txtYear.AllowPromptAsInput = true;
			txtYear.AnimateReadOnly = false;
			txtYear.AsciiOnly = false;
			txtYear.BackgroundImageLayout = ImageLayout.None;
			txtYear.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtYear, 2);
			txtYear.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtYear.Depth = 0;
			txtYear.Dock = DockStyle.Fill;
			txtYear.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtYear.HidePromptOnLeave = false;
			txtYear.HideSelection = true;
			txtYear.Hint = "Publication Year";
			txtYear.InsertKeyMode = InsertKeyMode.Default;
			txtYear.LeadingIcon = null;
			txtYear.Location = new Point(3, 374);
			txtYear.Mask = "";
			txtYear.MaxLength = 32767;
			txtYear.MouseState = MaterialSkin.MouseState.OUT;
			txtYear.Name = "txtYear";
			txtYear.PasswordChar = '\0';
			txtYear.PrefixSuffixText = null;
			txtYear.PromptChar = '_';
			txtYear.ReadOnly = false;
			txtYear.RejectInputOnFirstFailure = false;
			txtYear.ResetOnPrompt = true;
			txtYear.ResetOnSpace = true;
			txtYear.RightToLeft = RightToLeft.No;
			txtYear.SelectedText = "";
			txtYear.SelectionLength = 0;
			txtYear.SelectionStart = 0;
			txtYear.ShortcutsEnabled = true;
			txtYear.Size = new Size(312, 48);
			txtYear.SkipLiterals = true;
			txtYear.TabIndex = 7;
			txtYear.TabStop = false;
			txtYear.TextAlign = HorizontalAlignment.Left;
			txtYear.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtYear.TrailingIcon = null;
			txtYear.UseSystemPasswordChar = false;
			txtYear.ValidatingType = null;
			// 
			// btnCreateBook
			// 
			btnCreateBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel1.SetColumnSpan(btnCreateBook, 4);
			btnCreateBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			btnCreateBook.Depth = 0;
			btnCreateBook.Dock = DockStyle.Fill;
			btnCreateBook.HighEmphasis = true;
			btnCreateBook.Icon = null;
			btnCreateBook.Location = new Point(4, 430);
			btnCreateBook.Margin = new Padding(4, 6, 4, 6);
			btnCreateBook.MouseState = MaterialSkin.MouseState.HOVER;
			btnCreateBook.Name = "btnCreateBook";
			btnCreateBook.NoAccentTextColor = Color.Empty;
			btnCreateBook.Size = new Size(631, 44);
			btnCreateBook.TabIndex = 9;
			btnCreateBook.Text = "Create Book";
			btnCreateBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			btnCreateBook.UseAccentColor = false;
			btnCreateBook.UseVisualStyleBackColor = true;
			btnCreateBook.Click += btnCreateBook_Click;
			// 
			// txtQuantity
			// 
			txtQuantity.AllowPromptAsInput = true;
			txtQuantity.AnimateReadOnly = false;
			txtQuantity.AsciiOnly = false;
			txtQuantity.BackgroundImageLayout = ImageLayout.None;
			txtQuantity.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtQuantity, 2);
			txtQuantity.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtQuantity.Depth = 0;
			txtQuantity.Dock = DockStyle.Fill;
			txtQuantity.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtQuantity.HidePromptOnLeave = false;
			txtQuantity.HideSelection = true;
			txtQuantity.Hint = "Quantity";
			txtQuantity.InsertKeyMode = InsertKeyMode.Default;
			txtQuantity.LeadingIcon = null;
			txtQuantity.Location = new Point(3, 215);
			txtQuantity.Mask = "";
			txtQuantity.MaxLength = 32767;
			txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
			txtQuantity.Name = "txtQuantity";
			txtQuantity.PasswordChar = '\0';
			txtQuantity.PrefixSuffixText = null;
			txtQuantity.PromptChar = '_';
			txtQuantity.ReadOnly = false;
			txtQuantity.RejectInputOnFirstFailure = false;
			txtQuantity.ResetOnPrompt = true;
			txtQuantity.ResetOnSpace = true;
			txtQuantity.RightToLeft = RightToLeft.No;
			txtQuantity.SelectedText = "";
			txtQuantity.SelectionLength = 0;
			txtQuantity.SelectionStart = 0;
			txtQuantity.ShortcutsEnabled = true;
			txtQuantity.Size = new Size(312, 48);
			txtQuantity.SkipLiterals = true;
			txtQuantity.TabIndex = 5;
			txtQuantity.TabStop = false;
			txtQuantity.TextAlign = HorizontalAlignment.Left;
			txtQuantity.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtQuantity.TrailingIcon = null;
			txtQuantity.UseSystemPasswordChar = false;
			txtQuantity.ValidatingType = null;
			// 
			// cmbCategory
			// 
			cmbCategory.AutoResize = false;
			cmbCategory.BackColor = Color.FromArgb(255, 255, 255);
			tableLayoutPanel1.SetColumnSpan(cmbCategory, 4);
			cmbCategory.Depth = 0;
			cmbCategory.Dock = DockStyle.Fill;
			cmbCategory.DrawMode = DrawMode.OwnerDrawVariable;
			cmbCategory.DropDownHeight = 174;
			cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbCategory.DropDownWidth = 121;
			cmbCategory.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
			cmbCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
			cmbCategory.FormattingEnabled = true;
			cmbCategory.Hint = "Category";
			cmbCategory.IntegralHeight = false;
			cmbCategory.ItemHeight = 43;
			cmbCategory.Location = new Point(3, 268);
			cmbCategory.MaxDropDownItems = 4;
			cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
			cmbCategory.Name = "cmbCategory";
			cmbCategory.Size = new Size(633, 49);
			cmbCategory.StartIndex = 0;
			cmbCategory.TabIndex = 12;
			// 
			// pbImage
			// 
			tableLayoutPanel1.SetColumnSpan(pbImage, 2);
			pbImage.Dock = DockStyle.Fill;
			pbImage.Location = new Point(321, 56);
			pbImage.Name = "pbImage";
			tableLayoutPanel1.SetRowSpan(pbImage, 4);
			pbImage.Size = new Size(315, 206);
			pbImage.SizeMode = PictureBoxSizeMode.Zoom;
			pbImage.TabIndex = 13;
			pbImage.TabStop = false;
			pbImage.Click += pbImage_Click;
			// 
			// txtLanguage
			// 
			txtLanguage.AllowPromptAsInput = true;
			txtLanguage.AnimateReadOnly = false;
			txtLanguage.AsciiOnly = false;
			txtLanguage.BackgroundImageLayout = ImageLayout.None;
			txtLanguage.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtLanguage, 2);
			txtLanguage.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtLanguage.Depth = 0;
			txtLanguage.Dock = DockStyle.Fill;
			txtLanguage.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtLanguage.HidePromptOnLeave = false;
			txtLanguage.HideSelection = true;
			txtLanguage.Hint = "Language";
			txtLanguage.InsertKeyMode = InsertKeyMode.Default;
			txtLanguage.LeadingIcon = null;
			txtLanguage.Location = new Point(321, 374);
			txtLanguage.Mask = "";
			txtLanguage.MaxLength = 32767;
			txtLanguage.MouseState = MaterialSkin.MouseState.OUT;
			txtLanguage.Name = "txtLanguage";
			txtLanguage.PasswordChar = '\0';
			txtLanguage.PrefixSuffixText = null;
			txtLanguage.PromptChar = '_';
			txtLanguage.ReadOnly = false;
			txtLanguage.RejectInputOnFirstFailure = false;
			txtLanguage.ResetOnPrompt = true;
			txtLanguage.ResetOnSpace = true;
			txtLanguage.RightToLeft = RightToLeft.No;
			txtLanguage.SelectedText = "";
			txtLanguage.SelectionLength = 0;
			txtLanguage.SelectionStart = 0;
			txtLanguage.ShortcutsEnabled = true;
			txtLanguage.Size = new Size(315, 48);
			txtLanguage.SkipLiterals = true;
			txtLanguage.TabIndex = 14;
			txtLanguage.TabStop = false;
			txtLanguage.TextAlign = HorizontalAlignment.Left;
			txtLanguage.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtLanguage.TrailingIcon = null;
			txtLanguage.UseSystemPasswordChar = false;
			txtLanguage.ValidatingType = null;
			// 
			// materialCard1
			// 
			materialCard1.BackColor = Color.FromArgb(255, 255, 255);
			materialCard1.Controls.Add(tableLayoutPanel1);
			materialCard1.Depth = 0;
			materialCard1.Dock = DockStyle.Fill;
			materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
			materialCard1.Location = new Point(0, 0);
			materialCard1.Margin = new Padding(15);
			materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			materialCard1.Name = "materialCard1";
			materialCard1.Padding = new Padding(15);
			materialCard1.Size = new Size(669, 510);
			materialCard1.TabIndex = 1;
			// 
			// frmCreateBookModel
			// 
			AutoScaleDimensions = new SizeF(12F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(materialCard1);
			Font = new Font("Fira Code", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4);
			Name = "frmCreateBookModel";
			Size = new Size(669, 510);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
			materialCard1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTitle;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtAuthor;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPrice;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtQuantity;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPublisher;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtYear;
        private MaterialSkin.Controls.MaterialButton btnCreateBook;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtIsbn;
        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private PictureBox pbImage;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtLanguage;
    }
}
