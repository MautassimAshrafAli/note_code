
namespace note_code
{
    partial class favorit_pages
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
            this.urls_ = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.add_file = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // urls_
            // 
            this.urls_.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.urls_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.urls_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urls_.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.urls_.ForeColor = System.Drawing.Color.White;
            this.urls_.HideSelection = false;
            this.urls_.HoverSelection = true;
            this.urls_.LargeImageList = this.imageList1;
            this.urls_.Location = new System.Drawing.Point(26, 31);
            this.urls_.MultiSelect = false;
            this.urls_.Name = "urls_";
            this.urls_.Scrollable = false;
            this.urls_.Size = new System.Drawing.Size(721, 1329);
            this.urls_.SmallImageList = this.imageList1;
            this.urls_.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.urls_.TabIndex = 0;
            this.urls_.UseCompatibleStateImageBehavior = false;
            this.urls_.View = System.Windows.Forms.View.Tile;
            this.urls_.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.urls__ItemSelectionChanged);
            this.urls_.Click += new System.EventHandler(this.urls__Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(35, 35);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.gunaButton1.Location = new System.Drawing.Point(183, 1375);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(406, 73);
            this.gunaButton1.TabIndex = 15;
            this.gunaButton1.Text = "Close";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // add_file
            // 
            this.add_file.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_file.AutoSize = true;
            this.add_file.Font = new System.Drawing.Font("Segoe MDL2 Assets", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.add_file.Location = new System.Drawing.Point(256, 603);
            this.add_file.Name = "add_file";
            this.add_file.Size = new System.Drawing.Size(261, 184);
            this.add_file.TabIndex = 16;
            this.add_file.Text = "";
            // 
            // favorit_pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(773, 1482);
            this.Controls.Add(this.urls_);
            this.Controls.Add(this.add_file);
            this.Controls.Add(this.gunaButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "favorit_pages";
            this.Text = "favorit_pages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ListView urls_;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label add_file;
    }
}