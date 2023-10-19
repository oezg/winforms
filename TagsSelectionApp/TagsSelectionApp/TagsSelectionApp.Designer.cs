namespace TagsSelectionApp
{
    partial class TagsSelectionApp
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox.Location = new System.Drawing.Point(181, 67);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(341, 20);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Tip to add a tag";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(528, 67);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(528, 255);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(181, 105);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(341, 173);
            this.listBox.TabIndex = 4;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(528, 105);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // TagsSelectionApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox);
            this.Name = "TagsSelectionApp";
            this.Text = "TagsSelectionApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonRemove;
    }
}

