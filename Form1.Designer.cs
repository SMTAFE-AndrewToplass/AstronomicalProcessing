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
            SuspendLayout();
            // 
            // ListBoxData
            // 
            ListBoxData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxData.FormattingEnabled = true;
            ListBoxData.ItemHeight = 15;
            ListBoxData.Location = new Point(12, 56);
            ListBoxData.Name = "ListBoxData";
            ListBoxData.Size = new Size(249, 184);
            ListBoxData.TabIndex = 0;
            // 
            // LblSearchData
            // 
            LblSearchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblSearchData.AutoSize = true;
            LblSearchData.Location = new Point(12, 243);
            LblSearchData.Name = "LblSearchData";
            LblSearchData.Size = new Size(71, 15);
            LblSearchData.TabIndex = 1;
            LblSearchData.Text = "Search data:";
            // 
            // TextBoxSearchData
            // 
            TextBoxSearchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxSearchData.Location = new Point(12, 261);
            TextBoxSearchData.Name = "TextBoxSearchData";
            TextBoxSearchData.Size = new Size(168, 23);
            TextBoxSearchData.TabIndex = 2;
            // 
            // ButtonSearchData
            // 
            ButtonSearchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSearchData.Location = new Point(186, 260);
            ButtonSearchData.Name = "ButtonSearchData";
            ButtonSearchData.Size = new Size(75, 24);
            ButtonSearchData.TabIndex = 3;
            ButtonSearchData.Text = "Search";
            ButtonSearchData.UseVisualStyleBackColor = true;
            // 
            // ButtonSortData
            // 
            ButtonSortData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSortData.Location = new Point(12, 290);
            ButtonSortData.Name = "ButtonSortData";
            ButtonSortData.Size = new Size(249, 23);
            ButtonSortData.TabIndex = 4;
            ButtonSortData.Text = "Sort data";
            ButtonSortData.UseVisualStyleBackColor = true;
            // 
            // TextBoxEditItem
            // 
            TextBoxEditItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxEditItem.Location = new Point(12, 27);
            TextBoxEditItem.Name = "TextBoxEditItem";
            TextBoxEditItem.Size = new Size(249, 23);
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
            // AstronomicalProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 329);
            Controls.Add(LblEditItem);
            Controls.Add(TextBoxEditItem);
            Controls.Add(ButtonSortData);
            Controls.Add(ButtonSearchData);
            Controls.Add(TextBoxSearchData);
            Controls.Add(LblSearchData);
            Controls.Add(ListBoxData);
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
    }
}
