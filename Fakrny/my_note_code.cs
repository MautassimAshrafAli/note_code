using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace note_code
{
    public partial class my_note_code : UserControl
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public my_note_code()
        {
            InitializeComponent();
        }

        string file_path;

        public string icon_file {
            get
            {
                return file_icon.ImageLocation;
            } 
            set 
            {
                file_icon.ImageLocation = value;
            } 
        }

        public Image icon_file_as_img { 
            get
            {
                return file_icon.Image;
            }
            set 
            {
                file_icon.Image = value;
            }
        }

        public string file_name_ {
            get
            {
                return file_name.Text;
            } 
            set
            {
                file_name.Text = value;
            }
        }

        public string file_size_ {
            get 
            {
                return file_size.Text;
            }
            set 
            {
                file_size.Text = value;
            }
        }

        public string edit_time_ {
            get
            {
                return edit_time.Text;
            }
            set 
            {
                edit_time.Text = value;
            } 
        }

        public string file_path_ {
            get 
            {
                return file_path;
            }
            set 
            {
                file_path = value;
            }
        }

        public string program_language {
            get 
            {
                return pl.Text;
            } 
            set 
            {
                pl.Text = value;
            } 
        }


        private void my_code_note_code_Click(object sender, EventArgs e)
        {
            gunaElipsePanel1.BaseColor = Color.DimGray;

            note_code_main.get_note_code_note(file_path);

            note_code_main.pl_f(pl.Text);

            // note_code.Parse();

            //note_code.file_title.Visible = true;
            note_code_main.title.Text = Path.GetFileName(file_path).Replace(".txt", null);
            //note_code.edit_t.Visible = true;
            note_code_main.tableLayoutPanel1.Visible = true;
            note_code_main.list_min_note.Visible = true;
            note_code_main.fctb.Visible = true;
            note_code_main.fctb.BringToFront();
            note_code_main.fctb.Dock = DockStyle.Fill;


        }

        private void my_code_note_code_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel1.BaseColor = Color.DimGray;
        }

        private void my_code_note_code_MouseMove(object sender, MouseEventArgs e)
        {
            gunaElipsePanel1.BaseColor = Color.FromArgb(100, 88, 255);

        }
    }
}
