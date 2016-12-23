namespace NoteAppGUI.View
{
    partial class NotebookControl
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
            this.bookPanel = new System.Windows.Forms.Panel();
            this.bookNameLbl = new System.Windows.Forms.Label();
            this.noteIconLbl = new System.Windows.Forms.Label();
            this.bookPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookPanel
            // 
            this.bookPanel.BackColor = System.Drawing.Color.Teal;
            this.bookPanel.Controls.Add(this.noteIconLbl);
            this.bookPanel.Controls.Add(this.bookNameLbl);
            this.bookPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookPanel.Location = new System.Drawing.Point(0, 3);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(210, 48);
            this.bookPanel.TabIndex = 0;
            // 
            // bookNameLbl
            // 
            this.bookNameLbl.AutoSize = true;
            this.bookNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameLbl.ForeColor = System.Drawing.Color.White;
            this.bookNameLbl.Location = new System.Drawing.Point(36, 8);
            this.bookNameLbl.Name = "bookNameLbl";
            this.bookNameLbl.Size = new System.Drawing.Size(118, 28);
            this.bookNameLbl.TabIndex = 2;
            this.bookNameLbl.Text = "Notebook 1";
            // 
            // noteIconLbl
            // 
            this.noteIconLbl.AutoSize = true;
            this.noteIconLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteIconLbl.ForeColor = System.Drawing.Color.White;
            this.noteIconLbl.Location = new System.Drawing.Point(1, 5);
            this.noteIconLbl.Name = "noteIconLbl";
            this.noteIconLbl.Size = new System.Drawing.Size(37, 34);
            this.noteIconLbl.TabIndex = 3;
            this.noteIconLbl.Text = "X";
            // 
            // NotebookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookPanel);
            this.Name = "NotebookControl";
            this.Size = new System.Drawing.Size(210, 48);
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Label bookNameLbl;
        private System.Windows.Forms.Label noteIconLbl;
    }
}
