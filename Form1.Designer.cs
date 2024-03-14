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
            SuspendLayout();
            // 
            // ListBoxData
            // 
            ListBoxData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxData.FormattingEnabled = true;
            ListBoxData.ItemHeight = 15;
            ListBoxData.Location = new Point(12, 85);
            ListBoxData.Name = "ListBoxData";
            ListBoxData.Size = new Size(258, 229);
            ListBoxData.TabIndex = 0;
            ListBoxData.SelectedIndexChanged += ListBoxData_SelectedIndexChanged;
            // 
            // LblSearchData
            // 
            LblSearchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblSearchData.AutoSize = true;
            LblSearchData.Location = new Point(12, 317);
            LblSearchData.Name = "LblSearchData";
            LblSearchData.Size = new Size(71, 15);
            LblSearchData.TabIndex = 1;
            LblSearchData.Text = "Search data:";
            // 
            // TextBoxSearchData
            // 
            TextBoxSearchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxSearchData.Location = new Point(12, 335);
            TextBoxSearchData.Name = "TextBoxSearchData";
            TextBoxSearchData.Size = new Size(177, 23);
            TextBoxSearchData.TabIndex = 2;
            // 
            // ButtonSearchData
            // 
            ButtonSearchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSearchData.Location = new Point(195, 334);
            ButtonSearchData.Name = "ButtonSearchData";
            ButtonSearchData.Size = new Size(75, 24);
            ButtonSearchData.TabIndex = 3;
            ButtonSearchData.Text = "Search";
            ButtonSearchData.UseVisualStyleBackColor = true;
            ButtonSearchData.Click += ButtonSearchData_Click;
            // 
            // ButtonSortData
            // 
            ButtonSortData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSortData.Location = new Point(12, 364);
            ButtonSortData.Name = "ButtonSortData";
            ButtonSortData.Size = new Size(258, 23);
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
            TextBoxEditItem.Size = new Size(258, 23);
            TextBoxEditItem.TabIndex = 5;
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
            ButtonEditApply.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonEditApply.Location = new Point(12, 56);
            ButtonEditApply.Name = "ButtonEditApply";
            ButtonEditApply.Size = new Size(258, 23);
            ButtonEditApply.TabIndex = 7;
            ButtonEditApply.Text = "Apply edit";
            ButtonEditApply.UseVisualStyleBackColor = true;
            ButtonEditApply.Click += ButtonEditApply_Click;
            // 
            // AstronomicalProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 405);
            Controls.Add(ButtonEditApply);
            Controls.Add(LblEditItem);
            Controls.Add(TextBoxEditItem);
            Controls.Add(ButtonSortData);
            Controls.Add(ButtonSearchData);
            Controls.Add(TextBoxSearchData);
            Controls.Add(LblSearchData);
            Controls.Add(ListBoxData);
            MinimumSize = new Size(300, 250);
            Name = "AstronomicalProcessing";
            Text = "Astronomical Processing";
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
    }
}
