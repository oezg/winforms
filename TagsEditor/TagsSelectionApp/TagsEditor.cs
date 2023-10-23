using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TagsEditor
{
    public partial class TagsEditor : Form
    {
        private static string s_fileName = @"..\..\resources\tags.psv";
        private static string s_outputFile = @"..\..\resources\output.psv";

        private static string[] s_tags = File.ReadAllText(s_fileName).Split('|');

        public TagsEditor()
        {
            InitializeComponent();
            
            textBox.AutoCompleteCustomSource.AddRange(s_tags);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string tagToAdd = textBox.Text.Trim();
            
            if (string.IsNullOrEmpty(tagToAdd))
            {
                return;
            }
            
            if (listBox.Items.Contains(tagToAdd))
            {
                return;
            }

            listBox.Items.Add(tagToAdd);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            var tags = s_tags.AsEnumerable();

            foreach (string item in listBox.Items)
            {
                if (tags.Contains(item))
                {
                    continue;
                }

                tags = tags.Append(item);
            }

            tags = tags.OrderBy(tag => tag);

            string tagsText = string.Join("|", tags);

            File.WriteAllText(s_outputFile, tagsText);
        }
    }
}
