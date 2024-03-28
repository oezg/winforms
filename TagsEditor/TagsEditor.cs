using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TagsEditor
{
    public partial class TagsEditor : Form
    {
        private const string ConnectionString = @"Data Source=..\..\resources\orders.db";

        private void ExecuteSqlQuery()
        {
            string sql = "SELECT * FROM tags";
            using (SQLiteConnection dbConnection = new SQLiteConnection(ConnectionString))
            {
                dbConnection.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, dbConnection);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listSaved.Items.Add($"ID: {reader.GetInt32(0)}, Name: {reader.GetString(1)}");
                    }
                }
            }
        }

        private static string s_fileName = @"..\..\resources\tags.psv";
        private static string s_outputFile = @"..\..\resources\output.psv";

        private static string[] s_tags = File.ReadAllText(s_fileName).Split('|');

        public TagsEditor()
        {
            InitializeComponent();

            tagToAdd.AutoCompleteCustomSource.AddRange(s_tags);
            ExecuteSqlQuery();
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
