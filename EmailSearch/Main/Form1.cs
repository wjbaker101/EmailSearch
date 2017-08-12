using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Email_Search
{
    public partial class MainForm : Form
    {
        /*
         * Structure for each keyword, storing the keyword text and the number of times it occurs in the email.
         */
        private struct KeywordFrequency
        {
            public String Keyword;
            public int Frequency;
        }

        /*
         * A list of keywords and their frequencies that appear in the email.
         */
        private List<KeywordFrequency> KeywordFrequencies = new List<KeywordFrequency>(); 

        /*
         * Stores the previous email text so that when the colour of the keywords are changed to red, it does not instantly
         * become black again because the text has been changed.
         */
        private String PrevMainText = String.Empty;

        public MainForm()
        {
            InitializeComponent();

            // Event whenever the text is changed, to know when the email has been edited by the user
            RichTextbox_MainText.getTextbox().TextChanged += new EventHandler(MainForm_RichTextbox_TextChanged);

            Listbox_SearchCount.getListBox().SelectedIndexChanged += new EventHandler(MainForm_SelectedIndexChanged);
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            // Search will only start if there is text in the textbox
            if (Textbox_Keywords.getTextbox().Text.Length > 0)
            {
                GetKeywordsFromTextbox();
            }
        }

        /*
         * Formats the keyword textbox to create a list of each of the keywords it needs to seach for,
         * then finds out how often it appears in the text and adds it to the KeywordFrequencies list.
         */
        private void GetKeywordsFromTextbox()
        {
            List<String> Keywords = new List<String>();

            String[] KeywordsSplitted = Textbox_Keywords.getTextbox().Text.Split(',');

            KeywordFrequencies.Clear();
            foreach (String keyword in KeywordsSplitted)
            {
                if (keyword.Trim() != String.Empty)
                {
                    String FormattedKeyword = keyword.ToLower().Trim();
                    int Frequency = GetNumberOfKeywords(FormattedKeyword);

                    if (RichTextbox_MainText.getTextbox().Text.ToLower().Contains(FormattedKeyword))
                    {
                        KeywordFrequency NewKF;
                        NewKF.Keyword = keyword.Trim();
                        NewKF.Frequency = Frequency;
                        KeywordFrequencies.Add(NewKF);
                    }

                    ChangeColourOfKeywords(FormattedKeyword);
                }
            }

            AddKeywordsToListbox();
        }

        /*
         * Loops through the KeywordFrequencies list, adding each one to the Listbox with the
         * number of times it appears next to it.
         */
        private void AddKeywordsToListbox()
        {
            KeywordFrequencies = SortListByFrequency(KeywordFrequencies);
            Listbox_SearchCount.getListBox().Items.Clear();
            foreach (KeywordFrequency keyword in KeywordFrequencies)
            {
                Listbox_SearchCount.getListBox().Items.Add(keyword.Keyword + " (" + keyword.Frequency + ")");
            }
        }

        /*
         * Returns the number of times a keyword appears in the email text by splitting the string at the points
         * where it will have the keyword. This gives the number of times the keyword appears + 1.
         */
        private int GetNumberOfKeywords(String Keyword)
        {
            String[] MainTextSplitted = RichTextbox_MainText.getTextbox().Text.ToLower().Trim().Split(new String[] { Keyword }, StringSplitOptions.None);
            return MainTextSplitted.Length - 1;
        }

        /*
         * Uses a bubble sort loop to order the initial list into descending order and returns the new (ordered) list.
         */
        private List<KeywordFrequency> SortListByFrequency(List<KeywordFrequency> SortList)
        {
            List<KeywordFrequency> NewList = SortList;

            for (int count = 0; count < NewList.Count; count++)
            {
                for (int i = 0; i < NewList.Count - 1; i++)
                {
                    if (NewList[i].Frequency < NewList[i + 1].Frequency)
                    {
                        KeywordFrequency tempValue = NewList[i + 1];
                        NewList[i + 1] = NewList[i];
                        NewList[i] = tempValue;
                    }
                }
            }

            return NewList;
        }

        /*
         * Changes the colour of the keywords found in the email text.
         */
        private void ChangeColourOfKeywords(String Keyword)
        {
            Regex regex = new Regex(Keyword);
            int CaretPosition = RichTextbox_MainText.getTextbox().SelectionStart;

            foreach (Match match in regex.Matches(RichTextbox_MainText.getTextbox().Text.ToLower()))
            {
                RichTextbox_MainText.getTextbox().Select(match.Index, match.Length);
                RichTextbox_MainText.getTextbox().SelectionColor = Color.Red;
            }
            RichTextbox_MainText.getTextbox().SelectionStart = CaretPosition;
            RichTextbox_MainText.getTextbox().SelectionLength = 0;
        }

        /*
         * If the listbox selection is changed and it is not nothing it will underline keywords.
         */
        private void MainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listbox_SearchCount.getListBox().SelectedIndex > -1)
            {
                UnderlineSelectedKeyword(KeywordFrequencies[Listbox_SearchCount.getListBox().SelectedIndex].Keyword.ToLower());
            }
        }

        /*
         * Removes any previous underline in the textbox, then underlines the keywords found in the textbox.
         */
        private void UnderlineSelectedKeyword(String Keyword)
        {
            RemoveMainTextUnderline();
            Regex regex = new Regex(Keyword);
            int CaretPosition = RichTextbox_MainText.getTextbox().SelectionStart;
            Font textboxFont = RichTextbox_MainText.getTextbox().Font;

            foreach (Match match in regex.Matches(RichTextbox_MainText.getTextbox().Text.ToLower()))
            {
                RichTextbox_MainText.getTextbox().Select(match.Index, match.Length);
                RichTextbox_MainText.getTextbox().SelectionFont = new Font(textboxFont.FontFamily, textboxFont.Size, FontStyle.Underline); ;
            }
            RichTextbox_MainText.getTextbox().SelectionStart = CaretPosition;
            RichTextbox_MainText.getTextbox().SelectionLength = 0;
        }

        /*
         * Removes all underlines in the textbox.
         */
        private void RemoveMainTextUnderline()
        {
            int CaretPosition = RichTextbox_MainText.getTextbox().SelectionStart;
            RichTextbox_MainText.getTextbox().SelectAll();
            RichTextbox_MainText.getTextbox().SelectionFont = RichTextbox_MainText.getTextbox().Font;
            RichTextbox_MainText.getTextbox().SelectionStart = CaretPosition;
            RichTextbox_MainText.getTextbox().SelectionLength = 0;
        }

        /*
         * Clears the text in the email textbox.
         */
        private void Button_ClearMainText_Click(object sender, EventArgs e)
        {
            RichTextbox_MainText.getTextbox().Text = String.Empty;
            Listbox_SearchCount.getListBox().Items.Clear();
        }

        /*
         * Clears the text in the keywords textbox.
         */
        private void Button_ClearKeywords_Click(object sender, EventArgs e)
        {
            Textbox_Keywords.getTextbox().Text = String.Empty;
            Listbox_SearchCount.getListBox().Items.Clear();
            SetMainTextDefaultColour();
        }

        /*
         * Removes the red font on the keywords and clears the listbox of items.
         * Sets the previous email text to the current email text.
         */
        private void MainForm_RichTextbox_TextChanged(object sender, EventArgs e)
        {
            if (RichTextbox_MainText.getTextbox().Text != PrevMainText)
            {
                Listbox_SearchCount.getListBox().Items.Clear();
                SetMainTextDefaultColour();
                PrevMainText = RichTextbox_MainText.getTextbox().Text;
            }
        }

        /*
         * Sets all of the email text to a black font to remove any red font.
         */
        private void SetMainTextDefaultColour()
        {
            int CaretPosition = RichTextbox_MainText.getTextbox().SelectionStart;
            RichTextbox_MainText.getTextbox().SelectAll();
            RichTextbox_MainText.getTextbox().SelectionColor = Color.Black;
            RichTextbox_MainText.getTextbox().SelectionFont = RichTextbox_MainText.getTextbox().Font;
            RichTextbox_MainText.getTextbox().SelectionStart = CaretPosition;
            RichTextbox_MainText.getTextbox().SelectionLength = 0;
        }

        /*
         * Shows a message to tell the user how to enter keywords into the textbox.
         */
        private void Button_HelpKeywords_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter keywords you want to search for." + Environment.NewLine +
                            "Use commas to separate individual keywords." + Environment.NewLine +
                            "e.g. \"search, email, keywords\"", "Help",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        /*
         * Loads keywords from a file, or if the file does not exist it will create a new .csv file will
         * the default keywords.
         */
        private void Button_KeywordsFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("keywords.csv"))
            {
                String keywordsFileText = File.ReadAllText("keywords.csv");
                Textbox_Keywords.getTextbox().Text = keywordsFileText;
            }
            else
            {
                MessageBox.Show("Could not find the \"keyword.search\" file." + Environment.NewLine + "Creating default file.", "File", MessageBoxButtons.OK);

                String fileText = "fear, terror, threat, the enemy, out there, always, circling, watching, waiting";
                StreamWriter newFile = new StreamWriter("keywords.csv");
                newFile.WriteLine(fileText);
                newFile.Close();
            }
        }
    }
}
