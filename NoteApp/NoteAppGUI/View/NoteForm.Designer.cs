namespace NoteAppGUI.View
{
    partial class NoteForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.booksCombo = new System.Windows.Forms.ComboBox();
            this.delNoteBtn = new System.Windows.Forms.Button();
            this.saveNoteBtn = new System.Windows.Forms.Button();
            this.noteTitleLbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noteContentTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.noteTitleLbl);
            this.panel1.Controls.Add(this.delNoteBtn);
            this.panel1.Controls.Add(this.booksCombo);
            this.panel1.Controls.Add(this.saveNoteBtn);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 98);
            this.panel1.TabIndex = 0;
            // 
            // booksCombo
            // 
            this.booksCombo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksCombo.FormattingEnabled = true;
            this.booksCombo.Location = new System.Drawing.Point(16, 54);
            this.booksCombo.Name = "booksCombo";
            this.booksCombo.Size = new System.Drawing.Size(152, 33);
            this.booksCombo.TabIndex = 11;
            this.booksCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // delNoteBtn
            // 
            this.delNoteBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.delNoteBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delNoteBtn.Location = new System.Drawing.Point(471, 12);
            this.delNoteBtn.Name = "delNoteBtn";
            this.delNoteBtn.Size = new System.Drawing.Size(49, 36);
            this.delNoteBtn.TabIndex = 12;
            this.delNoteBtn.Text = "-";
            this.delNoteBtn.UseVisualStyleBackColor = false;
            this.delNoteBtn.Click += new System.EventHandler(this.delNoteBtn_Click);
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveNoteBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNoteBtn.Location = new System.Drawing.Point(526, 12);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(49, 36);
            this.saveNoteBtn.TabIndex = 11;
            this.saveNoteBtn.Text = "S";
            this.saveNoteBtn.UseVisualStyleBackColor = false;
            this.saveNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // noteTitleLbl
            // 
            this.noteTitleLbl.AutoSize = true;
            this.noteTitleLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.noteTitleLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.noteTitleLbl.Location = new System.Drawing.Point(11, 9);
            this.noteTitleLbl.Name = "noteTitleLbl";
            this.noteTitleLbl.Size = new System.Drawing.Size(68, 35);
            this.noteTitleLbl.TabIndex = 13;
            this.noteTitleLbl.Text = "Title";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // noteContentTxt
            // 
            this.noteContentTxt.Location = new System.Drawing.Point(1, 93);
            this.noteContentTxt.Multiline = true;
            this.noteContentTxt.Name = "noteContentTxt";
            this.noteContentTxt.Size = new System.Drawing.Size(578, 289);
            this.noteContentTxt.TabIndex = 2;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 382);
            this.Controls.Add(this.noteContentTxt);
            this.Controls.Add(this.panel1);
            this.Name = "NoteForm";
            this.Text = "Note";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox booksCombo;
        private System.Windows.Forms.Button delNoteBtn;
        private System.Windows.Forms.Button saveNoteBtn;
        private System.Windows.Forms.Label noteTitleLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox noteContentTxt;
    }
}