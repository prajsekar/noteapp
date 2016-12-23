namespace NoteApp.View
{
    partial class NotebookViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentPanel = new System.Windows.Forms.Panel();
            this.bookContentPanel = new System.Windows.Forms.Panel();
            this.noteListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.noteEditPanel = new System.Windows.Forms.Panel();
            this.hiddenIdLbl = new System.Windows.Forms.Label();
            this.saveNoteBtn = new System.Windows.Forms.Button();
            this.deleteNoteBtn = new System.Windows.Forms.Button();
            this.closeNoteBtn = new System.Windows.Forms.Button();
            this.noteContentTxt = new System.Windows.Forms.TextBox();
            this.noteTitleTxt = new System.Windows.Forms.TextBox();
            this.noteCreatedLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.noteCreateTitleLbl = new System.Windows.Forms.Label();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.notebookTitleLbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bookNameLbl = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            this.bookContentPanel.SuspendLayout();
            this.noteEditPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contentPanel.Controls.Add(this.bookContentPanel);
            this.contentPanel.Controls.Add(this.panel7);
            this.contentPanel.Controls.Add(this.deleteBookBtn);
            this.contentPanel.Controls.Add(this.notebookTitleLbl);
            this.contentPanel.Controls.Add(this.panel6);
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(688, 452);
            this.contentPanel.TabIndex = 10;
            // 
            // bookContentPanel
            // 
            this.bookContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookContentPanel.BackColor = System.Drawing.Color.White;
            this.bookContentPanel.Controls.Add(this.noteListPanel);
            this.bookContentPanel.Controls.Add(this.noteEditPanel);
            this.bookContentPanel.Location = new System.Drawing.Point(3, 64);
            this.bookContentPanel.Name = "bookContentPanel";
            this.bookContentPanel.Size = new System.Drawing.Size(682, 388);
            this.bookContentPanel.TabIndex = 13;
            // 
            // noteListPanel
            // 
            this.noteListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteListPanel.AutoScroll = true;
            this.noteListPanel.BackColor = System.Drawing.Color.White;
            this.noteListPanel.Location = new System.Drawing.Point(2, 0);
            this.noteListPanel.Name = "noteListPanel";
            this.noteListPanel.Size = new System.Drawing.Size(677, 100);
            this.noteListPanel.TabIndex = 7;
            // 
            // noteEditPanel
            // 
            this.noteEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteEditPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.noteEditPanel.Controls.Add(this.bookNameLbl);
            this.noteEditPanel.Controls.Add(this.hiddenIdLbl);
            this.noteEditPanel.Controls.Add(this.saveNoteBtn);
            this.noteEditPanel.Controls.Add(this.deleteNoteBtn);
            this.noteEditPanel.Controls.Add(this.closeNoteBtn);
            this.noteEditPanel.Controls.Add(this.noteContentTxt);
            this.noteEditPanel.Controls.Add(this.noteTitleTxt);
            this.noteEditPanel.Controls.Add(this.noteCreatedLbl);
            this.noteEditPanel.Location = new System.Drawing.Point(3, 105);
            this.noteEditPanel.Name = "noteEditPanel";
            this.noteEditPanel.Size = new System.Drawing.Size(676, 283);
            this.noteEditPanel.TabIndex = 6;
            // 
            // hiddenIdLbl
            // 
            this.hiddenIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hiddenIdLbl.AutoSize = true;
            this.hiddenIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.hiddenIdLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hiddenIdLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenIdLbl.ForeColor = System.Drawing.Color.White;
            this.hiddenIdLbl.Location = new System.Drawing.Point(524, 255);
            this.hiddenIdLbl.Name = "hiddenIdLbl";
            this.hiddenIdLbl.Size = new System.Drawing.Size(23, 19);
            this.hiddenIdLbl.TabIndex = 25;
            this.hiddenIdLbl.Text = "-1";
            this.hiddenIdLbl.Visible = false;
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveNoteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.saveNoteBtn.FlatAppearance.BorderSize = 0;
            this.saveNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNoteBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNoteBtn.ForeColor = System.Drawing.Color.White;
            this.saveNoteBtn.Location = new System.Drawing.Point(569, 1);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(55, 58);
            this.saveNoteBtn.TabIndex = 24;
            this.saveNoteBtn.Text = "X";
            this.saveNoteBtn.UseVisualStyleBackColor = false;
            this.saveNoteBtn.Click += new System.EventHandler(this.saveNoteBtn_Click);
            // 
            // deleteNoteBtn
            // 
            this.deleteNoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteNoteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.deleteNoteBtn.FlatAppearance.BorderSize = 0;
            this.deleteNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNoteBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNoteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteNoteBtn.Location = new System.Drawing.Point(515, 3);
            this.deleteNoteBtn.Name = "deleteNoteBtn";
            this.deleteNoteBtn.Size = new System.Drawing.Size(55, 45);
            this.deleteNoteBtn.TabIndex = 23;
            this.deleteNoteBtn.Text = "X";
            this.deleteNoteBtn.UseVisualStyleBackColor = false;
            this.deleteNoteBtn.Click += new System.EventHandler(this.deleteNoteBtn_Click);
            // 
            // closeNoteBtn
            // 
            this.closeNoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeNoteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.closeNoteBtn.FlatAppearance.BorderSize = 0;
            this.closeNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeNoteBtn.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.closeNoteBtn.ForeColor = System.Drawing.Color.White;
            this.closeNoteBtn.Location = new System.Drawing.Point(624, 1);
            this.closeNoteBtn.Name = "closeNoteBtn";
            this.closeNoteBtn.Size = new System.Drawing.Size(55, 58);
            this.closeNoteBtn.TabIndex = 20;
            this.closeNoteBtn.Text = "X";
            this.closeNoteBtn.UseVisualStyleBackColor = false;
            this.closeNoteBtn.Click += new System.EventHandler(this.closeNoteBtn_Click);
            // 
            // noteContentTxt
            // 
            this.noteContentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteContentTxt.BackColor = System.Drawing.Color.White;
            this.noteContentTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteContentTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteContentTxt.ForeColor = System.Drawing.Color.Black;
            this.noteContentTxt.Location = new System.Drawing.Point(13, 98);
            this.noteContentTxt.Multiline = true;
            this.noteContentTxt.Name = "noteContentTxt";
            this.noteContentTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.noteContentTxt.Size = new System.Drawing.Size(650, 154);
            this.noteContentTxt.TabIndex = 17;
            this.noteContentTxt.Text = "Title";
            // 
            // noteTitleTxt
            // 
            this.noteTitleTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.noteTitleTxt.BackColor = System.Drawing.Color.DarkCyan;
            this.noteTitleTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitleTxt.ForeColor = System.Drawing.Color.White;
            this.noteTitleTxt.Location = new System.Drawing.Point(13, 14);
            this.noteTitleTxt.Name = "noteTitleTxt";
            this.noteTitleTxt.Size = new System.Drawing.Size(282, 32);
            this.noteTitleTxt.TabIndex = 15;
            this.noteTitleTxt.Text = "Title";
            // 
            // noteCreatedLbl
            // 
            this.noteCreatedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.noteCreatedLbl.AutoSize = true;
            this.noteCreatedLbl.BackColor = System.Drawing.Color.Transparent;
            this.noteCreatedLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noteCreatedLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCreatedLbl.ForeColor = System.Drawing.Color.White;
            this.noteCreatedLbl.Location = new System.Drawing.Point(9, 255);
            this.noteCreatedLbl.Name = "noteCreatedLbl";
            this.noteCreatedLbl.Size = new System.Drawing.Size(139, 19);
            this.noteCreatedLbl.TabIndex = 4;
            this.noteCreatedLbl.Text = "10/12/2016 1:26 PM";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.Controls.Add(this.noteCreateTitleLbl);
            this.panel7.Location = new System.Drawing.Point(0, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(630, 24);
            this.panel7.TabIndex = 12;
            // 
            // noteCreateTitleLbl
            // 
            this.noteCreateTitleLbl.AutoSize = true;
            this.noteCreateTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.noteCreateTitleLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCreateTitleLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.noteCreateTitleLbl.Location = new System.Drawing.Point(11, 2);
            this.noteCreateTitleLbl.Name = "noteCreateTitleLbl";
            this.noteCreateTitleLbl.Size = new System.Drawing.Size(88, 19);
            this.noteCreateTitleLbl.TabIndex = 13;
            this.noteCreateTitleLbl.Text = "Created time";
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBookBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteBookBtn.FlatAppearance.BorderSize = 0;
            this.deleteBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBookBtn.Location = new System.Drawing.Point(630, 1);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(55, 57);
            this.deleteBookBtn.TabIndex = 22;
            this.deleteBookBtn.Text = "X";
            this.deleteBookBtn.UseVisualStyleBackColor = false;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // notebookTitleLbl
            // 
            this.notebookTitleLbl.AutoSize = true;
            this.notebookTitleLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.notebookTitleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebookTitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.notebookTitleLbl.Location = new System.Drawing.Point(11, 4);
            this.notebookTitleLbl.Name = "notebookTitleLbl";
            this.notebookTitleLbl.Size = new System.Drawing.Size(64, 28);
            this.notebookTitleLbl.TabIndex = 9;
            this.notebookTitleLbl.Text = "Notes";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(629, 35);
            this.panel6.TabIndex = 11;
            // 
            // bookNameLbl
            // 
            this.bookNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bookNameLbl.AutoSize = true;
            this.bookNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.bookNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLbl.ForeColor = System.Drawing.Color.White;
            this.bookNameLbl.Location = new System.Drawing.Point(9, 59);
            this.bookNameLbl.Name = "bookNameLbl";
            this.bookNameLbl.Size = new System.Drawing.Size(86, 23);
            this.bookNameLbl.TabIndex = 26;
            this.bookNameLbl.Text = "Notebook";
            // 
            // NotebookViewControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.contentPanel);
            this.Name = "NotebookViewControl";
            this.Size = new System.Drawing.Size(683, 452);
            this.Load += new System.EventHandler(this.NotebookViewControl_Load);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.bookContentPanel.ResumeLayout(false);
            this.noteEditPanel.ResumeLayout(false);
            this.noteEditPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel bookContentPanel;
        private System.Windows.Forms.FlowLayoutPanel noteListPanel;
        private System.Windows.Forms.Panel noteEditPanel;
        private System.Windows.Forms.Button saveNoteBtn;
        private System.Windows.Forms.Button deleteNoteBtn;
        private System.Windows.Forms.Button closeNoteBtn;
        private System.Windows.Forms.TextBox noteContentTxt;
        private System.Windows.Forms.TextBox noteTitleTxt;
        private System.Windows.Forms.Label noteCreatedLbl;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label noteCreateTitleLbl;
        private System.Windows.Forms.Button deleteBookBtn;
        private System.Windows.Forms.Label notebookTitleLbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label hiddenIdLbl;
        private System.Windows.Forms.Label bookNameLbl;
    }
}
