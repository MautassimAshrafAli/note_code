
namespace note_code
{
    partial class my_note_code
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
            this.file_name = new System.Windows.Forms.Label();
            this.file_size = new System.Windows.Forms.Label();
            this.file_icon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.edit_time = new System.Windows.Forms.Label();
            this.pl = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            ((System.ComponentModel.ISupportInitialize)(this.file_icon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // file_name
            // 
            this.file_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.file_name.AutoSize = true;
            this.file_name.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_name.ForeColor = System.Drawing.Color.White;
            this.file_name.Location = new System.Drawing.Point(158, 5);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(44, 31);
            this.file_name.TabIndex = 6;
            this.file_name.Text = "---";
            this.file_name.Click += new System.EventHandler(this.my_code_note_code_Click);
            this.file_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.my_code_note_code_MouseMove);
            // 
            // file_size
            // 
            this.file_size.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.file_size.AutoSize = true;
            this.file_size.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_size.ForeColor = System.Drawing.Color.White;
            this.file_size.Location = new System.Drawing.Point(3, 89);
            this.file_size.Name = "file_size";
            this.file_size.Size = new System.Drawing.Size(34, 31);
            this.file_size.TabIndex = 6;
            this.file_size.Text = "--";
            this.file_size.Click += new System.EventHandler(this.my_code_note_code_Click);
            this.file_size.MouseMove += new System.Windows.Forms.MouseEventHandler(this.my_code_note_code_MouseMove);
            // 
            // file_icon
            // 
            this.file_icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.file_icon.ErrorImage = null;
            this.file_icon.InitialImage = null;
            this.file_icon.Location = new System.Drawing.Point(222, 37);
            this.file_icon.Name = "file_icon";
            this.file_icon.Size = new System.Drawing.Size(70, 70);
            this.file_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.file_icon.TabIndex = 0;
            this.file_icon.TabStop = false;
            this.file_icon.Click += new System.EventHandler(this.my_code_note_code_Click);
            this.file_icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.my_code_note_code_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.file_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.file_size, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.edit_time, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pl, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(77, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 171);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.my_code_note_code_Click);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.my_code_note_code_MouseMove);
            // 
            // edit_time
            // 
            this.edit_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.edit_time.AutoSize = true;
            this.edit_time.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_time.ForeColor = System.Drawing.Color.White;
            this.edit_time.Location = new System.Drawing.Point(3, 47);
            this.edit_time.Name = "edit_time";
            this.edit_time.Size = new System.Drawing.Size(34, 31);
            this.edit_time.TabIndex = 7;
            this.edit_time.Text = "--";
            this.edit_time.Click += new System.EventHandler(this.my_code_note_code_Click);
            this.edit_time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.my_code_note_code_MouseMove);
            // 
            // pl
            // 
            this.pl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pl.AutoSize = true;
            this.pl.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl.ForeColor = System.Drawing.Color.White;
            this.pl.Location = new System.Drawing.Point(3, 133);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(34, 31);
            this.pl.TabIndex = 8;
            this.pl.Text = "--";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.DimGray;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(157, 315);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 5;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(200, 10);
            this.gunaElipsePanel1.TabIndex = 8;
            // 
            // my_note_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.file_icon);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "my_note_code";
            this.Size = new System.Drawing.Size(514, 357);
            this.Click += new System.EventHandler(this.my_code_note_code_Click);
            this.MouseLeave += new System.EventHandler(this.my_code_note_code_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.my_code_note_code_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.file_icon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox file_icon;
        private System.Windows.Forms.Label file_name;
        private System.Windows.Forms.Label file_size;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label edit_time;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label pl;
    }
}
