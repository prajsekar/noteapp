namespace NoteAppGUI.View
{
    partial class NoteEntryBox
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
            this.noteNameLbl = new System.Windows.Forms.Label();
            this.noteCreatedLbl = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noteContentLbl = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteNameLbl
            // 
            this.noteNameLbl.AutoSize = true;
            this.noteNameLbl.BackColor = System.Drawing.Color.Moccasin;
            this.noteNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noteNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.noteNameLbl.Location = new System.Drawing.Point(4, 4);
            this.noteNameLbl.Name = "noteNameLbl";
            this.noteNameLbl.Size = new System.Drawing.Size(65, 28);
            this.noteNameLbl.TabIndex = 0;
            this.noteNameLbl.Text = "label1";
            // 
            // noteCreatedLbl
            // 
            this.noteCreatedLbl.AutoSize = true;
            this.noteCreatedLbl.BackColor = System.Drawing.Color.Moccasin;
            this.noteCreatedLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noteCreatedLbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCreatedLbl.Location = new System.Drawing.Point(4, 30);
            this.noteCreatedLbl.Name = "noteCreatedLbl";
            this.noteCreatedLbl.Size = new System.Drawing.Size(139, 19);
            this.noteCreatedLbl.TabIndex = 1;
            this.noteCreatedLbl.Text = "10/12/2016 1:26 PM";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Moccasin;
            this.contentPanel.Controls.Add(this.panel1);
            this.contentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentPanel.Location = new System.Drawing.Point(3, 3);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(186, 110);
            this.contentPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.noteContentLbl);
            this.panel1.Enabled = false;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 57);
            this.panel1.TabIndex = 0;
            // 
            // noteContentLbl
            // 
            this.noteContentLbl.AutoEllipsis = true;
            this.noteContentLbl.AutoSize = true;
            this.noteContentLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteContentLbl.ForeColor = System.Drawing.Color.Black;
            this.noteContentLbl.Location = new System.Drawing.Point(5, 4);
            this.noteContentLbl.MaximumSize = new System.Drawing.Size(180, 50);
            this.noteContentLbl.Name = "noteContentLbl";
            this.noteContentLbl.Size = new System.Drawing.Size(178, 50);
            this.noteContentLbl.TabIndex = 0;
            this.noteContentLbl.Text = "This is note content, this can be multiple lines if not pages";
            // 
            // NoteEntryBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noteCreatedLbl);
            this.Controls.Add(this.noteNameLbl);
            this.Controls.Add(this.contentPanel);
            this.Name = "NoteEntryBox";
            this.Size = new System.Drawing.Size(196, 117);
            this.contentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteNameLbl;
        private System.Windows.Forms.Label noteCreatedLbl;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noteContentLbl;
    }
}
