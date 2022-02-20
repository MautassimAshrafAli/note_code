
namespace note_code
{
    partial class min_list
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.img = new System.Windows.Forms.PictureBox();
            this.file_name = new System.Windows.Forms.Label();
            this.hover_ = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // img
            // 
            this.img.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.img.ErrorImage = null;
            this.img.InitialImage = null;
            this.img.Location = new System.Drawing.Point(34, 22);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(50, 50);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 10;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.min_list_Click);
            this.img.MouseMove += new System.Windows.Forms.MouseEventHandler(this.min_list_MouseMove);
            // 
            // file_name
            // 
            this.file_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.file_name.AutoSize = true;
            this.file_name.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_name.ForeColor = System.Drawing.Color.White;
            this.file_name.Location = new System.Drawing.Point(96, 30);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(92, 35);
            this.file_name.TabIndex = 11;
            this.file_name.Text = "Name";
            this.file_name.Click += new System.EventHandler(this.min_list_Click);
            this.file_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.min_list_MouseMove);
            // 
            // hover_
            // 
            this.hover_.BackColor = System.Drawing.Color.Transparent;
            this.hover_.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hover_.Location = new System.Drawing.Point(0, 88);
            this.hover_.Name = "hover_";
            this.hover_.Size = new System.Drawing.Size(684, 6);
            this.hover_.TabIndex = 12;
            // 
            // min_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.hover_);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.img);
            this.DoubleBuffered = true;
            this.Name = "min_list";
            this.Size = new System.Drawing.Size(684, 94);
            this.Click += new System.EventHandler(this.min_list_Click);
            this.MouseLeave += new System.EventHandler(this.min_list_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.min_list_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label file_name;
        private System.Windows.Forms.Panel hover_;
    }
}
