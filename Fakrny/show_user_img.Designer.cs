
namespace note_code
{
    partial class show_user_img
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
            this.user_img = new System.Windows.Forms.PictureBox();
            this.form_opacty = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.user_img)).BeginInit();
            this.SuspendLayout();
            // 
            // user_img
            // 
            this.user_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_img.Location = new System.Drawing.Point(0, 0);
            this.user_img.Name = "user_img";
            this.user_img.Size = new System.Drawing.Size(763, 804);
            this.user_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_img.TabIndex = 0;
            this.user_img.TabStop = false;
            this.user_img.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // form_opacty
            // 
            this.form_opacty.Enabled = true;
            this.form_opacty.Interval = 29;
            this.form_opacty.Tick += new System.EventHandler(this.form_opacty_Tick);
            // 
            // show_user_img
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(763, 804);
            this.Controls.Add(this.user_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show_user_img";
            this.Opacity = 0D;
            this.Text = "user_ing";
            ((System.ComponentModel.ISupportInitialize)(this.user_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox user_img;
        private System.Windows.Forms.Timer form_opacty;
    }
}