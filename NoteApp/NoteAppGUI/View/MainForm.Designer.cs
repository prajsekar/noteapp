namespace NoteAppGUI
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
            this.bookView = new System.Windows.Forms.TreeView();
            this.addBookBtn = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            this.noteList = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel3.Controls.Add(this.bookView);
            this.panel3.Controls.Add(this.addBookBtn);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 412);
            this.panel3.TabIndex = 5;
            // 
            // bookView
            // 
            this.bookView.Location = new System.Drawing.Point(7, 6);
            this.bookView.Name = "bookView";
            this.bookView.Size = new System.Drawing.Size(253, 337);
            this.bookView.TabIndex = 10;
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addBookBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.Location = new System.Drawing.Point(206, 363);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(49, 36);
            this.addBookBtn.TabIndex = 9;
            this.addBookBtn.Text = "+";
            this.addBookBtn.UseVisualStyleBackColor = false;
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
            this.addNoteBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addNoteBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNoteBtn.Location = new System.Drawing.Point(471, 399);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(49, 36);
            this.addNoteBtn.TabIndex = 8;
            this.addNoteBtn.Text = "+";
            this.addNoteBtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(11, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Notes";
            // 
            // noteList
            // 
            this.noteList.Location = new System.Drawing.Point(7, 42);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(513, 337);
            this.noteList.TabIndex = 12;
            this.noteList.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.noteList);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.addNoteBtn);
            this.panel5.Location = new System.Drawing.Point(271, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 448);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(525, 35);
            this.panel6.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.searchTxtBox);
            this.panel4.Location = new System.Drawing.Point(0, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 40);
            this.panel4.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.TreeView bookView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addNoteBtn;
        private System.Windows.Forms.ListView noteList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
    }
}

