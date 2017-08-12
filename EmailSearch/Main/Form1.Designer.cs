namespace Email_Search
{
    partial class MainForm
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
            this.Label_Title = new System.Windows.Forms.Label();
            this.Label_MainText = new System.Windows.Forms.Label();
            this.Label_SearchKeywords = new System.Windows.Forms.Label();
            this.Label_SearchCount = new System.Windows.Forms.Label();
            this.Label_WilliamBaker = new System.Windows.Forms.Label();
            this.Label_OakwoodParkGrammarSchool = new System.Windows.Forms.Label();
            this.Textbox_Keywords = new Email_Search.EmailSearch.Controls.CustomTextbox();
            this.Button_KeywordsFile = new Email_Search.CustomButton();
            this.Button_HelpKeywords = new Email_Search.CustomButton();
            this.Listbox_SearchCount = new Email_Search.CustomListBox();
            this.Button_ClearMainText = new Email_Search.CustomButton();
            this.Button_Search = new Email_Search.CustomButton();
            this.Button_ClearKeywords = new Email_Search.CustomButton();
            this.RichTextbox_MainText = new Email_Search.CustomRichTextbox();
            this.SuspendLayout();
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(5, 9);
            this.Label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(183, 37);
            this.Label_Title.TabIndex = 1;
            this.Label_Title.Text = "Email Search";
            // 
            // Label_MainText
            // 
            this.Label_MainText.AutoSize = true;
            this.Label_MainText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MainText.Location = new System.Drawing.Point(7, 70);
            this.Label_MainText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_MainText.Name = "Label_MainText";
            this.Label_MainText.Size = new System.Drawing.Size(145, 20);
            this.Label_MainText.TabIndex = 2;
            this.Label_MainText.Text = "Enter Email Contents:";
            // 
            // Label_SearchKeywords
            // 
            this.Label_SearchKeywords.AutoSize = true;
            this.Label_SearchKeywords.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SearchKeywords.Location = new System.Drawing.Point(428, 70);
            this.Label_SearchKeywords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_SearchKeywords.Name = "Label_SearchKeywords";
            this.Label_SearchKeywords.Size = new System.Drawing.Size(169, 20);
            this.Label_SearchKeywords.TabIndex = 3;
            this.Label_SearchKeywords.Text = "Enter keywords to search:";
            // 
            // Label_SearchCount
            // 
            this.Label_SearchCount.AutoSize = true;
            this.Label_SearchCount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SearchCount.Location = new System.Drawing.Point(428, 133);
            this.Label_SearchCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_SearchCount.Name = "Label_SearchCount";
            this.Label_SearchCount.Size = new System.Drawing.Size(150, 20);
            this.Label_SearchCount.TabIndex = 6;
            this.Label_SearchCount.Text = "Instances of keywords:";
            // 
            // Label_WilliamBaker
            // 
            this.Label_WilliamBaker.AutoSize = true;
            this.Label_WilliamBaker.Location = new System.Drawing.Point(921, 512);
            this.Label_WilliamBaker.Name = "Label_WilliamBaker";
            this.Label_WilliamBaker.Size = new System.Drawing.Size(86, 13);
            this.Label_WilliamBaker.TabIndex = 21;
            this.Label_WilliamBaker.Text = "By William Baker";
            // 
            // Label_OakwoodParkGrammarSchool
            // 
            this.Label_OakwoodParkGrammarSchool.AutoSize = true;
            this.Label_OakwoodParkGrammarSchool.Location = new System.Drawing.Point(848, 525);
            this.Label_OakwoodParkGrammarSchool.Name = "Label_OakwoodParkGrammarSchool";
            this.Label_OakwoodParkGrammarSchool.Size = new System.Drawing.Size(159, 13);
            this.Label_OakwoodParkGrammarSchool.TabIndex = 22;
            this.Label_OakwoodParkGrammarSchool.Text = "Oakwood Park Grammar School";
            // 
            // Textbox_Keywords
            // 
            this.Textbox_Keywords.BackColor = System.Drawing.Color.White;
            this.Textbox_Keywords.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Keywords.Location = new System.Drawing.Point(432, 93);
            this.Textbox_Keywords.Name = "Textbox_Keywords";
            this.Textbox_Keywords.Size = new System.Drawing.Size(520, 21);
            this.Textbox_Keywords.TabIndex = 20;
            // 
            // Button_KeywordsFile
            // 
            this.Button_KeywordsFile.BackColor = System.Drawing.Color.White;
            this.Button_KeywordsFile.Location = new System.Drawing.Point(922, 120);
            this.Button_KeywordsFile.Name = "Button_KeywordsFile";
            this.Button_KeywordsFile.Size = new System.Drawing.Size(85, 23);
            this.Button_KeywordsFile.TabIndex = 17;
            this.Button_KeywordsFile.Text = "From File";
            this.Button_KeywordsFile.Click += new System.EventHandler(this.Button_KeywordsFile_Click);
            // 
            // Button_HelpKeywords
            // 
            this.Button_HelpKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_HelpKeywords.Location = new System.Drawing.Point(601, 75);
            this.Button_HelpKeywords.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Button_HelpKeywords.Name = "Button_HelpKeywords";
            this.Button_HelpKeywords.Size = new System.Drawing.Size(12, 12);
            this.Button_HelpKeywords.TabIndex = 16;
            this.Button_HelpKeywords.Text = "?";
            this.Button_HelpKeywords.Click += new System.EventHandler(this.Button_HelpKeywords_Click);
            // 
            // Listbox_SearchCount
            // 
            this.Listbox_SearchCount.BackColor = System.Drawing.Color.White;
            this.Listbox_SearchCount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listbox_SearchCount.Location = new System.Drawing.Point(432, 156);
            this.Listbox_SearchCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Listbox_SearchCount.Name = "Listbox_SearchCount";
            this.Listbox_SearchCount.Size = new System.Drawing.Size(575, 300);
            this.Listbox_SearchCount.TabIndex = 15;
            // 
            // Button_ClearMainText
            // 
            this.Button_ClearMainText.BackColor = System.Drawing.Color.White;
            this.Button_ClearMainText.Location = new System.Drawing.Point(11, 433);
            this.Button_ClearMainText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Button_ClearMainText.Name = "Button_ClearMainText";
            this.Button_ClearMainText.Size = new System.Drawing.Size(90, 23);
            this.Button_ClearMainText.TabIndex = 14;
            this.Button_ClearMainText.Text = "Clear Contents";
            this.Button_ClearMainText.Click += new System.EventHandler(this.Button_ClearMainText_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.BackColor = System.Drawing.Color.White;
            this.Button_Search.Location = new System.Drawing.Point(344, 433);
            this.Button_Search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(80, 23);
            this.Button_Search.TabIndex = 13;
            this.Button_Search.Text = "Analyse";
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Button_ClearKeywords
            // 
            this.Button_ClearKeywords.BackColor = System.Drawing.Color.White;
            this.Button_ClearKeywords.Location = new System.Drawing.Point(957, 93);
            this.Button_ClearKeywords.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Button_ClearKeywords.Name = "Button_ClearKeywords";
            this.Button_ClearKeywords.Size = new System.Drawing.Size(50, 21);
            this.Button_ClearKeywords.TabIndex = 12;
            this.Button_ClearKeywords.Text = "Clear";
            this.Button_ClearKeywords.Click += new System.EventHandler(this.Button_ClearKeywords_Click);
            // 
            // RichTextbox_MainText
            // 
            this.RichTextbox_MainText.BackColor = System.Drawing.Color.White;
            this.RichTextbox_MainText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextbox_MainText.Location = new System.Drawing.Point(11, 93);
            this.RichTextbox_MainText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RichTextbox_MainText.Name = "RichTextbox_MainText";
            this.RichTextbox_MainText.Size = new System.Drawing.Size(413, 334);
            this.RichTextbox_MainText.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1018, 547);
            this.Controls.Add(this.Label_OakwoodParkGrammarSchool);
            this.Controls.Add(this.Label_WilliamBaker);
            this.Controls.Add(this.Textbox_Keywords);
            this.Controls.Add(this.Button_KeywordsFile);
            this.Controls.Add(this.Button_HelpKeywords);
            this.Controls.Add(this.Listbox_SearchCount);
            this.Controls.Add(this.Button_ClearMainText);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.Button_ClearKeywords);
            this.Controls.Add(this.RichTextbox_MainText);
            this.Controls.Add(this.Label_SearchCount);
            this.Controls.Add(this.Label_SearchKeywords);
            this.Controls.Add(this.Label_MainText);
            this.Controls.Add(this.Label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label Label_MainText;
        private System.Windows.Forms.Label Label_SearchKeywords;
        private System.Windows.Forms.Label Label_SearchCount;
        private CustomRichTextbox RichTextbox_MainText;
        private CustomButton Button_ClearKeywords;
        private CustomButton Button_Search;
        private CustomButton Button_ClearMainText;
        private CustomListBox Listbox_SearchCount;
        private CustomButton Button_HelpKeywords;
        private CustomButton Button_KeywordsFile;
        private EmailSearch.Controls.CustomTextbox customTextbox1;
        private EmailSearch.Controls.CustomTextbox Textbox_Keywords;
        private System.Windows.Forms.Label Label_WilliamBaker;
        private System.Windows.Forms.Label Label_OakwoodParkGrammarSchool;
    }
}

