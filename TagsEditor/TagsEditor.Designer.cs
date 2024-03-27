namespace TagsEditor
{
    partial class TagsEditor
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
            this.tagToAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.listToAdd = new System.Windows.Forms.ListBox();
            this.buttonUndoAdd = new System.Windows.Forms.Button();
            this.bulkTagsToAdd = new System.Windows.Forms.TextBox();
            this.buttonAddBulk = new System.Windows.Forms.Button();
            this.listSaved = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listToRemove = new System.Windows.Forms.ListBox();
            this.buttonUndoRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tagToAdd
            // 
            this.tagToAdd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tagToAdd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tagToAdd.Location = new System.Drawing.Point(506, 255);
            this.tagToAdd.Name = "tagToAdd";
            this.tagToAdd.Size = new System.Drawing.Size(341, 20);
            this.tagToAdd.TabIndex = 0;
            this.tagToAdd.Text = "Tip to add a tag";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(853, 255);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(854, 369);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // listToAdd
            // 
            this.listToAdd.FormattingEnabled = true;
            this.listToAdd.Location = new System.Drawing.Point(506, 27);
            this.listToAdd.Name = "listToAdd";
            this.listToAdd.Size = new System.Drawing.Size(341, 173);
            this.listToAdd.TabIndex = 4;
            // 
            // buttonUndoAdd
            // 
            this.buttonUndoAdd.Location = new System.Drawing.Point(853, 27);
            this.buttonUndoAdd.Name = "buttonUndoAdd";
            this.buttonUndoAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonUndoAdd.TabIndex = 5;
            this.buttonUndoAdd.Text = "Undo Add";
            this.buttonUndoAdd.UseVisualStyleBackColor = true;
            this.buttonUndoAdd.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // bulkTagsToAdd
            // 
            this.bulkTagsToAdd.Location = new System.Drawing.Point(506, 219);
            this.bulkTagsToAdd.Name = "bulkTagsToAdd";
            this.bulkTagsToAdd.Size = new System.Drawing.Size(341, 20);
            this.bulkTagsToAdd.TabIndex = 6;
            this.bulkTagsToAdd.Text = "You can paste a comma separated list of tags";
            // 
            // buttonAddBulk
            // 
            this.buttonAddBulk.Location = new System.Drawing.Point(854, 215);
            this.buttonAddBulk.Name = "buttonAddBulk";
            this.buttonAddBulk.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBulk.TabIndex = 7;
            this.buttonAddBulk.Text = "Add Bulk";
            this.buttonAddBulk.UseVisualStyleBackColor = true;
            // 
            // listSaved
            // 
            this.listSaved.FormattingEnabled = true;
            this.listSaved.Location = new System.Drawing.Point(24, 27);
            this.listSaved.Name = "listSaved";
            this.listSaved.Size = new System.Drawing.Size(322, 173);
            this.listSaved.TabIndex = 8;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(352, 27);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // listToRemove
            // 
            this.listToRemove.FormattingEnabled = true;
            this.listToRemove.Location = new System.Drawing.Point(24, 219);
            this.listToRemove.Name = "listToRemove";
            this.listToRemove.Size = new System.Drawing.Size(322, 173);
            this.listToRemove.TabIndex = 10;
            // 
            // buttonUndoRemove
            // 
            this.buttonUndoRemove.Location = new System.Drawing.Point(353, 219);
            this.buttonUndoRemove.Name = "buttonUndoRemove";
            this.buttonUndoRemove.Size = new System.Drawing.Size(118, 23);
            this.buttonUndoRemove.TabIndex = 11;
            this.buttonUndoRemove.Text = "Undo Remove";
            this.buttonUndoRemove.UseVisualStyleBackColor = true;
            // 
            // TagsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.buttonUndoRemove);
            this.Controls.Add(this.listToRemove);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listSaved);
            this.Controls.Add(this.buttonAddBulk);
            this.Controls.Add(this.bulkTagsToAdd);
            this.Controls.Add(this.buttonUndoAdd);
            this.Controls.Add(this.listToAdd);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tagToAdd);
            this.Name = "TagsEditor";
            this.Text = "TagsEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tagToAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ListBox listToAdd;
        private System.Windows.Forms.Button buttonUndoAdd;
        private System.Windows.Forms.TextBox bulkTagsToAdd;
        private System.Windows.Forms.Button buttonAddBulk;
        private System.Windows.Forms.ListBox listSaved;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listToRemove;
        private System.Windows.Forms.Button buttonUndoRemove;
    }
}

