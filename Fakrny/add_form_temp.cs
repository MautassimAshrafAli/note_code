using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_code
{
    public partial class add_form_temp : UserControl
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

        public add_form_temp()
        {
            InitializeComponent();
        }


        private void add_form_temp_MouseLeave(object sender, EventArgs e)
        {
            add_file.ForeColor = Color.FromArgb(64, 68, 75);
            filel.ForeColor = Color.FromArgb(64, 68, 75);
        }

        private void add_form_temp_MouseMove(object sender, MouseEventArgs e)
        {
            add_file.ForeColor = Color.White;
            filel.ForeColor = Color.White;
        }

        private void add_form_temp_Click(object sender, EventArgs e)
        {
            add_file.ForeColor = Color.FromArgb(64, 68, 75);
            filel.ForeColor = Color.FromArgb(64, 68, 75);

            add_form add_Form = new add_form();
            add_Form.Show();
        }
    }
}
