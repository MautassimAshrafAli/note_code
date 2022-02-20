
namespace note_code
{
    partial class add_form_temp
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
            this.add_file = new System.Windows.Forms.Label();
            this.filel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // add_file
            // 
            this.add_file.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_file.AutoSize = true;
            this.add_file.Font = new System.Drawing.Font("Segoe MDL2 Assets", 69F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.add_file.Location = new System.Drawing.Point(137, 68);
            this.add_file.Name = "add_file";
            this.add_file.Size = new System.Drawing.Size(229, 161);
            this.add_file.TabIndex = 7;
            this.add_file.Text = "";
            this.add_file.Click += new System.EventHandler(this.add_form_temp_Click);
            this.add_file.MouseMove += new System.Windows.Forms.MouseEventHandler(this.add_form_temp_MouseMove);
            // 
            // filel
            // 
            this.filel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filel.AutoSize = true;
            this.filel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.filel.Location = new System.Drawing.Point(158, 266);
            this.filel.Name = "filel";
            this.filel.Size = new System.Drawing.Size(184, 31);
            this.filel.TabIndex = 8;
            this.filel.Text = "Add note code";
            this.filel.Click += new System.EventHandler(this.add_form_temp_Click);
            this.filel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.add_form_temp_MouseMove);
            // 
            // add_form_temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.filel);
            this.Controls.Add(this.add_file);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "add_form_temp";
            this.Size = new System.Drawing.Size(514, 357);
            this.Click += new System.EventHandler(this.add_form_temp_Click);
            this.MouseLeave += new System.EventHandler(this.add_form_temp_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.add_form_temp_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label add_file;
        private System.Windows.Forms.Label filel;
    }
}
