
namespace note_code
{
    partial class remove_form
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
            this.title = new System.Windows.Forms.Label();
            this.file_name_text = new System.Windows.Forms.TextBox();
            this.fine_name_label = new System.Windows.Forms.Label();
            this.close_ = new System.Windows.Forms.Label();
            this.form_opacty = new System.Windows.Forms.Timer(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(260, 45);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(310, 40);
            this.title.TabIndex = 10;
            this.title.Text = "Remove Note Code";
            // 
            // file_name_text
            // 
            this.file_name_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.file_name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.file_name_text.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.file_name_text.ForeColor = System.Drawing.Color.DarkGray;
            this.file_name_text.Location = new System.Drawing.Point(87, 271);
            this.file_name_text.Multiline = true;
            this.file_name_text.Name = "file_name_text";
            this.file_name_text.Size = new System.Drawing.Size(588, 35);
            this.file_name_text.TabIndex = 11;
            this.file_name_text.Text = "EX: C#";
            this.file_name_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.file_name_text_KeyDown);
            this.file_name_text.MouseEnter += new System.EventHandler(this.file_name_text_MouseEnter);
            this.file_name_text.MouseLeave += new System.EventHandler(this.file_name_text_MouseLeave);
            // 
            // fine_name_label
            // 
            this.fine_name_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fine_name_label.AutoSize = true;
            this.fine_name_label.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fine_name_label.ForeColor = System.Drawing.Color.Brown;
            this.fine_name_label.Location = new System.Drawing.Point(87, 223);
            this.fine_name_label.Name = "fine_name_label";
            this.fine_name_label.Size = new System.Drawing.Size(265, 31);
            this.fine_name_label.TabIndex = 12;
            this.fine_name_label.Text = "File Name to remove*";
            // 
            // close_
            // 
            this.close_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_.AutoSize = true;
            this.close_.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_.ForeColor = System.Drawing.Color.White;
            this.close_.Location = new System.Drawing.Point(785, 34);
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
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(542, 456);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(282, 64);
            this.gunaButton1.TabIndex = 14;
            this.gunaButton1.Text = "Remove my note code";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // error
            // 
            this.error.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(208, 354);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(347, 31);
            this.error.TabIndex = 15;
            this.error.Text = "*Please fill the required fields";
            this.error.Visible = false;
            // 
            // remove_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(860, 552);
            this.Controls.Add(this.error);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.close_);
            this.Controls.Add(this.fine_name_label);
            this.Controls.Add(this.file_name_text);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "remove_form";
            this.Opacity = 0D;
            this.Text = "add_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label fine_name_label;
        private System.Windows.Forms.TextBox file_name_text;
        private System.Windows.Forms.Label close_;
        private System.Windows.Forms.Timer form_opacty;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label error;
    }
}