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
            this.saveNoteBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noteContentTxt = new System.Windows.Forms.TextBox();
            this.deleteNoteBtn = new System.Windows.Forms.Button();
            this.noteTitleTxt = new System.Windows.Forms.TextBox();
            this.notebookTitleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.notebookTitleLbl);
            this.panel1.Controls.Add(this.noteTitleTxt);
            this.panel1.Controls.Add(this.booksCombo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 95);
            this.panel1.TabIndex = 0;
            // 
            // booksCombo
            // 
            this.booksCombo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksCombo.FormattingEnabled = true;
            this.booksCombo.Location = new System.Drawing.Point(304, 43);
            this.booksCombo.Name = "booksCombo";
            this.booksCombo.Size = new System.Drawing.Size(263, 33);
            this.booksCombo.TabIndex = 11;            
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNoteBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNoteBtn.ForeColor = System.Drawing.Color.White;
            this.saveNoteBtn.Location = new System.Drawing.Point(486, 344);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(82, 36);
            this.saveNoteBtn.TabIndex = 11;
            this.saveNoteBtn.Text = "Save";
            this.saveNoteBtn.UseVisualStyleBackColor = false;            
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
            this.noteContentTxt.Size = new System.Drawing.Size(578, 238);
            this.noteContentTxt.TabIndex = 2;
            // 
            // deleteNoteBtn
            // 
            this.deleteNoteBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.deleteNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNoteBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNoteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteNoteBtn.Location = new System.Drawing.Point(386, 344);
            this.deleteNoteBtn.Name = "deleteNoteBtn";
            this.deleteNoteBtn.Size = new System.Drawing.Size(82, 36);
            this.deleteNoteBtn.TabIndex = 12;
            this.deleteNoteBtn.Text = "Delete";
            this.deleteNoteBtn.UseVisualStyleBackColor = false;
            // 
            // noteTitleTxt
            // 
            this.noteTitleTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitleTxt.Location = new System.Drawing.Point(11, 44);
            this.noteTitleTxt.Name = "noteTitleTxt";
            this.noteTitleTxt.Size = new System.Drawing.Size(263, 32);
            this.noteTitleTxt.TabIndex = 14;
            // 
            // notebookTitleLbl
            // 
            this.notebookTitleLbl.AutoSize = true;
            this.notebookTitleLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.notebookTitleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebookTitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.notebookTitleLbl.Location = new System.Drawing.Point(10, 13);
            this.notebookTitleLbl.Name = "notebookTitleLbl";
            this.notebookTitleLbl.Size = new System.Drawing.Size(49, 28);
            this.notebookTitleLbl.TabIndex = 15;
            this.notebookTitleLbl.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(299, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Note Book";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 392);
            this.Controls.Add(this.deleteNoteBtn);
            this.Controls.Add(this.saveNoteBtn);
            this.Controls.Add(this.noteContentTxt);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button saveNoteBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox noteContentTxt;
        private System.Windows.Forms.Button deleteNoteBtn;
        private System.Windows.Forms.TextBox noteTitleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label notebookTitleLbl;
    }
}