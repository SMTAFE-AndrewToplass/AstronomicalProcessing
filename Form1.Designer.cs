namespace AstronomicalProcessing
{
    partial class AstronomicalProcessing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListBoxData = new ListBox();
            LblSearchData = new Label();
            TextBoxSearchData = new TextBox();
            ButtonSearchData = new Button();
            ButtonSortData = new Button();
            TextBoxEditItem = new TextBox();
            LblEditItem = new Label();
            ButtonEditApply = new Button();
            ButtonMidRange = new Button();
            TextBoxMidRange = new TextBox();
            TextBoxMode = new TextBox();
            ButtonMode = new Button();
            TextBoxAverage = new TextBox();
            ButtonAverage = new Button();
            TextBoxRange = new TextBox();
            ButtonRange = new Button();
            ButtonSequentialSearch = new Button();
            LabelMathsFunctions = new Label();
            TableLayoutMathsFunctions = new TableLayoutPanel();
            TableLayoutSearch = new TableLayoutPanel();
            TableLayoutMathsFunctions.SuspendLayout();
            TableLayoutSearch.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxData
            // 
            ListBoxData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxData.FormattingEnabled = true;
            ListBoxData.ItemHeight = 15;
            ListBoxData.Location = new Point(12, 56);
            ListBoxData.Name = "ListBoxData";
            ListBoxData.Size = new Size(324, 274);
            ListBoxData.TabIndex = 0;
            ListBoxData.SelectedIndexChanged += ListBoxData_SelectedIndexChanged;
            // 
            // LblSearchData
            // 
            LblSearchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblSearchData.AutoSize = true;
            LblSearchData.Location = new Point(12, 333);
            LblSearchData.Name = "LblSearchData";
            LblSearchData.Size = new Size(71, 15);
            LblSearchData.TabIndex = 1;
            LblSearchData.Text = "Search data:";
            // 
            // TextBoxSearchData
            // 
            TextBoxSearchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxSearchData.Location = new Point(12, 351);
            TextBoxSearchData.Name = "TextBoxSearchData";
            TextBoxSearchData.Size = new Size(324, 23);
            TextBoxSearchData.TabIndex = 2;
            TextBoxSearchData.KeyDown += TextBoxSearchData_KeyDown;
            // 
            // ButtonSearchData
            // 
            ButtonSearchData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSearchData.Location = new Point(3, 3);
            ButtonSearchData.Name = "ButtonSearchData";
            ButtonSearchData.Size = new Size(159, 25);
            ButtonSearchData.TabIndex = 3;
            ButtonSearchData.Text = "Binary Search";
            ButtonSearchData.UseVisualStyleBackColor = true;
            ButtonSearchData.Click += ButtonSearchData_Click;
            // 
            // ButtonSortData
            // 
            ButtonSortData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSortData.Location = new Point(12, 417);
            ButtonSortData.Name = "ButtonSortData";
            ButtonSortData.Size = new Size(324, 25);
            ButtonSortData.TabIndex = 4;
            ButtonSortData.Text = "Sort data";
            ButtonSortData.UseVisualStyleBackColor = true;
            ButtonSortData.Click += ButtonSortData_Click;
            // 
            // TextBoxEditItem
            // 
            TextBoxEditItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxEditItem.Location = new Point(12, 27);
            TextBoxEditItem.Name = "TextBoxEditItem";
            TextBoxEditItem.Size = new Size(243, 23);
            TextBoxEditItem.TabIndex = 5;
            TextBoxEditItem.KeyDown += TextBoxEditItem_KeyDown;
            // 
            // LblEditItem
            // 
            LblEditItem.AutoSize = true;
            LblEditItem.Location = new Point(12, 9);
            LblEditItem.Name = "LblEditItem";
            LblEditItem.Size = new Size(57, 15);
            LblEditItem.TabIndex = 6;
            LblEditItem.Text = "Edit item:";
            // 
            // ButtonEditApply
            // 
            ButtonEditApply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonEditApply.Location = new Point(261, 25);
            ButtonEditApply.Name = "ButtonEditApply";
            ButtonEditApply.Size = new Size(75, 25);
            ButtonEditApply.TabIndex = 7;
            ButtonEditApply.Text = "Apply";
            ButtonEditApply.UseVisualStyleBackColor = true;
            ButtonEditApply.Click += ButtonEditApply_Click;
            // 
            // ButtonMidRange
            // 
            ButtonMidRange.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonMidRange.Location = new Point(3, 32);
            ButtonMidRange.Name = "ButtonMidRange";
            ButtonMidRange.Size = new Size(76, 23);
            ButtonMidRange.TabIndex = 8;
            ButtonMidRange.Text = "Mid-range";
            ButtonMidRange.UseVisualStyleBackColor = true;
            // 
            // TextBoxMidRange
            // 
            TextBoxMidRange.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxMidRange.Location = new Point(3, 3);
            TextBoxMidRange.Name = "TextBoxMidRange";
            TextBoxMidRange.ReadOnly = true;
            TextBoxMidRange.Size = new Size(76, 23);
            TextBoxMidRange.TabIndex = 9;
            // 
            // TextBoxMode
            // 
            TextBoxMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxMode.Location = new Point(85, 3);
            TextBoxMode.Name = "TextBoxMode";
            TextBoxMode.ReadOnly = true;
            TextBoxMode.Size = new Size(76, 23);
            TextBoxMode.TabIndex = 11;
            // 
            // ButtonMode
            // 
            ButtonMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonMode.Location = new Point(85, 32);
            ButtonMode.Name = "ButtonMode";
            ButtonMode.Size = new Size(76, 23);
            ButtonMode.TabIndex = 10;
            ButtonMode.Text = "Mode";
            ButtonMode.UseVisualStyleBackColor = true;
            // 
            // TextBoxAverage
            // 
            TextBoxAverage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxAverage.Location = new Point(167, 3);
            TextBoxAverage.Name = "TextBoxAverage";
            TextBoxAverage.ReadOnly = true;
            TextBoxAverage.Size = new Size(76, 23);
            TextBoxAverage.TabIndex = 13;
            // 
            // ButtonAverage
            // 
            ButtonAverage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonAverage.Location = new Point(167, 32);
            ButtonAverage.Name = "ButtonAverage";
            ButtonAverage.Size = new Size(76, 23);
            ButtonAverage.TabIndex = 12;
            ButtonAverage.Text = "Average";
            ButtonAverage.UseVisualStyleBackColor = true;
            // 
            // TextBoxRange
            // 
            TextBoxRange.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxRange.Location = new Point(249, 3);
            TextBoxRange.Name = "TextBoxRange";
            TextBoxRange.ReadOnly = true;
            TextBoxRange.Size = new Size(76, 23);
            TextBoxRange.TabIndex = 15;
            // 
            // ButtonRange
            // 
            ButtonRange.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonRange.Location = new Point(249, 32);
            ButtonRange.Name = "ButtonRange";
            ButtonRange.Size = new Size(76, 23);
            ButtonRange.TabIndex = 14;
            ButtonRange.Text = "Range";
            ButtonRange.UseVisualStyleBackColor = true;
            // 
            // ButtonSequentialSearch
            // 
            ButtonSequentialSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSequentialSearch.Location = new Point(168, 3);
            ButtonSequentialSearch.Name = "ButtonSequentialSearch";
            ButtonSequentialSearch.Size = new Size(159, 25);
            ButtonSequentialSearch.TabIndex = 16;
            ButtonSequentialSearch.Text = "Sequential Search";
            ButtonSequentialSearch.UseVisualStyleBackColor = true;
            // 
            // LabelMathsFunctions
            // 
            LabelMathsFunctions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelMathsFunctions.AutoSize = true;
            LabelMathsFunctions.Location = new Point(12, 445);
            LabelMathsFunctions.Name = "LabelMathsFunctions";
            LabelMathsFunctions.Size = new Size(138, 15);
            LabelMathsFunctions.TabIndex = 17;
            LabelMathsFunctions.Text = "Mathematical Functions:";
            // 
            // TableLayoutMathsFunctions
            // 
            TableLayoutMathsFunctions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutMathsFunctions.AutoSize = true;
            TableLayoutMathsFunctions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutMathsFunctions.ColumnCount = 4;
            TableLayoutMathsFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutMathsFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutMathsFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutMathsFunctions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutMathsFunctions.Controls.Add(ButtonMidRange, 0, 1);
            TableLayoutMathsFunctions.Controls.Add(TextBoxMidRange, 0, 0);
            TableLayoutMathsFunctions.Controls.Add(ButtonMode, 1, 1);
            TableLayoutMathsFunctions.Controls.Add(TextBoxRange, 3, 0);
            TableLayoutMathsFunctions.Controls.Add(TextBoxMode, 1, 0);
            TableLayoutMathsFunctions.Controls.Add(ButtonRange, 3, 1);
            TableLayoutMathsFunctions.Controls.Add(ButtonAverage, 2, 1);
            TableLayoutMathsFunctions.Controls.Add(TextBoxAverage, 2, 0);
            TableLayoutMathsFunctions.Location = new Point(9, 463);
            TableLayoutMathsFunctions.Name = "TableLayoutMathsFunctions";
            TableLayoutMathsFunctions.RowCount = 2;
            TableLayoutMathsFunctions.RowStyles.Add(new RowStyle());
            TableLayoutMathsFunctions.RowStyles.Add(new RowStyle());
            TableLayoutMathsFunctions.Size = new Size(328, 58);
            TableLayoutMathsFunctions.TabIndex = 18;
            // 
            // TableLayoutSearch
            // 
            TableLayoutSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutSearch.AutoSize = true;
            TableLayoutSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutSearch.ColumnCount = 2;
            TableLayoutSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutSearch.Controls.Add(ButtonSearchData, 0, 0);
            TableLayoutSearch.Controls.Add(ButtonSequentialSearch, 1, 0);
            TableLayoutSearch.Location = new Point(9, 380);
            TableLayoutSearch.Name = "TableLayoutSearch";
            TableLayoutSearch.RowCount = 1;
            TableLayoutSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutSearch.Size = new Size(330, 31);
            TableLayoutSearch.TabIndex = 19;
            // 
            // AstronomicalProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 533);
            Controls.Add(TableLayoutSearch);
            Controls.Add(TableLayoutMathsFunctions);
            Controls.Add(LabelMathsFunctions);
            Controls.Add(ButtonEditApply);
            Controls.Add(LblEditItem);
            Controls.Add(TextBoxEditItem);
            Controls.Add(ButtonSortData);
            Controls.Add(TextBoxSearchData);
            Controls.Add(LblSearchData);
            Controls.Add(ListBoxData);
            MinimumSize = new Size(300, 400);
            Name = "AstronomicalProcessing";
            Text = "Astronomical Processing";
            TableLayoutMathsFunctions.ResumeLayout(false);
            TableLayoutMathsFunctions.PerformLayout();
            TableLayoutSearch.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxData;
        private Label LblSearchData;
        private TextBox TextBoxSearchData;
        private Button ButtonSearchData;
        private Button ButtonSortData;
        private TextBox TextBoxEditItem;
        private Label LblEditItem;
        private Button ButtonEditApply;
        private Button ButtonMidRange;
        private TextBox TextBoxMidRange;
        private TextBox TextBoxMode;
        private Button ButtonMode;
        private TextBox TextBoxAverage;
        private Button ButtonAverage;
        private TextBox TextBoxRange;
        private Button ButtonRange;
        private Button ButtonSequentialSearch;
        private Label LabelMathsFunctions;
        private TableLayoutPanel TableLayoutMathsFunctions;
        private TableLayoutPanel TableLayoutSearch;
    }
}
