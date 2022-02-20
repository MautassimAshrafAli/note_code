
namespace note_code
{
    partial class save_edit_note_code
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.close_ = new System.Windows.Forms.Label();
            this.form_opacty = new System.Windows.Forms.Timer(this.components);
            this.no_ = new Guna.UI.WinForms.GunaButton();
            this.error = new System.Windows.Forms.Label();
            this.yes_ = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // close_
            // 
            this.close_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_.AutoSize = true;
            this.close_.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_.ForeColor = System.Drawing.Color.White;
            this.close_.Location = new System.Drawing.Point(1013, 34);
            this.close_.Name = "close_";
            this.close_.Size = new System.Drawing.Size(29, 20);
            this.close_.TabIndex = 13;
            this.close_.Text = "";
            this.close_.Click += new System.EventHandler(this.close__Click);
            this.close_.MouseEnter += new System.EventHandler(this.close__MouseEnter);
            this.close_.MouseLeave += new System.EventHandler(this.close__MouseLeave);
            // 
            // form_opacty
            // 
            this.form_opacty.Enabled = true;
            this.form_opacty.Interval = 29;
            this.form_opacty.Tick += new System.EventHandler(this.form_opacty_Tick);
            // 
            // no_
            // 
            this.no_.AnimationHoverSpeed = 0.07F;
            this.no_.AnimationSpeed = 0.03F;
            this.no_.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.no_.BorderColor = System.Drawing.Color.Black;
            this.no_.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.no_.FocusedColor = System.Drawing.Color.Empty;
            this.no_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_.ForeColor = System.Drawing.Color.White;
            this.no_.Image = null;
            this.no_.ImageSize = new System.Drawing.Size(20, 20);
            this.no_.Location = new System.Drawing.Point(814, 459);
            this.no_.Name = "no_";
            this.no_.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.no_.OnHoverBorderColor = System.Drawing.Color.Black;
            this.no_.OnHoverForeColor = System.Drawing.Color.White;
            this.no_.OnHoverImage = null;
            this.no_.OnPressedColor = System.Drawing.Color.Black;
            this.no_.Size = new System.Drawing.Size(228, 64);
            this.no_.TabIndex = 14;
            this.no_.Text = "NO";
            this.no_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.no_.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // error
            // 
            this.error.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.White;
            this.error.Location = new System.Drawing.Point(23, 230);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(1028, 46);
            this.error.TabIndex = 15;
            this.error.Text = "You make some change in note code file to you wont save it";
            // 
            // yes_
            // 
            this.yes_.AnimationHoverSpeed = 0.07F;
            this.yes_.AnimationSpeed = 0.03F;
            this.yes_.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.yes_.BorderColor = System.Drawing.Color.Black;
            this.yes_.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.yes_.FocusedColor = System.Drawing.Color.Empty;
            this.yes_.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_.ForeColor = System.Drawing.Color.White;
            this.yes_.Image = null;
            this.yes_.ImageSize = new System.Drawing.Size(20, 20);
            this.yes_.Location = new System.Drawing.Point(562, 459);
            this.yes_.Name = "yes_";
            this.yes_.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.yes_.OnHoverBorderColor = System.Drawing.Color.Black;
            this.yes_.OnHoverForeColor = System.Drawing.Color.White;
            this.yes_.OnHoverImage = null;
            this.yes_.OnPressedColor = System.Drawing.Color.Black;
            this.yes_.Size = new System.Drawing.Size(228, 64);
            this.yes_.TabIndex = 14;
            this.yes_.Text = "Yes";
            this.yes_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yes_.Click += new System.EventHandler(this.yes__Click);
            // 
            // save_edit_note_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1088, 552);
            this.Controls.Add(this.error);
            this.Controls.Add(this.yes_);
            this.Controls.Add(this.no_);
            this.Controls.Add(this.close_);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "save_edit_note_code";
            this.Opacity = 0D;
            this.Text = "add_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label close_;
        private System.Windows.Forms.Timer form_opacty;
        private Guna.UI.WinForms.GunaButton no_;
        private System.Windows.Forms.Label error;
        private Guna.UI.WinForms.GunaButton yes_;
    }
}