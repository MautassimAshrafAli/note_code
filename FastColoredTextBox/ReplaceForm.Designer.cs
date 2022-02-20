namespace FastColoredTextBoxNS
{
    partial class ReplaceForm
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
            this.tbFind = new System.Windows.Forms.TextBox();
            this.cbRegex = new System.Windows.Forms.CheckBox();
            this.cbMatchCase = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWholeWord = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btFindNext = new Guna.UI.WinForms.GunaButton();
            this.btClose = new Guna.UI.WinForms.GunaButton();
            this.btReplace = new Guna.UI.WinForms.GunaButton();
            this.btReplaceAll = new Guna.UI.WinForms.GunaButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.replace_note = new System.Windows.Forms.Label();
            this.form_opacty = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbFind
            // 
            this.tbFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.tbFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFind.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbFind.ForeColor = System.Drawing.Color.White;
            this.tbFind.Location = new System.Drawing.Point(77, 82);
            this.tbFind.Margin = new System.Windows.Forms.Padding(6);
            this.tbFind.Multiline = true;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(648, 35);
            this.tbFind.TabIndex = 0;
            this.tbFind.TextChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // cbRegex
            // 
            this.cbRegex.AutoSize = true;
            this.cbRegex.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cbRegex.ForeColor = System.Drawing.Color.White;
            this.cbRegex.Location = new System.Drawing.Point(565, 151);
            this.cbRegex.Margin = new System.Windows.Forms.Padding(6);
            this.cbRegex.Name = "cbRegex";
            this.cbRegex.Size = new System.Drawing.Size(111, 35);
            this.cbRegex.TabIndex = 3;
            this.cbRegex.Text = "Regex";
            this.cbRegex.UseVisualStyleBackColor = true;
            this.cbRegex.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // cbMatchCase
            // 
            this.cbMatchCase.AutoSize = true;
            this.cbMatchCase.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cbMatchCase.ForeColor = System.Drawing.Color.White;
            this.cbMatchCase.Location = new System.Drawing.Point(114, 151);
            this.cbMatchCase.Margin = new System.Windows.Forms.Padding(6);
            this.cbMatchCase.Name = "cbMatchCase";
            this.cbMatchCase.Size = new System.Drawing.Size(169, 35);
            this.cbMatchCase.TabIndex = 1;
            this.cbMatchCase.Text = "Match case";
            this.cbMatchCase.UseVisualStyleBackColor = true;
            this.cbMatchCase.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(77, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find: ";
            // 
            // cbWholeWord
            // 
            this.cbWholeWord.AutoSize = true;
            this.cbWholeWord.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cbWholeWord.ForeColor = System.Drawing.Color.White;
            this.cbWholeWord.Location = new System.Drawing.Point(295, 151);
            this.cbWholeWord.Margin = new System.Windows.Forms.Padding(6);
            this.cbWholeWord.Name = "cbWholeWord";
            this.cbWholeWord.Size = new System.Drawing.Size(253, 35);
            this.cbWholeWord.TabIndex = 2;
            this.cbWholeWord.Text = "Match whole word";
            this.cbWholeWord.UseVisualStyleBackColor = true;
            this.cbWholeWord.CheckedChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(71, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Replace:";
            // 
            // tbReplace
            // 
            this.tbReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.tbReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbReplace.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbReplace.ForeColor = System.Drawing.Color.White;
            this.tbReplace.Location = new System.Drawing.Point(71, 278);
            this.tbReplace.Margin = new System.Windows.Forms.Padding(6);
            this.tbReplace.Multiline = true;
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(654, 35);
            this.tbReplace.TabIndex = 0;
            this.tbReplace.TextChanged += new System.EventHandler(this.cbMatchCase_CheckedChanged);
            this.tbReplace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            // 
            // btFindNext
            // 
            this.btFindNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btFindNext.AnimationHoverSpeed = 0.07F;
            this.btFindNext.AnimationSpeed = 0.03F;
            this.btFindNext.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btFindNext.BorderColor = System.Drawing.Color.Black;
            this.btFindNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btFindNext.FocusedColor = System.Drawing.Color.Empty;
            this.btFindNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFindNext.ForeColor = System.Drawing.Color.White;
            this.btFindNext.Image = null;
            this.btFindNext.ImageSize = new System.Drawing.Size(20, 20);
            this.btFindNext.Location = new System.Drawing.Point(71, 454);
            this.btFindNext.Name = "btFindNext";
            this.btFindNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btFindNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btFindNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btFindNext.OnHoverImage = null;
            this.btFindNext.OnPressedColor = System.Drawing.Color.Black;
            this.btFindNext.Size = new System.Drawing.Size(228, 64);
            this.btFindNext.TabIndex = 18;
            this.btFindNext.Text = "Find next";
            this.btFindNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btFindNext.Click += new System.EventHandler(this.btFindNext_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btClose.AnimationHoverSpeed = 0.07F;
            this.btClose.AnimationSpeed = 0.03F;
            this.btClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btClose.BorderColor = System.Drawing.Color.Black;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btClose.FocusedColor = System.Drawing.Color.Empty;
            this.btClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Image = null;
            this.btClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btClose.Location = new System.Drawing.Point(589, 538);
            this.btClose.Name = "btClose";
            this.btClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btClose.OnHoverImage = null;
            this.btClose.OnPressedColor = System.Drawing.Color.Black;
            this.btClose.Size = new System.Drawing.Size(228, 64);
            this.btClose.TabIndex = 17;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btReplace
            // 
            this.btReplace.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btReplace.AnimationHoverSpeed = 0.07F;
            this.btReplace.AnimationSpeed = 0.03F;
            this.btReplace.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btReplace.BorderColor = System.Drawing.Color.Black;
            this.btReplace.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btReplace.FocusedColor = System.Drawing.Color.Empty;
            this.btReplace.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReplace.ForeColor = System.Drawing.Color.White;
            this.btReplace.Image = null;
            this.btReplace.ImageSize = new System.Drawing.Size(20, 20);
            this.btReplace.Location = new System.Drawing.Point(333, 454);
            this.btReplace.Name = "btReplace";
            this.btReplace.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btReplace.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btReplace.OnHoverForeColor = System.Drawing.Color.White;
            this.btReplace.OnHoverImage = null;
            this.btReplace.OnPressedColor = System.Drawing.Color.Black;
            this.btReplace.Size = new System.Drawing.Size(228, 64);
            this.btReplace.TabIndex = 20;
            this.btReplace.Text = "Replace";
            this.btReplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btReplaceAll
            // 
            this.btReplaceAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btReplaceAll.AnimationHoverSpeed = 0.07F;
            this.btReplaceAll.AnimationSpeed = 0.03F;
            this.btReplaceAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btReplaceAll.BorderColor = System.Drawing.Color.Black;
            this.btReplaceAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btReplaceAll.FocusedColor = System.Drawing.Color.Empty;
            this.btReplaceAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReplaceAll.ForeColor = System.Drawing.Color.White;
            this.btReplaceAll.Image = null;
            this.btReplaceAll.ImageSize = new System.Drawing.Size(20, 20);
            this.btReplaceAll.Location = new System.Drawing.Point(589, 454);
            this.btReplaceAll.Name = "btReplaceAll";
            this.btReplaceAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btReplaceAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btReplaceAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btReplaceAll.OnHoverImage = null;
            this.btReplaceAll.OnPressedColor = System.Drawing.Color.Black;
            this.btReplaceAll.Size = new System.Drawing.Size(228, 64);
            this.btReplaceAll.TabIndex = 19;
            this.btReplaceAll.Text = "Replace all";
            this.btReplaceAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btReplaceAll.Click += new System.EventHandler(this.btReplaceAll_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // replace_note
            // 
            this.replace_note.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.replace_note.AutoSize = true;
            this.replace_note.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replace_note.ForeColor = System.Drawing.Color.Brown;
            this.replace_note.Location = new System.Drawing.Point(71, 376);
            this.replace_note.Name = "replace_note";
            this.replace_note.Size = new System.Drawing.Size(34, 31);
            this.replace_note.TabIndex = 21;
            this.replace_note.Text = "--";
            this.replace_note.Visible = false;
            // 
            // form_opacty
            // 
            this.form_opacty.Enabled = true;
            this.form_opacty.Interval = 29;
            this.form_opacty.Tick += new System.EventHandler(this.form_opacty_Tick);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(860, 627);
            this.Controls.Add(this.replace_note);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btReplaceAll);
            this.Controls.Add(this.btFindNext);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.cbWholeWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMatchCase);
            this.Controls.Add(this.cbRegex);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReplaceForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and replace";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbRegex;
        private System.Windows.Forms.CheckBox cbMatchCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbWholeWord;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbFind;
        public System.Windows.Forms.TextBox tbReplace;
        private Guna.UI.WinForms.GunaButton btFindNext;
        private Guna.UI.WinForms.GunaButton btReplace;
        private Guna.UI.WinForms.GunaButton btReplaceAll;
        private Guna.UI.WinForms.GunaButton btClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label replace_note;
        private System.Windows.Forms.Timer form_opacty;
    }
}