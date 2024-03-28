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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            textBox4 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 32);
            button1.Name = "button1";
            button1.Size = new Size(76, 23);
            button1.TabIndex = 8;
            button1.Text = "Mid-range";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(85, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 23);
            textBox2.TabIndex = 11;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(85, 32);
            button2.Name = "button2";
            button2.Size = new Size(76, 23);
            button2.TabIndex = 10;
            button2.Text = "Mode";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(167, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(76, 23);
            textBox3.TabIndex = 13;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(167, 32);
            button3.Name = "button3";
            button3.Size = new Size(76, 23);
            button3.TabIndex = 12;
            button3.Text = "Average";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(249, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(76, 23);
            textBox4.TabIndex = 15;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(249, 32);
            button4.Name = "button4";
            button4.Size = new Size(76, 23);
            button4.TabIndex = 14;
            button4.Text = "Range";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(168, 3);
            button5.Name = "button5";
            button5.Size = new Size(159, 25);
            button5.TabIndex = 16;
            button5.Text = "Sequential Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 445);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 17;
            label1.Text = "Mathematical Functions:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 2, 0);
            tableLayoutPanel1.Location = new Point(9, 463);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(328, 58);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ButtonSearchData, 0, 0);
            tableLayoutPanel2.Controls.Add(button5, 1, 0);
            tableLayoutPanel2.Location = new Point(9, 380);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(330, 31);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // AstronomicalProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 533);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(ButtonEditApply);
            Controls.Add(LblEditItem);
            Controls.Add(TextBoxEditItem);
            Controls.Add(ButtonSortData);
            Controls.Add(TextBoxSearchData);
            Controls.Add(LblSearchData);
            Controls.Add(ListBoxData);
            MinimumSize = new Size(300, 250);
            Name = "AstronomicalProcessing";
            Text = "Astronomical Processing";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
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
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private TextBox textBox4;
        private Button button4;
        private Button button5;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
