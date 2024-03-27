using System;
using System.Collections.Generic;
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

            tagToAdd.AutoCompleteCustomSource.AddRange(s_tags);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string tagToAdd = this.tagToAdd.Text.Trim();

            if (string.IsNullOrEmpty(tagToAdd))
            {
                return;
            }

            if (listToAdd.Items.Contains(tagToAdd))
            {
                return;
            }

            listToAdd.Items.Add(tagToAdd);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listToAdd.Items.Remove(listToAdd.SelectedItem);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            var tags = s_tags.AsEnumerable();
            //var x = new HashSet<string>(tags);
            ////x.UnionWith((IEnumerable<string>)listBox.Items);

            foreach (string item in listToAdd.Items)
            {
                //x.Add(item);
                if (tags.Contains(item))
                {
                    continue;
                }

                tags = tags.Append(item);
            }

            tags = tags.OrderBy(tag => tag);
            //x.OrderBy(t => t);

            string tagsText = string.Join("\n", tags);

            File.WriteAllText(s_outputFile, tagsText);
        }
    }
}
