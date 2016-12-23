namespace NoteApp.View
{
    partial class noteEditControl
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.booksCombo = new System.Windows.Forms.ComboBox();
            this.noteTitleTxt = new System.Windows.Forms.TextBox();
            this.noteCreatedLbl = new System.Windows.Forms.Label();
            this.noteCreatedBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.closeNoteBtn = new System.Windows.Forms.Button();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.DarkCyan;
            this.panel8.Controls.Add(this.closeNoteBtn);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.noteCreatedBtn);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Controls.Add(this.booksCombo);
            this.panel8.Controls.Add(this.noteTitleTxt);
            this.panel8.Controls.Add(this.noteCreatedLbl);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(516, 312);
            this.panel8.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.textBox1.Location = new System.Drawing.Point(13, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(490, 167);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Title";
            // 
            // booksCombo
            // 
            this.booksCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.booksCombo.BackColor = System.Drawing.Color.DarkCyan;
            this.booksCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksCombo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksCombo.ForeColor = System.Drawing.Color.White;
            this.booksCombo.FormattingEnabled = true;
            this.booksCombo.Location = new System.Drawing.Point(13, 53);
            this.booksCombo.Name = "booksCombo";
            this.booksCombo.Size = new System.Drawing.Size(282, 33);
            this.booksCombo.TabIndex = 16;
            // 
            // noteTitleTxt
            // 
            this.noteTitleTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.noteTitleTxt.BackColor = System.Drawing.Color.DarkCyan;
            this.noteTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTitleTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitleTxt.ForeColor = System.Drawing.Color.White;
            this.noteTitleTxt.Location = new System.Drawing.Point(13, 16);
            this.noteTitleTxt.Name = "noteTitleTxt";
            this.noteTitleTxt.Size = new System.Drawing.Size(282, 25);
            this.noteTitleTxt.TabIndex = 15;
            this.noteTitleTxt.Text = "Title";
            // 
            // noteCreatedLbl
            // 
            this.noteCreatedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noteCreatedLbl.AutoSize = true;
            this.noteCreatedLbl.BackColor = System.Drawing.Color.Transparent;
            this.noteCreatedLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noteCreatedLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCreatedLbl.ForeColor = System.Drawing.Color.White;
            this.noteCreatedLbl.Location = new System.Drawing.Point(9, 267);
            this.noteCreatedLbl.Name = "noteCreatedLbl";
            this.noteCreatedLbl.Size = new System.Drawing.Size(139, 19);
            this.noteCreatedLbl.TabIndex = 4;
            this.noteCreatedLbl.Text = "10/12/2016 1:26 PM";
            // 
            // noteCreatedBtn
            // 
            this.noteCreatedBtn.BackColor = System.Drawing.Color.Gray;
            this.noteCreatedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteCreatedBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCreatedBtn.ForeColor = System.Drawing.Color.White;
            this.noteCreatedBtn.Location = new System.Drawing.Point(427, 272);
            this.noteCreatedBtn.Name = "noteCreatedBtn";
            this.noteCreatedBtn.Size = new System.Drawing.Size(75, 32);
            this.noteCreatedBtn.TabIndex = 18;
            this.noteCreatedBtn.Text = "Save";
            this.noteCreatedBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(346, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // closeNoteBtn
            // 
            this.closeNoteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.closeNoteBtn.FlatAppearance.BorderSize = 0;
            this.closeNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeNoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.closeNoteBtn.ForeColor = System.Drawing.Color.White;
            this.closeNoteBtn.Location = new System.Drawing.Point(484, 1);
            this.closeNoteBtn.Name = "closeNoteBtn";
            this.closeNoteBtn.Size = new System.Drawing.Size(31, 33);
            this.closeNoteBtn.TabIndex = 20;
            this.closeNoteBtn.Text = "X";
            this.closeNoteBtn.UseVisualStyleBackColor = false;
            // 
            // noteEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Name = "noteEditControl";
            this.Size = new System.Drawing.Size(522, 318);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox booksCombo;
        private System.Windows.Forms.TextBox noteTitleTxt;
        private System.Windows.Forms.Label noteCreatedLbl;
        private System.Windows.Forms.Button closeNoteBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button noteCreatedBtn;

    }
}
