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
    public partial class remove_form : Form
    {
        public remove_form()
        {
            InitializeComponent();

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);

            this.CenterToScreen();
        }


        private void close__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close__MouseEnter(object sender, EventArgs e)
        {
            close_.ForeColor = Color.Silver;
        }

        private void close__MouseLeave(object sender, EventArgs e)
        {
            close_.ForeColor = Color.White;
        }

        private void form_opacty_Tick(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {

                form_opacty.Stop();

            }

            if (this.Opacity < 1)
            {

                this.Opacity += .29;
            }
            else
            {
                Application.OpenForms[this.Name].Focus();

                form_opacty.Stop();
            }
        }

        private void file_name_text_MouseEnter(object sender, EventArgs e)
        {
            if(file_name_text.Text == "EX: C#")
            {
                file_name_text.Text = string.Empty;
                file_name_text.ForeColor = Color.White;
            }
        }

        private void file_name_text_MouseLeave(object sender, EventArgs e)
        {
            if (file_name_text.Text == string.Empty)
            {
                file_name_text.Text = "EX: C#";
                file_name_text.ForeColor = Color.DimGray;
            }
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if ((file_name_text.Text == string.Empty) ||
                (file_name_text.Text == "EX: C#"))
            {
                error.Visible = true;
            }
            else {

                error.Visible = false;
                
                string path = @"C:\note_code\" + file_name_text.Text + ".txt";

                File.Delete(path);

                note_code_main.loadFiles(@"C:\note_code",1000);

                this.Close();
            }

        }

        private void file_name_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                e.SuppressKeyPress = true;

                if ((file_name_text.Text == string.Empty) ||
               (file_name_text.Text == "EX: C#"))
                {
                    error.Visible = true;
                }
                else
                {

                    error.Visible = false;

                    string path = @"C:\note_code\" + file_name_text.Text + ".txt";

                    File.Delete(path);

                    note_code_main.loadFiles(@"C:\note_code",1);

                    this.Close();
                }

            }
        }
    }
}
