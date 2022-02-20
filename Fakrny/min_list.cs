using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_code
{
    public partial class min_list : UserControl
    {
        public min_list()
        {
            InitializeComponent();
        }

        public string file_name_
        {
            get
            {
                return file_name.Text;
            }
            set
            {
                file_name.Text = value;
            }
        }

        public string icon_ { 
            get 
            {
                return img.ImageLocation;
            }
            set 
            {
                img.ImageLocation = value;

            } 
        }

        public Image icon_file_as_img
        {
            get
            {
                return img.Image;
            }
            set
            {
                img.Image = value;
            }
        }

        string file_path;

        public string file_path_
        {
            get
            {
                return file_path;
            }
            set
            {
                file_path = value;
            }
        }

        string pl;

        public string pl_
        {
            get
            {
                return pl;
            }
            set
            {
                pl = value;
            }
        }

        private void min_list_MouseMove(object sender, MouseEventArgs e)
        {     
          hover_.BackColor = Color.FromArgb(100, 88, 255);
        }

        private void min_list_MouseLeave(object sender, EventArgs e)
        {
            hover_.BackColor = Color.Transparent;
            
        }
    
        private void min_list_Click(object sender, EventArgs e)
        {

            note_code_main.get_note_code_note(file_path);

            note_code_main.pl_f(pl);

            note_code_main.title.Text = Path.GetFileName(file_path).Replace(".txt", null);
            note_code_main.tableLayoutPanel1.Visible = true;
            note_code_main.fctb.Visible = true;
            //note_code_main.fctb.BringToFront();
        }
    }

}
