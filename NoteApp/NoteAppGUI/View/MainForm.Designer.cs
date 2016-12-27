namespace NoteAppGUI.View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.syncStatusLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noteCountLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookCountLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.createBookConfirmPanel = new System.Windows.Forms.Panel();
            this.bookCreatedBtn = new System.Windows.Forms.Button();
            this.closeBookCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.newBookNameTxt = new System.Windows.Forms.TextBox();
            this.notebookStackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.bookContentPanel = new System.Windows.Forms.Panel();
            this.notebookViewControl1 = new NoteApp.View.NotebookViewControl();
            this.noNotesMessage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBookTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.createBookConfirmPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.bookContentPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.syncStatusLbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.noteCountLbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bookCountLbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(527, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 96);
            this.panel2.TabIndex = 1;
            // 
            // syncStatusLbl
            // 
            this.syncStatusLbl.AutoSize = true;
            this.syncStatusLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncStatusLbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.syncStatusLbl.Location = new System.Drawing.Point(121, 59);
            this.syncStatusLbl.Name = "syncStatusLbl";
            this.syncStatusLbl.Size = new System.Drawing.Size(97, 28);
            this.syncStatusLbl.TabIndex = 5;
            this.syncStatusLbl.Text = "Complete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sync ";
            // 
            // noteCountLbl
            // 
            this.noteCountLbl.AutoSize = true;
            this.noteCountLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCountLbl.ForeColor = System.Drawing.Color.White;
            this.noteCountLbl.Location = new System.Drawing.Point(121, 35);
            this.noteCountLbl.Name = "noteCountLbl";
            this.noteCountLbl.Size = new System.Drawing.Size(45, 28);
            this.noteCountLbl.TabIndex = 3;
            this.noteCountLbl.Text = "334";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes";
            // 
            // bookCountLbl
            // 
            this.bookCountLbl.AutoSize = true;
            this.bookCountLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCountLbl.ForeColor = System.Drawing.Color.White;
            this.bookCountLbl.Location = new System.Drawing.Point(121, 7);
            this.bookCountLbl.Name = "bookCountLbl";
            this.bookCountLbl.Size = new System.Drawing.Size(34, 28);
            this.bookCountLbl.TabIndex = 1;
            this.bookCountLbl.Text = "11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notebooks";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.addBookBtn);
            this.panel3.Controls.Add(this.leftPanel);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 412);
            this.panel3.TabIndex = 5;
            // 
            // addBookBtn
            // 
            this.addBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBookBtn.BackColor = System.Drawing.Color.White;
            this.addBookBtn.FlatAppearance.BorderSize = 0;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addBookBtn.Location = new System.Drawing.Point(97, 352);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(57, 51);
            this.addBookBtn.TabIndex = 11;
            this.addBookBtn.Text = "Add Book";
            this.addBookTip.SetToolTip(this.addBookBtn, "Add notebook");
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click_1);
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.Controls.Add(this.createBookConfirmPanel);
            this.leftPanel.Controls.Add(this.notebookStackPanel);
            this.leftPanel.Location = new System.Drawing.Point(3, 6);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(262, 340);
            this.leftPanel.TabIndex = 10;
            // 
            // createBookConfirmPanel
            // 
            this.createBookConfirmPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createBookConfirmPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.createBookConfirmPanel.Controls.Add(this.bookCreatedBtn);
            this.createBookConfirmPanel.Controls.Add(this.closeBookCreate);
            this.createBookConfirmPanel.Controls.Add(this.label6);
            this.createBookConfirmPanel.Controls.Add(this.newBookNameTxt);
            this.createBookConfirmPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBookConfirmPanel.Location = new System.Drawing.Point(12, 237);
            this.createBookConfirmPanel.Name = "createBookConfirmPanel";
            this.createBookConfirmPanel.Size = new System.Drawing.Size(223, 95);
            this.createBookConfirmPanel.TabIndex = 4;
            // 
            // bookCreatedBtn
            // 
            this.bookCreatedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bookCreatedBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bookCreatedBtn.FlatAppearance.BorderSize = 0;
            this.bookCreatedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookCreatedBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCreatedBtn.ForeColor = System.Drawing.Color.White;
            this.bookCreatedBtn.Location = new System.Drawing.Point(150, 3);
            this.bookCreatedBtn.Name = "bookCreatedBtn";
            this.bookCreatedBtn.Size = new System.Drawing.Size(34, 38);
            this.bookCreatedBtn.TabIndex = 28;
            this.bookCreatedBtn.Text = "X";
            this.bookCreatedBtn.UseVisualStyleBackColor = false;
            // 
            // closeBookCreate
            // 
            this.closeBookCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeBookCreate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.closeBookCreate.FlatAppearance.BorderSize = 0;
            this.closeBookCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBookCreate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.closeBookCreate.ForeColor = System.Drawing.Color.White;
            this.closeBookCreate.Location = new System.Drawing.Point(187, 3);
            this.closeBookCreate.Name = "closeBookCreate";
            this.closeBookCreate.Size = new System.Drawing.Size(35, 38);
            this.closeBookCreate.TabIndex = 27;
            this.closeBookCreate.Text = "X";
            this.closeBookCreate.UseVisualStyleBackColor = false;
            this.closeBookCreate.Click += new System.EventHandler(this.closeBookCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "New Notebook";
            // 
            // newBookNameTxt
            // 
            this.newBookNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newBookNameTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBookNameTxt.Location = new System.Drawing.Point(10, 48);
            this.newBookNameTxt.Name = "newBookNameTxt";
            this.newBookNameTxt.Size = new System.Drawing.Size(206, 31);
            this.newBookNameTxt.TabIndex = 0;
            // 
            // notebookStackPanel
            // 
            this.notebookStackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notebookStackPanel.AutoScroll = true;
            this.notebookStackPanel.Location = new System.Drawing.Point(12, 3);
            this.notebookStackPanel.Name = "notebookStackPanel";
            this.notebookStackPanel.Size = new System.Drawing.Size(247, 228);
            this.notebookStackPanel.TabIndex = 0;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(268, 412);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape2.Name = "lineShape1";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = -1;
            this.lineShape2.Y1 = 0;
            this.lineShape2.Y2 = 419;
            // 
            // userNameLbl
            // 
            this.userNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.Color.White;
            this.userNameLbl.Location = new System.Drawing.Point(10, 59);
            this.userNameLbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(126, 28);
            this.userNameLbl.TabIndex = 6;
            this.userNameLbl.Text = "John Smith";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 57);
            this.label5.TabIndex = 3;
            this.label5.Text = "Note App";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.userNameLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 96);
            this.panel1.TabIndex = 6;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(3, 4);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(230, 32);
            this.searchTxtBox.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.addNoteBtn);
            this.panel5.Controls.Add(this.bookContentPanel);
            this.panel5.Location = new System.Drawing.Point(271, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 448);
            this.panel5.TabIndex = 9;
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNoteBtn.BackColor = System.Drawing.Color.White;
            this.addNoteBtn.FlatAppearance.BorderSize = 0;
            this.addNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoteBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNoteBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.addNoteBtn.Location = new System.Drawing.Point(229, 388);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(57, 51);
            this.addNoteBtn.TabIndex = 12;
            this.addNoteBtn.Text = "Add Book";
            this.addBookTip.SetToolTip(this.addNoteBtn, "Add new note");
            this.addNoteBtn.UseVisualStyleBackColor = false;
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click_1);
            // 
            // bookContentPanel
            // 
            this.bookContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookContentPanel.BackColor = System.Drawing.Color.White;
            this.bookContentPanel.Controls.Add(this.notebookViewControl1);
            this.bookContentPanel.Controls.Add(this.noNotesMessage);
            this.bookContentPanel.Location = new System.Drawing.Point(1, 0);
            this.bookContentPanel.Name = "bookContentPanel";
            this.bookContentPanel.Size = new System.Drawing.Size(524, 382);
            this.bookContentPanel.TabIndex = 13;
            // 
            // notebookViewControl1
            // 
            this.notebookViewControl1.activeBook = null;
            this.notebookViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notebookViewControl1.Location = new System.Drawing.Point(0, 0);
            this.notebookViewControl1.Name = "notebookViewControl1";
            this.notebookViewControl1.Size = new System.Drawing.Size(524, 382);
            this.notebookViewControl1.TabIndex = 16;
            this.addBookTip.SetToolTip(this.notebookViewControl1, "Delete book");
            // 
            // noNotesMessage
            // 
            this.noNotesMessage.AutoSize = true;
            this.noNotesMessage.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noNotesMessage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.noNotesMessage.Location = new System.Drawing.Point(73, 175);
            this.noNotesMessage.Name = "noNotesMessage";
            this.noNotesMessage.Size = new System.Drawing.Size(378, 32);
            this.noNotesMessage.TabIndex = 15;
            this.noNotesMessage.Text = "Get organised! start taking notes...";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.searchBtn);
            this.panel4.Controls.Add(this.searchTxtBox);
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 40);
            this.panel4.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(233, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(32, 32);
            this.searchBtn.TabIndex = 29;
            this.searchBtn.Text = "X";
            this.addBookTip.SetToolTip(this.searchBtn, "Search notes");
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBookTip
            // 
            this.addBookTip.AutomaticDelay = 50;
            this.addBookTip.AutoPopDelay = 5000;
            this.addBookTip.InitialDelay = 50;
            this.addBookTip.ReshowDelay = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(799, 552);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Note App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.createBookConfirmPanel.ResumeLayout(false);
            this.createBookConfirmPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.bookContentPanel.ResumeLayout(false);
            this.bookContentPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noteCountLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bookCountLbl;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label syncStatusLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.FlowLayoutPanel notebookStackPanel;
        private System.Windows.Forms.Panel createBookConfirmPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newBookNameTxt;
        private System.Windows.Forms.Panel bookContentPanel;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button addNoteBtn;
        private System.Windows.Forms.Button bookCreatedBtn;
        private System.Windows.Forms.Button closeBookCreate;
        private System.Windows.Forms.Button searchBtn;
        private NoteApp.View.NotebookViewControl notebookViewControl1;
        private System.Windows.Forms.Label noNotesMessage;
        private System.Windows.Forms.ToolTip addBookTip;
    }
}

