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
            this.panel2 = new System.Windows.Forms.Panel();
            this.syncStatusLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noteCountLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookCountLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userNameLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.notebookTitleLbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.noteCreateTitleLbl = new System.Windows.Forms.Label();
            this.notesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.notebookStackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createBookConfirmPanel = new System.Windows.Forms.Panel();
            this.noteCreatedBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.newBookNameTxt = new System.Windows.Forms.TextBox();
            this.noteEntryBox1 = new NoteAppGUI.View.NoteEntryBox();
            this.noteEntryBox3 = new NoteAppGUI.View.NoteEntryBox();
            this.noteEntryBox7 = new NoteAppGUI.View.NoteEntryBox();
            this.noteEntryBox5 = new NoteAppGUI.View.NoteEntryBox();
            this.noteEntryBox6 = new NoteAppGUI.View.NoteEntryBox();
            this.noteEntryBox4 = new NoteAppGUI.View.NoteEntryBox();
            this.noteEntryBox2 = new NoteAppGUI.View.NoteEntryBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.notesPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.createBookConfirmPanel.SuspendLayout();
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
            this.syncStatusLbl.ForeColor = System.Drawing.Color.White;
            this.syncStatusLbl.Location = new System.Drawing.Point(121, 59);
            this.syncStatusLbl.Name = "syncStatusLbl";
            this.syncStatusLbl.Size = new System.Drawing.Size(124, 28);
            this.syncStatusLbl.TabIndex = 5;
            this.syncStatusLbl.Text = "In Progress....";
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
            this.addBookBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.ForeColor = System.Drawing.Color.White;
            this.addBookBtn.Location = new System.Drawing.Point(114, 363);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(124, 36);
            this.addBookBtn.TabIndex = 9;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.Controls.Add(this.notebookStackPanel);
            this.leftPanel.Controls.Add(this.createBookConfirmPanel);
            this.leftPanel.Location = new System.Drawing.Point(12, 6);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(253, 340);
            this.leftPanel.TabIndex = 10;
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
            this.userNameLbl.Text = "User Name";
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
            this.searchTxtBox.Size = new System.Drawing.Size(262, 32);
            this.searchTxtBox.TabIndex = 10;
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNoteBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNoteBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNoteBtn.ForeColor = System.Drawing.Color.White;
            this.addNoteBtn.Location = new System.Drawing.Point(379, 399);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(122, 36);
            this.addNoteBtn.TabIndex = 8;
            this.addNoteBtn.Text = "Add Note";
            this.addNoteBtn.UseVisualStyleBackColor = false;
            // 
            // notebookTitleLbl
            // 
            this.notebookTitleLbl.AutoSize = true;
            this.notebookTitleLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.notebookTitleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebookTitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.notebookTitleLbl.Location = new System.Drawing.Point(11, 4);
            this.notebookTitleLbl.Name = "notebookTitleLbl";
            this.notebookTitleLbl.Size = new System.Drawing.Size(118, 28);
            this.notebookTitleLbl.TabIndex = 9;
            this.notebookTitleLbl.Text = "Notebook 1";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.notesPanel);
            this.panel5.Controls.Add(this.notebookTitleLbl);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.addNoteBtn);
            this.panel5.Location = new System.Drawing.Point(271, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 448);
            this.panel5.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.AliceBlue;
            this.panel7.Controls.Add(this.noteCreateTitleLbl);
            this.panel7.Location = new System.Drawing.Point(0, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(526, 24);
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
            this.noteCreateTitleLbl.Size = new System.Drawing.Size(139, 19);
            this.noteCreateTitleLbl.TabIndex = 13;
            this.noteCreateTitleLbl.Text = "10/12/2016 1:26 PM";
            // 
            // notesPanel
            // 
            this.notesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesPanel.AutoScroll = true;
            this.notesPanel.BackColor = System.Drawing.Color.White;
            this.notesPanel.Controls.Add(this.noteEntryBox1);
            this.notesPanel.Controls.Add(this.noteEntryBox3);
            this.notesPanel.Controls.Add(this.noteEntryBox7);
            this.notesPanel.Controls.Add(this.noteEntryBox5);
            this.notesPanel.Controls.Add(this.noteEntryBox6);
            this.notesPanel.Controls.Add(this.noteEntryBox4);
            this.notesPanel.Controls.Add(this.noteEntryBox2);
            this.notesPanel.Location = new System.Drawing.Point(16, 77);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(500, 302);
            this.notesPanel.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(525, 35);
            this.panel6.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(499, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.searchTxtBox);
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 40);
            this.panel4.TabIndex = 8;
            // 
            // notebookStackPanel
            // 
            this.notebookStackPanel.AutoScroll = true;
            this.notebookStackPanel.Location = new System.Drawing.Point(3, 3);
            this.notebookStackPanel.Name = "notebookStackPanel";
            this.notebookStackPanel.Size = new System.Drawing.Size(245, 216);
            this.notebookStackPanel.TabIndex = 0;
            // 
            // createBookConfirmPanel
            // 
            this.createBookConfirmPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.createBookConfirmPanel.Controls.Add(this.noteCreatedBtn);
            this.createBookConfirmPanel.Controls.Add(this.label6);
            this.createBookConfirmPanel.Controls.Add(this.newBookNameTxt);
            this.createBookConfirmPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBookConfirmPanel.Location = new System.Drawing.Point(3, 225);
            this.createBookConfirmPanel.Name = "createBookConfirmPanel";
            this.createBookConfirmPanel.Size = new System.Drawing.Size(223, 108);
            this.createBookConfirmPanel.TabIndex = 2;
            // 
            // noteCreatedBtn
            // 
            this.noteCreatedBtn.BackColor = System.Drawing.Color.Gray;
            this.noteCreatedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteCreatedBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCreatedBtn.ForeColor = System.Drawing.Color.White;
            this.noteCreatedBtn.Location = new System.Drawing.Point(138, 68);
            this.noteCreatedBtn.Name = "noteCreatedBtn";
            this.noteCreatedBtn.Size = new System.Drawing.Size(75, 32);
            this.noteCreatedBtn.TabIndex = 11;
            this.noteCreatedBtn.Text = "Create";
            this.noteCreatedBtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Create New Notebook";
            // 
            // newBookNameTxt
            // 
            this.newBookNameTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBookNameTxt.Location = new System.Drawing.Point(7, 31);
            this.newBookNameTxt.Name = "newBookNameTxt";
            this.newBookNameTxt.Size = new System.Drawing.Size(206, 31);
            this.newBookNameTxt.TabIndex = 0;
            // 
            // noteEntryBox1
            // 
            this.noteEntryBox1.Location = new System.Drawing.Point(3, 3);
            this.noteEntryBox1.Name = "noteEntryBox1";
            this.noteEntryBox1.Size = new System.Drawing.Size(196, 117);
            this.noteEntryBox1.TabIndex = 0;
            // 
            // noteEntryBox3
            // 
            this.noteEntryBox3.Location = new System.Drawing.Point(205, 3);
            this.noteEntryBox3.Name = "noteEntryBox3";
            this.noteEntryBox3.Size = new System.Drawing.Size(196, 117);
            this.noteEntryBox3.TabIndex = 2;
            // 
            // noteEntryBox7
            // 
            this.noteEntryBox7.Location = new System.Drawing.Point(3, 126);
            this.noteEntryBox7.Name = "noteEntryBox7";
            this.noteEntryBox7.Size = new System.Drawing.Size(196, 117);
            this.noteEntryBox7.TabIndex = 15;
            // 
            // noteEntryBox5
            // 
            this.noteEntryBox5.Location = new System.Drawing.Point(205, 126);
            this.noteEntryBox5.Name = "noteEntryBox5";
            this.noteEntryBox5.Size = new System.Drawing.Size(196, 117);
            this.noteEntryBox5.TabIndex = 13;
            // 
            // noteEntryBox6
            // 
            this.noteEntryBox6.Location = new System.Drawing.Point(3, 249);
            this.noteEntryBox6.Name = "noteEntryBox6";
            this.noteEntryBox6.Size = new System.Drawing.Size(196, 117);
            this.noteEntryBox6.TabIndex = 14;
            // 
            // noteEntryBox4
            // 
            this.noteEntryBox4.Location = new System.Drawing.Point(205, 249);
            this.noteEntryBox4.Name = "noteEntryBox4";
            this.noteEntryBox4.Size = new System.Drawing.Size(196, 117);
            this.noteEntryBox4.TabIndex = 3;
            // 
            // noteEntryBox2
            // 
            this.noteEntryBox2.Location = new System.Drawing.Point(3, 372);
            this.noteEntryBox2.Name = "noteEntryBox2";
            this.noteEntryBox2.Size = new System.Drawing.Size(196, 117);
            this.noteEntryBox2.TabIndex = 1;
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
            this.Name = "MainForm";
            this.Text = "Note App";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.notesPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.createBookConfirmPanel.ResumeLayout(false);
            this.createBookConfirmPanel.PerformLayout();
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Label notebookTitleLbl;
        private System.Windows.Forms.Button addNoteBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel notesPanel;
        private System.Windows.Forms.FlowLayoutPanel leftPanel;
        private NoteEntryBox noteEntryBox1;
        private NoteEntryBox noteEntryBox3;
        private NoteEntryBox noteEntryBox7;
        private NoteEntryBox noteEntryBox5;
        private NoteEntryBox noteEntryBox6;
        private NoteEntryBox noteEntryBox4;
        private NoteEntryBox noteEntryBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label noteCreateTitleLbl;
        private System.Windows.Forms.FlowLayoutPanel notebookStackPanel;
        private System.Windows.Forms.Panel createBookConfirmPanel;
        private System.Windows.Forms.Button noteCreatedBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newBookNameTxt;
    }
}

